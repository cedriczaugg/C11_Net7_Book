// See https://aka.ms/new-console-template for more information

// JsonSerializer
using System.Text.Json;
using static System.Environment;
using static System.IO.Path;

Book mybook = new("C# 11 and .NET 7 - Modern Cross-Platform Development Fundamentals")
{
    Author = "Mark J Price",
    PublishDate = new DateTime(2022, 11, 8),
    Pages = 823,
    Created = DateTimeOffset.UtcNow
};

JsonSerializerOptions options = new()
{
    // IncludeFields = true, // includes all fields
    PropertyNameCaseInsensitive = true
    // WriteIndented = true,
    // PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
};
var filePath = Combine(CurrentDirectory, "mybook.json");
using (Stream fileStream = File.Create(filePath))
{
    JsonSerializer.Serialize(
        fileStream, mybook, options);
}

WriteLine("Written {0:N0} bytes of JSON to {1}",
    new FileInfo(filePath).Length,
    filePath);
WriteLine();
// display the serialized object graph 
WriteLine(File.ReadAllText(filePath));