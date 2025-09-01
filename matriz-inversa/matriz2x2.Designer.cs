namespace matriz_inversa
{
    partial class matriz2x2
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
            this.txtA11 = new System.Windows.Forms.TextBox();
            this.txtA12 = new System.Windows.Forms.TextBox();
            this.txtA21 = new System.Windows.Forms.TextBox();
            this.txtA22 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResult00 = new System.Windows.Forms.Label();
            this.lblResult11 = new System.Windows.Forms.Label();
            this.lblResult01 = new System.Windows.Forms.Label();
            this.lblResult10 = new System.Windows.Forms.Label();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnsiguiente = new System.Windows.Forms.Button();
            this.btnvolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtA11
            // 
            this.txtA11.Location = new System.Drawing.Point(86, 40);
            this.txtA11.Name = "txtA11";
            this.txtA11.Size = new System.Drawing.Size(100, 22);
            this.txtA11.TabIndex = 0;
            // 
            // txtA12
            // 
            this.txtA12.Location = new System.Drawing.Point(201, 40);
            this.txtA12.Name = "txtA12";
            this.txtA12.Size = new System.Drawing.Size(100, 22);
            this.txtA12.TabIndex = 1;
            // 
            // txtA21
            // 
            this.txtA21.Location = new System.Drawing.Point(86, 77);
            this.txtA21.Name = "txtA21";
            this.txtA21.Size = new System.Drawing.Size(100, 22);
            this.txtA21.TabIndex = 2;
            // 
            // txtA22
            // 
            this.txtA22.Location = new System.Drawing.Point(201, 77);
            this.txtA22.Name = "txtA22";
            this.txtA22.Size = new System.Drawing.Size(100, 22);
            this.txtA22.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(86, 140);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(82, 31);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResult00
            // 
            this.lblResult00.AutoSize = true;
            this.lblResult00.Location = new System.Drawing.Point(340, 40);
            this.lblResult00.Name = "lblResult00";
            this.lblResult00.Size = new System.Drawing.Size(0, 16);
            this.lblResult00.TabIndex = 6;
            // 
            // lblResult11
            // 
            this.lblResult11.AutoSize = true;
            this.lblResult11.Location = new System.Drawing.Point(407, 83);
            this.lblResult11.Name = "lblResult11";
            this.lblResult11.Size = new System.Drawing.Size(0, 16);
            this.lblResult11.TabIndex = 7;
            // 
            // lblResult01
            // 
            this.lblResult01.AutoSize = true;
            this.lblResult01.Location = new System.Drawing.Point(407, 40);
            this.lblResult01.Name = "lblResult01";
            this.lblResult01.Size = new System.Drawing.Size(0, 16);
            this.lblResult01.TabIndex = 8;
            // 
            // lblResult10
            // 
            this.lblResult10.AutoSize = true;
            this.lblResult10.Location = new System.Drawing.Point(340, 80);
            this.lblResult10.Name = "lblResult10";
            this.lblResult10.Size = new System.Drawing.Size(0, 16);
            this.lblResult10.TabIndex = 9;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(201, 140);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(80, 31);
            this.btnlimpiar.TabIndex = 10;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(343, 140);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(85, 31);
            this.btnsalir.TabIndex = 11;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.Location = new System.Drawing.Point(640, 385);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(104, 35);
            this.btnsiguiente.TabIndex = 12;
            this.btnsiguiente.Text = "Siguiente";
            this.btnsiguiente.UseVisualStyleBackColor = true;
            this.btnsiguiente.Click += new System.EventHandler(this.btnsiguiente_Click);
            // 
            // btnvolver
            // 
            this.btnvolver.Location = new System.Drawing.Point(29, 385);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(75, 35);
            this.btnvolver.TabIndex = 13;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Y";
            // 
            // matriz2x2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.btnsiguiente);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.lblResult10);
            this.Controls.Add(this.lblResult01);
            this.Controls.Add(this.lblResult11);
            this.Controls.Add(this.lblResult00);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtA22);
            this.Controls.Add(this.txtA21);
            this.Controls.Add(this.txtA12);
            this.Controls.Add(this.txtA11);
            this.Name = "matriz2x2";
            this.Text = "matriz2x2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtA11;
        private System.Windows.Forms.TextBox txtA12;
        private System.Windows.Forms.TextBox txtA21;
        private System.Windows.Forms.TextBox txtA22;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResult00;
        private System.Windows.Forms.Label lblResult11;
        private System.Windows.Forms.Label lblResult01;
        private System.Windows.Forms.Label lblResult10;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnsiguiente;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}