internal partial class Program
{
    public static void Main(string[] args)
    {
        // TimesTables(7, 15);
        decimal tacToPay = CalculateTax(amount: 254, twoLetterRegionCode: "CH");
        WriteLine($"You must pay {tacToPay} in tax.");
    }
}