using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace JogoPica
{
    class Color
    {
        public void Verde(string texto)
        {
            for (int i = 0; i < texto.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(texto[i]);
                Thread.Sleep(15);
                Console.ResetColor();
            }
            Console.WriteLine();
        }

        public void Amarelo(string texto)
        {
            for (int i = 0; i < texto.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(texto[i]);
                Thread.Sleep(15);
                Console.ResetColor();
            }
            Console.WriteLine();
        }


    }
}
