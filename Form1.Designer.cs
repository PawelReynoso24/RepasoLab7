namespace RepasoLab7
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonMostrarDatos = new System.Windows.Forms.Button();
            this.buttonOrdenarDatos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(470, 223);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonMostrarDatos
            // 
            this.buttonMostrarDatos.Location = new System.Drawing.Point(64, 313);
            this.buttonMostrarDatos.Name = "buttonMostrarDatos";
            this.buttonMostrarDatos.Size = new System.Drawing.Size(130, 56);
            this.buttonMostrarDatos.TabIndex = 1;
            this.buttonMostrarDatos.Text = "Mostrar Resumen";
            this.buttonMostrarDatos.UseVisualStyleBackColor = true;
            this.buttonMostrarDatos.Click += new System.EventHandler(this.buttonMostrarDatos_Click);
            // 
            // buttonOrdenarDatos
            // 
            this.buttonOrdenarDatos.Location = new System.Drawing.Point(229, 313);
            this.buttonOrdenarDatos.Name = "buttonOrdenarDatos";
            this.buttonOrdenarDatos.Size = new System.Drawing.Size(130, 56);
            this.buttonOrdenarDatos.TabIndex = 2;
            this.buttonOrdenarDatos.Text = "Ordenar Datos";
            this.buttonOrdenarDatos.UseVisualStyleBackColor = true;
            this.buttonOrdenarDatos.Click += new System.EventHandler(this.buttonOrdenarDatos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOrdenarDatos);
            this.Controls.Add(this.buttonMostrarDatos);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonMostrarDatos;
        private System.Windows.Forms.Button buttonOrdenarDatos;
    }
}

