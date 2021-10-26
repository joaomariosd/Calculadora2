using System;
using System.Globalization;
using CalculadoraSimples.Entities;


namespace CalculadoraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Calculadora!".ToUpper());
            Console.WriteLine();

            bool condicao = true;
            while (condicao)
            {
                Console.WriteLine("Digite a operação que deseja fazer:");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("+ = Soma, - = Subtração, * = Multiplicação, / = Divisão, s = Sair: ");
                string c = Console.ReadLine();
                Console.WriteLine();

                Calculadora calculadora = new Calculadora();           

                switch (c)
                {
                    case "+":
                        Console.WriteLine("O resultado da soma de " + calculadora.Soma().ToString("F2", CultureInfo.InvariantCulture));
                        Console.ReadLine();
                        Console.WriteLine();
                        break;
                    case "-":
                        Console.WriteLine("O resultado da subtração de " + calculadora.Subtracao().ToString("F2", CultureInfo.InvariantCulture));
                        Console.ReadLine();
                        Console.WriteLine();

                        break;
                    case "*":
                        Console.WriteLine("O resultado da multiplicação de " + calculadora.Multiplicacao().ToString("F2", CultureInfo.InvariantCulture));
                        Console.ReadLine();
                        Console.WriteLine();

                        break;
                    case "/":
                        Console.WriteLine("O resultado da divisão de " + calculadora.Divisao().ToString("F2", CultureInfo.InvariantCulture));
                        Console.ReadLine();
                        Console.WriteLine();

                        break;
                    case "s":
                        condicao = false;
                        Console.WriteLine("Saindo!");
                        Console.ReadLine();
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Nenhuma das opções disponíveis foi escolhidas!");
                        break;
                }

                Console.Clear();
            }

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey();
        }
    }
}
