namespace RoguelikeConsole
{
    class MeuMenu
    {

        enum OpcaoMenu
        {
            InimigoNormal,
            InimigoElite,
            InimigoBoss,
            Curar,
            Status,
            Loja,
            Sair,
            Invalida
        }
        public static void MenuPrincipal()
        {
            Console.WriteLine("BEM VINDO AO JOGO DE GUERRA");
            Console.WriteLine("Qual nome do seu herói?");
            string nome = Console.ReadLine();
            Console.WriteLine($"Bem vindo ó grande {nome}");
            Console.WriteLine("Qual será sua classe?");
            Console.WriteLine("1 - Guerreiro -- 15 de Vida, 0 de Armadura, 1 de dano, 0 de Ouro");
            Console.WriteLine("2 - Espadachim -- 10 de Vida, 0 de Armadura, 2 de dano, 0 de Ouro");
            Console.WriteLine("3 - Riquinho -- 10 de Vida, 0 de Armadura, 1  de dano, 4 de Ouro");

            int resposta;
            resposta = Inicio.VerificarRespostaInteira(1,3);
            Inventario inventario = new Inventario();
            Personagem heroi = new Personagem(nome, inventario, resposta);
            bool sairDoJogo = true, venceu = true;
            int raridadeDoLoot = 0;
            // 1 - Items Normais
            // 2 - Items Raros
            // 3 - Items Epicos
            int rodadas = 1;
            //Menu do Jogo
            while (sairDoJogo)
            {
                Console.WriteLine("O QUE DESEJA FAZER?");
                Console.WriteLine("1 - Enfrentar um inimigo normal");
                Console.WriteLine("2 - Enfrentar um inimigo de Elite");
                Console.WriteLine("3 - Enfrentar o chefe");
                Console.WriteLine("4 - Curar em 5");
                Console.WriteLine("5 - Verificar status");
                Console.WriteLine("6 - Visitar a loja");
                Console.WriteLine("7 - Sair do jogo");

                resposta = Inicio.VerificarRespostaInteira(1,7);
                OpcaoMenu OpcaoEscolhida = (OpcaoMenu)resposta-1;
                switch (OpcaoEscolhida)
                {
                    case OpcaoMenu.InimigoNormal:
                        //Batalha Normal
                        venceu = Batalha.Batalhando(heroi, Inimigos.criarInimigo());
                        if (!venceu)
                        {
                            MensagemGameOver(rodadas);
                            sairDoJogo = false;
                            Console.ReadLine();
                        }
                        else
                        {
                            raridadeDoLoot = 1;
                            heroi.Inventario.GanharItem(raridadeDoLoot);
                            heroi.VerificarVida();
                            heroi.adicionarOuro(1);
                            rodadas += 1;
                        }
                        Console.ReadLine();
                        break;
                    case OpcaoMenu.InimigoElite:
                        //Batalha Elite
                        venceu = Batalha.Batalhando(heroi, Inimigos.criarInimigoElite());
                        if (!venceu)
                        {
                            MensagemGameOver(rodadas);
                            sairDoJogo = false;
                            Console.ReadLine();
                        }
                        else
                        {
                            raridadeDoLoot = 2;
                            heroi.Inventario.GanharItem(raridadeDoLoot);
                            heroi.VerificarVida();
                            heroi.adicionarOuro(2);
                            rodadas += 1;
                        }
                        Console.ReadLine();
                        break;
                    case OpcaoMenu.InimigoBoss:
                        //Batalha Chefe
                        venceu = Batalha.Batalhando(heroi, Inimigos.criarInimigoChefe());
                        if (!venceu)
                        {
                            MensagemGameOver(rodadas);
                            sairDoJogo = false;
                            Console.ReadLine();
                        }
                        else
                        {
                            rodadas += 1;
                            Console.Clear();
                            heroi.Status();
                            Console.WriteLine($"Você ganhou em {rodadas} rodadas!! Parabéns {heroi.Nome}!");
                            sairDoJogo = false;
                            Console.ReadLine();
                        }
                        break;
                    case OpcaoMenu.Curar:
                        //Curar
                        heroi.CurarVida(5);
                        rodadas += 1;

                        Console.ReadLine();
                        break;
                    case OpcaoMenu.Status:
                        //Mostrar status do heroi
                        Console.Clear();
                        heroi.Status();
                        Console.ReadLine();
                        break;
                    case OpcaoMenu.Loja:
                        //Mostrar Loja
                        Loja.AbrirLoja(heroi);
                        rodadas += 1;
                        break;
                    case OpcaoMenu.Sair:
                        //SairDojogo
                        sairDoJogo = false;
                        Console.WriteLine("Obrigado por jogar a batalha de guerra");
                        Console.WriteLine($"Você jogou {rodadas} rodadas do jogo.");
                        Console.ReadLine();
                        break;
                }
                Console.Clear();

            }

        }


        public static void MensagemGameOver(int rodadas)
        {
            Console.Clear();
            Console.WriteLine("============GAME OVER==========");
            Console.WriteLine("   Você sobreviveu {0} rodadas   ", rodadas);
            Console.WriteLine("===============================");

        }

    }

}