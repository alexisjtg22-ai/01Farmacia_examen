using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Farmacia.Modelo;

namespace Farmacia
{
    public partial class FrmEmpleado : Form
    {
        int Empleado_id = 0;
        public FrmEmpleado()
        {
            InitializeComponent();
        }
       
        private void dg1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void limpiar()
        {
            txtnombre.Clear();
            txtemail.Clear();
            txttelefono.Clear();
            Empleado_id = 0;
            txtnombre.Focus();
        }
        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            dg1.DataSource = Empleado.obtener();
            if(dg1.ColumnCount >0)
            {
                dg1.Columns[0].Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombres = txtnombre.Text;
            string email= txtemail.Text;
            string telefono = txttelefono.Text;
            bool resultado = false;
            if (Empleado_id == 0)
            {
                resultado = Empleado.guardar(nombres, email, telefono);
            }
            else
            {
                resultado = Empleado.editar(nombres, email,telefono,Empleado_id);
            }
            if (resultado)
            {
                MessageBox.Show("Datos guardados correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al guardar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dg1.DataSource =Empleado.obtener();
            limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtnombre.Text = dg1.CurrentRow.Cells["nombre"].Value.ToString();
           txtemail.Text = dg1.CurrentRow.Cells["email"].Value.ToString();
            txttelefono.Text = dg1.CurrentRow.Cells["telefono"].Value.ToString();
            Empleado_id = Convert.ToInt32(dg1.CurrentRow.Cells["id"].Value.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dg1.CurrentRow.Cells["id"].Value.ToString());
            bool resultado = Empleado.eliminar(id);
            if (resultado)
            {
                MessageBox.Show("Datos eliminados correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al eliminar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dg1.DataSource = Empleado.obtener();
            limpiar();
        }
    }
    
}
