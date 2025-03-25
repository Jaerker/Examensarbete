# Examensarbete

Detta blir tyvärr info lite hastigt ihopslängt, på grund av det lite komplicerade upplägget av examensarbetet som jag tagit mig an! jag ber om ursäkt i förväg, Isak! 

## Generering och inskanningsverktyg för examinationshantering

Syftet med projektet var att skapa en funktion i den plattformen jag bygger som ska hjälpa till med att hantera examinationer i "offline" miljö. Jag kommer i mapparna här ta med stycken av kod som jag kodat under arbetets gång och förklara innan varje del vad syftet är med dem! Tyvärr så blir det svårt att testa detta lokalt, men jag har ordnat upp med ett konto som du ska kunna använda dig av för att kunna se lite vad jag försökt ge mig på! Jag ska dock beskriva vad varje mapp innehåller och funktionalitet. Vi kan även sitta ner en dag och kolla över detta dock tillsammans så kan jag förklara lite tydligare.

Det tråkiga är att jag inte lyckades få gjort det sista i examinationen, så en rättning av examinationer är tyvärr inte möjligt. Däremot så går det att skapa offline examinationer och skriva ut dem!

## Code > PdfTemplates
Dessa är mallar för info om hur strukturen ska vara på PDF filerna som skapas. Dessa är egentligen HTML filer som visas upp i en "Playwright" miljö i bakgrunden, vilket betyder att datorn drar ingång en browser utan bild och slänger upp informationen som jag vill ha den, sen sparar jag den som en "PDF Buffer" (Byte array) som senare är i behov av att konverteras till en Base64String, och då får vi PDF filen!

## Code > Services
Där, i `ExaminationRenderingService` sker själva renderingen av PDF filen. Det ser lite rörigt ut så förstår om du inte hänger med. Pga sjukdom och sånt som kom ivägen så blev det en del copy paste kod. 


## Code > DTO
Här är alla DataTransferObjects som jag använder, och en del som jag slutat använda och behöver rensa bort. Inget specifikt viktigt där egentligen för uppgiften, men den dyker upp!

## Code > wwwroot > js > saveaspdf.js

Här har vi egentligen funktionen som körs för att skapa PDF filen och se till att man laddar ner den till datorn!

## Code > API 
De API anrop som jag använder mig av med specifikt dessa delar av projektet


# Vad har jag lärt mig?

Jag har fått bra användning av att söka efter paket som kan vara användbara, men även hur man ska formulera sig när det gäller det. 

# Opponeringsupplägg

Jag försöker lägga upp så mycket kod här som jag kan som är relevant för dig inför uppgiften, då det blir jobbigt med hela projektet! Sen så kan jag, som nämnt innan, gå igenom på hemmabas om du vill över samtal så du får det du behöver för att göra en opponering så bra som möjligt! 

Jag kan ha glömt något, men säg bara till så kommer jag hjälpa dig på en gång! Jag ska även ge dig ett konto på Onsdag morgon som du kan använda dig av för att testa funktionerna som jag gjort!