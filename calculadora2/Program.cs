using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("cuatro procedimientos: \n 1. Suma \n 2. Resta \n 3. Cuadrado \n 4. Raiz Cuadrada");
            Console.WriteLine("ingrese la operacion que desea realizar seleccionando el respectivo número del 1 al 4");
            Console.WriteLine(" ");
            int operation = int.Parse(Console.ReadLine());
            calcular(operation);

        }

        private static void calcular(int operation)
        {

            Console.Clear();
            switch (operation)
            {
                case 1:
                    {
                        Console.WriteLine("Sumar");
                        Console.WriteLine("");
                        answer(operation);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Restar");
                        Console.WriteLine("");
                        answer(operation);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Multiplicar");
                        Console.WriteLine("");
                        answer(operation);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Dividir");
                        Console.WriteLine("");
                        answer(operation);
                        break;
                    }

                case 5:
                    {
                        Console.WriteLine("Elevar al cuadrado");
                        Console.WriteLine("");
                        answer(operation);
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine(" sacar Raíz cuadrada");
                        Console.WriteLine("");
                        answer(operation);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Operacion no disponible");
                        Console.ReadKey();
                        break;
                    }
            }

        } 

        private static void answer(int nOperacion)
        {
            Console.Write("Ingrese el primer número: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            int number2 = int.Parse(Console.ReadLine());

            if (nOperacion == 1)
            {
                double ans = number1 + number2;
                Console.WriteLine($"La suma es igual a: {ans}", number1, number2, ans);
            }
            if (nOperacion == 2)
            {
                double ans = number1 - number2;
                Console.WriteLine($"La resta es igual a: {ans}", number1, number2, ans);
            }
            if (nOperacion == 3)      
            {
                double ans = number1 * number2;
                Console.WriteLine($"La multiplicación es igual a: {ans}", number1, number2, ans);
            }
            if (nOperacion == 4)
            {
                if (number2 == 0)
                {
                    Console.WriteLine("No se puede dividir entre {0}", number2);
                }
                else
                {
                    double ans = number1 / number2;
                    Console.WriteLine($"La división es igual a: {ans}", number1, number2, ans);
                }
            }
            if (nOperacion == 5)
            {
                double ans = number1 * number1;
                Console.WriteLine($"El cuadrado es igual a: {ans}", number1, number2, ans);
            }
            if (nOperacion == 6)
            {
                double ans = Math.Sqrt(number1);
                Console.WriteLine($"La raíz cuadrada es igual a: {ans}", number1, number2, ans);
            }
            Console.ReadKey();
        }
    }
}
