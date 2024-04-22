namespace clasesymetodosestaticos_classlibrary_ejercicioI01
{
    public class Validador
    {
        public static string Saludar()
        {
            return "Hola";
        }

        public static bool Validar(int valor, int min, int max)
        {
            //return valor >= min && valor <= max;
            bool result;
            if (valor >= min && valor <= max)
            {
                result = true;
            }
            else
                result = false;
            {

            }

            return result;
        }

    }
}
