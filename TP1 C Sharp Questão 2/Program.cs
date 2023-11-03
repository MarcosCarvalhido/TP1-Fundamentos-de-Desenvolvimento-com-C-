/*
Faça um programa que solicite do usuário a taxa de juros,a quantidade de meses e o capital inicial.
Dado isso, calcule o montante a ser pago ao término do período.
Obs: Considere o cálculo de juros compostos.
*/

namespace TP1_C_Sharp_Questão_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double capital;
            double juros;
            int meses;
            double montante;
            capital = SetCapital();
            juros = SetJuros();
            meses = SetMeses();

            montante = capital * (Math.Pow((1 + juros), meses));

            LerResposta(Math.Round(montante));
        }
        protected static double SetCapital()
        {
            Console.Write("Digite a quantidade de capital: ");
            return double.Parse(Console.ReadLine());
        }
        protected static double SetJuros()
        {
            Console.Write("Digite a taixa de juros: ");
            return double.Parse(Console.ReadLine()) / 100;
        }
        protected static int SetMeses()
        {
            Console.Write("Digite a quantidade de meses: ");
            return int.Parse(Console.ReadLine());
        }
        protected static void LerResposta(double resposta)
        {
            Console.WriteLine("O Montante calculado apartir dos valores informados é: R$" + resposta);
        }
    }
}