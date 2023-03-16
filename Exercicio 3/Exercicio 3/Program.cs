using System.Globalization;
using System.Runtime.InteropServices;

namespace Exercicio_3
{
    internal class Program
    {
        static void Main()
        {
            List<string> frutas = new List<string>();
            Console.WriteLine("Digite as frutas separadas por virgula:");
            string input = Console.ReadLine();
            string[] frutasarray = input.Split(',');
            
            foreach (string fruta in frutasarray)
            {
                frutas.Add(fruta.Trim());
            }
            Console.WriteLine("\n frutas digitadas:");
            foreach (string fruta in frutas)
            {
                Console.WriteLine(FirstLetterToUpper(fruta));
            }
        }
        static string FirstLetterToUpper(string fruta)
        {
            if (string.IsNullOrEmpty(fruta))
            {
                return string.Empty;
            }
            if (!frutas.contains(fruta))
            char[] letters = fruta.ToCharArray();
            letters[0] = char.ToUpper(letters[0]);
            return new string(letters);
        }
    }
}
