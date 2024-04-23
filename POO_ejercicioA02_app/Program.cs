namespace POO_ejercicioA02_app;
using POO_ejercicioA02_class_library;
using System;

internal class Program
{
    static void Main(string[] args)
    {
        // Un cliente con un perro sin vacunar
        Mascota mascota1 = new Mascota("Bobby", "Perro", new DateTime(2019, 5, 15), new string[] { });
        Cliente cliente1 = new Cliente("Juan", "Perez", "Calle 123", "+541150188336", new Mascota[] { mascota1 });
        Console.WriteLine(cliente1.GetInfo());

        // Un cliente con un gato con la vacuna "Triple Felina"
        Mascota mascota2 = new Mascota("Felix", "Gato", new DateTime(2020, 6, 12), new string[] { "TripleFelina" });
        Cliente cliente2 = new Cliente("Maria", "Soledad", "Vereda 456", "+541169822774", new Mascota[] { mascota2 });
        Console.WriteLine(cliente2.GetInfo());

        // Un cliente con un gato sin vacunas y un perro con la vacuna contra la rabia.
        Mascota mascota3 = new Mascota("Ernie", "Perro", new DateTime(2021, 8, 20), new string[] { "Antirrábica" });
        Mascota mascota4 = new Mascota("Cleo", "Gato", new DateTime(2022, 3, 20), new string[] { });
        Cliente cliente3 = new Cliente("Marcelo", "Coelho", "Ruta 87", "+541178966003", new Mascota[] { mascota3, mascota4 });
        Console.WriteLine(cliente3.GetInfo());

        // Plus - Añadir vacunas nueva a una mascota && Añadir mascotas nuevas a un Cliente
        Console.WriteLine("-------Bonus-------");
        mascota1.AgregarVacuna("Antirrábica");
        mascota1.AgregarVacuna("Tetravalente");
        Mascota mascota5 = new Mascota("Filipo", "Gato", new DateTime(2023, 1, 15), new string[] { });
        cliente1.AgregarMascota(mascota5);
        Console.WriteLine(cliente1.GetInfo());

        
    }
}
