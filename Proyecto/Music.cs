using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Music : Productos
    {
        private string categoria;
        private string compania = "Sony Records";
        private string tipo { get; set; }
        public Music(string nombre, float precio, int cantidad=0) : base(nombre, precio,cantidad)
        {
            categoria = "Musica";
        }
        public override string ToString()
        {
            return ("Se ha agregado el disco " + Nombre + tipo + " de la categoría " + categoria + " de la compañía " + compania + " el cual tiene un costo de $" + Precio);
        }
    }
}
