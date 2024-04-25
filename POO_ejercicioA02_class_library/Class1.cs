using System.Text;
using POO_ejercicioA02_Mascota;

namespace POO_ejercicioA02_Cliente
{
    public class Cliente
    {
        private string nombre;
        private string apellido;
        private string domicilio;
        private string telefono;
        private Mascota[] mascotas;

        public Cliente(string nombre, string apellido, string domicilio, string telefono, Mascota[] mascotas)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.domicilio = domicilio;
            this.telefono = telefono;
            this.mascotas = mascotas;
        }

        public void AgregarMascota(Mascota mascota)
        {
            int newLength = this.mascotas.Length + 1;
            Mascota[] mascotasActualizadas = new Mascota[newLength];
            Array.Copy(this.mascotas, mascotasActualizadas, Math.Min(this.mascotas.Length, mascotasActualizadas.Length));
            mascotasActualizadas[mascotasActualizadas.Length - 1] = mascota;
            this.mascotas = mascotasActualizadas;
        }

        public string GetInfo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("-----------------------------------");
            sb.AppendLine($"Cliente: {this.nombre} {this.apellido}");
            sb.AppendLine($"Dirección: {this.domicilio}");
            sb.AppendLine($"Teléfono: {this.telefono}");

            if (this.mascotas.Length > 0)
            {
                sb.AppendLine("Mascotas:");
                foreach (var mascota in this.mascotas)
                {
                    sb.AppendLine(mascota.GetInfo());
                }
            }

            sb.AppendLine("-----------------------------------");

            return sb.ToString();
        }
    }

}
