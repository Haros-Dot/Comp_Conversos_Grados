namespace Comp_Conversos_Grados
{
    partial class ConversorGrados
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btncaf = new System.Windows.Forms.Button();
            this.btafac = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pantalla = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncaf
            // 
            this.btncaf.Location = new System.Drawing.Point(27, 136);
            this.btncaf.Name = "btncaf";
            this.btncaf.Size = new System.Drawing.Size(75, 23);
            this.btncaf.TabIndex = 0;
            this.btncaf.Text = "C A F";
            this.btncaf.UseVisualStyleBackColor = true;
            this.btncaf.Click += new System.EventHandler(this.button1_Click);
            // 
            // btafac
            // 
            this.btafac.Location = new System.Drawing.Point(169, 136);
            this.btafac.Name = "btafac";
            this.btafac.Size = new System.Drawing.Size(75, 23);
            this.btafac.TabIndex = 1;
            this.btafac.Text = "F A C";
            this.btafac.UseVisualStyleBackColor = true;
            this.btafac.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Resultado";
            // 
            // pantalla
            // 
            this.pantalla.Location = new System.Drawing.Point(89, 80);
            this.pantalla.Name = "pantalla";
            this.pantalla.Size = new System.Drawing.Size(92, 20);
            this.pantalla.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Grados a convertir";
            // 
            // ConversorGrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pantalla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btafac);
            this.Controls.Add(this.btncaf);
            this.Name = "ConversorGrados";
            this.Size = new System.Drawing.Size(286, 258);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncaf;
        private System.Windows.Forms.Button btafac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pantalla;
        private System.Windows.Forms.Label label2;
    }
}
