namespace TP1_C_Sharp_Questão_1
/*
 * Faça um programa que leia uma sequência de caracteres terminada por "F",
 * sendo que cada caractere na lista indica se o indivíduo é homem ("H"), mulher ("M"), criança ("C") ou idoso ("I").
 * O algoritmo deve informar no final o número total de homens, mulheres, crianças e idosos, além do percentual de cada categoria.
 */
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ColetarDados();
        }
        protected static void ColetarDados()
        {
            bool loop = true;
            int i = 1;
            List<string> lista = new List<string>();
            Console.WriteLine("Escolha uma das seguintes opções:");
            Console.WriteLine(" homem (\"H\"), mulher (\"M\"), criança (\"C\") ou idoso (\"I\").");
            Console.WriteLine(" Digite (\"F\") para terminar! ");
            while (loop)
            {
                string entrada;
                Console.Write($"Entrada {i}: ");
                entrada = Console.ReadLine();
                entrada = entrada.ToUpper();
                if ((entrada == "H") || (entrada == "M") || (entrada == "C") || (entrada == "I"))
                {
                    lista.Add(entrada);
                    i++;
                }
                else if (entrada == "F")
                {
                    loop = false;
                }
                else
                {
                    Console.WriteLine("Entrada Invalida!");
                }
            }
            ExibirDados(lista);
        }
        protected static void ExibirDados(List<string> lista)
        {
            int homens = lista.Count(lista.FindAll(Predicate "H"));
            int mulheres = 0;
            int crianças = 0;
            int idosos = 0;
            foreach (var item in lista)
            {
                //switch (item)
                //{
                //    case "H":
                //        {
                //            homens++;
                //            break;
                //        }
                //    case "M":
                //        {
                //            mulheres++;
                //            break;
                //        }
                //    case "C":
                //        {
                //            crianças++;
                //            break;
                //        }
                //    case "I":
                //        {
                //            idosos++;
                //            break;
                //        }
                //}
            }
        }
    }
}
