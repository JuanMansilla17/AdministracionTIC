namespace AdministracionTIC
{
    partial class VistaPrestamosPendientes
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
            this.prestamosPendientesDataGridView = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solicitante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaHorarioEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaHorarioEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaHorarioDevolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concretarPrestamoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosPendientesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // prestamosPendientesDataGridView
            // 
            this.prestamosPendientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prestamosPendientesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.recurso,
            this.solicitante,
            this.fechaHorarioEmision,
            this.fechaHorarioEntrega,
            this.fechaHorarioDevolucion,
            this.estado,
            this.observaciones});
            this.prestamosPendientesDataGridView.Location = new System.Drawing.Point(13, 13);
            this.prestamosPendientesDataGridView.Name = "prestamosPendientesDataGridView";
            this.prestamosPendientesDataGridView.Size = new System.Drawing.Size(843, 172);
            this.prestamosPendientesDataGridView.TabIndex = 0;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            // 
            // recurso
            // 
            this.recurso.HeaderText = "Recurso";
            this.recurso.Name = "recurso";
            // 
            // solicitante
            // 
            this.solicitante.HeaderText = "Solicitante";
            this.solicitante.Name = "solicitante";
            // 
            // fechaHorarioEmision
            // 
            this.fechaHorarioEmision.HeaderText = "Fecha y Horario de Emisión";
            this.fechaHorarioEmision.Name = "fechaHorarioEmision";
            // 
            // fechaHorarioEntrega
            // 
            this.fechaHorarioEntrega.HeaderText = "Fecha y Horario de Entrega";
            this.fechaHorarioEntrega.Name = "fechaHorarioEntrega";
            // 
            // fechaHorarioDevolucion
            // 
            this.fechaHorarioDevolucion.HeaderText = "Fecha y Horario de Devolución";
            this.fechaHorarioDevolucion.Name = "fechaHorarioDevolucion";
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            // 
            // observaciones
            // 
            this.observaciones.HeaderText = "Observaciones";
            this.observaciones.Name = "observaciones";
            // 
            // concretarPrestamoButton
            // 
            this.concretarPrestamoButton.Location = new System.Drawing.Point(351, 235);
            this.concretarPrestamoButton.Name = "concretarPrestamoButton";
            this.concretarPrestamoButton.Size = new System.Drawing.Size(178, 44);
            this.concretarPrestamoButton.TabIndex = 1;
            this.concretarPrestamoButton.Text = "CONCRETAR PRÉSTAMO";
            this.concretarPrestamoButton.UseVisualStyleBackColor = true;
            this.concretarPrestamoButton.Click += new System.EventHandler(this.concretarPrestamoButton_Click);
            // 
            // PrestamosPendientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 315);
            this.Controls.Add(this.concretarPrestamoButton);
            this.Controls.Add(this.prestamosPendientesDataGridView);
            this.Name = "PrestamosPendientes";
            this.Text = "PrestamosPendientes";
            ((System.ComponentModel.ISupportInitialize)(this.prestamosPendientesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView prestamosPendientesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn recurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn solicitante;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaHorarioEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaHorarioEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaHorarioDevolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn observaciones;
        private System.Windows.Forms.Button concretarPrestamoButton;
    }
}