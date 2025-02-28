using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionADO6D
{
    public partial class Form1 : Form
    {

        Datos datos = new Datos();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void Refrescar()
        {
            try
            {
                DataTable dataTable = new DataTable();

                dataTable = datos.TablaAutor();

                dgvDatos.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = new DataTable();

                dataTable = datos.FiltroAutor(txbFiltro.Text);

                dgvDatos.DataSource = dataTable;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string error = "";

                error = datos.AgregarAutor(txbId.Text, txbNombre.Text, txbApellido.Text, txbTelefono.Text, txbDireccion.Text, txbCiudad.Text, txbEstado.Text, Convert.ToInt32(txbCP.Text), chkContrato.Checked);

                if (string.IsNullOrEmpty(error))
                {
                    MessageBox.Show("Registro agregado correctamente", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
