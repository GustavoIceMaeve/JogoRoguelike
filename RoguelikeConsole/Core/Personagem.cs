using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoguelikeConsole
{
    public class Personagem
    {
        public string Nome { get; set; }
        public int Vida {get; set; }
        public int Ouro { get; set; }
        public int ChanceCritico { get; set; }
        public int DanoCritico { get; set; }
        public EscolhaClasse Classe { get; set; }

        public Inventario Inventario;


        int VidaBase { get; set; }
        int ArmaduraBase { get; set; }
        int DanoBase { get; set; }
        public enum EscolhaClasse

        {
            Guerreiro = 1,
            Espadachim = 2,
            Riquinho = 3,
            Assassino = 4
        }

        public Personagem(string nome,Inventario inventario,int resposta )
        {
            Nome = nome;
            Inventario = inventario;
            EscolhaClasse classeEscolhida = (EscolhaClasse)resposta;
            Classe = classeEscolhida;

            switch (classeEscolhida)
            {
                case EscolhaClasse.Guerreiro:
                    VidaBase = 15;
                    ArmaduraBase = 0;
                    DanoBase = 1;
                    Ouro = 0;
                    ChanceCritico = 20;
                    DanoCritico = 2;
                    break;

                case EscolhaClasse.Espadachim:
                    VidaBase = 10;
                    ArmaduraBase = 0;
                    DanoBase = 2;
                    Ouro = 0;
                    ChanceCritico = 20;
                    DanoCritico = 2;
                    break;

                case EscolhaClasse.Riquinho:
                    VidaBase = 15;
                    ArmaduraBase = 0;
                    DanoBase = 1;
                    Ouro = 4;
                    ChanceCritico = 20;
                    DanoCritico = 2;
                    break;

                case EscolhaClasse.Assassino:
                    VidaBase = 15;
                    ArmaduraBase = 0;
                    DanoBase = 1;
                    Ouro = 4;
                    ChanceCritico = 20;
                    DanoCritico = 4;
                    break;
            }

            Vida = VidaBase;

        }

        public void Status()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Classe: {Classe}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Ouro: {Ouro}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Vida: {Vida}/{VidaMaxima()}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Armadura: {ArmaduraAtual()}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Dano: {DanoAtual()}");
            Console.WriteLine($"Chance de Critico: {ChanceCritico}");
            Console.WriteLine($"Multiplicador de Critico: {DanoCritico}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Inventario: ");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{Inventario.items[i].StatusItem()}");
            }
        }

        public int VidaMaxima()
        {
            return VidaBase+Inventario.StatusItem(1);
        }
        public int DanoAtual()
        {
            return DanoBase+Inventario.StatusItem(3);
        }
        public int ArmaduraAtual()
        {
            return ArmaduraBase+Inventario.StatusItem(2);
        }
        public int ChanceCriticoAtual()
        {
            return ChanceCritico;
        }
        public int DanoCriticoAtual()
        {
            return DanoCritico;
        }

        public void perderVida(int DanoTomado)
        {
            Vida-=DanoTomado;
        }
        public void adicionarVida(int VidaAdicionada)
        {
            Vida+=VidaAdicionada;
        }

        public void VerificarVida()
        {
            if(Vida > VidaMaxima())
            {
                Vida = VidaMaxima();
            }
        }

        public void CurarVida(int cura)
        {
            if(Vida == 10 + Inventario.StatusItem(1))
            {
                Console.WriteLine("Sua vida já está no maximo.");
                Console.WriteLine("Digite enter...");

            }
            else if(Vida+cura > 10 + Inventario.StatusItem(1))
            {
                Vida = 10 + Inventario.StatusItem(1);
                Console.WriteLine($"Curado até a vida máxima. Vida Atual: {Vida}/{10 + Inventario.StatusItem(1)}");
                Console.WriteLine("Digite enter...");
            }
            else
            {
                Vida+=5;
                Console.WriteLine($"Curado 5 de Vida. Vida Atual: {Vida}/{10 + Inventario.StatusItem(1)}");
                Console.WriteLine("Digite enter...");
            }
        }

        public void adicionarOuro(int bonus)
        {
            Ouro+=bonus;
        }

    }
}