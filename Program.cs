using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__3__exc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double f, c;

            Console.WriteLine("Digite o valor da temperatura em Fahrenheit para que ela possa ser convertida em Celcius: ");
            f = double.Parse(Console.ReadLine());

            c = (5 * (f - 32)) /9;

            Console.WriteLine("O valor da temperatura convertida em Celcius é: " + c);
            Console.ReadKey();  

        }
    }
}
