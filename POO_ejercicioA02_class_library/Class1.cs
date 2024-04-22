using System.Text;

namespace POO_ejercicioA02_class_library
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

    public class Mascota
    {
        private string nombre;
        private string especie;
        private DateTime fechaNacimiento;
        private string[] vacunas;

        public Mascota(string nombre, string especie, DateTime fechaNacimiento, string[] vacunas)
        {
            this.nombre = nombre;
            this.especie = especie;
            this.fechaNacimiento = fechaNacimiento;
            this.vacunas = vacunas;
        }

        public void AgregarVacuna(string vacuna)
        {
            if (vacuna != null)
            {
                int newLength = this.vacunas.Length + 1;
                string[] vacunasActualizadas = new string[newLength];
                Array.Copy(this.vacunas, vacunasActualizadas, Math.Min(this.vacunas.Length, vacunasActualizadas.Length));
                vacunasActualizadas[vacunasActualizadas.Length - 1] = vacuna;
                this.vacunas = vacunasActualizadas;
            }
        }

        public string GetInfo()
        {
            StringBuilder sb = new StringBuilder();
            string infoVacunas = $"";
            sb.AppendLine("-----------------------------------");
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Especie: {this.especie}");
            sb.AppendLine($"Fecha de nacimiento: {this.fechaNacimiento.ToString("dd/MM/yyyy")}");

            if (this.vacunas.Length > 0)
            {
                foreach (var vacuna in this.vacunas)
                {
                    infoVacunas += $" {vacuna},";
                }

                infoVacunas = infoVacunas.TrimEnd(',');
                sb.AppendLine($"Vacunas: {infoVacunas}");
            }
            else
            {
                sb.AppendLine($"Vacunas: No tiene");
            }

            return sb.ToString();
        }
    }
}
