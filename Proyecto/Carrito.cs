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
    public partial class Carrito : Form
    {
        public  List<Productos> items ;
        public static List<int> quantity;
        private int cantidad;
        private Venta aux;
        //private Venta v;
        public Carrito(ref Venta v)
        {
            aux = v;
            InitializeComponent();
            List<Productos> items = v.ObtenerProd();
            List<int> quantity = v.ObtenerCant();

            int valor = 0;
            for (int i = 0; i < items.Count; i++)
            {
                string[] row = new string[] { items[i].Nombre, Convert.ToString(items[i].Precio), Convert.ToString(items[i].Cantidad), Convert.ToString((items[i].Precio) * (items[i].Cantidad)) };
                dataGridView1.Rows.Add(row);
            }
            string s="";
            for (int i = 0; i < items.Count; i++)
            {
                valor = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value.ToString());
                //quantity[i] = valor;
                s = s + " " + items[i].Nombre + " " + items[i].Precio + " " + items[i].Cantidad;
            }
            label2.Text = s;
            this.dataGridView1.Columns[0].ReadOnly = true;
            this.dataGridView1.Columns[1].ReadOnly = true;
            this.dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;

        }

        private void Carrito_Load(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        
       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void InitializeDataGridView()
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dataGridView1.SelectedRows)
            {
                aux.QuitarProducto(row.Index);
                dataGridView1.Rows.RemoveAt(row.Index);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cantidad = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                aux.Editar(e.RowIndex, cantidad);
            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar solo numero");
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = cantidad.ToString();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cantidad = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            //if(e.KeyCode == Keys.F2)
            //cantidad = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
        }
    }

}
