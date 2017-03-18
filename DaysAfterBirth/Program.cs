using System;
using System.Globalization;

namespace DaysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            var format = "dd-MM-yyyy";
            var inputDate = DateTime.ParseExact(Console.ReadLine(),format, provider);
            var newDate = inputDate.AddDays(999);
            Console.WriteLine(newDate.ToString(format));
            
        }
    }
}
