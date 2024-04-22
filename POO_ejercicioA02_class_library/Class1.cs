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

                infoVacunas = infoVacunas.TrimEnd(',') + "\n";
                sb.AppendLine($"Vacunas: {infoVacunas}");
            }
            else
            {
                sb.AppendLine($"Vacunas: No tiene");
            }

            sb.AppendLine("-----------------------------------");

            return sb.ToString();
        }
    }
}
