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
    public partial class Form1 : Form
    {
        private Venta v;
        public Form1()
        {
            InitializeComponent();
            v = new Venta();
        }

        public void reestablecerLink()
        {
            linkLabel1.LinkColor = Color.Blue;
            linkLabel2.LinkColor = Color.Blue;
            linkLabel3.LinkColor = Color.Blue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reestablecerLink();
            linkLabel2.LinkColor = Color.SlateBlue;
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "Videogame").SingleOrDefault<Form>();
            if (existe == null)
            {
                Videojuegos videogame = new Videojuegos(ref v);
                videogame.Visible = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            reestablecerLink();
            linkLabel1.LinkColor = Color.SlateBlue;
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "Musica").SingleOrDefault<Form>();
            if (existe == null)
            {
                Musica musica = new Musica(ref v);
                musica.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reestablecerLink();
            linkLabel3.LinkColor = Color.SlateBlue;
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "Peliculas").SingleOrDefault<Form>();
            if (existe == null)
            {
                Peliculas peliculas = new Peliculas(ref v);
                peliculas.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            reestablecerLink();
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "Carrito").SingleOrDefault<Form>();
            if(existe == null)
            {
                Carrito car = new Carrito(ref v);
                car.Visible = true;
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            reestablecerLink();
            linkLabel1.LinkColor = Color.SlateBlue;
            Musica musica = new Musica(ref v);
            musica.Visible = true;
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            reestablecerLink();
            linkLabel2.LinkColor = Color.SlateBlue;
            Videojuegos videogame = new Videojuegos(ref v);
            videogame.Visible = true;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            reestablecerLink();
            linkLabel3.LinkColor = Color.SlateBlue;
            Peliculas peliculas = new Peliculas(ref v);
            peliculas.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
