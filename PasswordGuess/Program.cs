using System;

namespace PasswordGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Console.WriteLine(input == "s3cr3t!P@ssw0rd" ? "Welcome" : "Wrong Password!");
        }
    }
}
