using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Pelicula : Productos
    {
        private string categoria;
        private string pais = "EUA";
        private string tipo = "Blue-ray";
        public Pelicula(string nombre, float precio,int cantidad = 0) : base(nombre, precio, cantidad)
        {
            categoria = "Pelicula";
        }
        public override String ToString()
        {
            return ("Se ha agregado la película " + Nombre + ", país de origen " + pais + ", el cual tiene un costo de $" + Precio + " además es " + tipo);
        }
    }
}
