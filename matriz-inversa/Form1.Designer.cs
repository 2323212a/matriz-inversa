namespace matriz_inversa
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
            this.btnmatriz2x2 = new System.Windows.Forms.Button();
            this.btnmatriz3x3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnmatriz2x2
            // 
            this.btnmatriz2x2.Location = new System.Drawing.Point(108, 111);
            this.btnmatriz2x2.Name = "btnmatriz2x2";
            this.btnmatriz2x2.Size = new System.Drawing.Size(75, 30);
            this.btnmatriz2x2.TabIndex = 0;
            this.btnmatriz2x2.Text = "2x2";
            this.btnmatriz2x2.UseVisualStyleBackColor = true;
            this.btnmatriz2x2.Click += new System.EventHandler(this.btnmatriz2x2_Click);
            // 
            // btnmatriz3x3
            // 
            this.btnmatriz3x3.Location = new System.Drawing.Point(231, 111);
            this.btnmatriz3x3.Name = "btnmatriz3x3";
            this.btnmatriz3x3.Size = new System.Drawing.Size(75, 30);
            this.btnmatriz3x3.TabIndex = 1;
            this.btnmatriz3x3.Text = "3x3";
            this.btnmatriz3x3.UseVisualStyleBackColor = true;
            this.btnmatriz3x3.Click += new System.EventHandler(this.btnmatriz3x3_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnmatriz3x3);
            this.Controls.Add(this.btnmatriz2x2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnmatriz2x2;
        private System.Windows.Forms.Button btnmatriz3x3;
    }
}

