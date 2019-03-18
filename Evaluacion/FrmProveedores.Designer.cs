namespace Evaluacion
{
    partial class FrmProveedores
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
            this.lvwProveedor = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvwProveedor
            // 
            this.lvwProveedor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3});
            this.lvwProveedor.GridLines = true;
            this.lvwProveedor.Location = new System.Drawing.Point(12, 12);
            this.lvwProveedor.Name = "lvwProveedor";
            this.lvwProveedor.Size = new System.Drawing.Size(328, 241);
            this.lvwProveedor.TabIndex = 8;
            this.lvwProveedor.UseCompatibleStateImageBehavior = false;
            this.lvwProveedor.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "Codigo";
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "Nombre proveedor";
            this.ColumnHeader2.Width = 173;
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "Pais";
            this.ColumnHeader3.Width = 90;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(265, 259);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 11;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(136, 260);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(13, 13);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "0";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(21, 260);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(109, 13);
            this.Label1.TabIndex = 9;
            this.Label1.Text = "Total de Proveedores";
            // 
            // FrmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 296);
            this.Controls.Add(this.lvwProveedor);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.Label1);
            this.Name = "FrmProveedores";
            this.Text = "FrmProveedores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ListView lvwProveedor;
        internal System.Windows.Forms.ColumnHeader ColumnHeader1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader2;
        internal System.Windows.Forms.ColumnHeader ColumnHeader3;
        internal System.Windows.Forms.Button btnCerrar;
        internal System.Windows.Forms.Label lblTotal;
        internal System.Windows.Forms.Label Label1;
    }
}