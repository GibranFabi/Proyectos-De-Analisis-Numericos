namespace InterpolacionWindowsForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbPuntos = new System.Windows.Forms.TextBox();
            this.tbValorInterpolar = new System.Windows.Forms.TextBox();
            this.btnInterpolar = new System.Windows.Forms.Button();
            this.tbResultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbPuntos
            // 
            this.tbPuntos.Location = new System.Drawing.Point(265, 18);
            this.tbPuntos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPuntos.Name = "tbPuntos";
            this.tbPuntos.Size = new System.Drawing.Size(110, 23);
            this.tbPuntos.TabIndex = 0;
            // 
            // tbValorInterpolar
            // 
            this.tbValorInterpolar.Location = new System.Drawing.Point(265, 86);
            this.tbValorInterpolar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbValorInterpolar.Name = "tbValorInterpolar";
            this.tbValorInterpolar.Size = new System.Drawing.Size(110, 23);
            this.tbValorInterpolar.TabIndex = 1;
            // 
            // btnInterpolar
            // 
            this.btnInterpolar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInterpolar.Location = new System.Drawing.Point(446, 68);
            this.btnInterpolar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInterpolar.Name = "btnInterpolar";
            this.btnInterpolar.Size = new System.Drawing.Size(96, 51);
            this.btnInterpolar.TabIndex = 2;
            this.btnInterpolar.Text = "INICIAR";
            this.btnInterpolar.UseVisualStyleBackColor = true;
            // 
            // tbResultado
            // 
            this.tbResultado.Location = new System.Drawing.Point(265, 147);
            this.tbResultado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.Size = new System.Drawing.Size(110, 23);
            this.tbResultado.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "ESCRIBE LOS PUNTOS X,Y";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(10, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "VALOR A INTERPOLAR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(10, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "VALOR INTERPOLADO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbResultado);
            this.Controls.Add(this.btnInterpolar);
            this.Controls.Add(this.tbValorInterpolar);
            this.Controls.Add(this.tbPuntos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Interpolacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbPuntos;
        private TextBox tbValorInterpolar;
        private Button btnInterpolar;
        private TextBox tbResultado;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}