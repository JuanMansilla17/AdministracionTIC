namespace AdministracionTIC
{
    partial class VistaSeleccionSolicitante
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
            this.solicitantesDataGridView = new System.Windows.Forms.DataGridView();
            this.seleccionarSolicitanteButton = new System.Windows.Forms.Button();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.universidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.solicitantesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // solicitantesDataGridView
            // 
            this.solicitantesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.solicitantesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombre,
            this.apellido,
            this.dni,
            this.cargo,
            this.telefono,
            this.mail,
            this.universidad,
            this.estado});
            this.solicitantesDataGridView.Location = new System.Drawing.Point(13, 13);
            this.solicitantesDataGridView.Name = "solicitantesDataGridView";
            this.solicitantesDataGridView.Size = new System.Drawing.Size(942, 197);
            this.solicitantesDataGridView.TabIndex = 0;
            // 
            // seleccionarSolicitanteButton
            // 
            this.seleccionarSolicitanteButton.Location = new System.Drawing.Point(404, 250);
            this.seleccionarSolicitanteButton.Name = "seleccionarSolicitanteButton";
            this.seleccionarSolicitanteButton.Size = new System.Drawing.Size(215, 52);
            this.seleccionarSolicitanteButton.TabIndex = 1;
            this.seleccionarSolicitanteButton.Text = "SELECCIONAR SOLICITANTE";
            this.seleccionarSolicitanteButton.UseVisualStyleBackColor = true;
            this.seleccionarSolicitanteButton.Click += new System.EventHandler(this.seleccionarSolicitanteButton_Click);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            // 
            // dni
            // 
            this.dni.HeaderText = "DNI";
            this.dni.Name = "dni";
            // 
            // cargo
            // 
            this.cargo.HeaderText = "Cargo";
            this.cargo.Name = "cargo";
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Teléfono";
            this.telefono.Name = "telefono";
            // 
            // mail
            // 
            this.mail.HeaderText = "Mail";
            this.mail.Name = "mail";
            // 
            // universidad
            // 
            this.universidad.HeaderText = "Universidad";
            this.universidad.Name = "universidad";
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            // 
            // VistaSeleccionSolicitante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 334);
            this.Controls.Add(this.seleccionarSolicitanteButton);
            this.Controls.Add(this.solicitantesDataGridView);
            this.Name = "VistaSeleccionSolicitante";
            this.Text = "VistaSeleccionSolicitante";
            ((System.ComponentModel.ISupportInitialize)(this.solicitantesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView solicitantesDataGridView;
        private System.Windows.Forms.Button seleccionarSolicitanteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn universidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}