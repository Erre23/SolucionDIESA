
namespace CapaPresentacion
{
    partial class FrmMetododePago
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
            this.GroupBox_MP = new System.Windows.Forms.GroupBox();
            this.cmb_EstadoM = new System.Windows.Forms.ComboBox();
            this.cmb_TipoP = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_TComision = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_TMoneda = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Rbtn_Debito = new System.Windows.Forms.RadioButton();
            this.Rbtn_Credito = new System.Windows.Forms.RadioButton();
            this.cmb_TipoTarjeta = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_NombreMP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_IdMPago = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Dgv_MetodoPago = new System.Windows.Forms.DataGridView();
            this.btn_NuevoMP = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Refrescar = new System.Windows.Forms.Button();
            this.btn_AgregarMP = new System.Windows.Forms.Button();
            this.btn_ModificarMP = new System.Windows.Forms.Button();
            this.btn_DeshabilitarMP = new System.Windows.Forms.Button();
            this.BTN_Salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupBox_MP.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_MetodoPago)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox_MP
            // 
            this.GroupBox_MP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_MP.Controls.Add(this.cmb_EstadoM);
            this.GroupBox_MP.Controls.Add(this.cmb_TipoP);
            this.GroupBox_MP.Controls.Add(this.label9);
            this.GroupBox_MP.Controls.Add(this.label8);
            this.GroupBox_MP.Controls.Add(this.txt_TComision);
            this.GroupBox_MP.Controls.Add(this.label7);
            this.GroupBox_MP.Controls.Add(this.cmb_TMoneda);
            this.GroupBox_MP.Controls.Add(this.label6);
            this.GroupBox_MP.Controls.Add(this.Rbtn_Debito);
            this.GroupBox_MP.Controls.Add(this.Rbtn_Credito);
            this.GroupBox_MP.Controls.Add(this.cmb_TipoTarjeta);
            this.GroupBox_MP.Controls.Add(this.label5);
            this.GroupBox_MP.Controls.Add(this.txt_Descripcion);
            this.GroupBox_MP.Controls.Add(this.label4);
            this.GroupBox_MP.Controls.Add(this.txt_NombreMP);
            this.GroupBox_MP.Controls.Add(this.label3);
            this.GroupBox_MP.Controls.Add(this.txt_IdMPago);
            this.GroupBox_MP.Controls.Add(this.label2);
            this.GroupBox_MP.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox_MP.Location = new System.Drawing.Point(110, 78);
            this.GroupBox_MP.Name = "GroupBox_MP";
            this.GroupBox_MP.Size = new System.Drawing.Size(898, 192);
            this.GroupBox_MP.TabIndex = 1;
            this.GroupBox_MP.TabStop = false;
            this.GroupBox_MP.Text = "Datos FormaPago";
            this.GroupBox_MP.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmb_EstadoM
            // 
            this.cmb_EstadoM.FormattingEnabled = true;
            this.cmb_EstadoM.Items.AddRange(new object[] {
            "Habilitado"});
            this.cmb_EstadoM.Location = new System.Drawing.Point(734, 36);
            this.cmb_EstadoM.Name = "cmb_EstadoM";
            this.cmb_EstadoM.Size = new System.Drawing.Size(126, 24);
            this.cmb_EstadoM.TabIndex = 18;
            // 
            // cmb_TipoP
            // 
            this.cmb_TipoP.FormattingEnabled = true;
            this.cmb_TipoP.Items.AddRange(new object[] {
            "Transferencia",
            "Tarjeta"});
            this.cmb_TipoP.Location = new System.Drawing.Point(154, 153);
            this.cmb_TipoP.Name = "cmb_TipoP";
            this.cmb_TipoP.Size = new System.Drawing.Size(203, 24);
            this.cmb_TipoP.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.label9.Location = new System.Drawing.Point(38, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Tipo de Pago:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(677, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Estado:";
            // 
            // txt_TComision
            // 
            this.txt_TComision.Location = new System.Drawing.Point(504, 155);
            this.txt_TComision.Name = "txt_TComision";
            this.txt_TComision.Size = new System.Drawing.Size(126, 23);
            this.txt_TComision.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.label7.Location = new System.Drawing.Point(375, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tasa de Comision:";
            // 
            // cmb_TMoneda
            // 
            this.cmb_TMoneda.FormattingEnabled = true;
            this.cmb_TMoneda.Items.AddRange(new object[] {
            "Dolar",
            "Soles"});
            this.cmb_TMoneda.Location = new System.Drawing.Point(504, 115);
            this.cmb_TMoneda.Name = "cmb_TMoneda";
            this.cmb_TMoneda.Size = new System.Drawing.Size(126, 24);
            this.cmb_TMoneda.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.label6.Location = new System.Drawing.Point(384, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tipo de Moneda:";
            // 
            // Rbtn_Debito
            // 
            this.Rbtn_Debito.AutoSize = true;
            this.Rbtn_Debito.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.Rbtn_Debito.Location = new System.Drawing.Point(549, 36);
            this.Rbtn_Debito.Name = "Rbtn_Debito";
            this.Rbtn_Debito.Size = new System.Drawing.Size(66, 21);
            this.Rbtn_Debito.TabIndex = 9;
            this.Rbtn_Debito.TabStop = true;
            this.Rbtn_Debito.Text = "Debito";
            this.Rbtn_Debito.UseVisualStyleBackColor = true;
            // 
            // Rbtn_Credito
            // 
            this.Rbtn_Credito.AutoSize = true;
            this.Rbtn_Credito.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.Rbtn_Credito.Location = new System.Drawing.Point(392, 36);
            this.Rbtn_Credito.Name = "Rbtn_Credito";
            this.Rbtn_Credito.Size = new System.Drawing.Size(70, 21);
            this.Rbtn_Credito.TabIndex = 8;
            this.Rbtn_Credito.TabStop = true;
            this.Rbtn_Credito.Text = "Credito";
            this.Rbtn_Credito.UseVisualStyleBackColor = true;
            // 
            // cmb_TipoTarjeta
            // 
            this.cmb_TipoTarjeta.FormattingEnabled = true;
            this.cmb_TipoTarjeta.Items.AddRange(new object[] {
            "Visa",
            "BCP"});
            this.cmb_TipoTarjeta.Location = new System.Drawing.Point(504, 76);
            this.cmb_TipoTarjeta.Name = "cmb_TipoTarjeta";
            this.cmb_TipoTarjeta.Size = new System.Drawing.Size(126, 24);
            this.cmb_TipoTarjeta.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.label5.Location = new System.Drawing.Point(384, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tipo de Tarjeta:";
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(154, 116);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(203, 23);
            this.txt_Descripcion.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.label4.Location = new System.Drawing.Point(57, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Descripcion:";
            // 
            // txt_NombreMP
            // 
            this.txt_NombreMP.Location = new System.Drawing.Point(154, 77);
            this.txt_NombreMP.Name = "txt_NombreMP";
            this.txt_NombreMP.Size = new System.Drawing.Size(203, 23);
            this.txt_NombreMP.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.label3.Location = new System.Drawing.Point(24, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre MetodoP:";
            // 
            // txt_IdMPago
            // 
            this.txt_IdMPago.Location = new System.Drawing.Point(154, 36);
            this.txt_IdMPago.Name = "txt_IdMPago";
            this.txt_IdMPago.Size = new System.Drawing.Size(203, 23);
            this.txt_IdMPago.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.label2.Location = new System.Drawing.Point(42, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Id.MetodoPago:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.Dgv_MetodoPago);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(110, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(898, 330);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ListaFormaPago";
            // 
            // Dgv_MetodoPago
            // 
            this.Dgv_MetodoPago.AllowUserToAddRows = false;
            this.Dgv_MetodoPago.AllowUserToDeleteRows = false;
            this.Dgv_MetodoPago.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_MetodoPago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_MetodoPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_MetodoPago.Location = new System.Drawing.Point(41, 33);
            this.Dgv_MetodoPago.Name = "Dgv_MetodoPago";
            this.Dgv_MetodoPago.ReadOnly = true;
            this.Dgv_MetodoPago.Size = new System.Drawing.Size(773, 267);
            this.Dgv_MetodoPago.TabIndex = 0;
            this.Dgv_MetodoPago.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_MetodoPago_CellDoubleClick);
            // 
            // btn_NuevoMP
            // 
            this.btn_NuevoMP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_NuevoMP.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NuevoMP.Location = new System.Drawing.Point(1037, 298);
            this.btn_NuevoMP.Name = "btn_NuevoMP";
            this.btn_NuevoMP.Size = new System.Drawing.Size(92, 44);
            this.btn_NuevoMP.TabIndex = 3;
            this.btn_NuevoMP.Text = "Nuevo";
            this.btn_NuevoMP.UseVisualStyleBackColor = true;
            this.btn_NuevoMP.Click += new System.EventHandler(this.btn_NuevoMP_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Editar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editar.Location = new System.Drawing.Point(1037, 103);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(92, 44);
            this.btn_Editar.TabIndex = 4;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Refrescar
            // 
            this.btn_Refrescar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Refrescar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refrescar.Location = new System.Drawing.Point(1037, 155);
            this.btn_Refrescar.Name = "btn_Refrescar";
            this.btn_Refrescar.Size = new System.Drawing.Size(92, 44);
            this.btn_Refrescar.TabIndex = 5;
            this.btn_Refrescar.Text = "Refrescar";
            this.btn_Refrescar.UseVisualStyleBackColor = true;
            this.btn_Refrescar.Click += new System.EventHandler(this.btn_Refrescar_Click);
            // 
            // btn_AgregarMP
            // 
            this.btn_AgregarMP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AgregarMP.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarMP.Location = new System.Drawing.Point(1037, 357);
            this.btn_AgregarMP.Name = "btn_AgregarMP";
            this.btn_AgregarMP.Size = new System.Drawing.Size(92, 44);
            this.btn_AgregarMP.TabIndex = 6;
            this.btn_AgregarMP.Text = "Agregar";
            this.btn_AgregarMP.UseVisualStyleBackColor = true;
            this.btn_AgregarMP.Click += new System.EventHandler(this.btn_AgregarMP_Click);
            // 
            // btn_ModificarMP
            // 
            this.btn_ModificarMP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ModificarMP.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ModificarMP.Location = new System.Drawing.Point(1037, 423);
            this.btn_ModificarMP.Name = "btn_ModificarMP";
            this.btn_ModificarMP.Size = new System.Drawing.Size(92, 44);
            this.btn_ModificarMP.TabIndex = 7;
            this.btn_ModificarMP.Text = "Modificar";
            this.btn_ModificarMP.UseVisualStyleBackColor = true;
            this.btn_ModificarMP.Click += new System.EventHandler(this.btn_ModificarMP_Click);
            // 
            // btn_DeshabilitarMP
            // 
            this.btn_DeshabilitarMP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DeshabilitarMP.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeshabilitarMP.Location = new System.Drawing.Point(1037, 486);
            this.btn_DeshabilitarMP.Name = "btn_DeshabilitarMP";
            this.btn_DeshabilitarMP.Size = new System.Drawing.Size(92, 44);
            this.btn_DeshabilitarMP.TabIndex = 8;
            this.btn_DeshabilitarMP.Text = "Deshabilitar";
            this.btn_DeshabilitarMP.UseVisualStyleBackColor = true;
            this.btn_DeshabilitarMP.Click += new System.EventHandler(this.btn_DeshabilitarMP_Click);
            // 
            // BTN_Salir
            // 
            this.BTN_Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Salir.Location = new System.Drawing.Point(1037, 547);
            this.BTN_Salir.Name = "BTN_Salir";
            this.BTN_Salir.Size = new System.Drawing.Size(92, 44);
            this.BTN_Salir.TabIndex = 9;
            this.BTN_Salir.Text = "Salir";
            this.BTN_Salir.UseVisualStyleBackColor = true;
            this.BTN_Salir.Click += new System.EventHandler(this.BTN_Salir_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1141, 35);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mantenedor MetodoPago";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMetododePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 629);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Salir);
            this.Controls.Add(this.btn_DeshabilitarMP);
            this.Controls.Add(this.btn_ModificarMP);
            this.Controls.Add(this.btn_AgregarMP);
            this.Controls.Add(this.btn_Refrescar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_NuevoMP);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GroupBox_MP);
            this.Name = "FrmMetododePago";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMetododePago_Load);
            this.GroupBox_MP.ResumeLayout(false);
            this.GroupBox_MP.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_MetodoPago)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GroupBox_MP;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_NombreMP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_IdMPago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView Dgv_MetodoPago;
        private System.Windows.Forms.Button btn_NuevoMP;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Refrescar;
        private System.Windows.Forms.Button btn_AgregarMP;
        private System.Windows.Forms.Button btn_ModificarMP;
        private System.Windows.Forms.Button btn_DeshabilitarMP;
        private System.Windows.Forms.Button BTN_Salir;
        private System.Windows.Forms.ComboBox cmb_TipoP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_TComision;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_TMoneda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton Rbtn_Debito;
        private System.Windows.Forms.RadioButton Rbtn_Credito;
        private System.Windows.Forms.ComboBox cmb_TipoTarjeta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_EstadoM;
        private System.Windows.Forms.Label label1;
    }
}