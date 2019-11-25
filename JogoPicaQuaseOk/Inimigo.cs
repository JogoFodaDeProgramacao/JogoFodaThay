using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoPica
{
    class Inimigo
    {
        protected int vida;
        private int estamina;
        protected int ataque;


        public Inimigo(int vida, int estamina, int ataque)
        {
            this.vida = vida;
            this.estamina = estamina;
            this.ataque = ataque;     
        }

        public int Vida
        {
            set
            {
                if (value > 0)
                {
                    this.vida = value;
                }
                else
                {
                    this.vida = 0;
                }
            }
            get
            {
                return this.vida;
            }
        }
        public int Estamina
        {
            set
            {
                if (value > 0)
                {
                    this.estamina = value;
                }
                else
                {
                    this.estamina = 0;
                }
            }
            get
            {
                return this.estamina;
            }
        }
        public int Ataque
        {
            get
            {
                return this.ataque;
            }
        }

        public void DefendeuAtaque(Astronauta astro)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("[Inimigo]: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Defendeu o ataque do astronauta!");
            Console.ResetColor();
            this.Estamina -= 20;
            // StatusAstro
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Vida do astronauta: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(astro.Vida + ".");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" Estamina do astronauta: ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(astro.Estamina + ".");
            Console.ResetColor();
            // StatusEnemy
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Vida do inimigo: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(this.Vida + ".");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(" Estamina do inimigo: ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(this.Estamina + ".");
            Console.ResetColor();
            Console.WriteLine("=============================================");
            Console.WriteLine(String.Empty);
        }
        public virtual void Atacar(Astronauta astro)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("[Inimigo]: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Atacou o astronauta!");
            Console.ResetColor();

            int dano = this.ataque;
            astro.serAtacado(dano);
            this.Estamina -= 25;

            // StatusAstro
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Vida do astronauta: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(astro.Vida + ".");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" Estamina do astronauta: ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(astro.Estamina + ".");
            Console.ResetColor();
            // StatusEnemy
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Vida do inimigo: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(this.Vida + ".");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(" Estamina do inimigo: ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(this.Estamina + ".");
            Console.ResetColor();
            Console.WriteLine("=============================================");
            Console.WriteLine(String.Empty);
        }

        public void Defender(Astronauta astro)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("[Inimigo]: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("defendeu, não perdeu vida.");
            Console.ResetColor();
           
            // StatusAstro
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Vida do astronauta: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(astro.Vida + ".");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Estamina do astronauta: ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(astro.Estamina + ".");
            Console.ResetColor();
            //StatusEnemy
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Vida do inimigo: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(this.vida + ".");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(" Estamina do inimigo: ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(this.estamina + ".");
            Console.ResetColor();
            Console.WriteLine("=============================================");
            Console.WriteLine(String.Empty);
            
        }

        public virtual void serAtacado(int dano)
        {
            dano = Math.Max(dano , 1);
            this.Vida = (this.vida - dano);

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Inimigo foi atacado com ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(dano + "pts ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("de dano. ");
        }

        public bool EstaVivo()
        {
            if (this.vida > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void perderEstamina(int perca)
        {
            this.Estamina -= perca;
        }
        public bool EstaCansado()
        {
            if (this.Estamina <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
