namespace CapaPresentacion
{
    partial class FrmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbTipoDocumentoIdentidad = new System.Windows.Forms.ComboBox();
            this.TbNumeroDocumentoIdentidad = new System.Windows.Forms.TextBox();
            this.BnBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TbApellidosNombres = new System.Windows.Forms.TextBox();
            this.TbContrasena = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BnIngresar = new System.Windows.Forms.Button();
            this.BnSalir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo Doc. Identidad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nº Doc. Identidad :";
            // 
            // CmbTipoDocumentoIdentidad
            // 
            this.CmbTipoDocumentoIdentidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoDocumentoIdentidad.FormattingEnabled = true;
            this.CmbTipoDocumentoIdentidad.Location = new System.Drawing.Point(188, 50);
            this.CmbTipoDocumentoIdentidad.Name = "CmbTipoDocumentoIdentidad";
            this.CmbTipoDocumentoIdentidad.Size = new System.Drawing.Size(242, 29);
            this.CmbTipoDocumentoIdentidad.TabIndex = 2;
            this.CmbTipoDocumentoIdentidad.SelectedValueChanged += new System.EventHandler(this.CmbTipoDocumentoIdentidad_SelectedValueChanged);
            // 
            // TbNumeroDocumentoIdentidad
            // 
            this.TbNumeroDocumentoIdentidad.Location = new System.Drawing.Point(188, 96);
            this.TbNumeroDocumentoIdentidad.Name = "TbNumeroDocumentoIdentidad";
            this.TbNumeroDocumentoIdentidad.Size = new System.Drawing.Size(242, 28);
            this.TbNumeroDocumentoIdentidad.TabIndex = 3;
            this.TbNumeroDocumentoIdentidad.TextChanged += new System.EventHandler(this.TbNumeroDocumentoIdentidad_TextChanged);
            // 
            // BnBuscar
            // 
            this.BnBuscar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BnBuscar.Location = new System.Drawing.Point(436, 95);
            this.BnBuscar.Name = "BnBuscar";
            this.BnBuscar.Size = new System.Drawing.Size(122, 31);
            this.BnBuscar.TabIndex = 4;
            this.BnBuscar.Text = "Buscar";
            this.BnBuscar.UseVisualStyleBackColor = true;
            this.BnBuscar.Click += new System.EventHandler(this.BnBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellidos y Nombres :";
            // 
            // TbApellidosNombres
            // 
            this.TbApellidosNombres.Location = new System.Drawing.Point(188, 141);
            this.TbApellidosNombres.Name = "TbApellidosNombres";
            this.TbApellidosNombres.ReadOnly = true;
            this.TbApellidosNombres.Size = new System.Drawing.Size(370, 28);
            this.TbApellidosNombres.TabIndex = 6;
            // 
            // TbContrasena
            // 
            this.TbContrasena.Enabled = false;
            this.TbContrasena.Location = new System.Drawing.Point(188, 188);
            this.TbContrasena.Name = "TbContrasena";
            this.TbContrasena.PasswordChar = '*';
            this.TbContrasena.Size = new System.Drawing.Size(242, 28);
            this.TbContrasena.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Contraseña :";
            // 
            // BnIngresar
            // 
            this.BnIngresar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BnIngresar.Location = new System.Drawing.Point(188, 232);
            this.BnIngresar.Name = "BnIngresar";
            this.BnIngresar.Size = new System.Drawing.Size(118, 31);
            this.BnIngresar.TabIndex = 9;
            this.BnIngresar.Text = "Ingresar";
            this.BnIngresar.UseVisualStyleBackColor = true;
            this.BnIngresar.Click += new System.EventHandler(this.BnIngresar_Click);
            // 
            // BnSalir
            // 
            this.BnSalir.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BnSalir.Location = new System.Drawing.Point(312, 232);
            this.BnSalir.Name = "BnSalir";
            this.BnSalir.Size = new System.Drawing.Size(118, 31);
            this.BnSalir.TabIndex = 10;
            this.BnSalir.Text = "Salir";
            this.BnSalir.UseVisualStyleBackColor = true;
            this.BnSalir.Click += new System.EventHandler(this.BnSalir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(212, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Inicio de Sesión";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 279);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BnSalir);
            this.Controls.Add(this.BnIngresar);
            this.Controls.Add(this.TbContrasena);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbApellidosNombres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BnBuscar);
            this.Controls.Add(this.TbNumeroDocumentoIdentidad);
            this.Controls.Add(this.CmbTipoDocumentoIdentidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbTipoDocumentoIdentidad;
        private System.Windows.Forms.TextBox TbNumeroDocumentoIdentidad;
        private System.Windows.Forms.Button BnBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbApellidosNombres;
        private System.Windows.Forms.TextBox TbContrasena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BnIngresar;
        private System.Windows.Forms.Button BnSalir;
        private System.Windows.Forms.Label label5;
    }
}