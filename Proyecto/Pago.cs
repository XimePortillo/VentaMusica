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
    public partial class Pago : Form
    {
        private float total;
        private float pago;
        private Venta aux;
        public Pago(float cantidad, ref Venta v)
        {
            InitializeComponent();
            total = cantidad;
            aux = v;
            label3.Text = "$" + total.ToString();
        }

        private void Pago_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                try
                {
                    pago = float.Parse(textBox1.Text.ToString());
                    float resultado = pago - total;
                    if (resultado < 0)
                        MessageBox.Show("Aun le falta $" + Math.Abs(resultado));
                    else
                    {
                        aux.Pagar();
                        MessageBox.Show("Su compra fue realizada con éxito. Su cambio es de $"+resultado);
                        var frm = Application.OpenForms.OfType<Carrito>().FirstOrDefault();
                        frm.Close();
                        this.Close();
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Ingrese por favor la cantidad en número con la que desea pagar");
                }
            }
            else
                MessageBox.Show("Favor de ingresar cantidad con la que desea pagar");
        }
    }
}
