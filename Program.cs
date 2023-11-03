// See https://aka.ms/new-console-template for more information
namespace CurrencyConverterDotNet;
internal class Program
{
    static void Main(string[] args)
    {
        CurrencyCode code = CurrencyCode.USD;
        Console.WriteLine($"{code.GetCode()}");
    }
}