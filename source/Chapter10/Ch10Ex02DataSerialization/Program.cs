using Ch10Ex02DataSerialization.AutoGen;

using (Northwind ctx = new Northwind())
{
    var categories = ctx.Categories;
    foreach (var category in categories)
    {
        Console.WriteLine(category.CategoryName);
        var products = ctx.Products.Where(p => p.Category == category);
        foreach (var product in products)
        {
                Console.WriteLine(product.ProductName);
        }
    }
}