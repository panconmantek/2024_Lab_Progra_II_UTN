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
            double maximoRecorrido = 0;

            for (int i = 0; i < this.conductores.Length; i++)
            {
                Conductor conductorActual = this.conductores[i];
                double kilometrosPorDia = conductorActual.ObtenerKilometrosPorDia(diaDeLaSemana);
                if (kilometrosPorDia > maximoRecorrido)
                {
                    nombre = conductorActual.ObtenerNombreDelConductor();
                    maximoRecorrido = kilometrosPorDia;
                }
            }

            return nombre;
        }

        public string ObtenerConductorConMayorRecorrido()
        {
            string nombre = string.Empty;
            double maximoRecorridoTotal = 0;

            foreach (var conductor in this.conductores)
            {
                double totalSemanalDelConductor = conductor.ObtenerTotalKmPorSemana();
                if(maximoRecorridoTotal < totalSemanalDelConductor)
                {
                    nombre = conductor.ObtenerNombreDelConductor();
                    maximoRecorridoTotal= totalSemanalDelConductor;
                }

            }

            return nombre;
        }
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

        public double ObtenerTotalKmPorSemana()
        {
            double total = 0;

            foreach (var kmDia in this.kilometrosPorDia)
            {
                total += kmDia;
            }

            return total;
        }
    }
}
