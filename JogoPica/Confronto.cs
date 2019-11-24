using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace JogoPica
{
    class Confronto
    {
        private Astronauta astro;
        private Inimigo inimigo;

        public Confronto(Astronauta astro, Inimigo inimigo)
        {
            this.astro = astro;
            this.inimigo = inimigo;
        }
        public void exibir()
        {
            Console.WriteLine("=============================================");
            Console.Write("Vida : ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(astro.Vida);
            Console.ResetColor();
            Console.Write("               Vida do inimigo: ");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(inimigo.Vida);
            Console.ResetColor();
        }

        public bool Batalhar()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Iniciando batalha..");
            Console.ResetColor();
            Thread.Sleep(1000);
            Console.WriteLine("Obs1 : O inimigo escolherá uma ação aleatória");
            Console.WriteLine("Obs2 : Em caso de defesa mútua, ela custará menos estamina [10]");
            Console.WriteLine("Obs3 : Se a estamina do inimigo zerar, você vence a batalha");
            Console.WriteLine("Obs4 : Perder a batalha resulta no fim do jogo");
            Console.WriteLine("Obs3 : Vencer a batalha resulta na regeneração total de estamina e vida");
            Console.WriteLine("Ataque do inimigo : " + inimigo.Ataque + " pts [25 Estamina]");

            Console.WriteLine(string.Empty);
            while (this.astro.EstaVivoB() && this.inimigo.EstaVivo() && (!this.inimigo.EstaCansado()))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Escolha uma ação: ");
                Console.WriteLine("[1] - Atacar (20 Estamina) [" + astro.Ataque + " pts]");
                Console.WriteLine("[2] - Defender(10 Estamina) [ Bloqueia todo o dano ]");

                Console.ResetColor();

                int opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1: // Astronauta ataca
                        Thread.Sleep(1500);
                        if (this.inimigo.EstaVivo()) // Inimigo está vivo?
                        {
                            Random random = new Random();
                            int num = random.Next(1, 101);

                            if ((opcao == 1) && (num >= 50)) // Se Astro ataca e inimigo ataca
                            {
                                this.astro.Atacar(this.inimigo); // Astronauta Ataca o inimigo
                                this.inimigo.Atacar(this.astro); // Inimigo Ataca o astronauta
                                // ATK X ATK
                            }
                            else if ((opcao == 1) && (num < 50)) // Astro ataca e inimigo defende
                            {
                                this.astro.perderEstamina(20);
                                this.inimigo.DefendeuAtaque(this.astro);
                                //ATK X DEF
                            }
                        }
                        break;
                    case 2: // Astronauta Defende
                        Thread.Sleep(1500);
                        if (this.inimigo.EstaVivo()) //Inimigo vivo?
                        {
                            Random random = new Random(); // Random inimigo
                            int num = random.Next(1, 101);

                            if ((opcao == 2) && (num >= 50)) // Se Astro defende e inimigo ataca
                            {
                                this.inimigo.perderEstamina(20);
                                this.astro.DefendeuAtaque(this.inimigo);
                                //DEF X ATK
                            }
                            else if ((opcao == 2) && (num < 50))
                            {
                                this.inimigo.perderEstamina(15); // Perde 15 de estamina por apenas defender
                                this.astro.perderEstamina(10); // Perde 10 de estamina por apenas defender
                                this.astro.Defender(inimigo);
                                this.inimigo.Defender(astro);
                                //DEF X DEF
                            }
                        }
                        break;
                }
            }



            if (this.astro.EstaVivoB())
            {
                // Vitória
                return true;
            }
            else
            {
                // Derrota
                return false;
            }
        }

    }

}
