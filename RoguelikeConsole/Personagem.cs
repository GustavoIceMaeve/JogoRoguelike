using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoguelikeConsole
{
    public class Personagem
    {
        string Nome;
        string Classe;
        int Vida;
        int Ouro=0;
        public Inventario Inventario;

        int VidaBase = 10;
        int ArmaduraBase = 0;
        int DanoBase = 1;

        public Personagem(string nome,int vida,Inventario inventario )
        {
            Nome = nome;
            Inventario = inventario;
            Vida = vida;

        }

        public void ClasseDoPersonagem(int classe)
        {
            if(classe == 1)
            {    
                VidaBase = 15;
                Classe = "Guerreiro";
            }
            else if(classe == 2)
            {   
                DanoBase = 2;
                Classe = "Espadachim";
            }
            else
            {   
                Ouro = 4;
                Classe = "Riquinho";
            }
        }

        public void Status()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Classe: {Classe}");
            Console.WriteLine($"Stats:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Ouro: {Ouro}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Vida: {Vida}/{VidaMaxima()}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Armadura: {ArmaduraBase + Inventario.StatusItem(2)}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Dano: {DanoBase + Inventario.StatusItem(3)}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Inventario: ");
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{Inventario.item[i].StatusItem()}");
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

        public void perderVida(int DanoTomado)
        {
            Vida-=DanoTomado;
        }
        public void adicionarVida(int VidaAdicionada)
        {
            Vida+=VidaAdicionada;
        }
        public int VidaAtual()
        {
            return Vida;
        }

        public void VerificarVida()
        {
            if(VidaAtual() > VidaMaxima())
            {
                setVida(VidaMaxima());
            }
        }

        public void CurarVida(int cura)
        {
            if(Vida == 10 + Inventario.StatusItem(1))
            {
                Console.WriteLine("Sua vida já está no maximo");
            }
            else if(Vida+cura > 10 + Inventario.StatusItem(1))
            {
                Vida = 10 + Inventario.StatusItem(1);
                Console.WriteLine($"Curado até a vida máxima. Vida Atual: {Vida}/{10 + Inventario.StatusItem(1)}"); 
            }
            else
            {
                Vida+=5;
                Console.WriteLine($"Curado 5 de Vida. Vida Atual: {Vida}/{10 + Inventario.StatusItem(1)}");
            }
        }

        public string GetNome()
        {
            return Nome;
        }
        public void adicionarOuro(int bonus)
        {
            Ouro+=bonus;
        }
        public int getOuro()
        {
            return Ouro;
        }

        public void setVida(int vida)
        {
            Vida = vida;
        }

    }
}