using System;

namespace Exercicio2_array
{
    internal class Program
    {
        static void Main()
        {
            string[] convidados = new string[20];
            for (int posiçao = 0; posiçao < convidados.Length; posiçao++)
            {
                Console.Write(" informe o nome do convidado: ");
                convidados[posiçao] = (Console.ReadLine());
                if (string.IsNullOrEmpty(convidados[posiçao])) 
                {
                    break;
                }
            }
           
            Console.WriteLine("Convidados informados:");
            for (int posiçao = 0;posiçao < convidados.Length;posiçao++)
            {
                Console.WriteLine(convidados[posiçao]);
            }
               
                
               
              
            Console.ReadKey();      
        }
    }
}