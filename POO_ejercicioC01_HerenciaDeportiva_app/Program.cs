namespace POO_ejercicioC01_HerenciaDeportiva_app;
using POO_ejercicioC01_Persona;
using POO_ejercicioC01_DirectorTecnico;
using POO_ejercicioC01_Jugador;
using POO_ejercicioC01_Equipo;

internal class Program
{
    static void Main(string[] args)
    {
        Persona person1 = new Persona("Mica", 40991761);
        Console.WriteLine(person1.MostrarDatos());

        DirectorTecnico dt1 = new DirectorTecnico("Jose Luis", new DateTime(1983, 3, 12));
        Console.WriteLine(dt1.MostrarDatos());
        dt1.SetDni(308857641);
        Console.WriteLine(dt1.MostrarDatos());

        Jugador j1 = new Jugador("Mariano Gomez", 41123864, 110, 230);
        Console.WriteLine(j1.MostrarDatos());

        Jugador j2 = new Jugador("Juan Jo", 41229345, 110, 68);
        Console.WriteLine(j2.MostrarDatos());

        Jugador j3 = new Jugador("Nosepon Ernombres", 41678864, 110, 36);
        Console.WriteLine(j3.MostrarDatos());

        Equipo e1 = new Equipo(2, "Almagro");
        Console.WriteLine(e1.Mostrar());

        if (e1 + j1)
        {
            Console.WriteLine(e1.Mostrar());
        }
    }
}
