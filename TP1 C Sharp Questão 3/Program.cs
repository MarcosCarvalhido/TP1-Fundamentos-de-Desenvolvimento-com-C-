namespace TP1_C_Sharp_Questão_3
/*
 * Uma progressão aritmética (PA) é uma sequência numérica em que cada termo, a partir do segundo, 
 * é igual a soma do termo anterior com uma constante. A constante é calculada como sendo a diferença entre o segundo e o primeiro número. 
 * Faça um programa que receba dois números inteiros e, a partir dessa informação, gere uma sequência em progressão aritmética.
 * */
{
    internal class Program
    {
        protected static String SequenciaPA { get; set; }
        static void Main(string[] args)
        {
            try
            {
            int sequencia = ColetarSequencia();

            double posição1 = ColetarEntrada(1);
            double posição2 = ColetarEntrada(2);
            double constante = CalcularConstante(posição1, posição2);
            CalcularPA(posição1, posição2, sequencia,constante);
            LerResposta();
            }
            catch
            {
                Console.WriteLine("Entrada invalida, tente novamente!");
            }
        }
        protected static void CalcularPA(double posição1, double posição2, int sequencia, double constante)
        {
            double posição3;
            double temp;
            for (int i = 0; i < sequencia; i++)
            {
                posição3 = posição1 + constante;
                GerarSequencia(posição3);
                temp = posição2;
                posição2 = posição3;
                posição1 = posição2;
            }
        }
        protected static double CalcularConstante(double posição1,double posição2)
        {
            return posição2 / posição1;
        }
        protected static void GerarSequencia(double numero)
        {
            SequenciaPA += $"{Math.Round(numero)}, ";
        }
        protected static double ColetarEntrada(int num)
        {
            Console.Write($"Informe o valor {num}: ");
            return double.Parse(Console.ReadLine());
        }
        protected static int ColetarSequencia()
        {
            Console.Write("Informe a quantidade da sequencia de P.A. que deseja gerar: ");
            return int.Parse(Console.ReadLine());
        }
        protected static void LerResposta()
        {
            Console.WriteLine("A Sequencia PA entre os numeros fornecidos é: ");
            Console.WriteLine(SequenciaPA);
        }

    }
}