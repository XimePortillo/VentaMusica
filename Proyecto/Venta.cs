using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Venta
    {
        private List<Productos> Prod = new List<Productos>();
        private List<int> cantidad = new List<int>();
        private float total;
        public string Articulos()
        {
            total = 0;
            string articulos = "Articulo         Precio     Cantidad\n";
            for (int i = 0; i < Prod.Count; i++)
            {
                articulos += (Convert.ToString(Prod[i].Nombre) + "    $" + Convert.ToString(Prod[i].Precio * cantidad[i]) + "        " + Convert.ToString(cantidad[i]) + "\n");
                total += Prod[i].Precio * cantidad[i];
            }
            articulos += "                     Total: $" + Convert.ToString(total);
            return articulos;
        }

        public void Agregar(Pelicula p )
        {
            bool existe = Prod.Any(x => x.Nombre == p.Nombre);
            if(!existe)
                Prod.Add(p);
            else
            {
                int id = Prod.FindIndex(x => x.Nombre == p.Nombre);
                Prod[id].Cantidad += p.Cantidad;
            }
        }
        public List<Productos> ObtenerProd()
        {
            return Prod;
        }
        public List<int> ObtenerCant()
        {
            return cantidad;
        }
        public void Dejar(Pelicula p)
        {

            for( int i=0;i<Prod.Count;i++)
            {
                if (Prod[i] == p)
                {
                    if (cantidad[i] >= 1)
                        cantidad[i] = cantidad[i] - 1;
                    else if (cantidad[i] == 0)
                    {
                        Prod.Remove(p);
                        cantidad[i] = 0;
                    }
                        

                }
            }
        }
        public void Agregar(Music m)
        {
            Prod.Add(m);
        }
        public void Agregar(Videogame v)
        {
            Prod.Add(v);
        }


        public void Cantidad(int cant)
        {
            cantidad.Add(cant);
        }
        public void Editar(int indexL, int cantidad)
        {
            Prod[indexL].Cantidad = cantidad;
        }
        public void QuitarProducto(int indexL)
        {
            Prod.RemoveAt(indexL);
        }
        /*public string Excecute(List<Productos> producto)
        {
            string articulos = "Articulo      Precio";
            foreach (var elemento in producto)
                articulos += (Convert.ToString(elemento.Nombre) + Convert.ToString(elemento.Precio));
            return articulos;
        }*/
    }
}
