namespace AdministracionTIC
{
    partial class VistaRecursoSeleccionado
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
            this.recursosDisponiblesDataGridView = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoRecurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seleccionarRecursoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.recursosDisponiblesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // recursosDisponiblesDataGridView
            // 
            this.recursosDisponiblesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recursosDisponiblesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descripcion,
            this.fecha,
            this.estado,
            this.observaciones,
            this.marca,
            this.modelo,
            this.tipoRecurso});
            this.recursosDisponiblesDataGridView.Location = new System.Drawing.Point(12, 37);
            this.recursosDisponiblesDataGridView.Name = "recursosDisponiblesDataGridView";
            this.recursosDisponiblesDataGridView.Size = new System.Drawing.Size(844, 200);
            this.recursosDisponiblesDataGridView.TabIndex = 0;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha de Adquisición";
            this.fecha.Name = "fecha";
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
            // marca
            // 
            this.marca.HeaderText = "Marca";
            this.marca.Name = "marca";
            // 
            // modelo
            // 
            this.modelo.HeaderText = "Modelo";
            this.modelo.Name = "modelo";
            // 
            // tipoRecurso
            // 
            this.tipoRecurso.HeaderText = "Tipo de recurso";
            this.tipoRecurso.Name = "tipoRecurso";
            // 
            // seleccionarRecursoButton
            // 
            this.seleccionarRecursoButton.Location = new System.Drawing.Point(361, 293);
            this.seleccionarRecursoButton.Name = "seleccionarRecursoButton";
            this.seleccionarRecursoButton.Size = new System.Drawing.Size(201, 47);
            this.seleccionarRecursoButton.TabIndex = 1;
            this.seleccionarRecursoButton.Text = "SELECCIONAR RECURSO";
            this.seleccionarRecursoButton.UseVisualStyleBackColor = true;
            this.seleccionarRecursoButton.Click += new System.EventHandler(this.seleccionarRecursoButton_Click);
            // 
            // VistaRecursoSeleccionado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 369);
            this.Controls.Add(this.seleccionarRecursoButton);
            this.Controls.Add(this.recursosDisponiblesDataGridView);
            this.Name = "VistaRecursoSeleccionado";
            this.Text = "VistaRecursoSeleccionado";
            ((System.ComponentModel.ISupportInitialize)(this.recursosDisponiblesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView recursosDisponiblesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoRecurso;
        private System.Windows.Forms.Button seleccionarRecursoButton;
    }
}