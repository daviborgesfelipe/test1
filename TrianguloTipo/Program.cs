using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ladoUm, ladoDois, ladoTres;
            Console.Clear();
            Console.WriteLine("Digite o primeiro lado e aperte enter");
            ladoUm = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo lado e aperte enter");
            ladoDois = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro lado e aperte enter");
            ladoTres = int.Parse(Console.ReadLine());
            if (ladoUm <= 0 || ladoDois <= 0 || ladoTres <= 0)
            {
                Console.WriteLine("\nO triangulo possui um ou mais lado com o valor igual ou menor que zero (0)");
                Console.ReadLine();
            }
            else if (ladoUm > ladoDois + ladoTres || ladoDois > ladoUm + ladoTres || ladoTres > ladoUm + ladoDois)
            {
                Console.WriteLine("\nO triangulo pussui um lado com o valor maior que a soma dos outros dois valores");
                Console.ReadLine();
            }
            else if (ladoUm == ladoDois && ladoDois == ladoTres)
            {
                Console.WriteLine("\nO triangulo é Equilatero possui todos os lados com os mesmos valores");
                Console.ReadLine();
            }
            else if (ladoUm == ladoDois || ladoDois == ladoTres || ladoTres == ladoUm)
            {
                Console.WriteLine("\nO triangulo é Isósceles possui dois lados com os valores iguais");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\nO triangulo é Escaleno possui todos os lados de valores diferentes");
                Console.ReadLine();
            }
        }
    }
}