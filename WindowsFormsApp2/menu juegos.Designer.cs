namespace WindowsFormsApp2
{
    partial class menu_juegos
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
            this.abc = new System.Windows.Forms.Button();
            this.voc = new System.Windows.Forms.Button();
            this.frases = new System.Windows.Forms.Button();
            this.NomUsu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // abc
            // 
            this.abc.Location = new System.Drawing.Point(249, 160);
            this.abc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.abc.Name = "abc";
            this.abc.Size = new System.Drawing.Size(112, 35);
            this.abc.TabIndex = 0;
            this.abc.Text = "ABC";
            this.abc.UseVisualStyleBackColor = true;
            this.abc.Click += new System.EventHandler(this.Abc_Click);
            // 
            // voc
            // 
            this.voc.Location = new System.Drawing.Point(514, 405);
            this.voc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.voc.Name = "voc";
            this.voc.Size = new System.Drawing.Size(156, 63);
            this.voc.TabIndex = 1;
            this.voc.Text = "Vocabulario especifico";
            this.voc.UseVisualStyleBackColor = true;
            // 
            // frases
            // 
            this.frases.Location = new System.Drawing.Point(780, 160);
            this.frases.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.frases.Name = "frases";
            this.frases.Size = new System.Drawing.Size(144, 68);
            this.frases.TabIndex = 2;
            this.frases.Text = "Fraces cotidianas";
            this.frases.UseVisualStyleBackColor = true;
            this.frases.Click += new System.EventHandler(this.frases_Click);
            // 
            // NomUsu
            // 
            this.NomUsu.AutoSize = true;
            this.NomUsu.Location = new System.Drawing.Point(1246, 33);
            this.NomUsu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NomUsu.Name = "NomUsu";
            this.NomUsu.Size = new System.Drawing.Size(51, 20);
            this.NomUsu.TabIndex = 3;
            this.NomUsu.Text = "label1";
            // 
            // menu_juegos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 712);
            this.Controls.Add(this.NomUsu);
            this.Controls.Add(this.frases);
            this.Controls.Add(this.voc);
            this.Controls.Add(this.abc);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "menu_juegos";
            this.Text = "menu_juegos";
            this.Load += new System.EventHandler(this.Menu_juegos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button abc;
        private System.Windows.Forms.Button voc;
        private System.Windows.Forms.Button frases;
        private System.Windows.Forms.Label NomUsu;
    }
}