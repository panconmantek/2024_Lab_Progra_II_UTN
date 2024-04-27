namespace POO_ejercicioC01_DirectorTecnico;
using POO_ejercicioC01_Persona;
using System.Text;

public class DirectorTecnico : Persona
{
    private DateTime fechaNacimiento;

    public DirectorTecnico(string nombre) : base(nombre)
    {

    }

    public DirectorTecnico(string nombre, DateTime fechaNacimiento) : this(nombre)
    {
        this.fechaNacimiento = fechaNacimiento;
    }

    public override string MostrarDatos()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Nombre: {this.GetNombre()}");
        sb.AppendLine($"DNI: {this.GetDni()}");
        sb.AppendLine($"Fecha de nacimiento: {this.fechaNacimiento.ToString("dd/MM/yyyy")}");

        return sb.ToString();
    }

    public static bool operator ==(DirectorTecnico dt1, DirectorTecnico dt2)
    {
        if (dt1.GetNombre() == dt2.GetNombre() && dt1.fechaNacimiento == dt2.fechaNacimiento)
        {
            return true;
        }
        return false;
    }

    public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
    {
        return !(dt1 == dt2);
    }
}
