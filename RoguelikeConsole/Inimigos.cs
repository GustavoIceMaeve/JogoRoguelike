using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoguelikeConsole
{
    public class Inimigos
    {
        static int inimigosFeitosComuns=5;
        static int inimigosFeitosElite=5;
        static int inimigosFeitosChefe=5;

        string Nome;
        int Vida;
        int Armadura;
        int Dano;
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
            int numeroDoItem = Random.Shared.Next(0,inimigosFeitosComuns);
            Inimigos[] tipoDeInimigos = new Inimigos[inimigosFeitosComuns];
            tipoDeInimigos[0] = new Inimigos("Slime Pequeno", 8, 0 , 1);
            tipoDeInimigos[1] = new Inimigos("Escudo Flutuante", 2 ,4, 2);
            tipoDeInimigos[2] = new Inimigos("Bandido com uma Espada", 3 , 0, 5);
            tipoDeInimigos[3] = new Inimigos("Bandido com um Escudo", 3 , 2, 3);
            tipoDeInimigos[4] = new Inimigos("Bandido com um Capuz", 6 , 0, 3);


            return tipoDeInimigos[numeroDoItem];
        }

        public static Inimigos criarInimigoElite()
        {
            //Adicionar a inimigosFeitos o número de inimigos
            int numeroDoItem = Random.Shared.Next(0,inimigosFeitosElite);
            Inimigos[] tipoDeInimigos = new Inimigos[inimigosFeitosElite];
            tipoDeInimigos[0] = new Inimigos("Slime Grande", 15 , 0 , 3);
            tipoDeInimigos[1] = new Inimigos("Gangue de Escudos Flutuantes", 3 , 10, 4);
            tipoDeInimigos[2] = new Inimigos("Cavaleiro com Espada Grande", 4 , 4, 8);
            tipoDeInimigos[3] = new Inimigos("Cavaleiro com Escudo Grande", 4 , 8, 4);
            tipoDeInimigos[4] = new Inimigos("Cavaleiro com Capacete de Metal", 8 , 3, 4);


            return tipoDeInimigos[numeroDoItem];
        }

        public static Inimigos criarInimigoChefe()
        {
            //Adicionar a inimigosFeitos o número de inimigos
            int numeroDoItem = Random.Shared.Next(0,inimigosFeitosChefe);
            Inimigos[] tipoDeInimigos = new Inimigos[inimigosFeitosChefe];
            tipoDeInimigos[0] = new Inimigos("Slime Chefe", 25, 0 , 5);
            tipoDeInimigos[1] = new Inimigos("Levitador de Escudos", 4 ,16, 6);
            tipoDeInimigos[2] = new Inimigos("Cavaleiro com Ódio", 10 , 5, 12);
            tipoDeInimigos[3] = new Inimigos("Cavaleiro Covarde", 20 , 20 , 5);
            tipoDeInimigos[4] = new Inimigos("Cavaleiro Mestre", 14 , 14, 8);

            return tipoDeInimigos[numeroDoItem];
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