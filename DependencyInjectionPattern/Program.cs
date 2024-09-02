

using DependencyInjectionPattern.Models;

ILogger logger = new DatabaseLogger();

ProductService productService = new ProductService(logger);
productService.AddProduct("Laptop");

Console.ReadLine();