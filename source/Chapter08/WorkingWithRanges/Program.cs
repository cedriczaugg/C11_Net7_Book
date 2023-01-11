namespace WorkingWithRanges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Samantha Jones";

            // getting lengths of the first and last names

            int lengthOfFirst = name.IndexOf(' ');
            int lengthOfLast = name.Length - lengthOfFirst - 1;

            // using substring

            string firstName = name.Substring(0, lengthOfFirst);
            string lastName = name.Substring(name.Length - lengthOfLast, lengthOfLast);

            WriteLine($"First name: {firstName}, Last name: {lastName}");

            // using spans

            ReadOnlySpan<char> nameAsSpan = name.AsSpan();
            ReadOnlySpan<char> lastNameSpan = lastName.AsSpan();
            ReadOnlySpan<char> firstNameSpan = firstName.AsSpan();

            WriteLine("First name: {0}, Last name: {1}",
                arg0: firstNameSpan.ToString(),
                arg1: lastNameSpan.ToString());
        }
    }
}