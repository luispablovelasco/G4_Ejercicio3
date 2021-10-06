namespace G4_Ejemplo3_4_Ejercicio3_
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtlado = new System.Windows.Forms.TextBox();
            this.btncalcularlado = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtradio = new System.Windows.Forms.TextBox();
            this.btncalcularradio = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnarreglo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtarreglo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(2, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(605, 297);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btncalcularlado);
            this.tabPage1.Controls.Add(this.txtlado);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(597, 271);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cuadrado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btncalcularradio);
            this.tabPage2.Controls.Add(this.txtradio);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(597, 271);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Circulo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lado:";
            // 
            // txtlado
            // 
            this.txtlado.Location = new System.Drawing.Point(72, 49);
            this.txtlado.Name = "txtlado";
            this.txtlado.Size = new System.Drawing.Size(248, 20);
            this.txtlado.TabIndex = 1;
            // 
            // btncalcularlado
            // 
            this.btncalcularlado.Location = new System.Drawing.Point(322, 101);
            this.btncalcularlado.Name = "btncalcularlado";
            this.btncalcularlado.Size = new System.Drawing.Size(75, 23);
            this.btncalcularlado.TabIndex = 2;
            this.btncalcularlado.Text = "Calcular";
            this.btncalcularlado.UseVisualStyleBackColor = true;
            this.btncalcularlado.Click += new System.EventHandler(this.btncalcularlado_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Radio:";
            // 
            // txtradio
            // 
            this.txtradio.Location = new System.Drawing.Point(74, 61);
            this.txtradio.Name = "txtradio";
            this.txtradio.Size = new System.Drawing.Size(216, 20);
            this.txtradio.TabIndex = 1;
            // 
            // btncalcularradio
            // 
            this.btncalcularradio.Location = new System.Drawing.Point(299, 101);
            this.btncalcularradio.Name = "btncalcularradio";
            this.btncalcularradio.Size = new System.Drawing.Size(75, 23);
            this.btncalcularradio.TabIndex = 2;
            this.btncalcularradio.Text = "Calcular";
            this.btncalcularradio.UseVisualStyleBackColor = true;
            this.btncalcularradio.Click += new System.EventHandler(this.btncalcularradio_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.txtarreglo);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.btnarreglo);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(597, 271);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Arreglo";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnarreglo
            // 
            this.btnarreglo.Location = new System.Drawing.Point(123, 80);
            this.btnarreglo.Name = "btnarreglo";
            this.btnarreglo.Size = new System.Drawing.Size(75, 23);
            this.btnarreglo.TabIndex = 0;
            this.btnarreglo.Text = "Calcular";
            this.btnarreglo.UseVisualStyleBackColor = true;
            this.btnarreglo.Click += new System.EventHandler(this.btnarreglo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Valor:";
            // 
            // txtarreglo
            // 
            this.txtarreglo.Location = new System.Drawing.Point(71, 39);
            this.txtarreglo.Name = "txtarreglo";
            this.txtarreglo.Size = new System.Drawing.Size(174, 20);
            this.txtarreglo.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(432, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(435, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(435, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(435, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(435, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "label10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 298);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.TabControl tabControl1;
        protected System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Button btncalcularlado;
        private System.Windows.Forms.TextBox txtlado;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btncalcularradio;
        private System.Windows.Forms.TextBox txtradio;
        private System.Windows.Forms.Label label3;
        protected System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtarreglo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnarreglo;
    }
}

