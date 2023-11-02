namespace TP1_C_Sharp_Questão_1
/*
 * Faça um programa que leia uma sequência de caracteres terminada por "F",
 * sendo que cada caractere na lista indica se o indivíduo é homem ("H"), mulher ("M"), criança ("C") ou idoso ("I").
 * O algoritmo deve informar no final o número total de homens, mulheres, crianças e idosos, além do percentual de cada categoria.
 */
{
    internal class Program
    {
        protected static int Homens { get; set; }
        protected static int Mulheres { get; set; }
        protected static int Crianças { get; set; }
        protected static int Idosos { get; set; }
        protected static int Total { get; set; }
        public static void Main(string[] args)
        {
            ExibirOpções();
            {
                bool loop = true;
                int i = 1;
                while (loop)
                {
                    string entrada = ColetarEntrada(i);
                    if (ValidarEntrada(entrada)) 
                    {
                        ContabilizarDados(entrada);
                        i++;
                    }
                    loop = VerificarLoop(entrada);
                }
                GerarTotal();
                ExibirDados();
            }
        }
        protected static string ColetarEntrada(int i)
        {
            string entrada;
            Console.Write($"Entrada {i}: ");
            entrada = Console.ReadLine();
            entrada = entrada.ToUpper();
            return entrada;
        }
        protected static bool VerificarLoop(string entrada)
        {
            bool loop = true;
            if (entrada == "F")
            {
                loop = false;
            }
            return loop;
        }
        protected static bool ValidarEntrada(string entrada)
        {
            bool valido = false;
            if ((entrada == "H") || (entrada == "M") || (entrada == "C") || (entrada == "I") || (entrada == "F"))
            {
                valido = true;
            }
            else
            {
                ExibirErro();
            }
            return valido;
        }
        protected static void ContabilizarDados(String entrada)
        {

            switch (entrada)
            {
                case "H":
                    {
                        Homens++;
                        break;
                    }
                case "M":
                    {
                        Mulheres++;
                        break;
                    }
                case "C":
                    {
                        Crianças++;
                        break;
                    }
                case "I":
                    {
                        Idosos++;
                        break;
                    }
            }
        }
        protected static void ExibirDados()
        {
            Console.WriteLine($"O total de entras foram de {Total}, sendo compostas por:");
            Console.WriteLine($"{Homens} Homens, que representão {GerarPorcentagem(Total, Homens)}% do total.");
            Console.WriteLine($"{Mulheres} Mulheres, que representão {GerarPorcentagem(Total, Mulheres)}% do total.");
            Console.WriteLine($"{Crianças} Crianças, que representão {GerarPorcentagem(Total, Crianças)}% do total.");
            Console.WriteLine($"{Idosos} Idosos, que representão {GerarPorcentagem(Total, Idosos)}% do total.");
        }
        protected static void ExibirOpções()
        {
            Console.WriteLine("Escolha uma das seguintes opções:");
            Console.WriteLine(" homem (\"H\"), mulher (\"M\"), criança (\"C\") ou idoso (\"I\").");
            Console.WriteLine(" Digite (\"F\") para terminar! ");
        }
        protected static void ExibirErro()
        {
            Console.WriteLine("Entrada Invalida! tente novamente.");
            ExibirOpções();
        }
        protected static double GerarPorcentagem(int total, int grupo)
        {
            return ((double)grupo / (double)total) * 100;
        }
        protected static void GerarTotal()
        {
            Total = Homens + Mulheres + Crianças + Idosos;
        }
    }
}
