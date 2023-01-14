namespace WorkingWithRanges;

internal class Program
{
    private static void Main(string[] args)
    {
        var name = "Samantha Jones";

        // getting lengths of the first and last names

        var lengthOfFirst = name.IndexOf(' ');
        var lengthOfLast = name.Length - lengthOfFirst - 1;

        // using substring

        var firstName = name.Substring(0, lengthOfFirst);
        var lastName = name.Substring(name.Length - lengthOfLast, lengthOfLast);

        WriteLine($"First name: {firstName}, Last name: {lastName}");

        // using spans

        var nameAsSpan = name.AsSpan();
        var lastNameSpan = lastName.AsSpan();
        var firstNameSpan = firstName.AsSpan();

        WriteLine("First name: {0}, Last name: {1}",
            firstNameSpan.ToString(),
            lastNameSpan.ToString());
    }
}