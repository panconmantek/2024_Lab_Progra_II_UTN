using POO_ejercicioI01_VehiculoTerrestre;
using System.Text;
namespace POO_ejercicioI01_Moto
{
    public class Moto : VehiculoTerrestre
    {
        private short cilindrada;

        public Moto(short cantidadRuedas, short cantidadPuertas, Colores color, short cilindrada) : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cilindrada = cilindrada;
        }

        public static string MostrarInformacion(Moto moto)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("_____________Moto_____________");
            sb.AppendLine(VehiculoTerrestre.ObtenerVehiculo(moto));
            sb.AppendLine($"Cilindrada: {moto.cilindrada}");

            return sb.ToString();
        }
    }
}
