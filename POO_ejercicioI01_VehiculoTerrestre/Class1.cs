using System.Reflection;
using System.Text;

namespace POO_ejercicioI01_VehiculoTerrestre
{
    public enum Colores
    {
        Rojo,
        Blanco,
        Azul,
        Gris,
        Negro
    }
    public class VehiculoTerrestre
    {
        private short cantidadRuedas;
        private short cantidadPuertas;
        private Colores color;

        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, Colores color)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
        }

        public short GetCantidadRuedas()
        {
            return this.cantidadRuedas;
        }

        public short GetCantidadPuertas()
        {
            return this.cantidadPuertas;
        }

        public Colores GetColor()
        {
            return this.color;
        }

        public static string ObtenerVehiculo(VehiculoTerrestre vehiculo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cantidad de ruedas: {vehiculo.cantidadRuedas}");
            sb.AppendLine($"Cantidad de puertas: {vehiculo.cantidadPuertas}");
            sb.AppendLine($"Color: {vehiculo.color}");

            return TrimFinalParagraphLine(sb.ToString());
        }

        static string TrimFinalParagraphLine(string text)
        {
            // Split the text into paragraphs
            string[] paragraphs = text.Split(new string[] { "\n\n" }, StringSplitOptions.None);

            // Trim the final paragraph line
            paragraphs[paragraphs.Length - 1] = paragraphs[paragraphs.Length - 1].TrimEnd();

            // Join the paragraphs back together
            return string.Join("\n\n", paragraphs);
        }

    }
}
