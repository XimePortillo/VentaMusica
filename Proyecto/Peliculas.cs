using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Peliculas : Form
    {
        private Venta ven;
        public Peliculas(ref Venta v)
        {
            InitializeComponent();
            ven = v;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Pelicula peli = new Pelicula("Birds of Prey", Convert.ToSingle(325.5));
            Cantidad c = new Cantidad(peli, ref ven);
            c.Visible = true;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Pelicula peli = new Pelicula("Joker", Convert.ToSingle(400));
            Cantidad c = new Cantidad(peli, ref ven);
            c.Visible = true;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Pelicula peli = new Pelicula("Wonder Woman", Convert.ToSingle(239.80));
            Cantidad c = new Cantidad(peli, ref ven);
            c.Visible = true;
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Pelicula peli = new Pelicula("Justice League", Convert.ToSingle(158));
            Cantidad c = new Cantidad(peli, ref ven);
            c.Visible = true;
        }

        private void Peliculas_Load(object sender, EventArgs e)
        {

        }
    }
}
