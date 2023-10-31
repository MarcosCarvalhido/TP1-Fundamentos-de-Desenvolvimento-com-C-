using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_C_Sharp_Questão_2
{
    internal class Calcular
    {
        protected double capital;
        protected double juros;
        protected int meses;

        public void Montante()
        {
            double montante;
            capital = SetCapital();
            juros = SetJuros();
            meses = SetMeses();

            montante = capital * (Math.Pow((1 + juros), meses));

            LerResposta(Math.Round(montante));
        }
        protected double SetCapital()
        {
            Console.Write("Digite a quantidade de capital: ");
            return  double.Parse(Console.ReadLine());
        }
        protected double SetJuros()
        {
            Console.Write("Digite a taixa de juros: ");
            return double.Parse(Console.ReadLine()) / 100;
        }
        protected int SetMeses()
        {
            Console.Write("Digite a quantidade de meses: ");
            return int.Parse(Console.ReadLine());
        }
        protected void LerResposta(double resposta)
        {
            Console.WriteLine("O Montante calculado apartir dos valores informados é: R$" + resposta);
        }
    }
}
