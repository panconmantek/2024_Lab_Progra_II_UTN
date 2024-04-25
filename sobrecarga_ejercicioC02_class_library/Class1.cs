using System.Runtime.CompilerServices;
using System.Text;

namespace SOBRECARGA_ejercicioC02_Producto
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

}
