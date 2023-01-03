internal partial class Program
{
    public static void Main(string[] args)
    {
        // TimesTables(7, 15);
        var tacToPay = CalculateTax(254, "CH");
        WriteLine($"You must pay {tacToPay} in tax.");
    }
}