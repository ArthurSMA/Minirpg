using System;
using Minirpg.Entities;

namespace Minirpg
{
    class MyGame
    {
        static void Main(string[] args)
        {
            Console.Clear();            
            string init = " INICIO ";
            Amarelo am = new Amarelo(init);
            Console.WriteLine();
            TelaInicio tn = new TelaInicio();
        }
    }
}
