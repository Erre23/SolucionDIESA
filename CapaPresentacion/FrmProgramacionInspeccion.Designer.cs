namespace CapaPresentacion
{
    partial class FrmProgramacionInspeccion
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
            this.GbCliente = new System.Windows.Forms.GroupBox();
            this.BnBuscarCliente = new System.Windows.Forms.Button();
            this.TbCliente = new System.Windows.Forms.TextBox();
            this.CmbTipoDocumentoIdentidad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BnGuardar = new System.Windows.Forms.Button();
            this.BnCancelar = new System.Windows.Forms.Button();
            this.BnNuevo = new System.Windows.Forms.Button();
            this.BnBuscar = new System.Windows.Forms.Button();
            this.BnSalir = new System.Windows.Forms.Button();
            this.BnAnular = new System.Windows.Forms.Button();
            this.GbProgramacion = new System.Windows.Forms.GroupBox();
            this.BnBuscarDisponibilidad = new System.Windows.Forms.Button();
            this.CbInspector = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.CbHora = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CbTaller = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TbVehiculo = new System.Windows.Forms.TextBox();
            this.CbTipoInspeccion = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TbTotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.GbPago = new System.Windows.Forms.GroupBox();
            this.CbMetodoPago = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.TbAnulado = new CapaPresentacion.Controls.CustomTextBox();
            this.TbRegistroFechaHora = new CapaPresentacion.Controls.CustomTextBox();
            this.TbNumeroProgramacion = new CapaPresentacion.Controls.CustomTextBox();
            this.TbNumeroDocumentoIdentidad = new CapaPresentacion.Controls.CustomTextBox();
            this.GbCliente.SuspendLayout();
            this.GbProgramacion.SuspendLayout();
            this.GbPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbCliente
            // 
            this.GbCliente.Controls.Add(this.BnBuscarCliente);
            this.GbCliente.Controls.Add(this.TbCliente);
            this.GbCliente.Controls.Add(this.TbNumeroDocumentoIdentidad);
            this.GbCliente.Controls.Add(this.CmbTipoDocumentoIdentidad);
            this.GbCliente.Controls.Add(this.label4);
            this.GbCliente.Controls.Add(this.label3);
            this.GbCliente.Controls.Add(this.label2);
            this.GbCliente.Location = new System.Drawing.Point(12, 73);
            this.GbCliente.Name = "GbCliente";
            this.GbCliente.Size = new System.Drawing.Size(958, 110);
            this.GbCliente.TabIndex = 7;
            this.GbCliente.TabStop = false;
            this.GbCliente.Text = "Datos del Cliente";
            // 
            // BnBuscarCliente
            // 
            this.BnBuscarCliente.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BnBuscarCliente.Location = new System.Drawing.Point(781, 30);
            this.BnBuscarCliente.Name = "BnBuscarCliente";
            this.BnBuscarCliente.Size = new System.Drawing.Size(166, 30);
            this.BnBuscarCliente.TabIndex = 4;
            this.BnBuscarCliente.Text = "Buscar Cliente";
            this.BnBuscarCliente.UseVisualStyleBackColor = true;
            this.BnBuscarCliente.Click += new System.EventHandler(this.BnBuscarCliente_Click);
            // 
            // TbCliente
            // 
            this.TbCliente.Location = new System.Drawing.Point(139, 69);
            this.TbCliente.Name = "TbCliente";
            this.TbCliente.ReadOnly = true;
            this.TbCliente.Size = new System.Drawing.Size(636, 24);
            this.TbCliente.TabIndex = 6;
            // 
            // CmbTipoDocumentoIdentidad
            // 
            this.CmbTipoDocumentoIdentidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoDocumentoIdentidad.FormattingEnabled = true;
            this.CmbTipoDocumentoIdentidad.Location = new System.Drawing.Point(139, 33);
            this.CmbTipoDocumentoIdentidad.Name = "CmbTipoDocumentoIdentidad";
            this.CmbTipoDocumentoIdentidad.Size = new System.Drawing.Size(228, 25);
            this.CmbTipoDocumentoIdentidad.TabIndex = 1;
            this.CmbTipoDocumentoIdentidad.SelectedIndexChanged += new System.EventHandler(this.CmbTipoDocumentoIdentidad_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cliente :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(431, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nº Documento :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tipo Doc. Ident. :";
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
            this.label1.TabIndex = 0;
            this.label1.Text = "Programación de Inspección";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BnGuardar
            // 
            this.BnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BnGuardar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BnGuardar.Location = new System.Drawing.Point(387, 452);
            this.BnGuardar.Name = "BnGuardar";
            this.BnGuardar.Size = new System.Drawing.Size(110, 35);
            this.BnGuardar.TabIndex = 12;
            this.BnGuardar.Text = "Guardar";
            this.BnGuardar.UseVisualStyleBackColor = true;
            this.BnGuardar.Click += new System.EventHandler(this.BnGuardar_Click);
            // 
            // BnCancelar
            // 
            this.BnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BnCancelar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BnCancelar.Location = new System.Drawing.Point(506, 452);
            this.BnCancelar.Name = "BnCancelar";
            this.BnCancelar.Size = new System.Drawing.Size(110, 35);
            this.BnCancelar.TabIndex = 13;
            this.BnCancelar.Text = "Cancelar";
            this.BnCancelar.UseVisualStyleBackColor = true;
            this.BnCancelar.Click += new System.EventHandler(this.BnCancelar_Click);
            // 
            // BnNuevo
            // 
            this.BnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BnNuevo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BnNuevo.Location = new System.Drawing.Point(12, 452);
            this.BnNuevo.Name = "BnNuevo";
            this.BnNuevo.Size = new System.Drawing.Size(110, 35);
            this.BnNuevo.TabIndex = 9;
            this.BnNuevo.Text = "Nuevo";
            this.BnNuevo.UseVisualStyleBackColor = true;
            this.BnNuevo.Click += new System.EventHandler(this.BnNuevo_Click);
            // 
            // BnBuscar
            // 
            this.BnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BnBuscar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BnBuscar.Location = new System.Drawing.Point(271, 452);
            this.BnBuscar.Name = "BnBuscar";
            this.BnBuscar.Size = new System.Drawing.Size(110, 35);
            this.BnBuscar.TabIndex = 11;
            this.BnBuscar.Text = "Buscar";
            this.BnBuscar.UseVisualStyleBackColor = true;
            this.BnBuscar.Click += new System.EventHandler(this.BnBuscar_Click);
            // 
            // BnSalir
            // 
            this.BnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BnSalir.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BnSalir.Location = new System.Drawing.Point(860, 452);
            this.BnSalir.Name = "BnSalir";
            this.BnSalir.Size = new System.Drawing.Size(110, 35);
            this.BnSalir.TabIndex = 14;
            this.BnSalir.Text = "Salir";
            this.BnSalir.UseVisualStyleBackColor = true;
            this.BnSalir.Click += new System.EventHandler(this.BnSalir_Click);
            // 
            // BnAnular
            // 
            this.BnAnular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BnAnular.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BnAnular.Location = new System.Drawing.Point(128, 452);
            this.BnAnular.Name = "BnAnular";
            this.BnAnular.Size = new System.Drawing.Size(137, 35);
            this.BnAnular.TabIndex = 10;
            this.BnAnular.Text = "Anular";
            this.BnAnular.UseVisualStyleBackColor = true;
            this.BnAnular.Click += new System.EventHandler(this.BnAnular_Click);
            // 
            // GbProgramacion
            // 
            this.GbProgramacion.Controls.Add(this.BnBuscarDisponibilidad);
            this.GbProgramacion.Controls.Add(this.CbInspector);
            this.GbProgramacion.Controls.Add(this.label10);
            this.GbProgramacion.Controls.Add(this.DtpFecha);
            this.GbProgramacion.Controls.Add(this.label9);
            this.GbProgramacion.Controls.Add(this.CbHora);
            this.GbProgramacion.Controls.Add(this.label8);
            this.GbProgramacion.Controls.Add(this.CbTaller);
            this.GbProgramacion.Controls.Add(this.label5);
            this.GbProgramacion.Controls.Add(this.TbVehiculo);
            this.GbProgramacion.Controls.Add(this.CbTipoInspeccion);
            this.GbProgramacion.Controls.Add(this.label6);
            this.GbProgramacion.Controls.Add(this.label7);
            this.GbProgramacion.Location = new System.Drawing.Point(12, 191);
            this.GbProgramacion.Name = "GbProgramacion";
            this.GbProgramacion.Size = new System.Drawing.Size(958, 178);
            this.GbProgramacion.TabIndex = 7;
            this.GbProgramacion.TabStop = false;
            this.GbProgramacion.Text = "Detalle de la Programación";
            // 
            // BnBuscarDisponibilidad
            // 
            this.BnBuscarDisponibilidad.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BnBuscarDisponibilidad.Location = new System.Drawing.Point(781, 68);
            this.BnBuscarDisponibilidad.Name = "BnBuscarDisponibilidad";
            this.BnBuscarDisponibilidad.Size = new System.Drawing.Size(166, 64);
            this.BnBuscarDisponibilidad.TabIndex = 6;
            this.BnBuscarDisponibilidad.Text = "Buscar Disponibilidad";
            this.BnBuscarDisponibilidad.UseVisualStyleBackColor = true;
            this.BnBuscarDisponibilidad.Click += new System.EventHandler(this.BnBuscarDisponibilidad_Click);
            // 
            // CbInspector
            // 
            this.CbInspector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbInspector.FormattingEnabled = true;
            this.CbInspector.Location = new System.Drawing.Point(139, 138);
            this.CbInspector.Name = "CbInspector";
            this.CbInspector.Size = new System.Drawing.Size(636, 25);
            this.CbInspector.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(60, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Inspector :";
            // 
            // DtpFecha
            // 
            this.DtpFecha.CustomFormat = "dddd dd/MM/yyyy";
            this.DtpFecha.Enabled = false;
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFecha.Location = new System.Drawing.Point(139, 104);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(228, 24);
            this.DtpFecha.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(82, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Fecha :";
            // 
            // CbHora
            // 
            this.CbHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbHora.FormattingEnabled = true;
            this.CbHora.Location = new System.Drawing.Point(547, 104);
            this.CbHora.Name = "CbHora";
            this.CbHora.Size = new System.Drawing.Size(228, 25);
            this.CbHora.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(495, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Hora :";
            // 
            // CbTaller
            // 
            this.CbTaller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTaller.FormattingEnabled = true;
            this.CbTaller.Location = new System.Drawing.Point(139, 68);
            this.CbTaller.Name = "CbTaller";
            this.CbTaller.Size = new System.Drawing.Size(636, 25);
            this.CbTaller.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Taller :";
            // 
            // TbVehiculo
            // 
            this.TbVehiculo.Location = new System.Drawing.Point(547, 33);
            this.TbVehiculo.Name = "TbVehiculo";
            this.TbVehiculo.Size = new System.Drawing.Size(228, 24);
            this.TbVehiculo.TabIndex = 3;
            // 
            // CbTipoInspeccion
            // 
            this.CbTipoInspeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTipoInspeccion.FormattingEnabled = true;
            this.CbTipoInspeccion.Location = new System.Drawing.Point(139, 33);
            this.CbTipoInspeccion.Name = "CbTipoInspeccion";
            this.CbTipoInspeccion.Size = new System.Drawing.Size(228, 25);
            this.CbTipoInspeccion.TabIndex = 1;
            this.CbTipoInspeccion.SelectedIndexChanged += new System.EventHandler(this.CbTipoInspeccion_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(474, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Vehiculo :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tipo de Inspección :";
            // 
            // TbTotal
            // 
            this.TbTotal.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbTotal.Location = new System.Drawing.Point(547, 22);
            this.TbTotal.Name = "TbTotal";
            this.TbTotal.ReadOnly = true;
            this.TbTotal.Size = new System.Drawing.Size(228, 30);
            this.TbTotal.TabIndex = 3;
            this.TbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(414, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 23);
            this.label11.TabIndex = 2;
            this.label11.Text = "Total a Pagar:";
            // 
            // GbPago
            // 
            this.GbPago.Controls.Add(this.TbTotal);
            this.GbPago.Controls.Add(this.label11);
            this.GbPago.Controls.Add(this.CbMetodoPago);
            this.GbPago.Controls.Add(this.label14);
            this.GbPago.Location = new System.Drawing.Point(12, 375);
            this.GbPago.Name = "GbPago";
            this.GbPago.Size = new System.Drawing.Size(786, 68);
            this.GbPago.TabIndex = 8;
            this.GbPago.TabStop = false;
            this.GbPago.Text = "Datos del Pago";
            // 
            // CbMetodoPago
            // 
            this.CbMetodoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbMetodoPago.FormattingEnabled = true;
            this.CbMetodoPago.Location = new System.Drawing.Point(139, 26);
            this.CbMetodoPago.Name = "CbMetodoPago";
            this.CbMetodoPago.Size = new System.Drawing.Size(228, 25);
            this.CbMetodoPago.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Método de Pago :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "Nº Programación :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(486, 44);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 17);
            this.label15.TabIndex = 3;
            this.label15.Text = "Registro :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(809, 44);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 17);
            this.label16.TabIndex = 5;
            this.label16.Text = "Anulado :";
            // 
            // TbAnulado
            // 
            this.TbAnulado.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbAnulado.ForeColor = System.Drawing.Color.Red;
            this.TbAnulado.Location = new System.Drawing.Point(882, 41);
            this.TbAnulado.Name = "TbAnulado";
            this.TbAnulado.ReadOnly = true;
            this.TbAnulado.Size = new System.Drawing.Size(77, 26);
            this.TbAnulado.TabIndex = 6;
            this.TbAnulado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TbAnulado.TipoCaracteres = CapaPresentacion.Controls.CustomTextBox.TipoInput.Todo;
            // 
            // TbRegistroFechaHora
            // 
            this.TbRegistroFechaHora.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbRegistroFechaHora.Location = new System.Drawing.Point(559, 41);
            this.TbRegistroFechaHora.Name = "TbRegistroFechaHora";
            this.TbRegistroFechaHora.ReadOnly = true;
            this.TbRegistroFechaHora.Size = new System.Drawing.Size(228, 26);
            this.TbRegistroFechaHora.TabIndex = 4;
            this.TbRegistroFechaHora.TipoCaracteres = CapaPresentacion.Controls.CustomTextBox.TipoInput.Todo;
            // 
            // TbNumeroProgramacion
            // 
            this.TbNumeroProgramacion.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbNumeroProgramacion.Location = new System.Drawing.Point(151, 41);
            this.TbNumeroProgramacion.Name = "TbNumeroProgramacion";
            this.TbNumeroProgramacion.ReadOnly = true;
            this.TbNumeroProgramacion.Size = new System.Drawing.Size(217, 26);
            this.TbNumeroProgramacion.TabIndex = 2;
            this.TbNumeroProgramacion.TipoCaracteres = CapaPresentacion.Controls.CustomTextBox.TipoInput.Todo;
            // 
            // TbNumeroDocumentoIdentidad
            // 
            this.TbNumeroDocumentoIdentidad.Location = new System.Drawing.Point(547, 33);
            this.TbNumeroDocumentoIdentidad.Name = "TbNumeroDocumentoIdentidad";
            this.TbNumeroDocumentoIdentidad.Size = new System.Drawing.Size(228, 24);
            this.TbNumeroDocumentoIdentidad.TabIndex = 3;
            this.TbNumeroDocumentoIdentidad.TipoCaracteres = CapaPresentacion.Controls.CustomTextBox.TipoInput.Todo;
            this.TbNumeroDocumentoIdentidad.TextChanged += new System.EventHandler(this.TbNumeroDocumentoIdentidad_TextChanged);
            // 
            // FrmProgramacionInspeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 499);
            this.Controls.Add(this.TbAnulado);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.TbRegistroFechaHora);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TbNumeroProgramacion);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.GbPago);
            this.Controls.Add(this.GbProgramacion);
            this.Controls.Add(this.BnSalir);
            this.Controls.Add(this.BnBuscar);
            this.Controls.Add(this.BnAnular);
            this.Controls.Add(this.BnNuevo);
            this.Controls.Add(this.BnCancelar);
            this.Controls.Add(this.BnGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GbCliente);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmProgramacionInspeccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Programación de Inspección";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmProgramacionInspeccion_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmProgramacionInspeccion_FormClosed);
            this.Load += new System.EventHandler(this.FrmProgramacionInspeccion_Load);
            this.GbCliente.ResumeLayout(false);
            this.GbCliente.PerformLayout();
            this.GbProgramacion.ResumeLayout(false);
            this.GbProgramacion.PerformLayout();
            this.GbPago.ResumeLayout(false);
            this.GbPago.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GbCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbCliente;
        private CapaPresentacion.Controls.CustomTextBox TbNumeroDocumentoIdentidad;
        private System.Windows.Forms.ComboBox CmbTipoDocumentoIdentidad;
        private System.Windows.Forms.Button BnGuardar;
        private System.Windows.Forms.Button BnCancelar;
        private System.Windows.Forms.Button BnNuevo;
        private System.Windows.Forms.Button BnBuscar;
        private System.Windows.Forms.Button BnSalir;
        private System.Windows.Forms.Button BnAnular;
        private System.Windows.Forms.GroupBox GbProgramacion;
        private System.Windows.Forms.TextBox TbVehiculo;
        private System.Windows.Forms.ComboBox CbTipoInspeccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CbHora;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CbTaller;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CbInspector;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TbTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox GbPago;
        private System.Windows.Forms.ComboBox CbMetodoPago;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button BnBuscarCliente;
        private System.Windows.Forms.Button BnBuscarDisponibilidad;
        private Controls.CustomTextBox TbNumeroProgramacion;
        private System.Windows.Forms.Label label13;
        private Controls.CustomTextBox TbRegistroFechaHora;
        private System.Windows.Forms.Label label15;
        private Controls.CustomTextBox TbAnulado;
        private System.Windows.Forms.Label label16;
    }
}