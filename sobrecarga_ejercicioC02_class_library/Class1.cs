using System.Runtime.CompilerServices;
using System.Text;

namespace sobrecarga_ejercicioC02_class_library
{
    public class Producto
    {
        private string marca;
        private string codigoDeBarra;
        private float precio;

        public Producto(string marca, string codigoDeBarra, float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigoDeBarra;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto producto)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Marca: {producto.GetMarca()}");
            sb.AppendLine($"Precio: {producto.GetPrecio()}");
            sb.AppendLine($"Código: {(string)producto}");

            return sb.ToString();
        }

        public static explicit operator string(Producto producto)
        {
            return producto.codigoDeBarra;
        }

        public static bool operator ==(Producto producto1, Producto producto2)
        {
            // Retornará true si las marcas y códigos de barra son iguales, false caso contrario.
            if (!(producto1 is null || producto2 is null))
            {
                return (producto1.GetMarca() == producto2.GetMarca() && producto1.codigoDeBarra == producto2.codigoDeBarra);
            }
            return false;
        }

        public static bool operator !=(Producto producto1, Producto producto2)
        {
            return !(producto1 == producto2);
        }

        public static bool operator ==(Producto producto1, string producto2)
        {
            // Retornará true si la marca del producto coincide con la cadena pasada como argumento, false caso contrario.
            if (producto1.GetMarca() == producto2)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Producto producto1, string producto2)
        {
            return !(producto1 == producto2);
        }


    }

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
