namespace POO_ejercicioA01_Conductor
{
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
