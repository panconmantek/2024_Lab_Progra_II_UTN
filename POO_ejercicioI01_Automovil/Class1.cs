using POO_ejercicioI01_VehiculoTerrestre;
using System.Text;
namespace POO_ejercicioI01_Automovil
{
    public class Automovil : VehiculoTerrestre
    {
        private short cantidadMarchas;
        private int cantidadPasajeros;

        public Automovil(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int cantidadPasajeros) : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.cantidadPasajeros = cantidadPasajeros;
        }

        public static string MostrarInformacion(Automovil auto)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("_____________Auto_____________");
            sb.AppendLine(VehiculoTerrestre.ObtenerVehiculo(auto));
            sb.AppendLine($"Cantidad de Marchas: {auto.cantidadMarchas}");
            sb.AppendLine($"Pasajeros: {auto.cantidadPasajeros}");

            return sb.ToString();
        }
    }
}
