﻿namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {

        // Versão 1: Estrutura básica e entrada do usuário              
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("              Jogo da Forca!               ");
                Console.WriteLine("-------------------------------------------");

                Console.WriteLine("Digite uma letra: ");
                char chute = Console.ReadLine()[0];

                Console.WriteLine(chute);

                Console.ReadLine();


            }

        }
    }
}
