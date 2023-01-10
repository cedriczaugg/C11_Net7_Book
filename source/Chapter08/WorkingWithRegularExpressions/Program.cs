// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;

Write("Enter your age:");
string input = ReadLine()!;

Regex ageChecker = new (@"\d");

if (ageChecker.IsMatch(input))
{
    WriteLine("Thank you.");
}
else
{
    WriteLine($"This is not a valid age: {input}");
}