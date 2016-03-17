namespace CalculoPromedio
{
    partial class FrmPromedio
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
            this.txtAlumno = new System.Windows.Forms.TextBox();
            this.cboCurso = new System.Windows.Forms.ComboBox();
            this.grupo = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtLC1 = new System.Windows.Forms.TextBox();
            this.txtLC2 = new System.Windows.Forms.TextBox();
            this.txtLC3 = new System.Windows.Forms.TextBox();
            this.txtLC4 = new System.Windows.Forms.TextBox();
            this.txtLP = new System.Windows.Forms.TextBox();
            this.txtEF = new System.Windows.Forms.TextBox();
            this.txtNA = new System.Windows.Forms.TextBox();
            this.lstR = new System.Windows.Forms.ListBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grupo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROMEDIO DE NOTAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ALUMNO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "CURSO";
            // 
            // txtAlumno
            // 
            this.txtAlumno.Location = new System.Drawing.Point(114, 55);
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.Size = new System.Drawing.Size(174, 20);
            this.txtAlumno.TabIndex = 1;
            // 
            // cboCurso
            // 
            this.cboCurso.FormattingEnabled = true;
            this.cboCurso.Location = new System.Drawing.Point(114, 98);
            this.cboCurso.Name = "cboCurso";
            this.cboCurso.Size = new System.Drawing.Size(121, 21);
            this.cboCurso.TabIndex = 2;
            // 
            // grupo
            // 
            this.grupo.Controls.Add(this.txtNA);
            this.grupo.Controls.Add(this.txtEF);
            this.grupo.Controls.Add(this.txtLP);
            this.grupo.Controls.Add(this.txtLC4);
            this.grupo.Controls.Add(this.txtLC3);
            this.grupo.Controls.Add(this.txtLC2);
            this.grupo.Controls.Add(this.txtLC1);
            this.grupo.Controls.Add(this.btnCalcular);
            this.grupo.Controls.Add(this.label10);
            this.grupo.Controls.Add(this.label9);
            this.grupo.Controls.Add(this.label8);
            this.grupo.Controls.Add(this.label7);
            this.grupo.Controls.Add(this.label6);
            this.grupo.Controls.Add(this.label5);
            this.grupo.Controls.Add(this.label4);
            this.grupo.Location = new System.Drawing.Point(17, 138);
            this.grupo.Name = "grupo";
            this.grupo.Size = new System.Drawing.Size(552, 102);
            this.grupo.TabIndex = 3;
            this.grupo.TabStop = false;
            this.grupo.Text = "Evaluaciones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "LC1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "LC2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "LC3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(183, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "LC4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(270, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "LP";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(326, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "EF";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(380, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "NA";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(449, 28);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 49);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtLC1
            // 
            this.txtLC1.Location = new System.Drawing.Point(13, 57);
            this.txtLC1.Name = "txtLC1";
            this.txtLC1.Size = new System.Drawing.Size(43, 20);
            this.txtLC1.TabIndex = 2;
            // 
            // txtLC2
            // 
            this.txtLC2.Location = new System.Drawing.Point(62, 57);
            this.txtLC2.Name = "txtLC2";
            this.txtLC2.Size = new System.Drawing.Size(43, 20);
            this.txtLC2.TabIndex = 2;
            // 
            // txtLC3
            // 
            this.txtLC3.Location = new System.Drawing.Point(111, 57);
            this.txtLC3.Name = "txtLC3";
            this.txtLC3.Size = new System.Drawing.Size(43, 20);
            this.txtLC3.TabIndex = 2;
            // 
            // txtLC4
            // 
            this.txtLC4.Location = new System.Drawing.Point(166, 57);
            this.txtLC4.Name = "txtLC4";
            this.txtLC4.Size = new System.Drawing.Size(43, 20);
            this.txtLC4.TabIndex = 2;
            // 
            // txtLP
            // 
            this.txtLP.Location = new System.Drawing.Point(247, 57);
            this.txtLP.Name = "txtLP";
            this.txtLP.Size = new System.Drawing.Size(43, 20);
            this.txtLP.TabIndex = 2;
            // 
            // txtEF
            // 
            this.txtEF.Location = new System.Drawing.Point(312, 57);
            this.txtEF.Name = "txtEF";
            this.txtEF.Size = new System.Drawing.Size(43, 20);
            this.txtEF.TabIndex = 2;
            // 
            // txtNA
            // 
            this.txtNA.Location = new System.Drawing.Point(374, 57);
            this.txtNA.Name = "txtNA";
            this.txtNA.Size = new System.Drawing.Size(43, 20);
            this.txtNA.TabIndex = 2;
            // 
            // lstR
            // 
            this.lstR.FormattingEnabled = true;
            this.lstR.Location = new System.Drawing.Point(21, 266);
            this.lstR.Name = "lstR";
            this.lstR.Size = new System.Drawing.Size(547, 160);
            this.lstR.TabIndex = 4;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(21, 432);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 49);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(493, 432);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 49);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmPromedio
            // 
            this.AcceptButton = this.btnCalcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 491);
            this.Controls.Add(this.lstR);
            this.Controls.Add(this.grupo);
            this.Controls.Add(this.cboCurso);
            this.Controls.Add(this.txtAlumno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Name = "FrmPromedio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmPromedio_Load);
            this.grupo.ResumeLayout(false);
            this.grupo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAlumno;
        private System.Windows.Forms.ComboBox cboCurso;
        private System.Windows.Forms.GroupBox grupo;
        private System.Windows.Forms.TextBox txtNA;
        private System.Windows.Forms.TextBox txtEF;
        private System.Windows.Forms.TextBox txtLP;
        private System.Windows.Forms.TextBox txtLC4;
        private System.Windows.Forms.TextBox txtLC3;
        private System.Windows.Forms.TextBox txtLC2;
        private System.Windows.Forms.TextBox txtLC1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstR;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
    }
}

