# Zadání:

Webová služba s jednou metodou „SendSMS“. Pomocí HTTP metody GET (popř. PUT) se přijmou 2 parametry:

Příjemce – tel. číslo v mezinárodním formátu,
Text – řetězec max. 320 znaků v ASCII7

Požadavky:

Jazyk C#, framework .NET Core 3.1 nebo .NET 5 nebo .NET 6 (podle vlastní preference) Přijatá data budou uložena v SQL databázi pro další zpracování Kód by mělo být možné integrovat do většího holdingového řešení

# Návod na zprovoznění:

Ve windows netestováno (pro Visual Studio by měl fungovat soubor s projektem Test.sln)

v souboru Controllers/SendSMSController.cs je potřeba změnit cestu k souboru s daty "SendSMS.txt"
 
V linuxu stačí ve složce "Test" příkaz $dotnet run

# Poznámky

Ǔloha řešena od 23.6.2022 bez předchozích zkušeností s ASP.NET, s modelem MVC a s vývojem .NET aplikací v Linuxu.
