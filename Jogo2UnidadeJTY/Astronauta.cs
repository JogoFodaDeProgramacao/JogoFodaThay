
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Jogo2UnidadeJTY
{
    class Astronauta
    {
        private int estamina;
        private int fome;
        private int sede;
        private int artefatos = 5;

        public Astronauta(int estamina, int fome, int sede)
        {
            this.estamina = estamina;
            this.fome = fome;
            this.sede = sede;
        }

        public void exibirStatus()
        {
            Console.WriteLine("Estamina: " + this.estamina);
            Console.WriteLine("Fome: " + this.fome);
            Console.WriteLine("Sede: " + this.sede);
            Thread.Sleep(500);
            Console.Clear();
        }
    }
}
