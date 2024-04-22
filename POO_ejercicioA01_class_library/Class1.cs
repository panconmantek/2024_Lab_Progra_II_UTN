using System.Runtime.CompilerServices;

namespace POO_ejercicioA01_class_library
{
    public class EmpresaDeTransporte
    {
        private string denominacion;
        private Conductor[] conductores;

        public EmpresaDeTransporte(string denominacion, Conductor[] conductores)
        {
            this.denominacion = denominacion;
            this.conductores = conductores;
        }

        public string ObtenerMaximosKmRecorridos(int diaDeLaSemana)
        {
            string nombre = string.Empty;
            double maximoRecorrido = double.MaxValue;

            for (int i = 0; i < this.conductores.Length; i++)
            {
                Conductor conductorActual = this.conductores[i];
                double kilometrosPorDia = conductorActual.ObtenerKilometrosPorDia(diaDeLaSemana - 1);
                if (maximoRecorrido < kilometrosPorDia)
                {
                    nombre = conductorActual.ObtenerNombreDelConductor();
                }
            }

            return nombre;
        }

        //public double ObtenerConductorConMayorRecorrido(int diaDeLaSemana)
        //{

        //}
    }

    public class Conductor
    {
        private string nombre;
        private double[] kilometrosPorDia;

        public Conductor(string nombre, double[] kilometrosPorDia)
        {
            this.nombre = nombre;
            this.kilometrosPorDia = kilometrosPorDia;
        }

        public string ObtenerNombreDelConductor()
        {
            return this.nombre;
        }

        public double ObtenerKilometrosPorDia(int diaDeLaSemana)
        {
            return this.kilometrosPorDia[diaDeLaSemana];
        }
    }
}
