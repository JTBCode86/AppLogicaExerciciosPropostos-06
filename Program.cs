using System;

namespace AppLogicaExerciciosPropostos_06
{
    /// <summary>
    /// Exercícios sobre Estrutura Condicional (if-else)
    /// Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
    /// seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em
    /// nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.
    /// </summary>
    class Program
    {
        public static string validarIntervalo(double valor) 
        {
            string msg;
            if (valor>=0 && valor <=25)
            {
                msg = "Intervalo 0-25";
            }
            else if (valor >= 25 && valor <= 50)
            {
                msg = "Intervalo 25-50";
            }
            else if (valor >= 50 && valor <= 75)
            {
                msg = "Intervalo 5-75";
            }
            else if (valor >= 75 && valor <= 100)
            {
                msg = "Intervalo 75-100";
            }
            else
            {
                msg = "Forda do intervalo";
            }
            return msg;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o valor a ser prourado: ");
            double valor = double.Parse(Console.ReadLine());
            string resultado = validarIntervalo(valor);

            Console.Clear();
            Console.WriteLine("Resultado da busca: {0}", resultado);
            Console.ReadLine();
        }
    }
}
