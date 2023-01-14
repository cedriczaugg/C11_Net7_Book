// See https://aka.ms/new-console-template for more information

using Packt.Shared;

Northwind db = new();
WriteLine($"Provider: {db.Database.ProviderName}");

QueryingCategories();
// FilteredIncludes();
// QueryingProducts();
// QueryingWithLike();
// GetRandomProduct();