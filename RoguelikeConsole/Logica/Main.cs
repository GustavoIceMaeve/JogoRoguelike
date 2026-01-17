using System.ComponentModel.Design;

namespace RoguelikeConsole
{
    class Inicio
    {


        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.White;
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
                numeroInteiro = false;
            }

            if(resposta < min || resposta > max)
                {
                    if (numeroInteiro)
                    {
                        Console.WriteLine("Número fora do alcance! Digite um número entre os indicados!");
                        Console.WriteLine("Números Validos:");

                        for (int i = 0; i< max; i++)
                        {
                            if (i + 1 == max)
                                Console.WriteLine($"{i + 1}");
                            else 
                                Console.Write($"{i + 1} ,");

                        }
                    }
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