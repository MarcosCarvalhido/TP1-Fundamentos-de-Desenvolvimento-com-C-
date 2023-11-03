/*Faça um programa que leia uma sequência de números terminada em zero
 * mostre para cada número lido se ele é primo ou não. 
 * No final, mostre a quantidade de números lidos, a quantidade de primos e não primos.
 */
namespace TP1_C_Sharp_Questão_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExibirMenu();
            bool loop = true;
            int i = 0;
            int primos = 0;
            while (loop)
            {
                string entrada = ColetarEntrada(i);
                if (ValidarEntrada(entrada))
                {
                    if (VerificarPrimo(int.Parse(entrada)))
                    {
                        primos++;
                    }
                    i++;
                    loop = VerificarLoop(int.Parse(entrada));
                }
            }
            ExibirResultado(i, primos);
        }
        protected static bool VerificarPrimo(int numero)
        {
            if ((numero % 2 != 0) || (numero % 3 != 0) || (numero % 5 != 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        protected static void ExibirMenu()
        {
            Console.WriteLine("Insira numeros inteiros a seguir para verificar os primos.");
            Console.WriteLine("Digite [ 0 ] para contabilizar o resultado.");
        }
        protected static string ColetarEntrada(int i)
        {
            Console.Write($"Entrada {i + 1}: ");
            return Console.ReadLine();
        }
        protected static bool ValidarEntrada(string entrada)
        {
            if (int.TryParse(entrada, out int énumero))
            {
                return true;
            }
            else
            {
                ExibirErro();
                return false;
            }
        }
        protected static bool VerificarLoop(int entrada)
        {
            if (entrada != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        protected static void ExibirErro()
        {
            Console.WriteLine("Entrada Invalida! tente novamente.");
            ExibirMenu();
        }
        protected static void ExibirResultado(int numeros, int primos)
        {
            Console.WriteLine("Total de numeros: " + (numeros - 1));
            Console.WriteLine("Total de numeros PRIMOS: " + primos);
            Console.WriteLine("Total de numeros NÃO primos: " + ((numeros - 1) - primos));
        }
    }
}