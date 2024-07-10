namespace CapaPresentacion
{
    partial class FrmMetodoPago
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
            this.TbNombre = new System.Windows.Forms.TextBox();
            this.LbNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GbLista = new System.Windows.Forms.GroupBox();
            this.DgvMetodoPago = new System.Windows.Forms.DataGridView();
            this.LbOpcion = new System.Windows.Forms.Label();
            this.BnGuardar = new System.Windows.Forms.Button();
            this.BnCancelar = new System.Windows.Forms.Button();
            this.BnNuevo = new System.Windows.Forms.Button();
            this.BnEditar = new System.Windows.Forms.Button();
            this.BnDeshabilitar = new System.Windows.Forms.Button();
            this.BnSalir = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GbDatos.SuspendLayout();
            this.GbLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMetodoPago)).BeginInit();
            this.SuspendLayout();
            // 
            // GbDatos
            // 
            this.GbDatos.Controls.Add(this.TbNombre);
            this.GbDatos.Controls.Add(this.LbNombre);
            this.GbDatos.Location = new System.Drawing.Point(12, 47);
            this.GbDatos.Name = "GbDatos";
            this.GbDatos.Size = new System.Drawing.Size(536, 65);
            this.GbDatos.TabIndex = 1;
            this.GbDatos.TabStop = false;
            this.GbDatos.Text = "Datos del Tipo de Inspección";
            // 
            // TbNombre
            // 
            this.TbNombre.Location = new System.Drawing.Point(81, 27);
            this.TbNombre.MaxLength = 50;
            this.TbNombre.Name = "TbNombre";
            this.TbNombre.Size = new System.Drawing.Size(449, 24);
            this.TbNombre.TabIndex = 7;
            // 
            // LbNombre
            // 
            this.LbNombre.AutoSize = true;
            this.LbNombre.Location = new System.Drawing.Point(11, 30);
            this.LbNombre.Name = "LbNombre";
            this.LbNombre.Size = new System.Drawing.Size(66, 17);
            this.LbNombre.TabIndex = 6;
            this.LbNombre.Text = "Nombre :";
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
            this.label1.Text = "Mantenedor - Tipo de Inspección";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GbLista
            // 
            this.GbLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbLista.Controls.Add(this.DgvMetodoPago);
            this.GbLista.Location = new System.Drawing.Point(12, 160);
            this.GbLista.Name = "GbLista";
            this.GbLista.Size = new System.Drawing.Size(958, 488);
            this.GbLista.TabIndex = 6;
            this.GbLista.TabStop = false;
            this.GbLista.Text = "Lista de Tipos de Inspección";
            // 
            // DgvMetodoPago
            // 
            this.DgvMetodoPago.AllowUserToAddRows = false;
            this.DgvMetodoPago.AllowUserToDeleteRows = false;
            this.DgvMetodoPago.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvMetodoPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMetodoPago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column6});
            this.DgvMetodoPago.Location = new System.Drawing.Point(12, 25);
            this.DgvMetodoPago.MultiSelect = false;
            this.DgvMetodoPago.Name = "DgvMetodoPago";
            this.DgvMetodoPago.ReadOnly = true;
            this.DgvMetodoPago.RowHeadersWidth = 51;
            this.DgvMetodoPago.RowTemplate.Height = 24;
            this.DgvMetodoPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvMetodoPago.Size = new System.Drawing.Size(935, 449);
            this.DgvMetodoPago.TabIndex = 0;
            // 
            // LbOpcion
            // 
            this.LbOpcion.BackColor = System.Drawing.SystemColors.Highlight;
            this.LbOpcion.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbOpcion.ForeColor = System.Drawing.Color.White;
            this.LbOpcion.Location = new System.Drawing.Point(12, 121);
            this.LbOpcion.Name = "LbOpcion";
            this.LbOpcion.Size = new System.Drawing.Size(246, 30);
            this.LbOpcion.TabIndex = 2;
            this.LbOpcion.Text = "OPCIÓN : NUEVO / EDITAR / BUSCAR";
            this.LbOpcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BnGuardar
            // 
            this.BnGuardar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BnGuardar.Location = new System.Drawing.Point(321, 119);
            this.BnGuardar.Name = "BnGuardar";
            this.BnGuardar.Size = new System.Drawing.Size(110, 35);
            this.BnGuardar.TabIndex = 3;
            this.BnGuardar.Text = "Guardar";
            this.BnGuardar.UseVisualStyleBackColor = true;
            this.BnGuardar.Click += new System.EventHandler(this.BnGuardar_Click);
            // 
            // BnCancelar
            // 
            this.BnCancelar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BnCancelar.Location = new System.Drawing.Point(440, 119);
            this.BnCancelar.Name = "BnCancelar";
            this.BnCancelar.Size = new System.Drawing.Size(110, 35);
            this.BnCancelar.TabIndex = 4;
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
            this.BnNuevo.TabIndex = 7;
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
            this.BnEditar.TabIndex = 8;
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
            this.BnDeshabilitar.TabIndex = 9;
            this.BnDeshabilitar.Text = "Deshabilitar";
            this.BnDeshabilitar.UseVisualStyleBackColor = true;
            this.BnDeshabilitar.Click += new System.EventHandler(this.BnDeshabilitar_Click);
            // 
            // BnSalir
            // 
            this.BnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BnSalir.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BnSalir.Location = new System.Drawing.Point(860, 656);
            this.BnSalir.Name = "BnSalir";
            this.BnSalir.Size = new System.Drawing.Size(110, 35);
            this.BnSalir.TabIndex = 11;
            this.BnSalir.Text = "Salir";
            this.BnSalir.UseVisualStyleBackColor = true;
            this.BnSalir.Click += new System.EventHandler(this.BnSalir_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 170;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Activo";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column6.Width = 125;
            // 
            // FrmMetodoPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 703);
            this.Controls.Add(this.BnSalir);
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
            this.Name = "FrmMetodoPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Mantenedor - Tipo de Inspección";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMetodoPago_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMetodoPago_FormClosed);
            this.Load += new System.EventHandler(this.FrmMetodoPago_Load);
            this.GbDatos.ResumeLayout(false);
            this.GbDatos.PerformLayout();
            this.GbLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMetodoPago)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbNombre;
        private System.Windows.Forms.TextBox TbNombre;
        private System.Windows.Forms.GroupBox GbLista;
        private System.Windows.Forms.Label LbOpcion;
        private System.Windows.Forms.Button BnGuardar;
        private System.Windows.Forms.Button BnCancelar;
        private System.Windows.Forms.Button BnNuevo;
        private System.Windows.Forms.Button BnEditar;
        private System.Windows.Forms.Button BnDeshabilitar;
        private System.Windows.Forms.Button BnSalir;
        private System.Windows.Forms.DataGridView DgvMetodoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}