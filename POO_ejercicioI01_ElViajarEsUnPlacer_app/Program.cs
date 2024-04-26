namespace POO_ejercicioI01_ElViajarEsUnPlacer_app;
using POO_ejercicioI01_VehiculoTerrestre;
using POO_ejercicioI01_Camion;
using POO_ejercicioI01_Automovil;
using POO_ejercicioI01_Moto;

internal class Program
{
    static void Main(string[] args)
    {
        VehiculoTerrestre vehiculo = new VehiculoTerrestre(4, 2, Colores.Negro);
        Camion camion = new Camion(8, 2, Colores.Rojo, 3, 250);
        Automovil auto = new Automovil(4, 4, Colores.Gris, 4, 2);
        Moto moto = new Moto(2, 0, Colores.Negro, 126);

        Console.WriteLine(VehiculoTerrestre.ObtenerVehiculo(vehiculo));
        Console.WriteLine(Camion.MostrarInformacion(camion));
        Console.WriteLine(Automovil.MostrarInformacion(auto));
        Console.WriteLine(Moto.MostrarInformacion(moto));
    }
}
