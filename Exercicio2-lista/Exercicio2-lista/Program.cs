namespace Exercicio2_lista
{
    internal class Program
    {
        static void Main()
        {
            List<string> convidados = new List<string>();
            while (true) 
            {

                Console.WriteLine("insira o nome do convidado");
                string nome = Console.ReadLine();
                if (string.IsNullOrEmpty(nome))
                {
                    break;
                }
                convidados.Add(nome);   
            }           
            if (convidados.Count > 0)
            {
                for (int i = 0; i < convidados.Count; i++)
                {
                    Console.WriteLine( convidados[i]);
                }
            }
        }
            
        
    }
}