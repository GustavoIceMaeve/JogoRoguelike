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
        public static int VerificarRespostaInteira(int min, int max)
        {
        int resposta = 0;
        bool numeroInteiro = false;
        bool numeroValido = false;
        
        while(!numeroInteiro || !numeroValido)
        {
            try
            {
                resposta = int.Parse(Console.ReadLine());
                numeroInteiro = true;
            }
            catch
            {
                Console.WriteLine("Você digitou algo que não é um número. Tente novamente");
            }

            if(resposta < min || resposta > max)
                {
                    Console.WriteLine("Número fora do alcance! Digite um número entre os indicados!");
                }
                else
                {
                    numeroValido = true;
                }

         }

            return resposta;
        }
        public static int VerificarRespostaInteira()
        {
            int resposta = 0;
            bool numeroInteiro = false;

            while (!numeroInteiro)
            {
                try
                {
                    resposta = int.Parse(Console.ReadLine());
                    numeroInteiro = true;
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