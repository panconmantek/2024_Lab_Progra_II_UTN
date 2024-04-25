using System.Runtime.CompilerServices;
using POO_ejercicioA01_Conductor;

namespace POO_ejercicioA01_EmpresaDeTransporte
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

}
