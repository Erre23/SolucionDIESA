namespace CapaPresentacion
{
    partial class FrmCliente
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
            this.GbDatos = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CbTipoDocumentoIdentidad = new System.Windows.Forms.ComboBox();
            this.TbNumeroDocumentoIdentidad = new System.Windows.Forms.TextBox();
            this.TbNombres = new System.Windows.Forms.TextBox();
            this.TbApellido1 = new System.Windows.Forms.TextBox();
            this.TbApellido2 = new System.Windows.Forms.TextBox();
            this.TbRazonSocial = new System.Windows.Forms.TextBox();
            this.TbEmail = new System.Windows.Forms.TextBox();
            this.TbTelefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.GbLista = new System.Windows.Forms.GroupBox();
            this.LbOpcion = new System.Windows.Forms.Label();
            this.BnGuardar = new System.Windows.Forms.Button();
            this.BnCancelar = new System.Windows.Forms.Button();
            this.BnNuevo = new System.Windows.Forms.Button();
            this.BnEditar = new System.Windows.Forms.Button();
            this.BnDeshabilitar = new System.Windows.Forms.Button();
            this.BnBuscar = new System.Windows.Forms.Button();
            this.BnSalir = new System.Windows.Forms.Button();
            this.BnFiltrar = new System.Windows.Forms.Button();
            this.DgvCliente = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GbDatos.SuspendLayout();
            this.GbLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // GbDatos
            // 
            this.GbDatos.Controls.Add(this.TbEmail);
            this.GbDatos.Controls.Add(this.TbTelefono);
            this.GbDatos.Controls.Add(this.label8);
            this.GbDatos.Controls.Add(this.label9);
            this.GbDatos.Controls.Add(this.TbRazonSocial);
            this.GbDatos.Controls.Add(this.TbApellido2);
            this.GbDatos.Controls.Add(this.TbApellido1);
            this.GbDatos.Controls.Add(this.TbNombres);
            this.GbDatos.Controls.Add(this.TbNumeroDocumentoIdentidad);
            this.GbDatos.Controls.Add(this.CbTipoDocumentoIdentidad);
            this.GbDatos.Controls.Add(this.label7);
            this.GbDatos.Controls.Add(this.label6);
            this.GbDatos.Controls.Add(this.label5);
            this.GbDatos.Controls.Add(this.label4);
            this.GbDatos.Controls.Add(this.label3);
            this.GbDatos.Controls.Add(this.label2);
            this.GbDatos.Location = new System.Drawing.Point(12, 47);
            this.GbDatos.Name = "GbDatos";
            this.GbDatos.Size = new System.Drawing.Size(782, 218);
            this.GbDatos.TabIndex = 0;
            this.GbDatos.TabStop = false;
            this.GbDatos.Text = "Datos del Cliente";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(982, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mantenedor - Cliente";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tipo Doc. Ident. :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nº Documento :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nombres :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Apellido 1 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(447, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Apellido 2 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Razón Social :";
            // 
            // CbTipoDocumentoIdentidad
            // 
            this.CbTipoDocumentoIdentidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTipoDocumentoIdentidad.FormattingEnabled = true;
            this.CbTipoDocumentoIdentidad.Location = new System.Drawing.Point(153, 33);
            this.CbTipoDocumentoIdentidad.Name = "CbTipoDocumentoIdentidad";
            this.CbTipoDocumentoIdentidad.Size = new System.Drawing.Size(228, 29);
            this.CbTipoDocumentoIdentidad.TabIndex = 6;
            // 
            // TbNumeroDocumentoIdentidad
            // 
            this.TbNumeroDocumentoIdentidad.Location = new System.Drawing.Point(547, 33);
            this.TbNumeroDocumentoIdentidad.Name = "TbNumeroDocumentoIdentidad";
            this.TbNumeroDocumentoIdentidad.Size = new System.Drawing.Size(228, 28);
            this.TbNumeroDocumentoIdentidad.TabIndex = 7;
            // 
            // TbNombres
            // 
            this.TbNombres.Location = new System.Drawing.Point(153, 69);
            this.TbNombres.Name = "TbNombres";
            this.TbNombres.Size = new System.Drawing.Size(622, 28);
            this.TbNombres.TabIndex = 8;
            // 
            // TbApellido1
            // 
            this.TbApellido1.Location = new System.Drawing.Point(153, 105);
            this.TbApellido1.Name = "TbApellido1";
            this.TbApellido1.Size = new System.Drawing.Size(228, 28);
            this.TbApellido1.TabIndex = 9;
            // 
            // TbApellido2
            // 
            this.TbApellido2.Location = new System.Drawing.Point(547, 105);
            this.TbApellido2.Name = "TbApellido2";
            this.TbApellido2.Size = new System.Drawing.Size(228, 28);
            this.TbApellido2.TabIndex = 10;
            // 
            // TbRazonSocial
            // 
            this.TbRazonSocial.Location = new System.Drawing.Point(153, 142);
            this.TbRazonSocial.Name = "TbRazonSocial";
            this.TbRazonSocial.Size = new System.Drawing.Size(622, 28);
            this.TbRazonSocial.TabIndex = 11;
            // 
            // TbEmail
            // 
            this.TbEmail.Location = new System.Drawing.Point(547, 180);
            this.TbEmail.Name = "TbEmail";
            this.TbEmail.Size = new System.Drawing.Size(228, 28);
            this.TbEmail.TabIndex = 15;
            // 
            // TbTelefono
            // 
            this.TbTelefono.Location = new System.Drawing.Point(153, 180);
            this.TbTelefono.Name = "TbTelefono";
            this.TbTelefono.Size = new System.Drawing.Size(228, 28);
            this.TbTelefono.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(479, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "Email :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(62, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 21);
            this.label9.TabIndex = 12;
            this.label9.Text = "Teléfono :";
            // 
            // GbLista
            // 
            this.GbLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbLista.Controls.Add(this.DgvCliente);
            this.GbLista.Location = new System.Drawing.Point(12, 312);
            this.GbLista.Name = "GbLista";
            this.GbLista.Size = new System.Drawing.Size(958, 336);
            this.GbLista.TabIndex = 2;
            this.GbLista.TabStop = false;
            this.GbLista.Text = "Lista de Clientes";
            // 
            // LbOpcion
            // 
            this.LbOpcion.BackColor = System.Drawing.SystemColors.Highlight;
            this.LbOpcion.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbOpcion.ForeColor = System.Drawing.Color.White;
            this.LbOpcion.Location = new System.Drawing.Point(12, 271);
            this.LbOpcion.Name = "LbOpcion";
            this.LbOpcion.Size = new System.Drawing.Size(381, 30);
            this.LbOpcion.TabIndex = 3;
            this.LbOpcion.Text = "OPCIÓN : NUEVO / EDITAR / BUSCAR";
            this.LbOpcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BnGuardar
            // 
            this.BnGuardar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BnGuardar.Location = new System.Drawing.Point(558, 269);
            this.BnGuardar.Name = "BnGuardar";
            this.BnGuardar.Size = new System.Drawing.Size(110, 35);
            this.BnGuardar.TabIndex = 4;
            this.BnGuardar.Text = "Guardar";
            this.BnGuardar.UseVisualStyleBackColor = true;
            this.BnGuardar.Click += new System.EventHandler(this.BnGuardar_Click);
            // 
            // BnCancelar
            // 
            this.BnCancelar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BnCancelar.Location = new System.Drawing.Point(677, 269);
            this.BnCancelar.Name = "BnCancelar";
            this.BnCancelar.Size = new System.Drawing.Size(110, 35);
            this.BnCancelar.TabIndex = 5;
            this.BnCancelar.Text = "Cancelar";
            this.BnCancelar.UseVisualStyleBackColor = true;
            this.BnCancelar.Click += new System.EventHandler(this.BnCancelar_Click);
            // 
            // BnNuevo
            // 
            this.BnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BnNuevo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BnNuevo.Location = new System.Drawing.Point(12, 656);
            this.BnNuevo.Name = "BnNuevo";
            this.BnNuevo.Size = new System.Drawing.Size(110, 35);
            this.BnNuevo.TabIndex = 6;
            this.BnNuevo.Text = "Nuevo";
            this.BnNuevo.UseVisualStyleBackColor = true;
            this.BnNuevo.Click += new System.EventHandler(this.BnNuevo_Click);
            // 
            // BnEditar
            // 
            this.BnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BnEditar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BnEditar.Location = new System.Drawing.Point(128, 656);
            this.BnEditar.Name = "BnEditar";
            this.BnEditar.Size = new System.Drawing.Size(110, 35);
            this.BnEditar.TabIndex = 7;
            this.BnEditar.Text = "Editar";
            this.BnEditar.UseVisualStyleBackColor = true;
            this.BnEditar.Click += new System.EventHandler(this.BnEditar_Click);
            // 
            // BnDeshabilitar
            // 
            this.BnDeshabilitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BnDeshabilitar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BnDeshabilitar.Location = new System.Drawing.Point(244, 656);
            this.BnDeshabilitar.Name = "BnDeshabilitar";
            this.BnDeshabilitar.Size = new System.Drawing.Size(137, 35);
            this.BnDeshabilitar.TabIndex = 8;
            this.BnDeshabilitar.Text = "Deshabilitar";
            this.BnDeshabilitar.UseVisualStyleBackColor = true;
            this.BnDeshabilitar.Click += new System.EventHandler(this.BnDeshabilitar_Click);
            // 
            // BnBuscar
            // 
            this.BnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BnBuscar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BnBuscar.Location = new System.Drawing.Point(387, 656);
            this.BnBuscar.Name = "BnBuscar";
            this.BnBuscar.Size = new System.Drawing.Size(110, 35);
            this.BnBuscar.TabIndex = 9;
            this.BnBuscar.Text = "Buscar";
            this.BnBuscar.UseVisualStyleBackColor = true;
            this.BnBuscar.Click += new System.EventHandler(this.BnBuscar_Click);
            // 
            // BnSalir
            // 
            this.BnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BnSalir.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BnSalir.Location = new System.Drawing.Point(860, 656);
            this.BnSalir.Name = "BnSalir";
            this.BnSalir.Size = new System.Drawing.Size(110, 35);
            this.BnSalir.TabIndex = 10;
            this.BnSalir.Text = "Salir";
            this.BnSalir.UseVisualStyleBackColor = true;
            this.BnSalir.Click += new System.EventHandler(this.BnSalir_Click);
            // 
            // BnFiltrar
            // 
            this.BnFiltrar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BnFiltrar.Location = new System.Drawing.Point(793, 269);
            this.BnFiltrar.Name = "BnFiltrar";
            this.BnFiltrar.Size = new System.Drawing.Size(110, 35);
            this.BnFiltrar.TabIndex = 11;
            this.BnFiltrar.Text = "Filtrar";
            this.BnFiltrar.UseVisualStyleBackColor = true;
            this.BnFiltrar.Click += new System.EventHandler(this.BnFiltrar_Click);
            // 
            // DgvCliente
            // 
            this.DgvCliente.AllowUserToAddRows = false;
            this.DgvCliente.AllowUserToDeleteRows = false;
            this.DgvCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.DgvCliente.Location = new System.Drawing.Point(12, 25);
            this.DgvCliente.Name = "DgvCliente";
            this.DgvCliente.ReadOnly = true;
            this.DgvCliente.RowHeadersWidth = 51;
            this.DgvCliente.RowTemplate.Height = 24;
            this.DgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCliente.Size = new System.Drawing.Size(935, 297);
            this.DgvCliente.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tipo Doc. Ident.";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 170;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nº Documento";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nombre Completo";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 300;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Teléfono";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Email";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 200;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 703);
            this.Controls.Add(this.BnFiltrar);
            this.Controls.Add(this.BnSalir);
            this.Controls.Add(this.BnBuscar);
            this.Controls.Add(this.BnDeshabilitar);
            this.Controls.Add(this.BnEditar);
            this.Controls.Add(this.BnNuevo);
            this.Controls.Add(this.BnCancelar);
            this.Controls.Add(this.BnGuardar);
            this.Controls.Add(this.LbOpcion);
            this.Controls.Add(this.GbLista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GbDatos);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Mantenedor - Cliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.GbDatos.ResumeLayout(false);
            this.GbDatos.PerformLayout();
            this.GbLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbApellido2;
        private System.Windows.Forms.TextBox TbApellido1;
        private System.Windows.Forms.TextBox TbNombres;
        private System.Windows.Forms.TextBox TbNumeroDocumentoIdentidad;
        private System.Windows.Forms.ComboBox CbTipoDocumentoIdentidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbRazonSocial;
        private System.Windows.Forms.TextBox TbEmail;
        private System.Windows.Forms.TextBox TbTelefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox GbLista;
        private System.Windows.Forms.Label LbOpcion;
        private System.Windows.Forms.Button BnGuardar;
        private System.Windows.Forms.Button BnCancelar;
        private System.Windows.Forms.Button BnNuevo;
        private System.Windows.Forms.Button BnEditar;
        private System.Windows.Forms.Button BnDeshabilitar;
        private System.Windows.Forms.Button BnBuscar;
        private System.Windows.Forms.Button BnSalir;
        private System.Windows.Forms.Button BnFiltrar;
        private System.Windows.Forms.DataGridView DgvCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}