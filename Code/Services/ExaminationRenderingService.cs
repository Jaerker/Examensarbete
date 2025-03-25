using AlfaCert.Models.ExaminationModels;
using AlfaCert.Service.PdfTemplates;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Playwright;
using QRCoder;

namespace AlfaCert.Service.Services
{
    public class ExaminationRenderingService
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ILoggerFactory _loggerFactory;
        public ExaminationRenderingService(IServiceProvider serviceProvider, ILoggerFactory loggerFactory)
        {
            _serviceProvider = serviceProvider;
            _loggerFactory = _serviceProvider.GetRequiredService<ILoggerFactory>();
            Microsoft.Playwright.Program.Main(["install"]);
        }
        public async Task<List<byte[]>> GenerateOfflineExaminationPdf(List<ExaminationModel> examinations)
        {
            QRCodeGenerator qrGenerator = new();


            await using var htmlRenderer = new HtmlRenderer(_serviceProvider, _loggerFactory);
            using var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = true,
            });
            List<byte[]> pdfs = new();

            var logoSvg = string.Empty;
            using (var hc = new HttpClient())
            {
                var imageBytes = await hc.GetByteArrayAsync(examinations[0].ExaminationTemplate.Sector.IconUrl);
                var imageBase64 = Convert.ToBase64String(imageBytes);


                logoSvg = $"data:image/svg+xml;base64,{imageBase64}";
            }


            foreach (var examination in examinations)
            {
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(examination.Id.ToString(), QRCodeGenerator.ECCLevel.L);
                PngByteQRCode qRCode = new PngByteQRCode(qrCodeData);
                byte[] qrCodeBytes = qRCode.GetGraphic(20);
                string qrCodeTest = Convert.ToBase64String(qrCodeBytes);
                var qrCode = string.Format("data:image/png;base64,{0}", qrCodeTest);


                var header = await htmlRenderer.Dispatcher.InvokeAsync(async () =>
                {
                    var dictionary = new Dictionary<string, object?>
                {
                    {"Examination", examination },
                    {"LogoSvg", logoSvg},
                    {"QrCode", qrCode}
                };

                    var parameters = ParameterView.FromDictionary(dictionary);
                    var output = await htmlRenderer.RenderComponentAsync<OfflineExaminationHeader>(parameters);
                    return output.ToHtmlString();

                });
                var footer = await htmlRenderer.Dispatcher.InvokeAsync(async () =>
                {
                    var dictionary = new Dictionary<string, object?>
                {
                    {"ExaminationId", examination.Id }
                };

                    var parameters = ParameterView.FromDictionary(dictionary);
                    var output = await htmlRenderer.RenderComponentAsync<OfflineExaminationFooter>(parameters);
                    return output.ToHtmlString();

                });

                var basePage = await htmlRenderer.Dispatcher.InvokeAsync(async () =>
                {
                    var baseDictionary = new Dictionary<string, object?>
                    {
                        {"Examination", examination },
                    };

                    var baseParameters = ParameterView.FromDictionary(baseDictionary);
                    var output = await htmlRenderer.RenderComponentAsync<OfflineExamination>(baseParameters);
                    
                    return output.ToHtmlString();

                });
                var questionsPage = await htmlRenderer.Dispatcher.InvokeAsync(async () =>
                {
                    var dictionary = new Dictionary<string, object?>
                    {
                        {"Questions", examination.ApplicantQuestions },
                    };

                    var parameters = ParameterView.FromDictionary(dictionary);
                    var output = await htmlRenderer.RenderComponentAsync<OfflineExaminationQuestions>(parameters);
                    return output.ToHtmlString();

                });

                var alternativesPage = await htmlRenderer.Dispatcher.InvokeAsync(async () =>
                {
                    var dictionary = new Dictionary<string, object?>
                    {
                        {"Questions", examination.ApplicantQuestions },
                    };

                    var parameters = ParameterView.FromDictionary(dictionary);
                    var output = await htmlRenderer.RenderComponentAsync<OfflineExaminationAlternatives>(parameters);
                    return output.ToHtmlString();

                });

                var page = await browser.NewPageAsync();
                await page.SetContentAsync(basePage);
                var pdf = await page.PdfAsync(new PagePdfOptions
                {
                    DisplayHeaderFooter = true,
                    HeaderTemplate = header,
                    FooterTemplate = footer,
                    PrintBackground = true,
                    Margin = new MarginOptions
                    {
                        Top = "4cm",
                        Bottom = "2cm",
                        Left = ".5cm",
                        Right = ".5cm"
                    },
                    Format = "A4",
                    Landscape = false,

                });
                var firstPdf = pdf;
                pdfs.Add(firstPdf);

                page = await browser.NewPageAsync();
                await page.SetContentAsync(questionsPage);
                pdf = await page.PdfAsync(new PagePdfOptions
                {
                    DisplayHeaderFooter = true,
                    HeaderTemplate = header,
                    FooterTemplate = footer,
                    PrintBackground = true,
                    Margin = new MarginOptions
                    {
                        Top = "5cm",
                        Bottom = "2cm",
                        Left = ".5cm",
                        Right = ".5cm"
                    },
                    Format = "A4",
                    Landscape = false,
                });
                
                var questionsPdf = pdf;

                pdfs.Add(questionsPdf);

                page = await browser.NewPageAsync();
                await page.SetContentAsync(alternativesPage);
                pdf = await page.PdfAsync(new PagePdfOptions
                {
                    DisplayHeaderFooter = true,
                    HeaderTemplate = header,
                    FooterTemplate = footer,
                    PrintBackground = true,
                    Margin = new MarginOptions
                    {
                        Top = "5cm",
                        Bottom = "2cm",
                        Left = ".5cm",
                        Right = ".5cm"
                    },
                    Format = "A4",
                    Landscape = false,
                });

                var alternativesPdf = pdf;

                pdfs.Add(alternativesPdf);

                await page.CloseAsync();
            }
            return pdfs;
        }

    }
}
