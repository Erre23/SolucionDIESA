﻿namespace CapaPresentacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GbCliente = new System.Windows.Forms.GroupBox();
            this.TbCliente = new System.Windows.Forms.TextBox();
            this.TbNumeroDocumentoIdentidad = new System.Windows.Forms.TextBox();
            this.CbTipoDocumentoIdentidad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GbLista = new System.Windows.Forms.GroupBox();
            this.DgvTarea = new System.Windows.Forms.DataGridView();
            this.BnGuardar = new System.Windows.Forms.Button();
            this.BnCancelar = new System.Windows.Forms.Button();
            this.BnNuevo = new System.Windows.Forms.Button();
            this.BnBuscar = new System.Windows.Forms.Button();
            this.BnSalir = new System.Windows.Forms.Button();
            this.BnAnular = new System.Windows.Forms.Button();
            this.GbProgramacion = new System.Windows.Forms.GroupBox();
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
            this.CbTipoComprobante = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CbFormaPago = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GbCliente.SuspendLayout();
            this.GbLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTarea)).BeginInit();
            this.GbProgramacion.SuspendLayout();
            this.GbPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbCliente
            // 
            this.GbCliente.Controls.Add(this.TbCliente);
            this.GbCliente.Controls.Add(this.TbNumeroDocumentoIdentidad);
            this.GbCliente.Controls.Add(this.CbTipoDocumentoIdentidad);
            this.GbCliente.Controls.Add(this.label4);
            this.GbCliente.Controls.Add(this.label3);
            this.GbCliente.Controls.Add(this.label2);
            this.GbCliente.Location = new System.Drawing.Point(12, 47);
            this.GbCliente.Name = "GbCliente";
            this.GbCliente.Size = new System.Drawing.Size(784, 110);
            this.GbCliente.TabIndex = 0;
            this.GbCliente.TabStop = false;
            this.GbCliente.Text = "Datos del Cliente";
            // 
            // TbCliente
            // 
            this.TbCliente.Location = new System.Drawing.Point(153, 69);
            this.TbCliente.Name = "TbCliente";
            this.TbCliente.ReadOnly = true;
            this.TbCliente.Size = new System.Drawing.Size(622, 28);
            this.TbCliente.TabIndex = 8;
            // 
            // TbNumeroDocumentoIdentidad
            // 
            this.TbNumeroDocumentoIdentidad.Location = new System.Drawing.Point(547, 33);
            this.TbNumeroDocumentoIdentidad.Name = "TbNumeroDocumentoIdentidad";
            this.TbNumeroDocumentoIdentidad.Size = new System.Drawing.Size(228, 28);
            this.TbNumeroDocumentoIdentidad.TabIndex = 7;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cliente :";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 21);
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
            this.label1.TabIndex = 1;
            this.label1.Text = "Programación de Inspección";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GbLista
            // 
            this.GbLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbLista.Controls.Add(this.DgvTarea);
            this.GbLista.Location = new System.Drawing.Point(12, 347);
            this.GbLista.Name = "GbLista";
            this.GbLista.Size = new System.Drawing.Size(958, 230);
            this.GbLista.TabIndex = 2;
            this.GbLista.TabStop = false;
            this.GbLista.Text = "Lista de Tareas";
            // 
            // DgvTarea
            // 
            this.DgvTarea.AllowUserToAddRows = false;
            this.DgvTarea.AllowUserToDeleteRows = false;
            this.DgvTarea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvTarea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTarea.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DgvTarea.Location = new System.Drawing.Point(12, 25);
            this.DgvTarea.Name = "DgvTarea";
            this.DgvTarea.ReadOnly = true;
            this.DgvTarea.RowHeadersWidth = 51;
            this.DgvTarea.RowTemplate.Height = 24;
            this.DgvTarea.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvTarea.Size = new System.Drawing.Size(935, 191);
            this.DgvTarea.TabIndex = 0;
            // 
            // BnGuardar
            // 
            this.BnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BnGuardar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BnGuardar.Location = new System.Drawing.Point(387, 656);
            this.BnGuardar.Name = "BnGuardar";
            this.BnGuardar.Size = new System.Drawing.Size(110, 35);
            this.BnGuardar.TabIndex = 4;
            this.BnGuardar.Text = "Guardar";
            this.BnGuardar.UseVisualStyleBackColor = true;
            this.BnGuardar.Click += new System.EventHandler(this.BnGuardar_Click);
            // 
            // BnCancelar
            // 
            this.BnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BnCancelar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BnCancelar.Location = new System.Drawing.Point(506, 656);
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
            // BnBuscar
            // 
            this.BnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BnBuscar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BnBuscar.Location = new System.Drawing.Point(271, 656);
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
            // BnAnular
            // 
            this.BnAnular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BnAnular.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BnAnular.Location = new System.Drawing.Point(128, 656);
            this.BnAnular.Name = "BnAnular";
            this.BnAnular.Size = new System.Drawing.Size(137, 35);
            this.BnAnular.TabIndex = 8;
            this.BnAnular.Text = "Anular";
            this.BnAnular.UseVisualStyleBackColor = true;
            this.BnAnular.Click += new System.EventHandler(this.BnAnular_Click);
            // 
            // GbProgramacion
            // 
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
            this.GbProgramacion.Location = new System.Drawing.Point(12, 163);
            this.GbProgramacion.Name = "GbProgramacion";
            this.GbProgramacion.Size = new System.Drawing.Size(784, 178);
            this.GbProgramacion.TabIndex = 11;
            this.GbProgramacion.TabStop = false;
            this.GbProgramacion.Text = "Datos de la Programación";
            // 
            // CbInspector
            // 
            this.CbInspector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbInspector.FormattingEnabled = true;
            this.CbInspector.Location = new System.Drawing.Point(153, 138);
            this.CbInspector.Name = "CbInspector";
            this.CbInspector.Size = new System.Drawing.Size(622, 29);
            this.CbInspector.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(56, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 21);
            this.label10.TabIndex = 14;
            this.label10.Text = "Inspector :";
            // 
            // DtpFecha
            // 
            this.DtpFecha.CustomFormat = "dddd dd/MM/yyyy";
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFecha.Location = new System.Drawing.Point(153, 104);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(228, 28);
            this.DtpFecha.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(82, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 21);
            this.label9.TabIndex = 12;
            this.label9.Text = "Fecha :";
            // 
            // CbHora
            // 
            this.CbHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbHora.FormattingEnabled = true;
            this.CbHora.Location = new System.Drawing.Point(640, 104);
            this.CbHora.Name = "CbHora";
            this.CbHora.Size = new System.Drawing.Size(135, 29);
            this.CbHora.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(578, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 21);
            this.label8.TabIndex = 10;
            this.label8.Text = "Hora :";
            // 
            // CbTaller
            // 
            this.CbTaller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTaller.FormattingEnabled = true;
            this.CbTaller.Location = new System.Drawing.Point(153, 68);
            this.CbTaller.Name = "CbTaller";
            this.CbTaller.Size = new System.Drawing.Size(622, 29);
            this.CbTaller.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Taller :";
            // 
            // TbVehiculo
            // 
            this.TbVehiculo.Location = new System.Drawing.Point(641, 33);
            this.TbVehiculo.Name = "TbVehiculo";
            this.TbVehiculo.Size = new System.Drawing.Size(135, 28);
            this.TbVehiculo.TabIndex = 7;
            // 
            // CbTipoInspeccion
            // 
            this.CbTipoInspeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTipoInspeccion.FormattingEnabled = true;
            this.CbTipoInspeccion.Location = new System.Drawing.Point(153, 33);
            this.CbTipoInspeccion.Name = "CbTipoInspeccion";
            this.CbTipoInspeccion.Size = new System.Drawing.Size(228, 29);
            this.CbTipoInspeccion.TabIndex = 6;
            this.CbTipoInspeccion.SelectedIndexChanged += new System.EventHandler(this.CbTipoInspeccion_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(552, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Vehiculo :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tipo de Insp :";
            // 
            // TbTotal
            // 
            this.TbTotal.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbTotal.Location = new System.Drawing.Point(812, 22);
            this.TbTotal.Name = "TbTotal";
            this.TbTotal.ReadOnly = true;
            this.TbTotal.Size = new System.Drawing.Size(135, 35);
            this.TbTotal.TabIndex = 13;
            this.TbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(652, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 28);
            this.label11.TabIndex = 12;
            this.label11.Text = "Total a Pagar:";
            // 
            // GbPago
            // 
            this.GbPago.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbPago.Controls.Add(this.CbTipoComprobante);
            this.GbPago.Controls.Add(this.TbTotal);
            this.GbPago.Controls.Add(this.label11);
            this.GbPago.Controls.Add(this.label12);
            this.GbPago.Controls.Add(this.CbFormaPago);
            this.GbPago.Controls.Add(this.label14);
            this.GbPago.Location = new System.Drawing.Point(12, 582);
            this.GbPago.Name = "GbPago";
            this.GbPago.Size = new System.Drawing.Size(958, 68);
            this.GbPago.TabIndex = 14;
            this.GbPago.TabStop = false;
            this.GbPago.Text = "Datos del Pago";
            // 
            // CbTipoComprobante
            // 
            this.CbTipoComprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTipoComprobante.FormattingEnabled = true;
            this.CbTipoComprobante.Location = new System.Drawing.Point(464, 26);
            this.CbTipoComprobante.Name = "CbTipoComprobante";
            this.CbTipoComprobante.Size = new System.Drawing.Size(171, 29);
            this.CbTipoComprobante.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(332, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 21);
            this.label12.TabIndex = 7;
            this.label12.Text = "Tipo de Comp. :";
            // 
            // CbFormaPago
            // 
            this.CbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbFormaPago.FormattingEnabled = true;
            this.CbFormaPago.Location = new System.Drawing.Point(143, 26);
            this.CbFormaPago.Name = "CbFormaPago";
            this.CbFormaPago.Size = new System.Drawing.Size(166, 29);
            this.CbFormaPago.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 21);
            this.label14.TabIndex = 0;
            this.label14.Text = "Forma de Pago :";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tarea";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 170;
            // 
            // Column2
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "Precio";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // FrmProgramacionInspeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 703);
            this.Controls.Add(this.GbPago);
            this.Controls.Add(this.GbProgramacion);
            this.Controls.Add(this.BnSalir);
            this.Controls.Add(this.BnBuscar);
            this.Controls.Add(this.BnAnular);
            this.Controls.Add(this.BnNuevo);
            this.Controls.Add(this.BnCancelar);
            this.Controls.Add(this.BnGuardar);
            this.Controls.Add(this.GbLista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GbCliente);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmProgramacionInspeccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Programación de Inspección";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.GbCliente.ResumeLayout(false);
            this.GbCliente.PerformLayout();
            this.GbLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTarea)).EndInit();
            this.GbProgramacion.ResumeLayout(false);
            this.GbProgramacion.PerformLayout();
            this.GbPago.ResumeLayout(false);
            this.GbPago.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbCliente;
        private System.Windows.Forms.TextBox TbNumeroDocumentoIdentidad;
        private System.Windows.Forms.ComboBox CbTipoDocumentoIdentidad;
        private System.Windows.Forms.GroupBox GbLista;
        private System.Windows.Forms.Button BnGuardar;
        private System.Windows.Forms.Button BnCancelar;
        private System.Windows.Forms.Button BnNuevo;
        private System.Windows.Forms.Button BnBuscar;
        private System.Windows.Forms.Button BnSalir;
        private System.Windows.Forms.DataGridView DgvTarea;
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
        private System.Windows.Forms.ComboBox CbFormaPago;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox CbTipoComprobante;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}