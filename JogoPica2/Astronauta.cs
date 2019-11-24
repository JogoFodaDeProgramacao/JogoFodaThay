using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace JogoPica
{
    class Astronauta
    {
        private decimal estamina;
        private decimal fome;
        private decimal sede;
        private int artefatos;
        private decimal vida;
        private int ataque;

        public Astronauta(decimal estamina, decimal fome, decimal sede, int artefatos, decimal vida, int ataque)
        {
            this.estamina = estamina;
            this.fome = fome;
            this.sede = sede;
            this.artefatos = artefatos;
            this.vida = vida;
            this.ataque = ataque;
        }
        public void aumentoDeAgua(decimal aumento)
        {
            this.sede += aumento;
        }
        public void percaDeAgua(decimal perca)
        {
            this.Sede -= perca;
        }
        public void percaDeFome(decimal perca)
        {
            this.Fome -= perca;
        }
        public void resetStatus()
        {
            this.estamina = 100;
            this.vida = 100;
        }
        public void exibirStatus()
        {
            Console.WriteLine(string.Empty);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("==================================================");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" COSMIC ESCAPE ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=====================================================");
            Console.ResetColor();
            Console.WriteLine(string.Empty);
                        
            Console.WriteLine("- Seus status estão diminuindo!");
            Console.WriteLine("- Se FOME ou SEDE chegarem a 0, sua VIDA irá diminuir gradativamente                                                  ");
            Console.WriteLine("- Aperte alguma tecla sem pressionar enter                                                           Status do jogador");
            Console.WriteLine("[A] - Buscar água [10 Estamina]                                                                      -----------------");
            Console.WriteLine("[C] - Buscar comida [10 Estamina]                                                                    -Estamina.: " + this.estamina);
            Console.WriteLine("[M] - Buscar artefatos [30 Estamina]                                                                 -Fome.....: " + this.fome);
            Console.WriteLine("                                                                                                     -Sede.....: " + this.sede);
            Console.WriteLine("                                                                                                     -Artefatos: " + "" + this.artefatos);
            Console.WriteLine("                                                                                                     -Vida.....: " + this.vida);
            Console.WriteLine("                                                                                                     -----------------");
        }
        public void statusBatalhaAstro()
        {
            Console.WriteLine("===============");
            Console.Write("Vida : ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(this.Vida);
            Console.ResetColor();


            Console.Write("Estamina: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(this.estamina);
            Console.ResetColor();
            Console.WriteLine("===============");
        }
        public void serAtacado(decimal dano)
        {
            dano = Math.Max(dano, 1);
            this.Vida = (this.vida - dano);

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Astronauta foi atacado com ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(dano + "pts ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("de dano. ");
            Console.ResetColor();
        }
        public void Atacar(Inimigo inimigo)
        {
            // Ação      
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("[Astronauta]: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Atacou o inimigo!");
            Console.ResetColor();
            this.estamina = estamina - 10;
            int dano = this.ataque;
            inimigo.serAtacado(dano);

            // StatusAstro
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Vida do astronauta: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(this.vida + ".");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" Estamina do astronauta: ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(this.estamina + ".");
            Console.ResetColor();
            // StatusEnemy
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Vida do inimigo: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(inimigo.Vida + ".");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(" Estamina do inimigo: ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(inimigo.Estamina + ".");
            Console.ResetColor();

            Console.WriteLine(String.Empty);
        }

        public void DefendeuAtaque(Inimigo inimigo)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("[Astronauta]: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Defendeu o ataque do inimigo!");
            Console.ResetColor();
            this.estamina = estamina - 15;

            // StatusAstro
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Vida do astronauta: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(this.Vida + ".");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" Estamina do astronauta: ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(this.Estamina + ".");
            Console.ResetColor();
            // StatusEnemy
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Vida do inimigo: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(inimigo.Vida + ".");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(" Estamina do inimigo: ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(inimigo.Estamina + ".");
            Console.ResetColor();
            Console.WriteLine("=============================================");
            Console.WriteLine(String.Empty);

        }
        public void Defender(Inimigo inimigo)
        {
            // Ação
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("[Astronauta]: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("defendeu, não perdeu vida.");
            Console.ResetColor();

            //StatusAstro
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Vida do astronauta: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(this.vida + ".");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" Estamina do astronauta: ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(this.estamina + ".");
            Console.ResetColor();
            //StatusEnemy
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Vida do inimigo: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(inimigo.Vida + ".");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(" Estamina do inimigo: ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(inimigo.Estamina + ".");
            Console.ResetColor();

            Console.WriteLine(String.Empty);
        }

        public decimal Vida
        {
            set
            {
                if (value > 0)
                {
                    if (value > 100)
                    {
                        this.vida = 100;
                    }
                    else
                    {
                        this.vida = value;
                    }
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

        public decimal Estamina
        {
            set
            {
                if (value > 0)
                {
                    if (value > 100)
                    {
                        this.estamina = 100;
                    }
                    else
                    {
                        this.estamina = value;
                    }
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
        public decimal Sede
        {
            set
            {
                if (value > 0)
                {
                    if (value > 100)
                    {
                        this.sede = 100;
                    }
                    else
                    {
                        this.sede = value;
                    }
                }
                else
                {
                    this.sede = 0;
                }
            }
            get
            {
                return this.sede;
            }
        }
        public decimal Fome
        {
            set
            {
                if (value > 0)
                {
                    if (value > 100)
                    {
                        this.fome = 100;
                    }
                    else
                    {
                        this.fome = value;
                    }
                }
                else
                {
                    this.fome = 0;
                }

            }
            get
            {
                return this.fome;
            }
        }

        public bool EstaVivoB()
        {
            if (this.Vida > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Ataque
        {
            get
            {
                return this.ataque;
            }
        }
        public void perderEstamina(int perca)
        {
            this.estamina -= perca;
        }
        public void declinioVida(decimal declinio)
        {
            this.vida -= declinio;
        }
        public void GanhoEstamina(decimal ganho)
        {
            this.Estamina += ganho;
        }
        public int Artefatos
        {
            get
            {
                return this.artefatos;
            }
            set
            {
                if (value > 0) // Maior que 0?
                {
                    if (value > 5) // Maior que 5?
                    {
                        this.artefatos = 5;
                    }
                    else // Maior que 0 e menor que 5?
                    {
                        this.artefatos = value;
                    }
                }
                else // Menor que 0?
                {
                    this.artefatos = 0;
                }
            }
        }
    }
}
