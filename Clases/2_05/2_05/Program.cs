namespace AreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.CalcularAreaCuadrado(5));
            Console.WriteLine(Program.CalcularAreaCirculo(5));
            Console.WriteLine(Program.CalcularAreaTriangulo(5, 5));
        }

        static public double CalcularAreaCuadrado(double longitudLado) 
        {
            double areaTotal;
            areaTotal = Math.Pow(longitudLado, 2);
            return areaTotal;
        }

        static public double CalcularAreaTriangulo(double t_base, double t_altura) 
        {
            double areaTotal;
            areaTotal = (t_base * t_altura) / 2;
            return areaTotal;
        }

        static public double CalcularAreaCirculo(double radio) 
        {
            double areaTotal;
            areaTotal = double.Pi * Math.Pow(radio, 2);
            return areaTotal;
        }
    }
}