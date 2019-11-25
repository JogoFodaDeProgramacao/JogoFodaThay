using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace JogoPica
{
    class Puzzle
    {
        private bool lugar2block = false;
        private bool lugar3block = false;
        private bool lugar4block = false;
        private bool lugar5block = false;

        private bool art1Achado = false;
        private bool art2Achado = false;
        private bool art3Achado = false;
        private bool art4Achado = false;
        private bool art5Achado = false;

        Desenhos desenhos = new Desenhos();
        meuConsole meuconsole = new meuConsole();
        public bool BuscarAgua(Astronauta astro)
        {
            if(astro.Estamina >= 10)
            {
                meuconsole.Write("Saindo para buscar água...");
                astro.Estamina -= 10;
                Random random1 = new Random();
                int num1 = random1.Next(10, 50);

                Random random2 = new Random();
                int num2 = random2.Next(1, 10);

                int respSoma = num1 + num2;
                int respMulti = num1 * num2;
                int respQuadSoma = num1 * num1;

                Console.WriteLine("Qual o resultado da soma entre " + num1 + " e " + num2 + "?");
                int opcao = int.Parse(Console.ReadLine());
                if (opcao == respSoma)
                {
                    Console.WriteLine("Resposta certa!");
                    Console.WriteLine("Qual o resultado da multiplicação entre " + num1 + " e " + num2 + "?");
                    int opcao2 = int.Parse(Console.ReadLine());
                    if (opcao2 == respMulti)
                    {
                        Console.WriteLine("Resposta certa!");
                        Console.WriteLine("Qual o quadrado do número " + num1 + "?");
                        int opcao3 = int.Parse(Console.ReadLine());
                        if (opcao3 == respQuadSoma)
                        {
                            Random randomAgua = new Random();
                            int quant = randomAgua.Next(15, 31);
                            Console.WriteLine("Resposta certa!");
                            Console.WriteLine("Você achou " + quant + " de água!");
                            astro.Sede += quant;
                            Thread.Sleep(1500);
                            return true;
                        }
                        else
                        {
                            Random randomAgua = new Random();
                            int quant2 = randomAgua.Next(1, 7);
                            Console.WriteLine("Resposta errada!");
                            Console.WriteLine("Você perdeu " + quant2 + " de água!");
                            Thread.Sleep(1500);
                            astro.Sede -= quant2;
                            return false;
                        }
                    }
                    else
                    {
                        Random randomAgua = new Random();
                        int quant2 = randomAgua.Next(1, 7);
                        Console.WriteLine("Resposta errada!");
                        Console.WriteLine("Você perdeu " + quant2 + " de água!");
                        Thread.Sleep(1500);
                        astro.Sede -= quant2;
                        return false;
                    }
                }
                else
                {
                    Random randomAgua = new Random();
                    int quant2 = randomAgua.Next(1, 7);
                    Console.WriteLine("Resposta errada!");
                    Console.WriteLine("Você perdeu " + quant2 + " de água!");
                    Thread.Sleep(1500);
                    astro.Sede -= quant2;
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Sem estamina suficiente!");
                return false;
            }

        }

        public bool BuscarComida(Astronauta astro)
        {
            if (astro.Estamina >= 10)
            {
                meuconsole.Write("Saindo para buscar comida");
                Random random1 = new Random();
                int num1 = random1.Next(5, 45);

                Random random2 = new Random();
                int num2 = random2.Next(1, 15);

                int respSoma = num1 + num2;
                int respMulti = num1 * num2;
                int respQuadSoma = num1 * num1;

                Console.WriteLine("Qual o resultado da soma entre " + num1 + " e " + num2 + "?");
                int opcao = int.Parse(Console.ReadLine());
                if (opcao == respSoma)
                {
                    Console.WriteLine("Resposta certa!");
                    Console.WriteLine("Qual o resultado da multiplicação entre " + num1 + " e " + num2 + "?");
                    int opcao2 = int.Parse(Console.ReadLine());
                    if (opcao2 == respMulti)
                    {
                        Console.WriteLine("Resposta certa!");
                        Console.WriteLine("Qual o quadrado do número " + num1 + "?");
                        int opcao3 = int.Parse(Console.ReadLine());
                        if (opcao3 == respQuadSoma)
                        {
                            Random randomAgua = new Random();
                            int quant = randomAgua.Next(15, 31);
                            Console.WriteLine("Resposta certa!");
                            Console.WriteLine("Você achou " + quant + " de comida!");
                            astro.Fome += quant;
                            Thread.Sleep(1500);
                            return true;
                        }
                        else
                        {
                            Random randomAgua = new Random();
                            int quant2 = randomAgua.Next(1, 7);
                            Console.WriteLine("Resposta errada!");
                            Console.WriteLine("Você perdeu " + quant2 + " de comida!");
                            Thread.Sleep(1500);
                            astro.Fome -= quant2;
                            return false;
                        }
                    }
                    else
                    {
                        Random randomAgua = new Random();
                        int quant2 = randomAgua.Next(1, 7);
                        Console.WriteLine("Resposta errada!");
                        Console.WriteLine("Você perdeu " + quant2 + " de comida!");
                        Thread.Sleep(1500);
                        astro.Fome -= quant2;
                        return false;
                    }
                }
                else
                {
                    Random randomAgua = new Random();
                    int quant2 = randomAgua.Next(1, 7);
                    Console.WriteLine("Resposta errada!");
                    Console.WriteLine("Você perdeu " + quant2 + " de comida!");
                    Thread.Sleep(1500);
                    astro.Fome -= quant2;
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Sem estamina suficiente!");
                return false;
            }
        }

        public void BuscarArtefatos(Astronauta astro)
        {
           if (astro.Estamina >= 30)
           {
                Random randomLugar1 = new Random();
                Random randomLugar2 = new Random();
                Random randomLugar3 = new Random();
                Random randomLugar4 = new Random();
                Random randomLugar5 = new Random();

                int Lugar1 = randomLugar1.Next(1, 4);
                int Lugar2 = randomLugar2.Next(1, 4);
                int Lugar3 = randomLugar3.Next(1, 4);
                int Lugar4 = randomLugar4.Next(1, 4);
                int Lugar5 = randomLugar5.Next(1, 4);

                Color colorido = new Color();
                Console.WriteLine(string.Empty);
                Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine(string.Empty);
                colorido.Ciano("Você está saindo em busca dos 5 artefatos perdidos para consertar o foguete");
                colorido.Amarelo("OBS 1 : Buscar artefatos custa inicialmente 30 de estamina");
                colorido.Amarelo("OBS 2 : Caso ache um artefato, perderá mais 10 de estamina voltando para a base");
                colorido.Amarelo("OBS 3 : Caso NÃO ache um artefato, perderá mais 20 de estamina voltando para a base");
                colorido.Amarelo("OBS 4 : As regiões são desbloqueadas por hierarquia, começando pela região 1");
                colorido.Amarelo("OBS 5 : Sempre que iniciar a ação Buscar Artefatos, a posição deles será trocada aleatoriamente");
                Console.WriteLine(string.Empty);
                colorido.Ciano("Em que região deseja procurar?");
                colorido.Cinza("[1] - Montanhas de sulfato");
                colorido.Cinza("[2] - Vale pedregoso");
                colorido.Cinza("[3] - Caverna de chumbo");
                colorido.Cinza("[4] - Canyon de ametista");
                colorido.Cinza("[5] - Rio de mercúrio");

                int opcaoEscolhida = int.Parse(Console.ReadLine());   
                // 1 ------------------------------------------------
                if (opcaoEscolhida == 1 && !art1Achado)
                {
                    astro.Estamina -= 30;
                    desenhos.Montanha();
                    Console.WriteLine("Você escolheu explorar as regiões montanhosas de sulfato!, é bom levar uma máscara de gás para não morrer..");
                    Console.WriteLine("Quando a nave caiu, o reservatório de combustível foi desacoplado dela e voou longe para o alto dessas montanhas..");
                    Console.WriteLine("Digite em qual lugar você quer procurar [Apenas uma chance]");
                    Console.WriteLine("[1] - Norte");
                    Console.WriteLine("[2] - Sul");
                    Console.WriteLine("[3] - Leste");
                    Console.WriteLine("[4] - Oeste");
                    int opcaoAstro = int.Parse(Console.ReadLine());
                    if (opcaoAstro == Lugar1)
                    {
                        art1Achado = true;
                        desenhos.art1Found();
                        astro.Artefatos += 1;
                        astro.Estamina -= 10;
                        lugar2block = true;
                        Console.WriteLine("Aperte qualquer tecla para continuar.. [ClearScreen]");
                        Console.ReadKey();
                    } 
                    else if (opcaoAstro != Lugar1 && (opcaoAstro == 1 || opcaoAstro == 2 || opcaoAstro == 3 || opcaoAstro == 4))
                    {
                        Console.WriteLine("Você não achou nenhum artefato aqui...");
                        astro.Estamina -= 20;
                        Console.WriteLine("Aperte qualquer tecla para continuar.. [ClearScreen]");
                        Console.ReadKey();

                    }
                    else
                    {
                        Console.WriteLine("Você escolheu uma opção inválida, mesmo assim perdeu 30 de estamina");
                        Console.WriteLine("Aperte qualquer tecla para continuar.. [ClearScreen]");
                        Console.ReadKey();
                    }
                }
                else if((opcaoEscolhida == 1 && art1Achado))
                {
                    Console.WriteLine("Este artefato já foi encontrado!");
                }
                // 2 ------------------------------------------------
                if (opcaoEscolhida == 2 && lugar2block && !art2Achado)
                {
                    astro.Estamina -= 30;
                    desenhos.Vale();
                    Console.WriteLine("Você escolheu explorar a região do vale pedregoso!, esteja atento às depressões de pedra deste local..");
                    Console.WriteLine("No desastre da nave, o reservatório de oxigênio foi desacoplado dela e voou longe para o fundo deste vale..");
                    Console.WriteLine("Digite em qual lugar você quer procurar [Apenas uma chance]");
                    Console.WriteLine("[1] - Norte");
                    Console.WriteLine("[2] - Sul");
                    Console.WriteLine("[3] - Leste");
                    Console.WriteLine("[4] - Oeste");
                    int opcaoAstro = int.Parse(Console.ReadLine());
                    if (opcaoAstro == Lugar2) 
                    {
                        art2Achado = true;
                        desenhos.art2Found();
                        astro.Artefatos += 1;
                        astro.Estamina -= 10;
                        lugar3block = true;
                        Console.WriteLine("Aperte qualquer tecla para continuar.. [ClearScreen]");
                        Console.ReadKey();
                    }
                    else if (opcaoAstro != Lugar2 && (opcaoAstro == 1 || opcaoAstro == 2 || opcaoAstro == 3 || opcaoAstro == 4))
                    {
                        Console.WriteLine("Você não achou nenhum artefato aqui...");
                        astro.Estamina -= 20;
                        Console.WriteLine("Aperte qualquer tecla para continuar.. [ClearScreen]");
                        Console.ReadKey();

                    }
                    else
                    {
                        Console.WriteLine("Você escolheu uma opção inválida, mesmo assim perdeu 30 de estamina");
                        Console.WriteLine("Aperte qualquer tecla para continuar.. [ClearScreen]");
                        Console.ReadKey();
                    }
                }
                else if(opcaoEscolhida == 2 && lugar2block && art2Achado)
                {
                    Console.WriteLine("Este artefato já foi encontrado!");
                }
                else if (opcaoEscolhida == 2 && !lugar2block)
                {
                    Console.WriteLine("O lugar que deseja explorar ainda está bloqueado, complete os lugares anteriores!");
                }
                // 3 ------------------------------------------------
                if (opcaoEscolhida == 3 && lugar3block && !art3Achado)
                {
                    astro.Estamina -= 30;
                    desenhos.Caverna();
                    Console.WriteLine("Você escolheu explorar a região da caverna de chumbo, uma respirada e você ja era!");
                    Console.WriteLine("O módulo de carga parece ter rolado até esta caverna..");
                    Console.WriteLine("Digite em qual lugar você quer procurar [Apenas uma chance]");
                    Console.WriteLine("[1] - Norte");
                    Console.WriteLine("[2] - Sul");
                    Console.WriteLine("[3] - Leste");
                    Console.WriteLine("[4] - Oeste");
                    int opcaoAstro = int.Parse(Console.ReadLine());
                    if (opcaoAstro == Lugar3) 
                    {
                        art3Achado = true;
                        desenhos.art3Found();
                        astro.Artefatos += 1;
                        astro.Estamina -= 10;
                        lugar4block = true;
                        Console.WriteLine("Aperte qualquer tecla para continuar.. [ClearScreen]");
                        Console.ReadKey();
                    }
                    else if (opcaoAstro != Lugar3 && (opcaoAstro == 1 || opcaoAstro == 2 || opcaoAstro == 3 || opcaoAstro == 4))
                    {
                        Console.WriteLine("Você não achou nenhum artefato aqui...");
                        astro.Estamina -= 20;
                        Console.WriteLine("Aperte qualquer tecla para continuar.. [ClearScreen]");
                        Console.ReadKey();

                    }
                    else
                    {
                        Console.WriteLine("Você escolheu uma opção inválida, mesmo assim perdeu 30 de estamina");
                        Console.WriteLine("Aperte qualquer tecla para continuar.. [ClearScreen]");
                        Console.ReadKey();
                    }
                }
                else if (opcaoEscolhida == 3 && lugar3block && art3Achado)
                {
                    Console.WriteLine("Este artefato ja foi encontrado!");
                }
                else if (opcaoEscolhida == 3 && !lugar3block)
                {
                    Console.WriteLine("O lugar que deseja explorar ainda está bloqueado, complete os lugares anteriores!");
                }
                // 4 ------------------------------------------------
                if (opcaoEscolhida == 4 && lugar4block && !art4Achado)
                {
                    astro.Estamina -= 30;
                    desenhos.Canyon();
                    Console.WriteLine("Você escolheu explorar a região do cânyon de ametista... que bela vista!");
                    Console.WriteLine("Sem o complexo de lançamento será impossível sair daqui, ache-o em meio ao mais belo cânyon ja visto!");
                    Console.WriteLine("Digite em qual lugar você quer procurar [Apenas uma chance]");
                    Console.WriteLine("[1] - Norte");
                    Console.WriteLine("[2] - Sul");
                    Console.WriteLine("[3] - Leste");
                    Console.WriteLine("[4] - Oeste");
                    int opcaoAstro = int.Parse(Console.ReadLine());
                    if (opcaoAstro == Lugar4)
                    {
                        art4Achado = true;
                        desenhos.art4Found();
                        astro.Artefatos += 1;
                        astro.Estamina -= 10;
                        lugar5block = true;
                        Console.WriteLine("Aperte qualquer tecla para continuar.. [ClearScreen]");
                        Console.ReadKey();
                    }
                    else if (opcaoAstro != Lugar4 && (opcaoAstro == 1 || opcaoAstro == 2 || opcaoAstro == 3 || opcaoAstro == 4))
                    {
                        Console.WriteLine("Você não achou nenhum artefato aqui...");
                        astro.Estamina -= 20;
                        Console.WriteLine("Aperte qualquer tecla para continuar.. [ClearScreen]");
                        Console.ReadKey();

                    }
                    else
                    {
                        Console.WriteLine("Você escolheu uma opção inválida, mesmo assim perdeu 30 de estamina");
                        Console.WriteLine("Aperte qualquer tecla para continuar.. [ClearScreen]");
                        Console.ReadKey();
                    }
                }
                else if (opcaoEscolhida == 4 && lugar4block && art4Achado)
                {
                    Console.WriteLine("Este artefato ja foi encontrado!");
                }
                else if (opcaoEscolhida == 4 && !lugar4block)
                {
                    Console.WriteLine("O lugar que deseja explorar ainda está bloqueado, complete os lugares anteriores!");
                }
                // 5 ------------------------------------------------
                if (opcaoEscolhida == 5 && lugar5block && !art5Achado)
                {
                    astro.Estamina -= 30;
                    desenhos.Rio();
                    Console.WriteLine("Você escolheu explorar a região do Rio de mercúrio... não é uma boa ideia tomar banho nisso ai..");
                    Console.WriteLine("A ogiva bem que poderia estar em um lugar menos perigoso... ainda bem que eu trouxe meu SCUBA (equipamento especial para mergulho)");
                    Console.WriteLine("Digite em qual lugar você quer procurar [Apenas uma chance]");
                    Console.WriteLine("[1] - Norte");
                    Console.WriteLine("[2] - Sul");
                    Console.WriteLine("[3] - Leste");
                    Console.WriteLine("[4] - Oeste");
                    int opcaoAstro = int.Parse(Console.ReadLine());
                    if (opcaoAstro == Lugar5)
                    {
                        art5Achado = true;
                        desenhos.art5Found();
                        astro.Artefatos += 1;
                        astro.Estamina -= 10;
                        Console.WriteLine("Aperte qualquer tecla para continuar.. [ClearScreen]");
                        Console.ReadKey();
                    }
                    else if (opcaoAstro != Lugar5 && (opcaoAstro == 1 || opcaoAstro == 2 || opcaoAstro == 3 || opcaoAstro == 4))
                    {
                        Console.WriteLine("Você não achou nenhum artefato aqui...");
                        astro.Estamina -= 20;
                        Console.WriteLine("Aperte qualquer tecla para continuar.. [ClearScreen]");
                        Console.ReadKey();

                    }
                    else
                    {
                        Console.WriteLine("Você escolheu uma opção inválida, mesmo assim perdeu 30 de estamina");
                        Console.WriteLine("Aperte qualquer tecla para continuar.. [ClearScreen]");
                        Console.ReadKey();
                    }
                }
                else if (opcaoEscolhida == 5 && lugar5block && art5Achado)
                {
                    Console.WriteLine("Este artefato ja foi encontrado!");
                }
                else if (opcaoEscolhida == 5 && !lugar5block)
                {
                    Console.WriteLine("O lugar que deseja explorar ainda está bloqueado, complete os lugares anteriores!");
                }
                
           }
           else
            {
                Console.WriteLine("Estamina insuficiente para executar ação!");
            }
            
        }
    }
}
