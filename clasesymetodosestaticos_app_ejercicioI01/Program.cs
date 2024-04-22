namespace clasesymetodosestaticos_app_ejercicioI01;
using clasesymetodosestaticos_classlibrary_ejercicioI01;

internal class Program
{
    static void Main(string[] args)
    {
        string numeroString;
        int input, min = int.MinValue, max = int.MaxValue, avg, sum = 0;
        for (int i = 0; i < 10; i++)
        {
            do
            {
                Console.WriteLine("Ingrese un numero. Iteración {0}", i);
                numeroString = Console.ReadLine();
            } while (!int.TryParse(numeroString, out input));

            if (Validador.Validar(input, -100, 100))
            {
                Console.WriteLine("{0} Está dentro del rango", input);
            }
            else
            {
                Console.WriteLine("{0} Está fuera del rango", input);
            }

            if (input > max) { max = input; }
            if (input < min) { min = input; }
            sum += input;
        }
        avg = sum / 10;
        Console.WriteLine("El promedio es {0}", avg);
        Console.WriteLine("El máximo es {0}", max);
        Console.WriteLine("El mínimo es {0}", min);
    }
}
