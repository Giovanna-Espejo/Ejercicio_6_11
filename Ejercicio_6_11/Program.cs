using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.Distributions;

namespace Ejercicio_6_11
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Ejercicio 6.11. La anchura X en milímetros de una población de coleópteros sigue una distribución normal\r\nN(μ,σ), dándose las siguientes probabilidades: P(X ≤ 12) = 0.77; P(X > 7) = 0.84. Se pide:");
            Console.WriteLine();
            Console.WriteLine("Escirbir lo siguienten numero decimal");
            Console.WriteLine();
            Console.WriteLine("Escribe el porcentaje de que la anchura sea mayor que X: ");
            double porcn1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el porcentaje de que la anchura sea menor que y: ");
            double porcn2 = double.Parse(Console.ReadLine()); 
            Console.WriteLine("Escribe el porcentaje de que la anchura sea menor que 12: ");
            double porcn3 = double.Parse(Console.ReadLine()); 
            Console.WriteLine("Escribe el porcentaje de que la anchura sea mayor que 7: ");
            double porcn4 = double.Parse(Console.ReadLine());
            Console.WriteLine();
            double disNEstd1 = Normal.InvCDF(0, 1, 1 - porcn1); 
            double disNEstd2 = Normal.InvCDF(0, 1, porcn2); 
            double disNEstd3 = Normal.InvCDF(0, 1, porcn3); 
            double disNEstd4 = Normal.InvCDF(0, 1, 1 - porcn4); 
            
            double desv = (12 - 7) / (disNEstd3 - disNEstd4);
            double media = 12 - desv * disNEstd3;

            double valX = media + disNEstd2 * desv;
            double valY = media - disNEstd1 * desv;

            double disNEstd5 = (8 - media) / desv;
            double disNEstd6 = (10 - media) / desv;
            double porcje = Normal.CDF(0, 1, disNEstd6) - Normal.CDF(0, 1, disNEstd5);

            Console.WriteLine("a) Los valores de miun(μ) son "+media+"  y sigma (σ) "+desv);
            Console.WriteLine("");
            Console.WriteLine("b) Proporción de individuos con anchura entre 8 y 10 milímetros es de " +porcje+"%");
            Console.WriteLine("");
            Console.WriteLine("c) La anchura de x es igual a "+valX+ " y la de y es igual a "+valY);
        }
    }
}