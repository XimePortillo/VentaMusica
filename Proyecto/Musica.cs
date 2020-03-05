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
    public partial class Musica : Form
    {
        private Venta ven;
        public Musica(ref Venta v)
        {
            InitializeComponent();
            ven = v;
        }

        private void Musica_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Music music = new Music("Beatles for sale", Convert.ToSingle(250));
            Cantidad c = new Cantidad(music, ref ven);
            c.Visible = true;
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Music music = new Music("Abbey Road", Convert.ToSingle(250));
            Cantidad c = new Cantidad(music, ref ven);
            c.Visible = true;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Music music = new Music("Hot Space", Convert.ToSingle(250));
            Cantidad c = new Cantidad(music, ref ven);
            c.Visible = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Music music = new Music("Its Rock and Roll", Convert.ToSingle(250));
            Cantidad c = new Cantidad(music, ref ven);
            c.Visible = true;
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Music music = new Music("Out of our heads", Convert.ToSingle(250));
            Cantidad c = new Cantidad(music, ref ven);
            c.Visible = true;
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Music music = new Music("Tatoo you", Convert.ToSingle(250));
            Cantidad c = new Cantidad(music, ref ven);
            c.Visible = true;
        }
    }
}
