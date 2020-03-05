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
    public partial class Cantidad : Form
    {
        private int cant;
        private Venta ven;
        private Pelicula peli;
        private Music music;
        private Videogame vgame;
        public Cantidad(Pelicula p, ref Venta v)
        {
            cant = 0;
            ven = v;
            peli = p;
            InitializeComponent();
            label2.Text = Convert.ToString(cant);
        }
        public Cantidad(Music m, ref Venta v)
        {
            cant = 0;
            ven = v;
            music = m;
            InitializeComponent();
            label2.Text = Convert.ToString(cant);
        }
        public Cantidad(Videogame vg, ref Venta v)
        {
            cant = 0;
            ven = v;
            vgame = vg;
            InitializeComponent();
            label2.Text = Convert.ToString(cant);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(cant >0)
                cant--;
            label2.Text = Convert.ToString(cant);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cant < 30)
                cant++;
            label2.Text = Convert.ToString(cant);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cant > 0)
            {
                if (peli != null)
                {
                    peli.Cantidad = cant;
                    ven.Agregar(peli);
                }
                else if(music != null)
                {
                    music.Cantidad = cant;
                    ven.Agregar(music);
                }
                else if (vgame != null)
                {
                    vgame.Cantidad = cant;
                    ven.Agregar(vgame);
                }
                Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "Carrito").SingleOrDefault<Form>();
                if (existe != null)
                {
                    
                }
            }
            Visible = false;
            if (cant > 0)
            {
                if (peli != null)
                    MessageBox.Show(peli.ToString() + ". " + cant + " pieza/s.");
                else if (music != null)
                    MessageBox.Show(music.ToString() + ". " + cant + " pieza/s.");
                else if (vgame != null)
                    MessageBox.Show(vgame.ToString() + ". "+ cant +" pieza/s.");
            }
            
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cant = 0;
            Visible = false;
        }

        private void Cantidad_Load(object sender, EventArgs e)
        {

        }
    }
}
