namespace Evaluacion
{
    partial class FrmListaRapida
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.chkTodo = new System.Windows.Forms.CheckBox();
            this.dtpFecha2 = new System.Windows.Forms.DateTimePicker();
            this.Label4 = new System.Windows.Forms.Label();
            this.dtpFecha1 = new System.Windows.Forms.DateTimePicker();
            this.Label3 = new System.Windows.Forms.Label();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.cboEmpleado = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.dgdPedido = new System.Windows.Forms.DataGridView();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.chkTodo);
            this.GroupBox1.Controls.Add(this.dtpFecha2);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.dtpFecha1);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.cboCliente);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.cboEmpleado);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(12, 15);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(384, 111);
            this.GroupBox1.TabIndex = 4;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Consulta Por";
            // 
            // chkTodo
            // 
            this.chkTodo.AutoSize = true;
            this.chkTodo.Location = new System.Drawing.Point(80, 84);
            this.chkTodo.Name = "chkTodo";
            this.chkTodo.Size = new System.Drawing.Size(94, 17);
            this.chkTodo.TabIndex = 8;
            this.chkTodo.Text = "Mostrar Todos";
            this.chkTodo.UseVisualStyleBackColor = true;
            // 
            // dtpFecha2
            // 
            this.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha2.Location = new System.Drawing.Point(262, 57);
            this.dtpFecha2.Name = "dtpFecha2";
            this.dtpFecha2.Size = new System.Drawing.Size(111, 20);
            this.dtpFecha2.TabIndex = 7;
            this.dtpFecha2.Value = new System.DateTime(2011, 6, 10, 0, 0, 0, 0);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(205, 58);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(54, 13);
            this.Label4.TabIndex = 6;
            this.Label4.Text = "Fecha fin.";
            // 
            // dtpFecha1
            // 
            this.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha1.Location = new System.Drawing.Point(262, 20);
            this.dtpFecha1.Name = "dtpFecha1";
            this.dtpFecha1.Size = new System.Drawing.Size(111, 20);
            this.dtpFecha1.TabIndex = 5;
            this.dtpFecha1.Value = new System.DateTime(2011, 6, 10, 0, 0, 0, 0);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(204, 22);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(53, 13);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Fecha ini.";
            // 
            // cboCliente
            // 
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(64, 54);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(137, 21);
            this.cboCliente.TabIndex = 3;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(6, 56);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(39, 13);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Cliente";
            // 
            // cboEmpleado
            // 
            this.cboEmpleado.FormattingEnabled = true;
            this.cboEmpleado.Location = new System.Drawing.Point(64, 20);
            this.cboEmpleado.Name = "cboEmpleado";
            this.cboEmpleado.Size = new System.Drawing.Size(137, 21);
            this.cboEmpleado.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(4, 22);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(54, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Empleado";
            // 
            // dgdPedido
            // 
            this.dgdPedido.AllowUserToAddRows = false;
            this.dgdPedido.AllowUserToDeleteRows = false;
            this.dgdPedido.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgdPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdPedido.Location = new System.Drawing.Point(12, 133);
            this.dgdPedido.Name = "dgdPedido";
            this.dgdPedido.ReadOnly = true;
            this.dgdPedido.Size = new System.Drawing.Size(384, 183);
            this.dgdPedido.TabIndex = 5;
            // 
            // FrmListaRapida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 349);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.dgdPedido);
            this.Name = "FrmListaRapida";
            this.Text = "FrmListaRapida";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdPedido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.CheckBox chkTodo;
        internal System.Windows.Forms.DateTimePicker dtpFecha2;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.DateTimePicker dtpFecha1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.ComboBox cboCliente;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.ComboBox cboEmpleado;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.DataGridView dgdPedido;
    }
}