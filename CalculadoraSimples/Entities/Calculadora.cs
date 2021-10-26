using System;
using System.Globalization;
using System.Text;

namespace CalculadoraSimples.Entities
{
    class Calculadora
    {
        public double Val { get; set; }
        public double Val2 { get; set; }

        public Calculadora()
        {

        }

        public Calculadora(double val, double val2)
        {
            Val = val;
            Val2 = val2;
        }

        public double Soma()
        {
            Console.Write("Digite o primeiro número: ");
            Val = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o segundo número: ");
            Val2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);            
            double sum = Val + Val2;
            return sum;
        }

        public double Subtracao()
        {
            Console.Write("Digite o primeiro número: ");
            Val = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o segundo número: ");
            Val2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);            
            double sub = Val - Val2;
            return sub;
        }

        public double Multiplicacao()
        {
            Console.Write("Digite o primeiro número: ");
            Val = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o segundo número: ");
            Val2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);            
            double mult = Val - Val2;
            return mult;
        }

        public double Divisao()
        {
            Console.Write("Digite o primeiro número: ");
            Val = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o segundo número: ");
            Val2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);            
            double div = Val - Val2;
            return div;

        }
    }
}
