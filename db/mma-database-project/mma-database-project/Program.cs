// See https://aka.ms/new-console-template for more information
using mma_database_project.Models.DataLayer;

Console.WriteLine("MMA Database Tester - Entity Framework!");

MMABooksContext context = new();
var invoices = context.Invoices.ToList();

foreach (Invoice inv in invoices) {
    Console.WriteLine(inv);
}
