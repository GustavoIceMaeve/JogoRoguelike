using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RoguelikeConsole
{


    public class Item
    {
        static int ItemsFeitosNormais = 10;
        static int ItemsFeitosRaros = 10;
        string Nome = "Vazio";
        int Dano = 0,Armadura = 0,Vida = 0;
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
            int numeroDoItem = Random.Shared.Next(0,ItemsFeitosNormais);
            Item[] ListaDeItems = new Item[ItemsFeitosNormais];
            ListaDeItems[0] = new Item("Espada", 5, 0 , 0);
            ListaDeItems[1] = new Item("Espada apontada", 3, 2, 0);
            ListaDeItems[2] = new Item("Espada do Desatento", 7, 0, -1);
            ListaDeItems[3] = new Item("Escudo", 0 ,5, 0);
            ListaDeItems[4] = new Item("Escudo com espinhos", 1, 4, 0);
            ListaDeItems[5] = new Item("Escudo do idiota", -1, 8, -1);
            ListaDeItems[6] = new Item("Capuz", 0 , 0, 5);
            ListaDeItems[7] = new Item("Capuz do Covarde", -1, 0, 7);
            ListaDeItems[8] = new Item("Capuz da agressividade", 2, 0 , 3);
            ListaDeItems[9] = new Item("Um kit de sobrevivência", 2, 2, 2);

            Console.WriteLine($"Parabéns! Você ganhou uma {ListaDeItems[numeroDoItem].Nome}!"
            + $"Os Status são +{ListaDeItems[numeroDoItem].Vida}  &{ListaDeItems[numeroDoItem].Armadura}  *{ListaDeItems[numeroDoItem].Dano}");

            return ListaDeItems[numeroDoItem];
        }

        public static Item ItemsRaros()
        {
            //ItemsFeitos tem que ser igual ao total de items na lista
            int numeroDoItem = Random.Shared.Next(0,ItemsFeitosRaros);
            Item[] ListaDeItems = new Item[ItemsFeitosRaros];
            ListaDeItems[0] = new Item("Espada Grande", 10, 0, 0);
            ListaDeItems[1] = new Item("Espada Proibida",15, 0, -3);
            ListaDeItems[2] = new Item("Espada e Escudo", 6 , 6, 0);
            ListaDeItems[3] = new Item("Escudo Grande", 0 ,10, 0);
            ListaDeItems[4] = new Item("Escudo de Metal", 1 , 8, 1);
            ListaDeItems[5] = new Item("Escudo do paladino", 2 , 5, 5);
            ListaDeItems[6] = new Item("Capacete de Metal", 0 , 0, 10);
            ListaDeItems[7] = new Item("Capacete do Odio", 6 , 0, 6);
            ListaDeItems[8] = new Item("Capacete do Preparado", 0 , 6, 6);
            ListaDeItems[9] = new Item("Kit completo de Pedra", 4 , 4, 4);


            Console.WriteLine($"Parabéns! Você ganhou uma {ListaDeItems[numeroDoItem].Nome}!"
            + $"Os Status são +{ListaDeItems[numeroDoItem].Vida}  &{ListaDeItems[numeroDoItem].Armadura}  *{ListaDeItems[numeroDoItem].Dano}");

            return ListaDeItems[numeroDoItem];
        }

        public string StatusItem()
        {
            return $"{Nome} --> +{Vida}  &{Armadura}  *{Dano}";
        }
        public string GetNome()
        {
            return Nome;
        }
        public int GetVida()
        {
            return Vida;
        }
        public int getArmadura()
        {
            return Armadura;
        }
        public int getDano()
        {
            return Dano;
        }

    }
}