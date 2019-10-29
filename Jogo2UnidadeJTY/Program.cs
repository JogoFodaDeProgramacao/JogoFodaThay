using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Jogo2UnidadeJTY
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime momentoInicial = DateTime.Now;


            
            Color color = new Color();
            Console.WriteLine("Olá! Seja bem vindo(a)!");
            Console.WriteLine("Como gostaria de ser chamado(a)?");
            string nome = Console.ReadLine();
            Console.WriteLine(nome + " que belo nome! Vamos então começar a nossa aventura!");
            color.Amarelo("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            color.Verde("Estamos no ano 2500, vivemos viajando entre os planetas apenas por diversão"); // Narração
            Console.WriteLine("AHHHH O QUE ESTÁ ACONTECENDO?! SOCORRO!"); // Astronauta
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Fique calmo, estamos tentando te localizar e logo enviaremos o que for preciso para que você volte para casa"); // Estação de controle
            Console.WriteLine("Lembre de seguir oo protocolo"); // Estação de controle
            Console.ResetColor();
            Console.WriteLine("NÃO! AQUI NÃO! "); // Astronauta
            color.Verde("Cai e a nave não consegue mais voar"); // Narração
            Console.WriteLine("Tudo bem, tudo bem, tenho que me acalmar"); // Astronauta
            Console.WriteLine("No manual dizia que eu não posso ir para muito longe, se as peças quebraram, todas devem estar por perto"); // Astronauta
            Console.WriteLine("Estou na Terra, então tenho 5 dias de suprimento, enquanto isso tenho que tomar cuidado."); // Astronauta
            Console.WriteLine("Espero conseguir encontrar tudo rápido, não posso demorar"); // Astronauta
            Console.WriteLine("");
            color.Amarelo("Pressione qualquer tecla...");
            Console.ReadKey();
            Console.Clear();
            

            Astronauta astro = new Astronauta(100, 100, 100);

            do
            {
                astro.exibirStatus();

                DateTime agora = DateTime.Now;

                int segundos = (agora - momentoInicial).Seconds;
                int minutos = (agora - momentoInicial).Minutes;

                Console.WriteLine("0" + minutos + ":" + segundos);

                if (minutos >= 1)
                {
                    Console.WriteLine("Está de noite");

                }

            } while (true);

        }
    }
}