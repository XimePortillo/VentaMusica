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
    }
}
