namespace POO_ejercicioC01_Jugador;
using POO_ejercicioC01_Persona;
using System.Text;

public class Jugador : Persona
{
    private int partidosJugados;
    private int totalGoles;

    public Jugador(string nombre, long dni) : base(nombre, dni)
    {
    }

    public Jugador(string nombre, long dni, int partidosJugados, int totalGoles) : this(nombre, dni)
    {
        this.partidosJugados = partidosJugados;
        this.totalGoles = totalGoles;
    }

    public int GetPartidosJugados()
    {
        return this.partidosJugados;
    }

    public void SetPartidosJugados(int partidosJugados)
    {
        this.partidosJugados = partidosJugados;
    }

    public int GetTotalGoles()
    {
        return this.totalGoles;
    }

    public void SetTotalGoles(int totalGoles)
    {
        this.totalGoles = totalGoles;
    }

    public double PromedioDeGoles()
    {
        return this.totalGoles / this.partidosJugados;
    }

    public override string MostrarDatos()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Nombre: {this.GetNombre()}");
        sb.AppendLine($"DNI: {this.GetDni()}");
        sb.AppendLine($"Partidos Jugados: {this.partidosJugados}");
        sb.AppendLine($"Goles: {this.totalGoles}");

        return sb.ToString();
    }

    public static bool operator ==(Jugador j1, Jugador j2)
    {
        if (j1.GetNombre() == j2.GetNombre())
        {
            return true;
        }
        return false;
    }

    public static bool operator !=(Jugador j1, Jugador j2)
    {
        return !(j1 == j2);
    }
}
