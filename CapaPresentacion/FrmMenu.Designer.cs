namespace CapaPresentacion
{
    partial class FrmMenu
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuMantenedor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaller = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTipoDocumentoIdentidad = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeInspeccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inspectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProgramarInspeccion = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConsultaHorarioDIsponible = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConsultaProgramacionInspeccion = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConsultaInspeccion = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.metodoPagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMantenedor,
            this.editMenu,
            this.viewMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // mnuMantenedor
            // 
            this.mnuMantenedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTaller,
            this.mnuTipoDocumentoIdentidad,
            this.mnuCliente,
            this.tipoDeInspeccionToolStripMenuItem,
            this.inspectorToolStripMenuItem,
            this.metodoPagoToolStripMenuItem,
            this.toolStripSeparator5,
            this.mnuExit});
            this.mnuMantenedor.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.mnuMantenedor.Name = "mnuMantenedor";
            this.mnuMantenedor.Size = new System.Drawing.Size(95, 20);
            this.mnuMantenedor.Text = "Mantenedores";
            // 
            // mnuTaller
            // 
            this.mnuTaller.Name = "mnuTaller";
            this.mnuTaller.Size = new System.Drawing.Size(248, 22);
            this.mnuTaller.Text = "Taller";
            this.mnuTaller.Click += new System.EventHandler(this.mnuTaller_Click);
            // 
            // mnuTipoDocumentoIdentidad
            // 
            this.mnuTipoDocumentoIdentidad.Name = "mnuTipoDocumentoIdentidad";
            this.mnuTipoDocumentoIdentidad.Size = new System.Drawing.Size(248, 22);
            this.mnuTipoDocumentoIdentidad.Text = "Tipo de Documento de Identidad";
            this.mnuTipoDocumentoIdentidad.Click += new System.EventHandler(this.mnuTipoDocumentoIdentidad_Click);
            // 
            // mnuCliente
            // 
            this.mnuCliente.Name = "mnuCliente";
            this.mnuCliente.Size = new System.Drawing.Size(248, 22);
            this.mnuCliente.Text = "Cliente";
            this.mnuCliente.Click += new System.EventHandler(this.mnuCliente_Click);
            // 
            // tipoDeInspeccionToolStripMenuItem
            // 
            this.tipoDeInspeccionToolStripMenuItem.Name = "tipoDeInspeccionToolStripMenuItem";
            this.tipoDeInspeccionToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.tipoDeInspeccionToolStripMenuItem.Text = "Tipo de Inspeccion";
            this.tipoDeInspeccionToolStripMenuItem.Click += new System.EventHandler(this.tipoDeInspeccionToolStripMenuItem_Click);
            // 
            // inspectorToolStripMenuItem
            // 
            this.inspectorToolStripMenuItem.Name = "inspectorToolStripMenuItem";
            this.inspectorToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.inspectorToolStripMenuItem.Text = "Inspector";
            this.inspectorToolStripMenuItem.Click += new System.EventHandler(this.inspectorToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(245, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(248, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProgramarInspeccion});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(89, 20);
            this.editMenu.Text = "Movimientos";
            // 
            // mnuProgramarInspeccion
            // 
            this.mnuProgramarInspeccion.Name = "mnuProgramarInspeccion";
            this.mnuProgramarInspeccion.Size = new System.Drawing.Size(190, 22);
            this.mnuProgramarInspeccion.Text = "Programar Inspección";
            this.mnuProgramarInspeccion.Click += new System.EventHandler(this.mnuProgramarInspeccion_Click);
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuConsultaHorarioDIsponible,
            this.mnuConsultaProgramacionInspeccion,
            this.mnuConsultaInspeccion});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(71, 20);
            this.viewMenu.Text = "Consultas";
            // 
            // mnuConsultaHorarioDIsponible
            // 
            this.mnuConsultaHorarioDIsponible.Name = "mnuConsultaHorarioDIsponible";
            this.mnuConsultaHorarioDIsponible.Size = new System.Drawing.Size(331, 22);
            this.mnuConsultaHorarioDIsponible.Text = "Consulta de horarios disponibles por taller";
            this.mnuConsultaHorarioDIsponible.Click += new System.EventHandler(this.mnuConsultaHorarioDisponible_Click);
            // 
            // mnuConsultaProgramacionInspeccion
            // 
            this.mnuConsultaProgramacionInspeccion.Name = "mnuConsultaProgramacionInspeccion";
            this.mnuConsultaProgramacionInspeccion.Size = new System.Drawing.Size(331, 22);
            this.mnuConsultaProgramacionInspeccion.Text = "Consulta de inspecciones programadas por taller";
            this.mnuConsultaProgramacionInspeccion.Click += new System.EventHandler(this.mnuConsultaProgramacionInspeccion_Click);
            // 
            // mnuConsultaInspeccion
            // 
            this.mnuConsultaInspeccion.Name = "mnuConsultaInspeccion";
            this.mnuConsultaInspeccion.Size = new System.Drawing.Size(331, 22);
            this.mnuConsultaInspeccion.Text = "Consulta de inspecciones realizadas por taller";
            this.mnuConsultaInspeccion.Click += new System.EventHandler(this.mnuConsultaInspeccion_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // metodoPagoToolStripMenuItem
            // 
            this.metodoPagoToolStripMenuItem.Name = "metodoPagoToolStripMenuItem";
            this.metodoPagoToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.metodoPagoToolStripMenuItem.Text = "Método de Pago";
            this.metodoPagoToolStripMenuItem.Click += new System.EventHandler(this.metodoPagoToolStripMenuItem_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Solución DIESA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem mnuCliente;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem mnuMantenedor;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuProgramarInspeccion;
        private System.Windows.Forms.ToolStripMenuItem mnuConsultaHorarioDIsponible;
        private System.Windows.Forms.ToolStripMenuItem mnuConsultaProgramacionInspeccion;
        private System.Windows.Forms.ToolStripMenuItem mnuConsultaInspeccion;
        private System.Windows.Forms.ToolStripMenuItem mnuTipoDocumentoIdentidad;
        private System.Windows.Forms.ToolStripMenuItem mnuTaller;
        private System.Windows.Forms.ToolStripMenuItem inspectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeInspeccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metodoPagoToolStripMenuItem;
    }
}



