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
                Thread.Sleep(10);
                Console.ResetColor();
            }
            Console.WriteLine();
        }

        public void AmareloL(string texto)
        {
            for (int i = 0; i < texto.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(texto[i]);
                Thread.Sleep(5);
                Console.ResetColor();
            }
            Console.WriteLine();
        }

        public void AmareloR(string texto)
        {
            for (int i = 0; i < texto.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(texto[i]);
                Console.ResetColor();
            }
            Console.WriteLine();
        }

        public void Ciano(string texto)
        {
            for (int i = 0; i < texto.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(texto[i]);
                Console.ResetColor();
            }
            Console.WriteLine();
        }

        public void CinzaL(string texto)
        {
            for (int i = 0; i < texto.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(texto[i]);
                Thread.Sleep(5);
                Console.ResetColor();
            }
            Console.WriteLine();
        }

        public void CinzaR(string texto)
        {
            for (int i = 0; i < texto.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(texto[i]);
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }
}
