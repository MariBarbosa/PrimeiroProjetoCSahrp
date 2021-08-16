using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 11");

            double valorInvertido = 1000;


            for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                valorInvertido = valorInvertido + valorInvertido * 0.0036;
                Console.WriteLine("Após " + contadorMes + " meses, você terá R$" + valorInvertido);
            }

            Console.ReadLine();
        }
    }
}
