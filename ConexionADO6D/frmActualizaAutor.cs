﻿using System;
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
    public partial class frmActualizaAutor : Form
    {
        string _id;
        string _Nombre;
        string _Apellido;
        string _Telefono;
        string _Direccion;
        string _Ciudad;
        string _Estado;
        string _CodigoPostal;
        bool _Contrato;

        Datos datos = new Datos();
        public frmActualizaAutor(string id, string Nombre, string Apellido, string Telefono, string Direccion, string Ciudad, string Estado, string CodigoPostal, bool Contrato)
        {
            InitializeComponent();

            //Inicializamor componentes globales con la información que recibe el formulario
            _id = id; 
            _Nombre = Nombre;
            _Apellido = Apellido;
            _Telefono = Telefono;
            _Direccion = Direccion;
            _Ciudad = Ciudad;
            _Estado = Estado;
            _CodigoPostal = CodigoPostal;
            _Contrato = Contrato;
        }

        private void frmActualizaAutor_Load(object sender, EventArgs e)
        {
            CargarEstados();

            mskId.Text = _id;
            mskId.Enabled = false;
            txbNombre.Text = _Nombre;
            txbApellido.Text = _Apellido;
            mskTelefono.Text = _Telefono;
            txbDireccion.Text = _Direccion;
            txbCiudad.Text = _Ciudad;
            cbEstado.Text = _Estado;
            txbCP.Text = _CodigoPostal;
            chkContrato.Checked = _Contrato;

        }

        private void CargarEstados()
        {
            DataTable dt = new DataTable();
            try
            {
                //Lenamos un dataTable con la información que regresa el metodo CargarEstados
                dt = datos.CargarEstados();

                //Cargamos el combobox con los estados
                cbEstado.DataSource = dt;
                //Indicamos que se va a mostrar el valor Nombre
                cbEstado.DisplayMember = "Nombre";
                //Indicamos que se va a enviar el valor Abreviación cuando realicemos alguna acción
                cbEstado.ValueMember = "Abreviacion";

                cbEstado.SelectedIndex = 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string Error;

                Error = datos.ModificarAutor(mskId.Text, txbNombre.Text, txbApellido.Text, mskTelefono.Text, txbDireccion.Text, txbCiudad.Text, cbEstado.SelectedValue.ToString(), Convert.ToInt32(txbCP.Text), chkContrato.Checked);
                if (string.IsNullOrEmpty(Error))
                {
                    MessageBox.Show("Registro Actualizado correctamente", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();

                    Form1 form1 = new Form1();
                    form1.Show();

                }
                else
                {
                    MessageBox.Show(Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmActualizaAutor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
