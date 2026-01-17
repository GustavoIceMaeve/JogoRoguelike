using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoguelikeConsole
{
    public class Batalha
    {

        public static bool Batalhando(Personagem heroi, Inimigos inimigo)
        {
            int vidaHeroi = heroi.Vida;
            int armaduraHeroi = heroi.ArmaduraAtual();
            int danoHeroi = heroi.DanoAtual();
            int chanceCriticoHeroi = heroi.ChanceCriticoAtual();
            int danoCriticoHeroi = heroi.DanoCriticoAtual();

            bool critico = false;

            int tentativaDeCritico = 0;

            int vidaInimigo = inimigo.Vida;
            int armaduraInimigo = inimigo.Armadura;
            int danoInimigo = inimigo.Dano;

            Console.Clear();

            while (true)
            {
                //Mostra os status
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{heroi.Nome,-25}: " +
                    $"HP:{vidaHeroi} " +
                    $"ESC:{armaduraHeroi}\t" +
                    $"DANO:{danoHeroi}\t ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(
                    $"{inimigo.Nome,-25}: " +
                    $"HP:{vidaInimigo}\t " +
                    $"ESC:{armaduraInimigo}\t" +
                    $"DANO:{danoInimigo}\t");

                //
                //  TURNO DO JOGADOR
                //

                Console.ForegroundColor = ConsoleColor.Green;

                //Verifica se o heroi deu critico
                tentativaDeCritico = Random.Shared.Next(0, 101);
                if (tentativaDeCritico > chanceCriticoHeroi)
                    critico = false;
                else
                    critico = true;
                Console.WriteLine($"Chance de Critico {chanceCriticoHeroi}, Numero Aleatorio {tentativaDeCritico}, Critou? = {critico}");
                if (critico)
                {
                    danoHeroi *= danoCriticoHeroi;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"CRITICO! Você da {danoHeroi} de dano inimigo");
                }
                else
                    Console.WriteLine($"Você da {danoHeroi} de dano no inimigo");


                Console.ReadLine();
                //Verifica se armadura do inimigo é maior que zero para dar dano nela antes
                if(armaduraInimigo > 0)
                {
                    if (armaduraInimigo < danoHeroi)
                    {
                        vidaInimigo+=armaduraInimigo;
                        vidaInimigo-=danoHeroi;
                        armaduraInimigo = 0;
                    }
                    else
                    {
                        armaduraInimigo-=danoHeroi;
                    }
                }
                else
                {
                    vidaInimigo-=danoHeroi;  
                }
                //Termina a batalha se a vida do inimigo chega a zero
                if(vidaInimigo <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("O inimigo morreu!");
                    Console.ReadLine();
                    return true;
                }
                if (critico)
                    danoHeroi /= danoCriticoHeroi;

                //Mostra os status
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{heroi.Nome,-25}: " +
                    $"HP:{vidaHeroi} " +
                    $"ESC:{armaduraHeroi}\t" +
                    $"DANO:{danoHeroi}\t ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(
                    $"{inimigo.Nome,-25}: " +
                    $"HP:{vidaInimigo}\t " +
                    $"ESC:{armaduraInimigo}\t" +
                    $"DANO:{danoInimigo}\t");


                //
                //
                //
                //
                //
                //
                //
                //
                //
                //
                //  TURNO DO INIMIGO
                //
                //
                //
                //
                //
                //
                //
                //
                //
                //


                Console.WriteLine($"Você toma {danoInimigo} de dano do inimigo");
                if (armaduraHeroi > 0)
                {
                    if(armaduraHeroi < danoInimigo)
                    {
                        vidaHeroi+=armaduraHeroi;
                        vidaHeroi-=danoInimigo;
                        heroi.adicionarVida(armaduraHeroi);
                        heroi.perderVida(danoInimigo);
                        armaduraHeroi = 0;
                    }
                    else
                    {
                        armaduraHeroi-=danoInimigo;
                    }
                }
                else
                {
                    vidaHeroi-=danoInimigo;
                    heroi.perderVida(danoInimigo);
                }
                if(vidaHeroi <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Você morreu");
                    Console.ReadLine();
                    return false;
                }

                Console.ReadLine();

            }



        }

    }
}