namespace TP1_C_Sharp_Questão_3
{
    internal class Calcular
    {
        public void ProgreçãoAritimadica()
        {
            int sequencia = SetSequencia();
            int posição1 = SetPosição1();
            int posição2 = SetPosição2();
            double constante = posição2 / posição1;

            for (int i = 0; i < sequencia; i++)
            {

            }
        }
        protected int SetPosição1()
        {
            Console.Write("Informe o primeiro valor: ");
            return int.Parse(Console.ReadLine());
        }
        protected int SetPosição2()
        {
            Console.Write("Informe o segundo valor: ");
            return int.Parse(Console.ReadLine()) / 100;
        }
        protected int SetSequencia()
        {
            Console.Write("Informe a quantidade da sequencia de P.A. que deseja gerar: ");
            return int.Parse(Console.ReadLine()) / 100;
        }
        protected void LerResposta(double resposta)
        {
            Console.WriteLine("O Montante calculado apartir dos valores informados é: R$" + resposta);
        }

    }
}
