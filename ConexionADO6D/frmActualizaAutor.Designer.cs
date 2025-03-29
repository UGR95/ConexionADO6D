namespace ConexionADO6D
{
    partial class frmActualizaAutor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mskTelefono = new System.Windows.Forms.MaskedTextBox();
            this.mskId = new System.Windows.Forms.MaskedTextBox();
            this.chkContrato = new System.Windows.Forms.CheckBox();
            this.txbCP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbEstado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbCiudad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbDireccion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbApellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mskTelefono
            // 
            this.mskTelefono.Location = new System.Drawing.Point(102, 120);
            this.mskTelefono.Mask = "999 000-0000";
            this.mskTelefono.Name = "mskTelefono";
            this.mskTelefono.Size = new System.Drawing.Size(100, 20);
            this.mskTelefono.TabIndex = 64;
            // 
            // mskId
            // 
            this.mskId.Location = new System.Drawing.Point(102, 10);
            this.mskId.Mask = "000-00-0000";
            this.mskId.Name = "mskId";
            this.mskId.Size = new System.Drawing.Size(100, 20);
            this.mskId.TabIndex = 63;
            // 
            // chkContrato
            // 
            this.chkContrato.AutoSize = true;
            this.chkContrato.Location = new System.Drawing.Point(65, 308);
            this.chkContrato.Name = "chkContrato";
            this.chkContrato.Size = new System.Drawing.Size(66, 17);
            this.chkContrato.TabIndex = 62;
            this.chkContrato.Text = "Contrato";
            this.chkContrato.UseVisualStyleBackColor = true;
            // 
            // txbCP
            // 
            this.txbCP.Location = new System.Drawing.Point(102, 270);
            this.txbCP.Name = "txbCP";
            this.txbCP.Size = new System.Drawing.Size(100, 20);
            this.txbCP.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "Código Postal";
            // 
            // txbEstado
            // 
            this.txbEstado.Location = new System.Drawing.Point(102, 234);
            this.txbEstado.MaxLength = 2;
            this.txbEstado.Name = "txbEstado";
            this.txbEstado.Size = new System.Drawing.Size(100, 20);
            this.txbEstado.TabIndex = 59;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 58;
            this.label7.Text = "Estado";
            // 
            // txbCiudad
            // 
            this.txbCiudad.Location = new System.Drawing.Point(102, 197);
            this.txbCiudad.Name = "txbCiudad";
            this.txbCiudad.Size = new System.Drawing.Size(100, 20);
            this.txbCiudad.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 56;
            this.label8.Text = "Ciudad";
            // 
            // txbDireccion
            // 
            this.txbDireccion.Location = new System.Drawing.Point(102, 161);
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.Size = new System.Drawing.Size(100, 20);
            this.txbDireccion.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 54;
            this.label9.Text = "Dirección";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Telefono";
            // 
            // txbApellido
            // 
            this.txbApellido.Location = new System.Drawing.Point(102, 88);
            this.txbApellido.Name = "txbApellido";
            this.txbApellido.Size = new System.Drawing.Size(100, 20);
            this.txbApellido.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Apellido";
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(102, 51);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(100, 20);
            this.txbNombre.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Id Autor";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(56, 351);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 65;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmActualizaAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 386);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.mskTelefono);
            this.Controls.Add(this.mskId);
            this.Controls.Add(this.chkContrato);
            this.Controls.Add(this.txbCP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbEstado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbCiudad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbDireccion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbApellido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmActualizaAutor";
            this.Text = "frmActualizaAutor";
            this.Load += new System.EventHandler(this.frmActualizaAutor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskTelefono;
        private System.Windows.Forms.MaskedTextBox mskId;
        private System.Windows.Forms.CheckBox chkContrato;
        private System.Windows.Forms.TextBox txbCP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbEstado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbCiudad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbDireccion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbApellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardar;
    }
}