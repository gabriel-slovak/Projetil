using System;

namespace Projetil
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---Projétil---");
            Console.ResetColor();
            Console.WriteLine();

            Console.Write("Entre com a velocidade, em m/s...: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            double velocidade = Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();

            Console.Write("Entre com o ângulo, em graus.....: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            double angulo = Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();

            double g = 9.80665;

            double anguloEmRadianos = angulo * (Math.PI / 180);

            double alcance = (Math.Pow(velocidade, 2) * Math.Sin(2 * anguloEmRadianos)) /g;
            double altura = Math.Pow((velocidade * Math.Sin(anguloEmRadianos)), 2) / (2*g);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Alcance = {alcance:N} m");
            Console.WriteLine($"Altura Máxima = {altura:N} m");
            Console.ResetColor();
            Console.WriteLine();
           
            


            
        }
    }
}
