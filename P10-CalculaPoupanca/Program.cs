using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 10");

            double valorinvertido = 1000;
            int contadorMes = 1;

            while(contadorMes <=12)
            {
                valorinvertido = valorinvertido + valorinvertido * 0.0036;
                Console.WriteLine("Após "+ contadorMes+ " meses, você terá R$" + valorinvertido);

                //contadorMes = contadorMes + 1;
                //contadorMes += 1;
                contadorMes++;

            }
            






            Console.ReadLine();
        }
    }
}
