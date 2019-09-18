namespace AdministracionTIC
{
    partial class VistaRecursos
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.aulaCheckBox = new System.Windows.Forms.CheckBox();
            this.modeloTextBox = new System.Windows.Forms.TextBox();
            this.marcaTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.agregarNuevoButton = new System.Windows.Forms.Button();
            this.eliminarButton = new System.Windows.Forms.Button();
            this.guardarCambiosButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.recursosDataGridView = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esAula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.editarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.recursosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(460, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RECURSOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Modelo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha de adquisición:";
            // 
            // aulaCheckBox
            // 
            this.aulaCheckBox.AutoSize = true;
            this.aulaCheckBox.Location = new System.Drawing.Point(13, 50);
            this.aulaCheckBox.Name = "aulaCheckBox";
            this.aulaCheckBox.Size = new System.Drawing.Size(125, 17);
            this.aulaCheckBox.TabIndex = 5;
            this.aulaCheckBox.Text = "El recurso es un aula";
            this.aulaCheckBox.UseVisualStyleBackColor = true;
            // 
            // modeloTextBox
            // 
            this.modeloTextBox.Location = new System.Drawing.Point(139, 223);
            this.modeloTextBox.Name = "modeloTextBox";
            this.modeloTextBox.Size = new System.Drawing.Size(245, 20);
            this.modeloTextBox.TabIndex = 7;
            // 
            // marcaTextBox
            // 
            this.marcaTextBox.Location = new System.Drawing.Point(139, 175);
            this.marcaTextBox.Name = "marcaTextBox";
            this.marcaTextBox.Size = new System.Drawing.Size(245, 20);
            this.marcaTextBox.TabIndex = 8;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.Location = new System.Drawing.Point(139, 125);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(245, 20);
            this.descripcionTextBox.TabIndex = 9;
            // 
            // agregarNuevoButton
            // 
            this.agregarNuevoButton.Location = new System.Drawing.Point(34, 339);
            this.agregarNuevoButton.Name = "agregarNuevoButton";
            this.agregarNuevoButton.Size = new System.Drawing.Size(75, 40);
            this.agregarNuevoButton.TabIndex = 10;
            this.agregarNuevoButton.Text = "AGREGAR NUEVO";
            this.agregarNuevoButton.UseVisualStyleBackColor = true;
            this.agregarNuevoButton.Click += new System.EventHandler(this.AgregarNuevoButton_Click);
            // 
            // eliminarButton
            // 
            this.eliminarButton.Location = new System.Drawing.Point(169, 339);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(75, 40);
            this.eliminarButton.TabIndex = 11;
            this.eliminarButton.Text = "ELIMINAR";
            this.eliminarButton.UseVisualStyleBackColor = true;
            this.eliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // guardarCambiosButton
            // 
            this.guardarCambiosButton.Location = new System.Drawing.Point(302, 339);
            this.guardarCambiosButton.Name = "guardarCambiosButton";
            this.guardarCambiosButton.Size = new System.Drawing.Size(75, 40);
            this.guardarCambiosButton.TabIndex = 12;
            this.guardarCambiosButton.Text = "GUARDAR CAMBIOS";
            this.guardarCambiosButton.UseVisualStyleBackColor = true;
            this.guardarCambiosButton.Click += new System.EventHandler(this.GuardarCambiosButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Location = new System.Drawing.Point(606, 339);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(75, 40);
            this.cancelarButton.TabIndex = 13;
            this.cancelarButton.Text = "CANCELAR";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(139, 271);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(217, 20);
            this.dateTimePicker.TabIndex = 14;
            // 
            // recursosDataGridView
            // 
            this.recursosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recursosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descripcion,
            this.fecha,
            this.estado,
            this.observaciones,
            this.marca,
            this.modelo,
            this.esAula});
            this.recursosDataGridView.Location = new System.Drawing.Point(411, 50);
            this.recursosDataGridView.Name = "recursosDataGridView";
            this.recursosDataGridView.Size = new System.Drawing.Size(809, 217);
            this.recursosDataGridView.TabIndex = 15;
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
            this.fecha.HeaderText = "Fecha Adquisición";
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
            // esAula
            // 
            this.esAula.HeaderText = "Tipo de recurso";
            this.esAula.Name = "esAula";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Código:";
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.Location = new System.Drawing.Point(139, 79);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(245, 20);
            this.codigoTextBox.TabIndex = 17;
            // 
            // editarButton
            // 
            this.editarButton.Location = new System.Drawing.Point(447, 339);
            this.editarButton.Name = "editarButton";
            this.editarButton.Size = new System.Drawing.Size(80, 40);
            this.editarButton.TabIndex = 18;
            this.editarButton.Text = "EDITAR RECURSO";
            this.editarButton.UseVisualStyleBackColor = true;
            this.editarButton.Click += new System.EventHandler(this.EditarButton_Click);
            // 
            // VistaRecursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 450);
            this.Controls.Add(this.editarButton);
            this.Controls.Add(this.codigoTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.recursosDataGridView);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.guardarCambiosButton);
            this.Controls.Add(this.eliminarButton);
            this.Controls.Add(this.agregarNuevoButton);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(this.marcaTextBox);
            this.Controls.Add(this.modeloTextBox);
            this.Controls.Add(this.aulaCheckBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VistaRecursos";
            this.Text = "Recursos";
            ((System.ComponentModel.ISupportInitialize)(this.recursosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox aulaCheckBox;
        private System.Windows.Forms.TextBox modeloTextBox;
        private System.Windows.Forms.TextBox marcaTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.Button agregarNuevoButton;
        private System.Windows.Forms.Button eliminarButton;
        private System.Windows.Forms.Button guardarCambiosButton;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.DataGridView recursosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn observaciones;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn esAula;
        private System.Windows.Forms.Button editarButton;
    }
}