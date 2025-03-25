namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {

        // Versão 3: Exibindo os caracteres que foram acertados          
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


                int quantidadeErros = 0;
                bool jogadorEnforcou = false;
                bool jogadorAcertou = false;

                do
                {
                    string dicaDaPalavra = string.Join(" ", letrasEncontradas);

                    Console.Clear();
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("              Jogo da Forca!               ");
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine($"Palavra secreta: {dicaDaPalavra}");

                    Console.WriteLine("Digite uma letra: ");
                    char chute = Console.ReadLine()[0]; // Obtem apenas o primeiro caracter de uma string

                    for (int contador = 0; contador < palavraSecreta.Length; contador++)
                    {
                       char letraAtual = palavraSecreta[contador];
                       
                        if (chute == letraAtual)
                        {
                            letrasEncontradas[contador] = letraAtual;
                        }
                    }

                    Console.ReadLine();

                } while (jogadorAcertou == false || jogadorEnforcou == false);

            }

        }
    }
}
