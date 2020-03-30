using System;
using GameTop.Lib;
using GameTop;

namespace GameTop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var jogo = new JogoFoda(
                new Jogador1("Ronaldo"),
                new Jogador2()
                );
            jogo.IniciarJogo();
        }
    }

    
    
}
