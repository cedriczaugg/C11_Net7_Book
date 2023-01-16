// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;

namespace WorkingWithText;

internal partial class Program
{
    public static void Main(string[] args)
    {
        var city = "London";
        WriteLine($"{city} is {city.Length} characters long.");
        WriteLine($"First char is {city[0]} and fourth is {city[3]}");

        var cities = "Paris,Tehran,Chennai,Sydney,New York,Medellín";
        var citiesArray = cities.Split(',');
        WriteLine($"There are {citiesArray.Length} items in the array:");
        foreach (var item in citiesArray) WriteLine(item);

        var fullName = "Alan Shore";
        var indexOfTheSpace = fullName.IndexOf(' ');
        var firstName = fullName.Substring(
            0, indexOfTheSpace);
        var lastName = fullName.Substring(
            indexOfTheSpace + 1);
        WriteLine($"Original: {fullName}");
        WriteLine($"Swapped: {lastName}, {firstName}");

        var company = "Microsoft";
        var startsWithM = company.StartsWith("M");
        var containsN = company.Contains("N");
        WriteLine($"Text: {company}");
        WriteLine($"Starts with M: {startsWithM}, contains an N: {containsN}");

        var recombined = string.Join(" => ", citiesArray);
        WriteLine(recombined);

        var fruit = "Apples";
        var price = 0.39M;
        var when = DateTime.Today;
        WriteLine($"Interpolated: {fruit} cost {price:C} on {when:dddd}.");
        WriteLine(string.Format("string.Format: {0} cost {1:C} on {2:dddd}.",
            fruit, price, when));

        // C# 1 to 10: Use escaped double-quote characters \"
        // string films = "\"Monsters, Inc.\",\"I, Tonya\",\"Lock, Stock and Two Smoking Barrels\"";
        // C# 11 or later: Use """ to start and end a raw string literal
        var films = """
"Monsters, Inc.","I, Tonya","Lock, Stock and Two Smoking Barrels"
""";
        WriteLine($"Films to split: {films}");
        var filmsDumb = films.Split(',');
        WriteLine("Splitting with string.Split method:");
        foreach (var film in filmsDumb) WriteLine(film);

        Regex csv = new(commaSeparatorText);
        var filmsSmart = csv.Matches(films);
        WriteLine("Splitting with regular expression:");
        foreach (Match film in filmsSmart) WriteLine(film.Groups[2].Value);

        Regex ageChecker = new(digitsOnlyText);
    }
}