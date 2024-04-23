namespace sobrecarga_ejercicioI01_class_library
{
    public class Sumador
    {
        private int cantidadSumas;

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public Sumador() : this(0)
        {

        }

        public long Sumar(long n1, long n2)
        {
            this.cantidadSumas++;
            return n1 + n2;
        }

        public string Sumar(string s1, string s2)
        {
            this.cantidadSumas++;
            return s1 + s2;
        }

        public static explicit operator int(Sumador sumador)
        {
            return sumador.cantidadSumas;
        }

        public static long operator +(Sumador s1, Sumador s2)
        {
            /*
             * Sobrecargar el operador + (suma) con dos operadores de tipo Sumador. 
             * El resultado será un long correspondiente al resultado de la suma del 
             * atributo cantidadSumas de cada argumento.           
             */
            return (int)s1 + (int)s2;
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {
            /*
             * Sobrecargar el operador | (pipe) con dos operadores de tipo Sumador. 
             * Deberá retornar true si ambos sumadores tienen igual valor en el 
             * atributo cantidadSumas.           
             */
            if ((int)s1 == (int)s2)
            {
                return true;
            }
            return false;
        }
    }
}
