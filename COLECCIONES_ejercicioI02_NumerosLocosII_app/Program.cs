using System;

namespace COLECCIONES_ejercicioI02_NumerosLocosII_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> lista = new List<int>();
            Queue<int> colaPositivos = new Queue<int>();
            Stack<int> stackPositivos = new Stack<int>();
            Queue<int> colaNegavos = new Queue<int>();
            Stack<int> stackNegativos = new Stack<int>();

            for (int i = 0; i < 20; i++)
            {
                int numeroAleatorio;
                do
                {
                    numeroAleatorio = random.Next(-100, 100);
                    lista.Add(numeroAleatorio);
                } while (numeroAleatorio == 0);
            }

            Console.WriteLine("Orden predeterminado");
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            lista.Sort();
            Console.WriteLine("Orden ascendente");
            foreach (var item in lista)
            {
                Console.WriteLine(item);
                if (item < 0)
                {
                    colaNegavos.Enqueue(item);
                    stackNegativos.Push(item);
                }
                else
                {
                    colaPositivos.Enqueue(item);
                    stackPositivos.Push(item);
                }
            }

            Console.WriteLine("Orden descendente");
            for (int i = lista.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(lista[i]);
            }

            Console.WriteLine("Positivos");
            foreach (var item in colaPositivos)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Negativos");
            foreach (var item in stackNegativos)
            {
                Console.WriteLine(item);
            }


        }
    }
}
