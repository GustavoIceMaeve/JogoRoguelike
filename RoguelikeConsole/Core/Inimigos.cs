using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoguelikeConsole
{
    public class Inimigos
    {
        string Nome;
        int Vida;
        int Armadura;
        int Dano;

        static List<Inimigos> inimigosComuns = new List<Inimigos>()
        {
            new Inimigos("Slime Pequeno", 8, 0 , 1),
            new Inimigos("Escudo Flutuante", 2 ,4, 2),
            new Inimigos("Bandido com uma Espada", 3 , 0, 5),
            new Inimigos("Bandido com um Escudo", 3 , 2, 3),
            new Inimigos("Bandido com um Capuz", 6 , 0, 3)
        };
        static List<Inimigos> inimigosElite = new List<Inimigos>()
        {
            new Inimigos("Slime Grande", 15 , 0 , 3),
            new Inimigos("Gangue de Escudos Flutuantes", 3 , 10, 4),
            new Inimigos("Cavaleiro com Espada Grande", 4 , 4, 8),
            new Inimigos("Cavaleiro com Escudo Grande", 4 , 8, 4),
            new Inimigos("Cavaleiro com Capacete de Metal", 8 , 3, 4)
        };
        static List<Inimigos> inimigosChefe = new List<Inimigos>()
        {
            new Inimigos("Slime Chefe", 25, 0 , 5),
            new Inimigos("Levitador de Escudos", 4 ,16, 6),
            new Inimigos("Cavaleiro com Ódio", 10 , 5, 12),
            new Inimigos("Cavaleiro Covarde", 20 , 20 , 5),
            new Inimigos("Cavaleiro Mestre", 14 , 14, 8)
        };


        public Inimigos(string nome, int vida, int armadura, int dano)
        {
            Nome = nome;
            Vida = vida;
            Armadura = armadura;
            Dano = dano;
        }

        public static Inimigos criarInimigo()
        {
            //Adicionar a inimigosFeitos o número de inimigos
            int numeroDoItem = Random.Shared.Next(0,inimigosComuns.Count);

            return inimigosComuns[numeroDoItem];
        }

        public static Inimigos criarInimigoElite()
        {
            //Adicionar a inimigosFeitos o número de inimigos
            int numeroDoItem = Random.Shared.Next(0,inimigosElite.Count);

            return inimigosElite[numeroDoItem];
        }

        public static Inimigos criarInimigoChefe()
        {
            //Adicionar a inimigosFeitos o número de inimigos
            int numeroDoItem = Random.Shared.Next(0,inimigosChefe.Count);

            return inimigosChefe[numeroDoItem];
        }

        public int danoInimigo()
        {
            return Dano;
        }

        public int vidaInimigo(){
            return Vida;
        }

        public int armaduraInimigo()
        {
            return Armadura;
        }

        public string nomeInimigo()
        {
            return Nome;
        }
    }
}