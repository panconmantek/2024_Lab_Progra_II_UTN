namespace POO_ejercicioC01_Equipo;
using POO_ejercicioC01_Jugador;
using System.Text;

public class Equipo
{
    private int cantidadDeJugadores;
    private string nombre;
    private Jugador[] jugadores;

    public Equipo()
    {
        this.cantidadDeJugadores = 0;
        this.nombre = "";
        this.jugadores = new Jugador[0];
    }

    public Equipo(int cantidadDeJugadores, string nombre)
    {
        this.cantidadDeJugadores = cantidadDeJugadores;
        this.nombre = nombre;
        this.jugadores = new Jugador[cantidadDeJugadores];
    }

    public string Mostrar()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"Equipo: {this.nombre}");
        sb.AppendLine($"Jugadores: ");

        foreach (var jugador in this.jugadores)
        {
            if (jugador is not null)
            {
                sb.Append(jugador.MostrarDatos());
                sb.AppendLine($"Promedio: {jugador.PromedioDeGoles()}");
            }
        }

        return sb.ToString();
    }

    public static bool operator +(Equipo equipo, Jugador jugador)
    {
        if (equipo is not null && jugador is not null)
        {
            int newSize = equipo.cantidadDeJugadores++;
            Jugador[] resizedArray = new Jugador[newSize];
            Array.Copy(equipo.jugadores, resizedArray, equipo.jugadores.Length);
            resizedArray[newSize - 1] = jugador;
            equipo.jugadores = resizedArray;
            return true;
        }
        return false;
    }
}
