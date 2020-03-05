using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Videogame : Productos
    {
        private string categoria;
        private string compania = "Ubisoft";
        private string consola = "Xbox 360";
        public Videogame(string nombre, float precio, int cantidad=0) : base(nombre, precio, cantidad)
        {
            categoria = "Videojuego";
        }
        public override String ToString()
        {
            return ("Se ha agregado el videojuego " + Nombre + " de la categoría " + categoria + " de la compañía " + compania + " el cual tiene un costo de $" + Precio + " y se encuentra disponible para " + consola);
        }
    }
}
