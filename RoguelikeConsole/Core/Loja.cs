using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoguelikeConsole
{
    public class Loja
    {
        static Item[] itemsDaLoja = new Item[4];
        public static void AbrirLoja(Personagem heroi)
        {
            
            //Achar 4 items aleatorios para a loja
            for(int i = 0; i < 3; i++)
            {
                itemsDaLoja[i] = Item.ItemsNormais();
            }
            itemsDaLoja[3] = Item.ItemsRaros();

            //Mostrar Loja
            Console.WriteLine($"OURO ATUAL: {heroi.getOuro()}");
            MostrarLoja();
            //Escolha de comprar

            //Numeros Validos são somente 1,2,3,4
            Console.WriteLine("Qual item deseja?? -1 para sair da loja");
            int escolhaItem = Inicio.VerificarRespostaInteira();
            int preco = escolhaItem*2;
            while(escolhaItem != -1)
            {
                
                if(escolhaItem > 0 && escolhaItem<5)
                {
                    if(preco > heroi.getOuro())
                    {
                        Console.WriteLine("Você não tem ouro para comprar esse item");
                        escolhaItem = Inicio.VerificarRespostaInteira();
                    
                    }
                    else
                    {
                        heroi.Inventario.trocarItem(itemsDaLoja[escolhaItem-1]);
                        heroi.adicionarOuro((preco)*-1); 
                        escolhaItem = -1;
                    }

                }
                else
                {
                    Console.WriteLine("Número não valido!");
                    escolhaItem = Inicio.VerificarRespostaInteira();
                }
            }

            
            
        }
        private static void MostrarLoja()
        {
            Console.Clear();
            Console.WriteLine("==========BEM-VINDO A LOJA ========");
            int preco = 1;
            foreach(Item i in itemsDaLoja)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{i.GetNome()} -- +{i.GetVida()} -- &{i.getArmadura()} -- *{i.getDano()} -- ${preco*2}");
                preco++;
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("====================================");

        }
        
    }
}