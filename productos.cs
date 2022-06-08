using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VaidrollTeamWindowsFormsApp1
{
    public partial class productos : Form
    {
        int codigo = 1;
        public productos()
        {
            InitializeComponent();
        }

        void limpiar()
        {
            txtId.Text = codigo.ToString();
            txtNombre.Text = "";
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtColor.Text = "";
            txtPrecio.Text = "";
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            object[] agregardato =
                    {
                    codigo.ToString(),
                    txtNombre.Text,
                    txtMarca.Text,
                    txtModelo.Text,
                    txtColor.Text,
                    txtPrecio.Text
                    };
            dataGridView1.Rows.Add(agregardato);
            MessageBox.Show("Producto registrado.", "Mensaje");
            codigo++;
            txtId.Text = codigo.ToString();
            limpiar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                int fila = dataGridView1.CurrentCell.RowIndex;
                txtId.Text = dataGridView1[0, fila].Value.ToString();
                txtNombre.Text = dataGridView1[1, fila].Value.ToString();
                txtMarca.Text = dataGridView1[2, fila].Value.ToString();
                txtModelo.Text = dataGridView1[3, fila].Value.ToString();
                txtColor.Text = dataGridView1[4, fila].Value.ToString();
                txtPrecio.Text = dataGridView1[5, fila].Value.ToString();
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                int indice = dataGridView1.CurrentRow.Index;
                dataGridView1.Rows[indice].Cells[0].Value = txtId.Text;
                dataGridView1.Rows[indice].Cells[1].Value = txtNombre.Text;
                dataGridView1.Rows[indice].Cells[2].Value = txtMarca.Text;
                dataGridView1.Rows[indice].Cells[3].Value = txtModelo.Text;
                dataGridView1.Rows[indice].Cells[4].Value = txtColor.Text;
                dataGridView1.Rows[indice].Cells[5].Value = txtPrecio.Text;
                MessageBox.Show("Producto modificado.", "Mensaje");
                limpiar();
            }

        }

        
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btneliminar.Visible==false)
            {
                btneliminar.Visible = true;
            }
            else
            {
                btneliminar.Visible = false;
            }
        }

        private void btneliminar_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                int fil = dataGridView1.CurrentRow.Index;
                dataGridView1.Rows.RemoveAt(fil);
                MessageBox.Show("Producto eliminado.", "Mensaje");
            }
            limpiar();
        }
    }
}
