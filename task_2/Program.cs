// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;
namespace Myspace
{
    class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter phone number: ");
                string phone = Console.ReadLine();
                var result = Regex.Match(phone, @"\+380 [0-9]{2} [0-9]{3} [0-9]{2} [0-9]{2}");
                bool a = result.Success;
                Console.WriteLine(a);
            }
        }
    }
}