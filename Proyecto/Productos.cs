using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public abstract class Productos
    {
        private float precio;

        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public float Precio
        {
            get
            {
                return precio;
            }
            set
            {
                if (value >= 0)
                    precio = value;
            }
        }

        public Productos(string name, float price, int cant)
        {
            Nombre = name;
            precio = price;
            Cantidad = cant;
        }

        public override string ToString()
        {
            return ("Se ha agregado el producto " + Nombre + " el cual tiene un costo de $" + Precio);
        }
    }
}
