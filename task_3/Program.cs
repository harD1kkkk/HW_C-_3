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
                Console.WriteLine("Enter password: ");
                string password = Console.ReadLine();
                var result = Regex.Match(password, "^(?=.*[A-Z])(?=.*[a-z])(?=.*\\d)(?=.*[!@#$%]).{8,}$");
                bool a = result.Success;
                Console.WriteLine(a);
            }
        }
    }
}