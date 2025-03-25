using Microsoft.Playwright;

namespace AlfaCert.Service.Services
{
    internal class MarginOptions : Margin
    {
        public string Top { get; set; }
        public string Bottom { get; set; }
        public string Left { get; set; }
        public string Right { get; set; }
    }
}