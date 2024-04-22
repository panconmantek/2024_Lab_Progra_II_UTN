namespace POO_ejercicioA01_app;
using POO_ejercicioA01_class_library;

internal class Program
{
    static void Main(string[] args)
    {
        Conductor chofer1 = new Conductor("Jose Juan", new double[] { 159, 628, 12, 0, 79, 15, 862 });
        Conductor chofer2 = new Conductor("Enrique Lopez", new double[] { 484, 0, 0, 0, 75, 205, 862 });
        Conductor chofer3 = new Conductor("Marcelo Aguero", new double[] { 175, 0, 3, 400, 2, 45, 87 });
        EmpresaDeTransporte empresa1 = new EmpresaDeTransporte("Tata rápido", new Conductor[] { chofer1, chofer2, chofer3 });
        
        Console.WriteLine("Maximos km recorridos día 3: {0}", empresa1.ObtenerMaximosKmRecorridos(3));
        Console.WriteLine("Maximos km recorridos día 5: {0}", empresa1.ObtenerMaximosKmRecorridos(5));
        Console.WriteLine("El chofer que más km recorrió: {0}", empresa1.ObtenerConductorConMayorRecorrido());
    }
}
