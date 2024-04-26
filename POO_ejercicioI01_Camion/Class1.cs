using POO_ejercicioI01_VehiculoTerrestre;
using System.Drawing;
using System.Reflection;
using System.Text;

namespace POO_ejercicioI01_Camion
{
    public class Camion : VehiculoTerrestre
    {
        private short cantidadMarchas;
        private int pesoCarga;

        public Camion(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int pesoCarga) : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.pesoCarga = pesoCarga;
        }

        public static string MostrarInformacion(Camion camion)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("____________Camion____________");
            sb.AppendLine(VehiculoTerrestre.ObtenerVehiculo(camion));
            sb.AppendLine($"Cantidad de Marchas: {camion.cantidadMarchas}");
            sb.AppendLine($"Carga: {camion.pesoCarga}kg");

            return sb.ToString();
        }
    }
}
