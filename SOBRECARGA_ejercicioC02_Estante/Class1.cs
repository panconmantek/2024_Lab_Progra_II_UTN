using System.Text;
using SOBRECARGA_ejercicioC02_Producto;

namespace SOBRECARGA_ejercicioC02_Estante
{
    public class Estante
    {
        private int ubicacionEstante;
        private Producto[] productos;

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacionEstante) : this(capacidad)
        {
            this.ubicacionEstante = ubicacionEstante;
        }

        public Producto[] GetProducto()
        {
            return this.productos;
        }

        public static string MostrarEstante(Estante estante)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Ubicación: {estante.ubicacionEstante}");
            sb.AppendLine($"Productos:");

            foreach (var producto in estante.productos)
            {
                sb.AppendLine(Producto.MostrarProducto(producto));
            }

            return sb.ToString();
        }

        public static bool operator ==(Estante estante, Producto producto)
        {
            // Retornará true si es que el producto ya se encuentra en el estante, false caso contrario.
            for (int i = 0; i < estante.productos.Length; i++)
            {
                if (estante.productos[i] is not null)
                {
                    if (estante.productos[i] == producto)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator !=(Estante estante, Producto producto)
        {
            return !(estante == producto);
        }

        public static bool operator +(Estante estante, Producto producto)
        {
            /*
             * Retornará true y agregará el producto si el estante posee 
             * capacidad de almacenar al menos un producto más y dicho producto 
             * no se encuentra en el estante, false caso contrario. Reutilizar código.
            */

            if (estante != producto)
            {
                for (int i = 0; i < estante.productos.Length; i++)
                {
                    if (estante.productos[i] is null)
                    {
                        estante.productos[i] = producto;
                        return true;
                    }
                }
            }

            return false;
        }

        public static Estante operator -(Estante estante, Producto producto)
        {
            /*
             * Retornará un estante sin el producto, siempre y cuando 
             * el producto se encuentre en el listado. Reutilizar código.
             */

            for (int i = 0; i < estante.productos.Length; i++)
            {
                if (estante.productos[i] == producto)
                {
                    estante.productos[i] = null;
                }
            }

            return estante;
        }
    }
}
