# Zadání:

Webová služba s jednou metodou „SendSMS“. Pomocí HTTP metody GET (popř. PUT) se přijmou 2 parametry:

Příjemce – tel. číslo v mezinárodním formátu,
Text – řetězec max. 320 znaků v ASCII7

Požadavky:

Jazyk C#, framework .NET Core 3.1 nebo .NET 5 nebo .NET 6 (podle vlastní preference) Přijatá data budou uložena v SQL databázi pro další zpracování Kód by mělo být možné integrovat do většího holdingového řešení

# Ukázka řešení:

video po commitu 4bad9a2678672884b01acb6fe4708f09266f47df (16.7.2022): https://github.com/pribyto4/Test4/blob/main/Test.flv

# Návod na zprovoznění:

Ve windows netestováno (pro Visual Studio by měl fungovat soubor s projektem Test.sln)

Postup instalace potřebných knihoven v Linuxu: https://docs.microsoft.com/cs-cz/dotnet/core/install

Postup instalace MS SQL v linuxu: https://docs.microsoft.com/en-us/sql/linux/quickstart-install-connect-ubuntu?view=sql-server-ver15

ConnectionStrings v souboru appsettings.json je potřeba nastavit podle nastavení MS SQL

Postup pro migraci databáze: https://docs.microsoft.com/cs-cz/ef/core/cli/dotnet
 
V linuxu ve složce "Test" spustit příkaz $dotnet run

# Poznámky

Ǔloha řešena od 23.6.2022 bez předchozích zkušeností s ASP.NET, s modelem MVC a s vývojem .NET aplikací v Linuxu.
