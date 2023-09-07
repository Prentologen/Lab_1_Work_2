class Converter
{
    private double usdRate;
    private double eurRate;
    private double plnRate;

    public Converter(double usd, double eur, double pln)
    {
        usdRate = usd;
        eurRate = eur;
        plnRate = pln;
    }

    public double ConvertToCurrency(double amount, string currency)
    {
        switch (currency.ToLower())
        {
            case "usd":
                return amount / usdRate;
            case "eur":
                return amount / eurRate;
            case "pln":
                return amount / plnRate;
            default:
                Console.WriteLine("!Unknown Currency!");
                return 0.0;
        }
    }

    public double ConvertFromCurrency(double amount, string currency)
    {
        switch (currency.ToLower())
        {
            case "usd":
                return amount * usdRate;
            case "eur":
                return amount * eurRate;
            case "pln":
                return amount * plnRate;
            default:
                Console.WriteLine("!Unknown Currency!");
                return 0.0;
        }
    }
}

class Program
{
    static void Main()
    {
        Converter converter = new Converter(37.1, 39.50, 8.50);

        double amountInUah = 1;
        double usdAmount = converter.ConvertToCurrency(amountInUah, "usd");
        double eurAmount = converter.ConvertToCurrency(amountInUah, "eur");
        double plnAmount = converter.ConvertToCurrency(amountInUah, "pln");

        Console.WriteLine($"{amountInUah} гривень = {usdAmount} USD");
        Console.WriteLine($"{amountInUah} гривень = {eurAmount} EUR");
        Console.WriteLine($"{amountInUah} гривень = {plnAmount} PLN");

        double usdToUah = converter.ConvertFromCurrency(100, "usd");
        double eurToUah = converter.ConvertFromCurrency(200, "eur");
        double plnToUah = converter.ConvertFromCurrency(300, "pln");

        Console.WriteLine($"100 USD = {usdToUah} гривень");
        Console.WriteLine($"200 EUR = {eurToUah} гривень");
        Console.WriteLine($"300 PLN = {plnToUah} гривень");
    }
}