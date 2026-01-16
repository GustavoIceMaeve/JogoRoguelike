using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace RoguelikeConsole
{
    public class Inventario
    {

    public List<Item> items = new List<Item>()
    {
        new Item(),
        new Item(),
        new Item()
    };

    public enum StatusDoItem
        {
            Vida,
            Armadura,
            Dano
        }
        


    //Ação de ganhar um item
    public  void GanharItem(int Raridade)
    {
        //Inicializa um objeto item e sortea ele entre os normais
        Item loot = new Item();
        // Depende da Raridade do Item
        // 1 - Items Normais
        // 2 - Items Raros
        // 3 - Items Epicos
        if(Raridade == 1)
        {
            loot = Item.ItemsNormais();            
        }
        else if(Raridade == 2)
        {
            loot = Item.ItemsRaros();
        }

        Console.WriteLine("Deseja adicionar em o item no seu inventario? ");
        Console.WriteLine("1 - Sim");
        Console.WriteLine("2 - Não");
        //Qualquer outro numero além de 1 descarta o item
        int resposta = Inicio.VerificarRespostaInteira(1,2);
        if(resposta == 1)
                trocarItem(loot);
        else
            Console.WriteLine("Item descartado!!");         
    
    }

    
    public int StatusItem(int tipo)
        {
            //tipo = 1 Vida
            //tipo = 2 Armadura
            //tipo = 3 Dano
            int soma =0;
            StatusDoItem status = (StatusDoItem)tipo;
            if(status == StatusDoItem.Vida)
            {
                for(int i = 0; i < 3; i++)
                {
                    soma+=items[i].GetVida();
                }
            }else if(status == StatusDoItem.Armadura)
            {
                for(int i = 0; i < 3; i++)
                {
                    soma+=items[i].getArmadura();
                }
            }
            else if(status == StatusDoItem.Dano)
            {    
                for(int i = 0; i < 3; i++)
                {
                    soma+=items[i].getDano();
                }
            }
            return soma;
        }

    //Recebe o item da livraria e pergunta em qual slot encaixar
    public void trocarItem(Item lootRecebido)
        {
            Console.WriteLine("Em qual slot??"); 
            Console.WriteLine($"Inventario: ");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"SLOT {i+1} --> {items[i].StatusItem()}");
            }
            int slot = Inicio.VerificarRespostaInteira(1,3);
            items[slot-1] = lootRecebido;
            Console.WriteLine($"Item {lootRecebido.GetNome()} adicionado com sucesso no slot {slot}");
            Console.ReadLine();
        }


    }
}