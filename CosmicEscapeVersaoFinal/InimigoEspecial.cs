using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoPica
{
    class InimigoEspecial : Inimigo
    {
        public InimigoEspecial(int vida, int estamina, int ataque) : base(vida, estamina, ataque)
        {
        }
        public override void Atacar(Astronauta astro)
        {
            Random random = new Random();
            int chance = random.Next(0, 101);
            // 75% chance de ataque normal
            if (chance <= 75)
            {
                base.Atacar(astro);
            }
            else
            {
                AtaquePenetrante(astro);
            }
        }
        public void AtaquePenetrante(Astronauta astro) // Dobra o dano de ataque e recupera vida
        {

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("[Inimigo]: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Atacou o astronauta com ataque penetrante, dobro de ataque e regen de vida!");
            Console.ResetColor();

            int dano = this.ataque *2; 
            astro.serAtacado(dano);
            this.Estamina -= 35;
            this.Vida += 15;

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
        
    }
}
