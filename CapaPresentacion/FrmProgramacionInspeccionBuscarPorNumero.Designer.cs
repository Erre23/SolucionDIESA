namespace CapaPresentacion
{
    partial class FrmProgramacionInspeccionBuscarPorNumero
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
            this.TbNumeroProgramacion = new CapaPresentacion.Controls.CustomTextBox();
            this.LbNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BnBuscar = new System.Windows.Forms.Button();
            this.BnCancelar = new System.Windows.Forms.Button();
            this.GbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbDatos
            // 
            this.GbDatos.Controls.Add(this.TbNumeroProgramacion);
            this.GbDatos.Controls.Add(this.LbNombre);
            this.GbDatos.Location = new System.Drawing.Point(12, 47);
            this.GbDatos.Name = "GbDatos";
            this.GbDatos.Size = new System.Drawing.Size(536, 65);
            this.GbDatos.TabIndex = 1;
            this.GbDatos.TabStop = false;
            this.GbDatos.Text = "Datos de Búsqueda";
            // 
            // TbNumeroProgramacion
            // 
            this.TbNumeroProgramacion.Location = new System.Drawing.Point(139, 27);
            this.TbNumeroProgramacion.MaxLength = 10;
            this.TbNumeroProgramacion.Name = "TbNumeroProgramacion";
            this.TbNumeroProgramacion.Size = new System.Drawing.Size(391, 24);
            this.TbNumeroProgramacion.TabIndex = 1;
            this.TbNumeroProgramacion.TipoCaracteres = CapaPresentacion.Controls.CustomTextBox.TipoInput.SoloNumeros;
            // 
            // LbNombre
            // 
            this.LbNombre.AutoSize = true;
            this.LbNombre.Location = new System.Drawing.Point(11, 30);
            this.LbNombre.Name = "LbNombre";
            this.LbNombre.Size = new System.Drawing.Size(122, 17);
            this.LbNombre.TabIndex = 0;
            this.LbNombre.Text = "Nº Programación :";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(562, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Programación Inspección - Buscar Por Número";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BnBuscar
            // 
            this.BnBuscar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BnBuscar.Location = new System.Drawing.Point(321, 119);
            this.BnBuscar.Name = "BnBuscar";
            this.BnBuscar.Size = new System.Drawing.Size(110, 35);
            this.BnBuscar.TabIndex = 2;
            this.BnBuscar.Text = "Buscar";
            this.BnBuscar.UseVisualStyleBackColor = true;
            this.BnBuscar.Click += new System.EventHandler(this.BnBuscar_Click);
            // 
            // BnCancelar
            // 
            this.BnCancelar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BnCancelar.Location = new System.Drawing.Point(440, 119);
            this.BnCancelar.Name = "BnCancelar";
            this.BnCancelar.Size = new System.Drawing.Size(110, 35);
            this.BnCancelar.TabIndex = 3;
            this.BnCancelar.Text = "Cancelar";
            this.BnCancelar.UseVisualStyleBackColor = true;
            this.BnCancelar.Click += new System.EventHandler(this.BnCancelar_Click);
            // 
            // FrmProgramacionInspeccionBuscarPorNumero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 166);
            this.Controls.Add(this.BnCancelar);
            this.Controls.Add(this.BnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GbDatos);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProgramacionInspeccionBuscarPorNumero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Programación Inspección - Buscar Por Número";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.GbDatos.ResumeLayout(false);
            this.GbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbNombre;
        private Controls.CustomTextBox TbNumeroProgramacion;
        private System.Windows.Forms.Button BnBuscar;
        private System.Windows.Forms.Button BnCancelar;
    }
}