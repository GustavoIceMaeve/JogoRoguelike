using System.ComponentModel.Design;

namespace RoguelikeConsole
{
    class Inicio
    {


        static void Main()
        {
            MeuMenu.MenuPrincipal();
        }

        //Metodo publico estatico para verificar se o numero é realmente um numero inteiro para não dar erros
        public static int VerificarRespostaInteira()
        {
        int resposta = 0;
        bool naoNumero = true;
        while(naoNumero){
            try
            {
                resposta = int.Parse(Console.ReadLine());
                naoNumero = false;
            }
            catch
            {
                Console.WriteLine("Você diigtou algo que não é um número. Tente novamente");
            }
         }

            return resposta;
        }




    }
}