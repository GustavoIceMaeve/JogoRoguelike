using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace RoguelikeConsole
{
    public class Inventario
    {


    public Item[] item = new Item[3];

    
        
    public Inventario()
        {
            for(int i = 0; i < 3; i++)
            {
                item[i] = new Item();
            }
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

        Console.WriteLine("Deseja adicionar em o item no seu inventario? 1 para SIM");
        //Qualquer outro numero além de 1 descarta o item
        int resposta = Inicio.VerificarRespostaInteira();
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
            if(tipo == 1)
            {
                for(int i = 0; i < 3; i++)
                {
                    soma+=item[i].GetVida();
                }
            }else if(tipo == 2)
            {
                for(int i = 0; i < 3; i++)
                {
                    soma+=item[i].getArmadura();
                }
            }
            else
            {    
                for(int i = 0; i < 3; i++)
                {
                    soma+=item[i].getDano();
                }
            }
            return soma;
        }
    //Recebe o item da livraria e pergunta em qual slot encaixar
    public void trocarItem(Item lootRecebido)
        {
            int slot = 50;
            //Numeros Validos são somente 1,2,3
            while(slot > 4 || slot < 0)
            {
                Console.WriteLine("Em qual slot??");
                slot = Inicio.VerificarRespostaInteira();
                if(slot > 4 || slot < 0)
                {
                    Console.WriteLine("Numero Invalido");
                } 
            }
            item[slot-1] = lootRecebido;
            Console.WriteLine($"Item {lootRecebido.GetNome()} adicionado com sucesso no slot {slot}");
        }


    }
}