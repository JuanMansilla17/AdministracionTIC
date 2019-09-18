namespace AdministracionTIC
{
    partial class VistaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.recursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.préstamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recursosToolStripMenuItem,
            this.préstamosToolStripMenuItem,
            this.solicitantesToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // recursosToolStripMenuItem
            // 
            this.recursosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMToolStripMenuItem});
            this.recursosToolStripMenuItem.Name = "recursosToolStripMenuItem";
            this.recursosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.recursosToolStripMenuItem.Text = "Recursos";
            // 
            // aBMToolStripMenuItem
            // 
            this.aBMToolStripMenuItem.Name = "aBMToolStripMenuItem";
            this.aBMToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aBMToolStripMenuItem.Text = "ABM";
            this.aBMToolStripMenuItem.Click += new System.EventHandler(this.aBMToolStripMenuItem_Click);
            // 
            // préstamosToolStripMenuItem
            // 
            this.préstamosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem});
            this.préstamosToolStripMenuItem.Name = "préstamosToolStripMenuItem";
            this.préstamosToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.préstamosToolStripMenuItem.Text = "Préstamos";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // solicitantesToolStripMenuItem
            // 
            this.solicitantesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMToolStripMenuItem1});
            this.solicitantesToolStripMenuItem.Name = "solicitantesToolStripMenuItem";
            this.solicitantesToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.solicitantesToolStripMenuItem.Text = "Solicitantes";
            // 
            // aBMToolStripMenuItem1
            // 
            this.aBMToolStripMenuItem1.Name = "aBMToolStripMenuItem1";
            this.aBMToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.aBMToolStripMenuItem1.Text = "ABM";
            this.aBMToolStripMenuItem1.Click += new System.EventHandler(this.aBMToolStripMenuItem1_Click);
            // 
            // VistaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "VistaPrincipal";
            this.Text = "Administración TIC - UTN Facultad Regional San Francisco";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem recursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem préstamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMToolStripMenuItem1;
    }
}

