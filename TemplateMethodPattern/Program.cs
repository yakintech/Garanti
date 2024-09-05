

using TemplateMethodPattern.Models;

//SystemReports reports = new PDFReport();
//reports.GenerateReport();

SystemReports reports = new XMLReport();
reports.GenerateReport();

Console.ReadLine();