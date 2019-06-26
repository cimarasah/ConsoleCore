using System;
using GameTop.Lib;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
           var jogador1 = new Jogador1("Cimara");
           var jogador2 = new Jogador2();
           var jogo = new JogoFoda(jogador1, jogador2);
           jogo.IniciarJogo();
        }
    }

    
}
