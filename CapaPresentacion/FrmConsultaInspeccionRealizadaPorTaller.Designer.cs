namespace CapaPresentacion
{
    partial class FrmConsultaInspeccionRealizadaPorTaller
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
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.CbTaller = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GbLista = new System.Windows.Forms.GroupBox();
            this.DgvHorario = new System.Windows.Forms.DataGridView();
            this.BnSalir = new System.Windows.Forms.Button();
            this.BnFiltrar = new System.Windows.Forms.Button();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.GbDatos.SuspendLayout();
            this.GbLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHorario)).BeginInit();
            this.SuspendLayout();
            // 
            // GbDatos
            // 
            this.GbDatos.Controls.Add(this.DtpFecha);
            this.GbDatos.Controls.Add(this.CbTaller);
            this.GbDatos.Controls.Add(this.label3);
            this.GbDatos.Controls.Add(this.label2);
            this.GbDatos.Location = new System.Drawing.Point(12, 47);
            this.GbDatos.Name = "GbDatos";
            this.GbDatos.Size = new System.Drawing.Size(730, 72);
            this.GbDatos.TabIndex = 0;
            this.GbDatos.TabStop = false;
            this.GbDatos.Text = "Datos de Búsqueda";
            // 
            // DtpFecha
            // 
            this.DtpFecha.CustomFormat = "dddd dd/MM/yyyy";
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFecha.Location = new System.Drawing.Point(482, 34);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(237, 28);
            this.DtpFecha.TabIndex = 7;
            // 
            // CbTaller
            // 
            this.CbTaller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTaller.FormattingEnabled = true;
            this.CbTaller.Location = new System.Drawing.Point(75, 33);
            this.CbTaller.Name = "CbTaller";
            this.CbTaller.Size = new System.Drawing.Size(306, 29);
            this.CbTaller.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fecha :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Taller :";
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
            this.label1.Text = "Consulta de Inspecciones Realizadas por Taller";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GbLista
            // 
            this.GbLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbLista.Controls.Add(this.DgvHorario);
            this.GbLista.Location = new System.Drawing.Point(12, 125);
            this.GbLista.Name = "GbLista";
            this.GbLista.Size = new System.Drawing.Size(958, 523);
            this.GbLista.TabIndex = 2;
            this.GbLista.TabStop = false;
            this.GbLista.Text = "Lista de Horarios";
            // 
            // DgvHorario
            // 
            this.DgvHorario.AllowUserToAddRows = false;
            this.DgvHorario.AllowUserToDeleteRows = false;
            this.DgvHorario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvHorario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column6,
            this.Column7,
            this.Column8});
            this.DgvHorario.Location = new System.Drawing.Point(12, 25);
            this.DgvHorario.Name = "DgvHorario";
            this.DgvHorario.ReadOnly = true;
            this.DgvHorario.RowHeadersWidth = 51;
            this.DgvHorario.RowTemplate.Height = 24;
            this.DgvHorario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvHorario.Size = new System.Drawing.Size(935, 484);
            this.DgvHorario.TabIndex = 0;
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
            this.BnFiltrar.Location = new System.Drawing.Point(748, 80);
            this.BnFiltrar.Name = "BnFiltrar";
            this.BnFiltrar.Size = new System.Drawing.Size(110, 35);
            this.BnFiltrar.TabIndex = 11;
            this.BnFiltrar.Text = "Filtrar";
            this.BnFiltrar.UseVisualStyleBackColor = true;
            this.BnFiltrar.Click += new System.EventHandler(this.BnFiltrar_Click);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Taller";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 230;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Fecha";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Hora";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Inspector Asignado";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 250;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Vehículo";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Cliente";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 300;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Estado";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 200;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "        ";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 75;
            // 
            // FrmConsultaInspeccionRealizadaPorTaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 703);
            this.Controls.Add(this.BnFiltrar);
            this.Controls.Add(this.BnSalir);
            this.Controls.Add(this.GbLista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GbDatos);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmConsultaInspeccionRealizadaPorTaller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Consulta de Inspecciones Realizadas por Taller";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.GbDatos.ResumeLayout(false);
            this.GbDatos.PerformLayout();
            this.GbLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvHorario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbTaller;
        private System.Windows.Forms.GroupBox GbLista;
        private System.Windows.Forms.Button BnSalir;
        private System.Windows.Forms.Button BnFiltrar;
        private System.Windows.Forms.DataGridView DgvHorario;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewButtonColumn Column8;
    }
}