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
            Calcular calcular = new Calcular();
            calcular.Montante();
        }
    }
}