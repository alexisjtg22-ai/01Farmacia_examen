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
    public partial class FrmMedicamentos : Form
    {
        int Empleado_id = 0;
        public FrmMedicamentos()
        {
            InitializeComponent();
        }

        private void FrmMedicamentos_Load(object sender, EventArgs e)
        {
          dataGridView1.DataSource = Medicamento.obtener();
            if (dataGridView1.ColumnCount > 0)
            {
                dataGridView1.Columns[0].Visible = false;
            }
        }
        public void limpiar()
        {
            txtnombre.Clear();
            txtpriac.Clear();
            txtconce.Clear();
            txtpre.Clear();
            txtlabo.Clear();
            txtregis.Clear();
            txtrequiere.Clear();
            Empleado_id = 0;
            txtnombre.Focus();
        }

        private void btnGuardarMedicamento_Click(object sender, EventArgs e)
        {
            string nombres= txtnombre.Text;
            string principio_activo = txtpriac.Text;
            string concentracion = txtconce.Text;
            string presentacion = txtpre.Text;
            string laboratorio = txtlabo.Text;
            string registro_sanitario = txtregis.Text;
            string requiere_receta = txtrequiere.Text;
            bool resultado = false;
            if (Empleado_id == 0)
            {
                resultado=Medicamento.guardar(nombres, principio_activo, concentracion, presentacion, laboratorio, registro_sanitario, requiere_receta);
            }
            else
            {
                resultado = Medicamento.editar(nombres, principio_activo,concentracion,presentacion,laboratorio,registro_sanitario,requiere_receta, Empleado_id);
            }
            if (resultado)
            {
                MessageBox.Show("Datos guardados correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al guardar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridView1.DataSource = Medicamento.obtener();
            limpiar();
        }

        private void btnEditarMedicamento_Click(object sender, EventArgs e)
        {
            txtnombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtpriac.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtconce.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtpre.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtlabo.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtregis.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtrequiere.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            Empleado_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void btnEliminarMedicamento_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            bool resultado = Medicamento.eliminar(id);
            if (resultado)
            {
                MessageBox.Show("Datos eliminados correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al eliminar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridView1.DataSource = Medicamento.obtener();
            limpiar();
        }
    }
}

