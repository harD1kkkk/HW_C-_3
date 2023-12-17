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
                Console.WriteLine("Enter email: ");
                string email = Console.ReadLine();
                var result = Regex.Match(email, "^[a-zA-Z0-9]+[/.]+[a-zA-Z0-9]+[@]+(itstep)+(.ua)$");
                bool a = result.Success;
                Console.WriteLine(a);
            }
        }
    }
}