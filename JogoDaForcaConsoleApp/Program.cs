namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {

        // Versão 2: Exibir palavra secreta com traços            
        static void Main(string[] args)
        {
            while(true)
            {
                string palavraSecreta = "MELANCIA";

                char[] letrasEncontradas = new char[palavraSecreta.Length];

                for (int caractere = 0; caractere < letrasEncontradas.Length, caractere++)
                {
                    letrasEncontradas[caractere] = '_';
                   
                }

                string dicaDaPalavra = string.Join(" ", letrasEncontradas);

                Console.Clear();
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("              Jogo da Forca!               ");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine($"Palavra secreta: {dicaDaPalavra}");

                Console.WriteLine("Digite uma letra: ");
                char chute = Console.ReadLine()[0]; // Obtem apenas o primeiro caracter de uma string

                Console.WriteLine(chute);

                Console.ReadLine();


            }

        }
    }
}
