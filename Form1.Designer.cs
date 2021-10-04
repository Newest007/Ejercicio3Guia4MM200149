
namespace Ejercicio3___Guía4_MM200149
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtresultado1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtlado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtresultado2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtradio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtresultado3 = new System.Windows.Forms.TextBox();
            this.txtdigmenor = new System.Windows.Forms.TextBox();
            this.txtdigmayor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btncalrombo = new System.Windows.Forms.Button();
            this.btncalcirculo = new System.Windows.Forms.Button();
            this.btncalcuadrado = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido al Ejercicio 3 de la guía 4!";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(70, 76);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(591, 263);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btncalcuadrado);
            this.tabPage1.Controls.Add(this.txtresultado1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtlado);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(583, 227);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Área de un Cuadrado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtresultado1
            // 
            this.txtresultado1.Enabled = false;
            this.txtresultado1.Location = new System.Drawing.Point(247, 133);
            this.txtresultado1.MaxLength = 5;
            this.txtresultado1.Name = "txtresultado1";
            this.txtresultado1.ReadOnly = true;
            this.txtresultado1.Size = new System.Drawing.Size(126, 30);
            this.txtresultado1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Resultado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Lado";
            // 
            // txtlado
            // 
            this.txtlado.Location = new System.Drawing.Point(247, 74);
            this.txtlado.MaxLength = 5;
            this.txtlado.Name = "txtlado";
            this.txtlado.Size = new System.Drawing.Size(126, 30);
            this.txtlado.TabIndex = 1;
            this.txtlado.TextChanged += new System.EventHandler(this.txtlado_TextChanged);
            this.txtlado.Enter += new System.EventHandler(this.txtlado_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "A = Lado * Lado";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btncalcirculo);
            this.tabPage2.Controls.Add(this.txtresultado2);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtradio);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(583, 227);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Área de un Círculo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtresultado2
            // 
            this.txtresultado2.Enabled = false;
            this.txtresultado2.Location = new System.Drawing.Point(249, 137);
            this.txtresultado2.MaxLength = 5;
            this.txtresultado2.Name = "txtresultado2";
            this.txtresultado2.ReadOnly = true;
            this.txtresultado2.Size = new System.Drawing.Size(111, 30);
            this.txtresultado2.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(151, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "Resultado";
            // 
            // txtradio
            // 
            this.txtradio.Location = new System.Drawing.Point(249, 70);
            this.txtradio.MaxLength = 5;
            this.txtradio.Name = "txtradio";
            this.txtradio.Size = new System.Drawing.Size(111, 30);
            this.txtradio.TabIndex = 2;
            this.txtradio.TextChanged += new System.EventHandler(this.txtradio_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Radio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "A = π * (radio)^2";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btncalrombo);
            this.tabPage3.Controls.Add(this.txtresultado3);
            this.tabPage3.Controls.Add(this.txtdigmenor);
            this.tabPage3.Controls.Add(this.txtdigmayor);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Location = new System.Drawing.Point(4, 32);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(583, 227);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Área de un Rombo";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtresultado3
            // 
            this.txtresultado3.Enabled = false;
            this.txtresultado3.Location = new System.Drawing.Point(263, 167);
            this.txtresultado3.MaxLength = 5;
            this.txtresultado3.Name = "txtresultado3";
            this.txtresultado3.ReadOnly = true;
            this.txtresultado3.Size = new System.Drawing.Size(111, 30);
            this.txtresultado3.TabIndex = 7;
            this.txtresultado3.TextChanged += new System.EventHandler(this.txtresultado3_TextChanged);
            // 
            // txtdigmenor
            // 
            this.txtdigmenor.Location = new System.Drawing.Point(263, 117);
            this.txtdigmenor.MaxLength = 5;
            this.txtdigmenor.Name = "txtdigmenor";
            this.txtdigmenor.Size = new System.Drawing.Size(111, 30);
            this.txtdigmenor.TabIndex = 6;
            this.txtdigmenor.TextChanged += new System.EventHandler(this.txtdigmenor_TextChanged);
            // 
            // txtdigmayor
            // 
            this.txtdigmayor.Location = new System.Drawing.Point(263, 73);
            this.txtdigmayor.MaxLength = 5;
            this.txtdigmayor.Name = "txtdigmayor";
            this.txtdigmayor.Size = new System.Drawing.Size(111, 30);
            this.txtdigmayor.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(167, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 23);
            this.label11.TabIndex = 4;
            this.label11.Text = "Resultado";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(126, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 23);
            this.label10.TabIndex = 3;
            this.label10.Text = "Diagonal Menor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(126, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 23);
            this.label9.TabIndex = 2;
            this.label9.Text = "Diagonal Mayor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(149, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(294, 23);
            this.label8.TabIndex = 1;
            this.label8.Text = "A = (Diagonal Mayor * Diagonal Menor) /2";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(359, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(206, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 48);
            this.button2.TabIndex = 3;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btncalrombo
            // 
            this.btncalrombo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncalrombo.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalrombo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncalrombo.Location = new System.Drawing.Point(406, 107);
            this.btncalrombo.Name = "btncalrombo";
            this.btncalrombo.Size = new System.Drawing.Size(116, 48);
            this.btncalrombo.TabIndex = 8;
            this.btncalrombo.Text = "Calcular";
            this.btncalrombo.UseVisualStyleBackColor = false;
            this.btncalrombo.Click += new System.EventHandler(this.button3_Click);
            // 
            // btncalcirculo
            // 
            this.btncalcirculo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncalcirculo.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcirculo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncalcirculo.Location = new System.Drawing.Point(401, 92);
            this.btncalcirculo.Name = "btncalcirculo";
            this.btncalcirculo.Size = new System.Drawing.Size(116, 48);
            this.btncalcirculo.TabIndex = 9;
            this.btncalcirculo.Text = "Calcular";
            this.btncalcirculo.UseVisualStyleBackColor = false;
            this.btncalcirculo.Click += new System.EventHandler(this.button4_Click);
            // 
            // btncalcuadrado
            // 
            this.btncalcuadrado.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncalcuadrado.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcuadrado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncalcuadrado.Location = new System.Drawing.Point(407, 94);
            this.btncalcuadrado.Name = "btncalcuadrado";
            this.btncalcuadrado.Size = new System.Drawing.Size(116, 48);
            this.btncalcuadrado.TabIndex = 10;
            this.btncalcuadrado.Text = "Calcular";
            this.btncalcuadrado.UseVisualStyleBackColor = false;
            this.btncalcuadrado.Click += new System.EventHandler(this.btncalcuadrado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 420);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "v";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtresultado1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtlado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtresultado2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtradio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtresultado3;
        private System.Windows.Forms.TextBox txtdigmenor;
        private System.Windows.Forms.TextBox txtdigmayor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btncalrombo;
        private System.Windows.Forms.Button btncalcirculo;
        private System.Windows.Forms.Button btncalcuadrado;
    }
}

