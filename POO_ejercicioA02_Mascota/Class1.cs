using System.Text;

namespace POO_ejercicioA02_Mascota
{
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
