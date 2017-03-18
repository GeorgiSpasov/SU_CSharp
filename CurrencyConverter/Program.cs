using System;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = double.Parse(Console.ReadLine());
            var convertedCurrency = Console.ReadLine().ToUpper();
            var convertingCurrency = Console.ReadLine().ToUpper();
            var usd = 1.79549;
            var eur = 1.95583;
            var gbp = 2.53405;
            double convertedSum = 0;

            switch (convertedCurrency + convertingCurrency)
            {
                case "BGNUSD": // BGN
                    convertedSum = sum / usd;
                    break;
                case "BGNEUR":
                    convertedSum = sum / eur;
                    break;
                case "BGNGBP":
                    convertedSum = sum / gbp;
                    break;
                case "USDBGN": // USD
                    convertedSum = sum * usd;
                    break;
                case "USDEUR":
                    convertedSum = sum * usd / eur;
                    break;
                case "USDGBP":
                    convertedSum = sum * usd / gbp;
                    break;
                case "EURBGN": // EUR
                    convertedSum = sum * eur;
                    break;
                case "EURUSD":
                    convertedSum = sum * eur / usd;
                    break;
                case "EURGBP":
                    convertedSum = sum * eur / gbp;
                    break;
                case "GBPBGN": // GBP
                    convertedSum = sum * gbp;
                    break;
                case "GBPEUR":
                    convertedSum = sum * gbp / eur;
                    break;
                case "GBPUSD":
                    convertedSum = sum * gbp / usd;
                    break;
                default:
                    break;
            }

            Console.WriteLine(Math.Round(convertedSum, 2) + " " + convertingCurrency);
        }
    }
}
