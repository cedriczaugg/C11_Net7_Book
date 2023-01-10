// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;

namespace WorkingWithText;
internal partial class Program
{
    public static void Main(string[] args)
    {
        string city = "London";
        WriteLine($"{city} is {city.Length} characters long.");
        WriteLine($"First char is {city[0]} and fourth is {city[3]}");

        string cities = "Paris,Tehran,Chennai,Sydney,New York,Medellín";
        string[] citiesArray = cities.Split(',');
        WriteLine($"There are {citiesArray.Length} items in the array:");
        foreach (string item in citiesArray)
        {
            WriteLine(item);
        }

        string fullName = "Alan Shore";
        int indexOfTheSpace = fullName.IndexOf(' ');
        string firstName = fullName.Substring(
            startIndex: 0, length: indexOfTheSpace);
        string lastName = fullName.Substring(
            startIndex: indexOfTheSpace + 1);
        WriteLine($"Original: {fullName}");
        WriteLine($"Swapped: {lastName}, {firstName}");

        string company = "Microsoft";
        bool startsWithM = company.StartsWith("M"); 
        bool containsN = company.Contains("N");
        WriteLine($"Text: {company}");
        WriteLine($"Starts with M: {startsWithM}, contains an N: {containsN}");

        string recombined = string.Join(" => ", citiesArray); 
        WriteLine(recombined);

        string fruit = "Apples"; 
        decimal price = 0.39M; 
        DateTime when = DateTime.Today;
        WriteLine($"Interpolated: {fruit} cost {price:C} on {when:dddd}."); 
        WriteLine(string.Format("string.Format: {0} cost {1:C} on {2:dddd}.",
            arg0: fruit, arg1: price, arg2: when));

        // C# 1 to 10: Use escaped double-quote characters \"
        // string films = "\"Monsters, Inc.\",\"I, Tonya\",\"Lock, Stock and Two Smoking Barrels\"";
        // C# 11 or later: Use """ to start and end a raw string literal
        string films = """
"Monsters, Inc.","I, Tonya","Lock, Stock and Two Smoking Barrels"
""";
        WriteLine($"Films to split: {films}");
        string[] filmsDumb = films.Split(',');
        WriteLine("Splitting with string.Split method:");
        foreach (string film in filmsDumb)
        {
            WriteLine(film);
        }

        Regex csv = new(commaSeparatorText);
        MatchCollection filmsSmart = csv.Matches(films);
        WriteLine("Splitting with regular expression:");
        foreach (Match film in filmsSmart)
        {
            WriteLine(film.Groups[2].Value);
        }

        Regex ageChecker = new(digitsOnlyText);
    }
}
