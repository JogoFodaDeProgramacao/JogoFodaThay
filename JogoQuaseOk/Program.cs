using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace JogoPica
{
    class Program
    {
        static void Main(string[] args)
        {                       
            Console.WindowWidth = 130;
            Console.WindowHeight = 40;

            Console.WriteLine("                                                                              ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("==================================================================================================================================");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("  ______   ______        _______..___  ___.  __    ______     _______      _______.  ______      ___      .______    _______ ");
            Console.WriteLine(" /      | /  __  \\      /       ||   \\/   | |  |  /      |   |   ____|    /       | /      |    /   \\     |   _  \\  |   ____|");
            Console.WriteLine("|  ,----'|  |  |  |    |   (----`|  \\  /  | |  | |  ,----'   |  |__      |   (----`|  ,----'   /  ^  \\    |  |_)  | |  |__   ");
            Console.WriteLine("|  |     |  |  |  |     \\   \\    |  |\\/|  | |  | |  |        |   __|      \\   \\    |  |       /  /_\\  \\   |   ___/  |   __|  ");
            Console.WriteLine("|  `----.|  `--'  | .----)   |   |  |  |  | |  | |  `----.   |  |____ .----)   |   |  `----. /  _____  \\  |  |      |  |____ ");
            Console.WriteLine(" \\______| \\______/  |_______/    |__|  |__| |__|  \\______|   |_______||_______/     \\______|/__/     \\__\\ | _|      |_______|");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("                                                                              ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("==================================================================================================================================");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                                                                              ");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("                                                \\▄▄▄/                                            ");
            Console.WriteLine("              █                                   █                               ████████        ");
            Console.WriteLine("              ██   █    ██                     ███████                           ██████████       ");
            Console.WriteLine("              ███ ██  █ ██                    ███ █ ███                         ██████ █████      ");
            Console.WriteLine("              ███ █   █ ██                    █████████                        ██████  ██████     ");
            Console.WriteLine("             ███████   ████                   █████████                       ██████    ██████    ");
            Console.WriteLine("            ████████████████                 ██       ██                     ██████      ██████   ");

            // Chão
            Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Console.WindowWidth = 120;
            
            Color colorido = new Color();
            Console.WriteLine(string.Empty);
            Console.WriteLine("                                             Olá! Seja bem vindo(a)!");
            Console.WriteLine("Como gostaria de ser chamado(a)?");
            string nome = Console.ReadLine();
            Console.WriteLine(string.Empty);
            Console.WriteLine("Que belo nome, " + nome + "! Vamos então começar a nossa aventura");
            Console.WriteLine(string.Empty);
            colorido.Amarelo("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(string.Empty);
            colorido.Verde("Estamos no ano 2500, vivemos viajando entre os planetas apenas por diversão"); // Narração
            Console.WriteLine("AHHHH O QUE ESTÁ ACONTECENDO?! SOCORRO!"); // Astronauta
            colorido.Ciano("Fique calmo, estamos tentando te localizar e logo enviaremos o que for preciso para que você volte para casa"); // Estação de controle
            Console.WriteLine("NÃO! AQUI NÃO! "); // Astronauta
            colorido.Verde("Cai e a nave não consegue mais voar"); // Narração
            Console.WriteLine("Tudo bem, tudo bem, tenho que me acalmar"); // Astronauta
            Console.WriteLine("No treinamento dizia que eu não posso ir para muito longe, se as peças quebraram, todas devem estar por perto"); // Astronauta

            Console.WriteLine("Estou na Terra, então tenho 5 dias de suprimento, enquanto isso tenho que tomar cuidado."); // Astronauta
            Console.WriteLine("Espero conseguir encontrar tudo rápido, não posso demorar"); // Astronauta
            Console.WriteLine("");
            colorido.Amarelo("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            
            Inimigo inimigo = new Inimigo(100, 100, 25);
            Inimigo inimigo2 = new Inimigo(100, 100, 25);
            Inimigo inimigo3 = new Inimigo(100, 100, 25);
            Inimigo inimigo4 = new Inimigo(100, 100, 25);
            Inimigo inimigo5 = new Inimigo(100, 100, 25);

            Inimigo inimigoEspecial = new InimigoEspecial(100, 100, 35);
            Inimigo inimigoEspecial2 = new InimigoEspecial(100, 100, 35);
            Inimigo inimigoEspecial3 = new InimigoEspecial(100, 100, 35);
            Inimigo inimigoEspecial4 = new InimigoEspecial(100, 100, 35);
            Inimigo inimigoEspecial5 = new InimigoEspecial(100, 100, 35);


            Astronauta astro = new Astronauta(100, 100, 100, 0, 100, 15);

            Confronto confronto = new Confronto(astro, inimigo);
            Confronto confronto2 = new Confronto(astro, inimigo2);
            Confronto confronto3 = new Confronto(astro, inimigo3);
            Confronto confronto4 = new Confronto(astro, inimigo4);
            Confronto confronto5 = new Confronto(astro, inimigo5);

            Confronto confrontoEspecial = new Confronto(astro, inimigoEspecial);
            Confronto confrontoEspecial2 = new Confronto(astro, inimigoEspecial2);
            Confronto confrontoEspecial3 = new Confronto(astro, inimigoEspecial3);
            Confronto confrontoEspecial4 = new Confronto(astro, inimigoEspecial4);
            Confronto confrontoEspecial5 = new Confronto(astro, inimigoEspecial5);

            Puzzle puzzle = new Puzzle();
            Color color = new Color();
            meuConsole mc = new meuConsole();
            DateTime momentoInicial = DateTime.Now;
            int dia = 1;
            do
            {
                //Decaimento de agua e fome
                if ((astro.Sede <= 0) || (astro.Fome <= 0))
                {
                    astro.declinioVida(0.3M);
                }
                astro.exibirStatus();
                Thread.Sleep(1000);
                Console.Clear();

                DateTime agora = DateTime.Now;

                int segundos = (agora - momentoInicial).Seconds;
                int minutos = (agora - momentoInicial).Minutes;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Tempo: ");
                Console.WriteLine(minutos + ":" + segundos);
                Console.WriteLine("Dia : " + dia);
                Console.ResetColor();

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo consolek = Console.ReadKey(true);

                    if (consolek.Key == ConsoleKey.A)
                    {
                        puzzle.BuscarAgua(astro);
                        Thread.Sleep(200);

                    }
                    if (consolek.Key == ConsoleKey.C)
                    {
                        puzzle.BuscarComida(astro);
                        Thread.Sleep(200);
                    }
                    if (consolek.Key == ConsoleKey.M)
                    {
                        puzzle.BuscarArtefatos(astro);
                        Thread.Sleep(200);
                    }
                }
                if (minutos == 2 && segundos == 0) // Dia 2
                {
                    // Anoitece
                    // 100 % de batalha comum
                    Random randomInv = new Random();
                    int opcaoInimigo = randomInv.Next(1, 3);
                    Console.WriteLine("A noite chegou, escolha um lugar para se esconder imediatamente!");
                    Console.WriteLine("     [1] - Buggy              [2] - Domo Espacial");
                    Console.WriteLine("        \\▄▄▄/                                     ");
                    Console.WriteLine("           █                        ████████        ");
                    Console.WriteLine("        ███████                    ██████████       ");
                    Console.WriteLine("       ███ █ ███                  ██████ █████      ");
                    Console.WriteLine("       █████████                 ██████  ██████     ");
                    Console.WriteLine("       █████████                ██████    ██████    ");
                    Console.WriteLine("      ██       ██              ██████      ██████   ");

                    // Chão
                    Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
                    Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                    int opcaoAstro = int.Parse(Console.ReadLine());
                    Console.WriteLine("Você escolheu se esconder na opção " + opcaoAstro);
                    Console.WriteLine("o inimigo escolheu invadir a opção " + opcaoInimigo);
                    if (opcaoAstro == opcaoInimigo)
                    {
                        mc.Write("O inimigo invadiu onde você se escondeu!");
                        Thread.Sleep(3000);
                        bool winBattle = confronto.Batalhar();
                        if (winBattle)
                        {
                            Console.WriteLine("O astronauta venceu!");
                            Console.WriteLine("Apagando a tela...");
                            astro.resetStatus();
                            Thread.Sleep(10000);

                        }
                        else
                        {
                            Console.WriteLine("O alien venceu.. você perdeu o jogo.");
                            Thread.Sleep(5000);
                            winBattle = false;

                        }
                        minutos += 1;
                    }
                    else
                    {
                        Console.WriteLine("O inimigo não te achou, um novo dia está começando...");
                        mc.Write("Aperte qualquer tecla para continuar...[ClearScreen]");
                        Console.ReadKey();

                    }
                    dia = 2;
                }
                else if (minutos == 5 && segundos == 0 ) // Dia 3
                {
                    Random randomInv = new Random();
                    int opcaoInimigo = randomInv.Next(1, 3);
                    Console.WriteLine("A noite chegou, escolha um lugar para se esconder imediatamente!");
                    Console.WriteLine("     [1] - Buggy              [2] - Domo Espacial");
                    Console.WriteLine("        \\▄▄▄/                                     ");
                    Console.WriteLine("           █                        ████████        ");
                    Console.WriteLine("        ███████                    ██████████       ");
                    Console.WriteLine("       ███ █ ███                  ██████ █████      ");
                    Console.WriteLine("       █████████                 ██████  ██████     ");
                    Console.WriteLine("       █████████                ██████    ██████    ");
                    Console.WriteLine("      ██       ██              ██████      ██████   ");

                    // Chão
                    Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
                    Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                    int opcaoAstro = int.Parse(Console.ReadLine());
                    Console.WriteLine("Você escolheu se esconder na opção " + opcaoAstro);
                    Console.WriteLine("o inimigo escolheu invadir a opção " + opcaoInimigo);
                    if (opcaoAstro == opcaoInimigo)
                    {
                        // 25% de chance de batalha especial
                        Random random = new Random();
                        int chance = random.Next(0, 101);
                        // 75% chance batalha comum
                        bool winBattle;
                        if (chance <= 75) // 75% de chance de batalha comum
                        {
                            mc.Write("O inimigo invadiu onde você estava escondido!");
                            Thread.Sleep(3000);
                            winBattle = confronto2.Batalhar();
                            if (winBattle)
                            {
                                Console.WriteLine("O astronauta venceu!");
                                Console.WriteLine("Apagando a tela...");
                                astro.resetStatus();
                                Thread.Sleep(10000);

                            }
                            else
                            {
                                Console.WriteLine("O alien venceu.. você perdeu o jogo.");
                                Thread.Sleep(5000);
                                winBattle = false;

                            }
                        }
                        else // 25% chance de batalha especial
                        {
                            mc.Write("O inimigo invadiu onde você estava escondido [Batalha especial]!");
                            Thread.Sleep(3000);
                            winBattle = confrontoEspecial.Batalhar();
                            if (winBattle)
                            {
                                Console.WriteLine("O astronauta venceu!");
                                Console.WriteLine("Apagando a tela...");
                                astro.resetStatus();
                                Thread.Sleep(10000);

                            }
                            else
                            {
                                Console.WriteLine("O alien venceu.. você perdeu o jogo.");
                                Thread.Sleep(5000);
                                winBattle = false;

                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("O inimigo não te achou, um novo dia está começando...");
                        mc.Write("Aperte qualquer tecla para continuar...[ClearScreen]");
                        Console.ReadKey();
                    }
                    minutos += 1;
                    dia = 3;
                }
                else if (minutos == 7 && segundos == 0) // Dia 4
                {
                    Random randomInv = new Random();
                    int opcaoInimigo = randomInv.Next(1, 3);
                    Console.WriteLine("A noite chegou, escolha um lugar para se esconder imediatamente!");
                    Console.WriteLine("     [1] - Buggy              [2] - Domo Espacial");
                    Console.WriteLine("        \\▄▄▄/                                     ");
                    Console.WriteLine("           █                        ████████        ");
                    Console.WriteLine("        ███████                    ██████████       ");
                    Console.WriteLine("       ███ █ ███                  ██████ █████      ");
                    Console.WriteLine("       █████████                 ██████  ██████     ");
                    Console.WriteLine("       █████████                ██████    ██████    ");
                    Console.WriteLine("      ██       ██              ██████      ██████   ");

                    // Chão
                    Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
                    Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                    int opcaoAstro = int.Parse(Console.ReadLine());
                    Console.WriteLine("Você escolheu se esconder na opção " + opcaoAstro);
                    Console.WriteLine("o inimigo escolheu invadir a opção " + opcaoInimigo);
                    if (opcaoInimigo == opcaoAstro)
                    {
                        // 25% de chance de batalha especial
                        Random random = new Random();
                        int chance = random.Next(0, 101);
                        // 50% chance batalha comum
                        bool winBattle;
                        if (chance <= 50) // 50% de chance de batalha comum
                        {
                            mc.Write("O inimigo invadiu onde você estava escondido!");
                            Thread.Sleep(3000);
                            winBattle = confronto3.Batalhar();
                            if (winBattle)
                            {
                                Console.WriteLine("O astronauta venceu!");
                                Console.WriteLine("Apagando a tela...");
                                astro.resetStatus();
                                Thread.Sleep(10000);

                            }
                            else
                            {
                                Console.WriteLine("O alien venceu.. você perdeu o jogo.");
                                Thread.Sleep(5000);
                                winBattle = false;

                            }
                        }
                        else // 50% chance de batalha especial
                        {
                            mc.Write("O inimigo invadiu onde você estava escondido [Batalha especial]!");
                            Thread.Sleep(3000);
                            winBattle = confrontoEspecial2.Batalhar();
                            if (winBattle)
                            {
                                Console.WriteLine("O astronauta venceu!");
                                Console.WriteLine("Apagando a tela...");
                                astro.resetStatus();
                                Thread.Sleep(10000);

                            }
                            else
                            {
                                Console.WriteLine("O alien venceu.. você perdeu o jogo.");
                                Thread.Sleep(5000);
                                winBattle = false;

                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("O inimigo não te achou, um novo dia está começando...");
                        mc.Write("Aperte qualquer tecla para continuar...[ClearScreen]");
                        Console.ReadKey();
                    }
                    dia = 4;
                    minutos += 1;
                }
                else if (minutos == 10 && segundos == 0)
                {
                    Random randomInv = new Random();
                    int opcaoInimigo = randomInv.Next(1, 3);
                    Console.WriteLine("A noite chegou, escolha um lugar para se esconder imediatamente!");
                    Console.WriteLine("     [1] - Buggy              [2] - Domo Espacial");
                    Console.WriteLine("        \\▄▄▄/                                     ");
                    Console.WriteLine("           █                        ████████        ");
                    Console.WriteLine("        ███████                    ██████████       ");
                    Console.WriteLine("       ███ █ ███                  ██████ █████      ");
                    Console.WriteLine("       █████████                 ██████  ██████     ");
                    Console.WriteLine("       █████████                ██████    ██████    ");
                    Console.WriteLine("      ██       ██              ██████      ██████   ");

                    // Chão
                    Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
                    Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                    int opcaoAstro = int.Parse(Console.ReadLine());
                    Console.WriteLine("Você escolheu se esconder na opção " + opcaoAstro);
                    Console.WriteLine("o inimigo escolheu invadir a opção " + opcaoInimigo);
                    if (opcaoAstro == opcaoInimigo)
                    {
                        // 100% de chance de batalha especial
                        mc.Write("O inimigo invadiu onde você estava escondido [Batalha Especial]!");
                        Thread.Sleep(3000);
                        bool winBattle = confrontoEspecial3.Batalhar();
                        if (winBattle)
                        {
                            Console.WriteLine("O astronauta venceu!");
                            Console.WriteLine("Apagando a tela...");
                            astro.resetStatus();
                            Thread.Sleep(10000);

                        }
                        else
                        {
                            Console.WriteLine("O alien venceu.. você perdeu o jogo.");
                            Thread.Sleep(5000);
                            winBattle = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("O inimigo não te achou, um novo dia está começando...");
                        mc.Write("Aperte qualquer tecla para continuar...[ClearScreen]");
                        Console.ReadKey();
                    }
                    dia = 5;
                }
                if (astro.Artefatos > 5 && dia == 5)
                {
                    Console.WriteLine("5 dias se passaram e o astronauta não encontrou os 5 artefatos..");
                    Console.WriteLine("Os aliens invadiram o planeta e ele não conseguiu sair!");
                    Console.WriteLine("Fim de jogo!");
                    Console.ReadKey();
                    break;
                    // Perde o jogo
                }
                else if (astro.Artefatos == 5)
                {
                    Console.WriteLine("O foguete foi reconstruido!");
                    Console.WriteLine("Saindo do planeta...");
                    Console.WriteLine("Você venceu o jogo!");
                    Console.WriteLine("Aperte qualquer tecla para fechar o jogo..");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                astro.percaDeAgua(0.23M); // Variável de perca de água
                astro.percaDeFome(0.20M); // Variável de perca de fome
                astro.GanhoEstamina(1.5M); // Variável de ganho de estamina
            } while (astro.EstaVivoB());
            Console.WriteLine("Voce perdeu o game!"); // Mensagem de game over
            Console.ReadKey();
        }
    }
}