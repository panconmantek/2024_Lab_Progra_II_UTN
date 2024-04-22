namespace intro_ejercicioI01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Ingresar 5 números por consola, guardándolos en una variable escalar. 
                Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
            */
            double sum = 0, max = 0, min = 0, average;
            bool firstRound = false;

            for (int i = 0; i < 5; i++)
            {
                double current;
                Console.WriteLine("Ingrese un número");
                string input = Console.ReadLine();

                if (double.TryParse(input, out current))
                {
                    if(!firstRound) {
                        firstRound = true;
                        max = current; 
                        min = current;
                    }
                    sum += current;
                    if (current > max) { max = current; }
                    if (current < min) { min = current; }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
                    i--;
                }
            }

            average = sum / 5;
            Console.WriteLine("El promedio es {0}. El máximo valor ingresado es {1} y el mínimo {2}. Adiós.", average, max, min);
        }
    }
}
