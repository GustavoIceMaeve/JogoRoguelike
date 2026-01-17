using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RoguelikeConsole
{

    
    public class Item
    {
        public string Nome { get; set; }
        public int Dano { get; set; }
        public int Armadura { get; set; }
        public int Vida { get; set; }

        static List<Item> itemsNormais = new List<Item>()
        {
            new Item("Espada", 5, 0 , 0),
            new Item("Espada apontada", 3, 2, 0),
            new Item("Espada do Desatento", 7, 0, -1),
            new Item("Escudo", 0 ,5, 0),
            new Item("Escudo com espinhos", 1, 4, 0),
            new Item("Escudo do idiota", -1, 8, -1),
            new Item("Capuz", 0 , 0, 5),
            new Item("Capuz do Covarde", -1, 0, 7),
            new Item("Capuz da agressividade", 2, 0 , 3),
            new Item("Um kit de sobrevivência", 2, 2, 2)
        };

        static List<Item> itemsRaros = new List<Item>()
        {
            new Item("Espada Grande", 10, 0, 0),
            new Item("Espada Proibida", 15, 0, -3),
            new Item("Espada e Escudo", 6, 6, 0),
            new Item("Escudo Grande", 0, 10, 0),
            new Item("Escudo de Metal", 1, 8, 1),
            new Item("Escudo do paladino", 2, 5, 5),
            new Item("Capacete de Metal", 0, 0, 10),
            new Item("Capacete do Odio", 6, 0, 6),
            new Item("Capacete do Preparado", 0, 6, 6),
            new Item("Kit completo de Pedra", 4, 4, 4)
        };

        public Item(string nome, int dano, int armadura, int vida)
        {
            Nome = nome;
            Dano = dano;
            Armadura = armadura;
            Vida = vida;
        }
        public Item()
        {
            Nome = "Vazio";
            Dano = 0;
            Armadura = 0;
            Vida = 0;
        }



        public static Item ItemsNormais()
        {
            //ItemsFeitos tem que ser igual ao total de items na lista
            int numeroDoItem = Random.Shared.Next(0, itemsNormais.Count);
            Item itemSorteado = itemsNormais[numeroDoItem];
            Console.WriteLine($"Parabéns você ganhou {itemSorteado.Nome}!");
            Console.WriteLine($"Os Status são:\n" +
                $"{(itemSorteado.Vida != 0 ? $"HP: {itemSorteado.Vida}\n" : "")}" +
                $"{(itemSorteado.Armadura != 0 ? $"ESC: {itemSorteado.Armadura}\n" : "")}" +
                $"{(itemSorteado.Dano != 0 ? $"DANO: {itemSorteado.Dano}\n" : "")}" +
                $"");




            return itemsNormais[numeroDoItem];
        }

        public static Item ItemsRaros()
        {
            //ItemsFeitos tem que ser igual ao total de items na lista
            int numeroDoItem = Random.Shared.Next(0,itemsRaros.Count);
            Item itemSorteado = itemsRaros[numeroDoItem];

            Console.WriteLine($"Parabéns você ganhou {itemSorteado.Nome}!");
            Console.WriteLine($"Os Status são:\n" +
                $"{(itemSorteado.Vida != 0 ? $"HP: {itemSorteado.Vida}\n" : "")}" +
                $"{(itemSorteado.Armadura != 0 ? $"ESC: {itemSorteado.Armadura}\n" : "")}" +
                $"{(itemSorteado.Dano != 0 ? $"DANO: {itemSorteado.Dano}\n" : "")}"
            );

            return itemsRaros[numeroDoItem];
        }

        public string StatusDoItemEscrito()
        {
            if(!(Nome == "Vazio"))
            {
                return $"{Nome} --> " +
                    $"{(Vida != 0 ? $"HP: {Vida} ": "")}" +
                    $"{(Armadura != 0 ? $"ESC: {Armadura} " : "")}" +
                    $"{(Dano != 0 ? $"DANO: {Dano}": "")}"  ;
            }
            return "SLOT VAZIO ";
        }
    }
}