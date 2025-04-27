namespace JogoDaForca.ConsoleApp
{
    public class JogoForca
    {
        public string palavraEscolhida;


        public string SortearPalavra()
        {
            string[] palavras =
            {
                    "ABACATE",
                    "ABACAXI",
                    "ACEROLA",
                    "ACAI",
                    "ARACA",
                    "ABACATE",
                    "BACABA",
                    "BACURI",
                    "BANANA",
                    "CAJA",
                    "CAJU",
                    "CARAMBOLA",
                    "CUPUACU",
                    "GRAVIOLA",
                    "GOIABA",
                    "JABUTICABA",
                    "JENIPAPO",
                    "MACA",
                    "MANGABA",
                    "MANGA",
                    "MARACUJA",
                    "MURICI",
                    "PEQUI",
                    "PITANGA",
                    "PITAYA",
                    "SAPOTI",
                    "TANGERINA",
                    "UMBU",
                    "UVA",
                    "UVAIA"
            };

            Random random = new Random();

            int indiceEscolhido = random.Next(palavras.Length);

            string palavraEscolhida = palavras[indiceEscolhido];

            return palavraEscolhida;

        }
        public void tamanhoDaPalavra(char[] letrasEncontradas)
        {
            for (int caractere = 0; caractere < letrasEncontradas.Length; caractere++)
                letrasEncontradas[caractere] = '_';
        }

        public void DesenharForca(int quantidadeErros)
        {
            string cabecaDoBoneco = quantidadeErros >= 1 ? " o " : " ";
            string tronco = quantidadeErros >= 2 ? "x" : " ";
            string troncoBaixo = quantidadeErros >= 2 ? " x " : " ";
            string bracoEsquerdo = quantidadeErros >= 3 ? "/" : " ";
            string bracoDireito = quantidadeErros >= 4 ? @"\" : " ";
            string pernas = quantidadeErros >= 5 ? "/ \\" : " ";

            Console.Clear();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Jogo da Forca");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(" ___________        ");
            Console.WriteLine(" |/        |        ");
            Console.WriteLine(" |        {0}       ", cabecaDoBoneco);
            Console.WriteLine(" |        {0}{1}{2} ", bracoEsquerdo, tronco, bracoDireito);
            Console.WriteLine(" |        {0}       ", troncoBaixo);
            Console.WriteLine(" |        {0}       ", pernas);
            Console.WriteLine(" |                  ");
            Console.WriteLine(" |                  ");
            Console.WriteLine("_|____              ");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Erros do jogador: " + quantidadeErros);
            Console.WriteLine("----------------------------------------------");
        }

        public bool CompararLetras(char chute, char[] letrasEncontradas, bool letraFoiEncontrada)
        {
            for (int contador = 0; contador < palavraEscolhida.Length; contador++)
            {
                char letraAtual = palavraEscolhida[contador];

                if (chute == letraAtual)
                {
                    letrasEncontradas[contador] = letraAtual;
                    letraFoiEncontrada = true;
                }
            }
                return letraFoiEncontrada;
        }

        public bool JogadorAcertou(bool jogadorAcertou)
        {
            if (jogadorAcertou)
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine($"Você acertou a palavra secreta {palavraEscolhida}, parabéns!");
                Console.WriteLine("----------------------------------------------");
            }
            return jogadorAcertou;
        }

        public bool JogadorEnforcou(bool jogadorEnforcou)
        {
            if (jogadorEnforcou)
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine($"Você foi enforcado! A palavra era {palavraEscolhida}.");
                Console.WriteLine("----------------------------------------------");
            }
            return jogadorEnforcou;
        }

    }
}
