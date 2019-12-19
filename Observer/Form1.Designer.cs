namespace Observer
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Ag = new System.Windows.Forms.Button();
            this.Elim = new System.Windows.Forms.Button();
            this.checa = new System.Windows.Forms.Button();
            this.conect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 279);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(627, 141);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Checa cambios";
            // 
            // Ag
            // 
            this.Ag.Location = new System.Drawing.Point(117, 111);
            this.Ag.Name = "Ag";
            this.Ag.Size = new System.Drawing.Size(183, 36);
            this.Ag.TabIndex = 2;
            this.Ag.Text = "Agrega algo";
            this.Ag.UseVisualStyleBackColor = true;
            this.Ag.Click += new System.EventHandler(this.Ag_Click);
            // 
            // Elim
            // 
            this.Elim.Location = new System.Drawing.Point(424, 111);
            this.Elim.Name = "Elim";
            this.Elim.Size = new System.Drawing.Size(163, 36);
            this.Elim.TabIndex = 3;
            this.Elim.Text = "Elimina ese algo";
            this.Elim.UseVisualStyleBackColor = true;
            this.Elim.Click += new System.EventHandler(this.Elim_Click);
            // 
            // checa
            // 
            this.checa.Location = new System.Drawing.Point(424, 208);
            this.checa.Name = "checa";
            this.checa.Size = new System.Drawing.Size(150, 42);
            this.checa.TabIndex = 4;
            this.checa.Text = "Checa cambios";
            this.checa.UseVisualStyleBackColor = true;
            this.checa.Click += new System.EventHandler(this.checa_Click);
            // 
            // conect
            // 
            this.conect.Location = new System.Drawing.Point(745, 140);
            this.conect.Name = "conect";
            this.conect.Size = new System.Drawing.Size(100, 38);
            this.conect.TabIndex = 5;
            this.conect.Text = "Conecta";
            this.conect.UseVisualStyleBackColor = true;
            this.conect.Click += new System.EventHandler(this.conect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 450);
            this.Controls.Add(this.conect);
            this.Controls.Add(this.checa);
            this.Controls.Add(this.Elim);
            this.Controls.Add(this.Ag);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Ag;
        private System.Windows.Forms.Button Elim;
        private System.Windows.Forms.Button checa;
        private System.Windows.Forms.Button conect;
    }
}

