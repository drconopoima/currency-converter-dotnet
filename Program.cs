// See https://aka.ms/new-console-template for more information
namespace CurrencyConverterDotNet;
internal class Program
{
    static void Main(string[] args)
    {
        CurrencyCode first_currency=CurrencyCode.NONE;
        bool correct = false;
        while (!correct) {
            try {
                Console.Write("Please introduce initial currency: "); 
                string first_currency_string = Console.ReadLine();
                first_currency = CurrencyCodeExtensions.FromText(first_currency_string);
                correct = true;
            }
            catch {
                // Console.WriteLine($"Could not interpret value {first_currency_string} as a valid currect");
            }
        };
        Console.WriteLine($"Your choice for initial currency is {first_currency.GetCode()}");
    }
}