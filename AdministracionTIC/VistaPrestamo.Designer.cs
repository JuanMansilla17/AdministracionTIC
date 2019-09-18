namespace AdministracionTIC
{
    partial class VistaPrestamo
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
            this.label6 = new System.Windows.Forms.Label();
            this.prestamoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.horaEntregaTextBox = new System.Windows.Forms.TextBox();
            this.minutoEntregaTextBox = new System.Windows.Forms.TextBox();
            this.horaDevolucionTextBox = new System.Windows.Forms.TextBox();
            this.minutoDevolucionTextBox = new System.Windows.Forms.TextBox();
            this.observacionTextBox = new System.Windows.Forms.TextBox();
            this.guardarPrestamoButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.prestamoInmediatoCheckBox = new System.Windows.Forms.CheckBox();
            this.prestamoDataGridView = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solicitante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaHoraEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaHoraEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaHoraDevolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recursoTextBox = new System.Windows.Forms.TextBox();
            this.buscarRecursoButton = new System.Windows.Forms.Button();
            this.solicitanteTextBox = new System.Windows.Forms.TextBox();
            this.buscarSolicitanteButton = new System.Windows.Forms.Button();
            this.verPrestamosPendientesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Recurso:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha préstamo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hora entrega:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hora devolución:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Observaciones:";
            // 
            // prestamoDateTimePicker
            // 
            this.prestamoDateTimePicker.Location = new System.Drawing.Point(148, 99);
            this.prestamoDateTimePicker.Name = "prestamoDateTimePicker";
            this.prestamoDateTimePicker.Size = new System.Drawing.Size(212, 20);
            this.prestamoDateTimePicker.TabIndex = 7;
            // 
            // horaEntregaTextBox
            // 
            this.horaEntregaTextBox.Location = new System.Drawing.Point(148, 141);
            this.horaEntregaTextBox.Name = "horaEntregaTextBox";
            this.horaEntregaTextBox.Size = new System.Drawing.Size(53, 20);
            this.horaEntregaTextBox.TabIndex = 8;
            // 
            // minutoEntregaTextBox
            // 
            this.minutoEntregaTextBox.Location = new System.Drawing.Point(223, 141);
            this.minutoEntregaTextBox.Name = "minutoEntregaTextBox";
            this.minutoEntregaTextBox.Size = new System.Drawing.Size(54, 20);
            this.minutoEntregaTextBox.TabIndex = 9;
            // 
            // horaDevolucionTextBox
            // 
            this.horaDevolucionTextBox.Location = new System.Drawing.Point(148, 187);
            this.horaDevolucionTextBox.Name = "horaDevolucionTextBox";
            this.horaDevolucionTextBox.Size = new System.Drawing.Size(53, 20);
            this.horaDevolucionTextBox.TabIndex = 10;
            // 
            // minutoDevolucionTextBox
            // 
            this.minutoDevolucionTextBox.Location = new System.Drawing.Point(223, 187);
            this.minutoDevolucionTextBox.Name = "minutoDevolucionTextBox";
            this.minutoDevolucionTextBox.Size = new System.Drawing.Size(54, 20);
            this.minutoDevolucionTextBox.TabIndex = 11;
            // 
            // observacionTextBox
            // 
            this.observacionTextBox.Location = new System.Drawing.Point(148, 324);
            this.observacionTextBox.Multiline = true;
            this.observacionTextBox.Name = "observacionTextBox";
            this.observacionTextBox.Size = new System.Drawing.Size(229, 50);
            this.observacionTextBox.TabIndex = 13;
            // 
            // guardarPrestamoButton
            // 
            this.guardarPrestamoButton.Location = new System.Drawing.Point(32, 393);
            this.guardarPrestamoButton.Name = "guardarPrestamoButton";
            this.guardarPrestamoButton.Size = new System.Drawing.Size(106, 45);
            this.guardarPrestamoButton.TabIndex = 14;
            this.guardarPrestamoButton.Text = "REGISTRAR PRÉSTAMO";
            this.guardarPrestamoButton.UseVisualStyleBackColor = true;
            this.guardarPrestamoButton.Click += new System.EventHandler(this.GuardarPrestamoButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(207, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Solicitante:";
            // 
            // prestamoInmediatoCheckBox
            // 
            this.prestamoInmediatoCheckBox.AutoSize = true;
            this.prestamoInmediatoCheckBox.Location = new System.Drawing.Point(35, 51);
            this.prestamoInmediatoCheckBox.Name = "prestamoInmediatoCheckBox";
            this.prestamoInmediatoCheckBox.Size = new System.Drawing.Size(140, 17);
            this.prestamoInmediatoCheckBox.TabIndex = 19;
            this.prestamoInmediatoCheckBox.Text = "Realizar préstamo ahora";
            this.prestamoInmediatoCheckBox.UseVisualStyleBackColor = true;
            this.prestamoInmediatoCheckBox.CheckedChanged += new System.EventHandler(this.actualCheckBox_CheckedChanged);
            // 
            // prestamoDataGridView
            // 
            this.prestamoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prestamoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.recurso,
            this.solicitante,
            this.fechaHoraEmision,
            this.fechaHoraEntrega,
            this.fechaHoraDevolucion,
            this.estado,
            this.observaciones});
            this.prestamoDataGridView.Location = new System.Drawing.Point(505, 51);
            this.prestamoDataGridView.Name = "prestamoDataGridView";
            this.prestamoDataGridView.Size = new System.Drawing.Size(843, 244);
            this.prestamoDataGridView.TabIndex = 20;
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
            // fechaHoraEmision
            // 
            this.fechaHoraEmision.HeaderText = "Fecha y Horario de Emisión";
            this.fechaHoraEmision.Name = "fechaHoraEmision";
            // 
            // fechaHoraEntrega
            // 
            this.fechaHoraEntrega.HeaderText = "Fecha y Horario de Entrega";
            this.fechaHoraEntrega.Name = "fechaHoraEntrega";
            // 
            // fechaHoraDevolucion
            // 
            this.fechaHoraDevolucion.HeaderText = "Fecha y Horario de Devolución";
            this.fechaHoraDevolucion.Name = "fechaHoraDevolucion";
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
            // recursoTextBox
            // 
            this.recursoTextBox.Enabled = false;
            this.recursoTextBox.Location = new System.Drawing.Point(148, 234);
            this.recursoTextBox.Name = "recursoTextBox";
            this.recursoTextBox.Size = new System.Drawing.Size(229, 20);
            this.recursoTextBox.TabIndex = 21;
            // 
            // buscarRecursoButton
            // 
            this.buscarRecursoButton.Location = new System.Drawing.Point(394, 232);
            this.buscarRecursoButton.Name = "buscarRecursoButton";
            this.buscarRecursoButton.Size = new System.Drawing.Size(51, 23);
            this.buscarRecursoButton.TabIndex = 22;
            this.buscarRecursoButton.Text = "Buscar";
            this.buscarRecursoButton.UseVisualStyleBackColor = true;
            this.buscarRecursoButton.Click += new System.EventHandler(this.buscarRecursoButton_Click);
            // 
            // solicitanteTextBox
            // 
            this.solicitanteTextBox.Enabled = false;
            this.solicitanteTextBox.Location = new System.Drawing.Point(148, 275);
            this.solicitanteTextBox.Name = "solicitanteTextBox";
            this.solicitanteTextBox.Size = new System.Drawing.Size(229, 20);
            this.solicitanteTextBox.TabIndex = 23;
            // 
            // buscarSolicitanteButton
            // 
            this.buscarSolicitanteButton.Location = new System.Drawing.Point(394, 272);
            this.buscarSolicitanteButton.Name = "buscarSolicitanteButton";
            this.buscarSolicitanteButton.Size = new System.Drawing.Size(51, 23);
            this.buscarSolicitanteButton.TabIndex = 24;
            this.buscarSolicitanteButton.Text = "Buscar";
            this.buscarSolicitanteButton.UseVisualStyleBackColor = true;
            this.buscarSolicitanteButton.Click += new System.EventHandler(this.buscarSolicitanteButton_Click);
            // 
            // verPrestamosPendientesButton
            // 
            this.verPrestamosPendientesButton.Location = new System.Drawing.Point(384, 393);
            this.verPrestamosPendientesButton.Name = "verPrestamosPendientesButton";
            this.verPrestamosPendientesButton.Size = new System.Drawing.Size(134, 45);
            this.verPrestamosPendientesButton.TabIndex = 25;
            this.verPrestamosPendientesButton.Text = "VER PRÉSTAMOS PENDIENTES";
            this.verPrestamosPendientesButton.UseVisualStyleBackColor = true;
            this.verPrestamosPendientesButton.Click += new System.EventHandler(this.verPrestamosPendientesButton_Click);
            // 
            // VistaPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 450);
            this.Controls.Add(this.verPrestamosPendientesButton);
            this.Controls.Add(this.buscarSolicitanteButton);
            this.Controls.Add(this.solicitanteTextBox);
            this.Controls.Add(this.buscarRecursoButton);
            this.Controls.Add(this.recursoTextBox);
            this.Controls.Add(this.prestamoDataGridView);
            this.Controls.Add(this.prestamoInmediatoCheckBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.guardarPrestamoButton);
            this.Controls.Add(this.observacionTextBox);
            this.Controls.Add(this.minutoDevolucionTextBox);
            this.Controls.Add(this.horaDevolucionTextBox);
            this.Controls.Add(this.minutoEntregaTextBox);
            this.Controls.Add(this.horaEntregaTextBox);
            this.Controls.Add(this.prestamoDateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VistaPrestamo";
            this.Text = "Prestamos";
            ((System.ComponentModel.ISupportInitialize)(this.prestamoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker prestamoDateTimePicker;
        private System.Windows.Forms.TextBox horaEntregaTextBox;
        private System.Windows.Forms.TextBox minutoEntregaTextBox;
        private System.Windows.Forms.TextBox horaDevolucionTextBox;
        private System.Windows.Forms.TextBox minutoDevolucionTextBox;
        private System.Windows.Forms.TextBox observacionTextBox;
        private System.Windows.Forms.Button guardarPrestamoButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox prestamoInmediatoCheckBox;
        private System.Windows.Forms.DataGridView prestamoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn recurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn solicitante;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaHoraEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaHoraEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaHoraDevolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn observaciones;
        private System.Windows.Forms.TextBox recursoTextBox;
        private System.Windows.Forms.Button buscarRecursoButton;
        private System.Windows.Forms.TextBox solicitanteTextBox;
        private System.Windows.Forms.Button buscarSolicitanteButton;
        private System.Windows.Forms.Button verPrestamosPendientesButton;
    }
}