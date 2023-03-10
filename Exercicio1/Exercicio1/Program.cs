namespace ConsoleApp2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("quantos convidados tem o noivo? ");
            int NumConvidadosNoivo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("quantos convidados tem a noiva?");
            int NumConvidadosNoiva = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("quantos convidados do noivo apareceram");
            int Numconvidadosnoivopresente = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("quantos convidados da noiva apareceram? ");
            int NumConvidadosnoivapresente = Convert.ToInt32(Console.ReadLine());

            int pessoas_na_festa = (NumConvidadosnoivapresente + Numconvidadosnoivopresente);

            if (Convert.ToBoolean(NumConvidadosNoiva < NumConvidadosnoivapresente) || Convert.ToBoolean(NumConvidadosNoivo < Numconvidadosnoivopresente)) ;
            {
                int intrusos = (NumConvidadosnoivapresente - NumConvidadosNoiva) + (Numconvidadosnoivopresente - NumConvidadosNoivo);
                Console.WriteLine("Temos " + (intrusos) + " intrusos na festa");
            }
            if (NumConvidadosNoiva > NumConvidadosNoivo)
            {
                Console.WriteLine("A noiva convidou mais do que o noivo");
            }
            else
            {
                Console.WriteLine("O noivo convidou mais do que a noiva");
            }
            if (Convert.ToBoolean(NumConvidadosNoiva == NumConvidadosnoivapresente) && Convert.ToBoolean(NumConvidadosNoivo == Numconvidadosnoivopresente)) ;
            {
                Console.WriteLine("Todos os convidados apareceram, portaria fechada!!");
            }
            if (Convert.ToBoolean(NumConvidadosNoiva != NumConvidadosnoivapresente) || Convert.ToBoolean(NumConvidadosNoivo != Numconvidadosnoivopresente)) ;
            {
                Console.WriteLine("Conferir lista de entrada!!!");
            }
            if (NumConvidadosNoivo >= Numconvidadosnoivopresente)
            {
                Console.WriteLine("Conferir pela ultima vez a lista do noivo!");
            }
            if (NumConvidadosnoivapresente <= NumConvidadosNoiva)
            {
                Console.WriteLine("Conferir pela ultima vez a lista de entrada da noiva!");
            }
            if (pessoas_na_festa >= 200)
            {
                bool festacheia = true;
                if (!festacheia) ;
                Console.WriteLine("festa cheia");
            }

            {

            }
        }
    }
}