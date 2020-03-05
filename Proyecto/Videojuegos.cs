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
    public partial class Videojuegos : Form
    {
        private Venta ven;
        public Videojuegos(ref Venta v)
        {
            InitializeComponent();
            ven = v;
        }
        private void Videojuegos_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Videogame videogame = new Videogame("Assassin's Creed", Convert.ToSingle(150));
            Cantidad c = new Cantidad(videogame, ref ven);
            c.Visible = true;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Videogame videogame = new Videogame("Assassin's Creed II", Convert.ToSingle(280));
            Cantidad c = new Cantidad(videogame, ref ven);
            c.Visible = true;
        }
    }
}
