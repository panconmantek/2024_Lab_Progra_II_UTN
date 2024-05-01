namespace COLECCIONES_ejercicioI01_NumerosLocos_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> numeros = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                int numeroAleatorio = random.Next(1, 100);

                if (!numeros.Contains(numeroAleatorio))
                {
                    numeros.Add(numeroAleatorio);
                }
            }

            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }

            numeros.Sort();

            Console.WriteLine("Orden ascente");

            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("Orden descendente");
            numeros.Reverse();

            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }


        }
    }
}
