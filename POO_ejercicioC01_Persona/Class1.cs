using System.Text;

namespace POO_ejercicioC01_Persona
{
    public class Persona
    {
        private string nombre;
        private long dni;

        public string GetNombre()
        {
            return this.nombre;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public long GetDni()
        {
            return this.dni;
        }

        public void SetDni(long dni)
        {
            this.dni = dni;
        }

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public Persona(string nombre, long dni) : this(nombre)
        {
            this.dni = dni;
        }

        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"DNI: {this.dni}");

            return sb.ToString();
        }

    }
}
