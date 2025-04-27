namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        // Versão 6: Refatoração com utilização de Classes e Métodos
        static void Main(string[] args)
        {
            while (true)
            {
                JogoForca jogo = new JogoForca();

                jogo.palavraEscolhida = jogo.SortearPalavra();

                char[] letrasEncontradas = new char[jogo.palavraEscolhida.Length];

                jogo.tamanhoDaPalavra(letrasEncontradas);

                int quantidadeErros = 0;
                bool jogadorEnforcou = false;
                bool jogadorAcertou = false;

                do
                {
                    jogo.DesenharForca(quantidadeErros);

                    Console.WriteLine("Palavra escolhida: " + String.Join("", letrasEncontradas));
                    Console.WriteLine("----------------------------------------------");
                    Console.Write("Digite uma letra: ");
                    char chute = Console.ReadLine()!.ToUpper()[0];

                    bool letraFoiEncontrada = false;

                    bool encontrada = jogo.CompararLetras(chute, letrasEncontradas, letraFoiEncontrada);

                    if (encontrada == false)
                    {
                        quantidadeErros++;
                    }
                    string palavraEncontrada = String.Join("", letrasEncontradas);

                    jogadorAcertou = palavraEncontrada == jogo.palavraEscolhida;
                    jogadorEnforcou = quantidadeErros > 5;

                    jogo.JogadorAcertou(jogadorAcertou);

                    jogo.JogadorEnforcou(jogadorEnforcou);

                } while (jogadorEnforcou == false && jogadorAcertou == false);

                Console.Write("Deseja continuar? (S/N): ");

                string opcaoContinuar = Console.ReadLine().ToUpperInvariant();

                if (opcaoContinuar != "S")
                    break;
            }
        }
    }
}
