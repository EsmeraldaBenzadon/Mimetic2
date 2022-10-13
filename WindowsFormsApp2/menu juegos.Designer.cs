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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu_juegos));
            this.abc = new System.Windows.Forms.Button();
            this.voc = new System.Windows.Forms.Button();
            this.frases = new System.Windows.Forms.Button();
            this.NomUsu = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // abc
            // 
            this.abc.BackColor = System.Drawing.Color.Transparent;
            this.abc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.abc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abc.Location = new System.Drawing.Point(180, 233);
            this.abc.Name = "abc";
            this.abc.Size = new System.Drawing.Size(276, 164);
            this.abc.TabIndex = 0;
            this.abc.UseVisualStyleBackColor = false;
            this.abc.Click += new System.EventHandler(this.Abc_Click);
            // 
            // voc
            // 
            this.voc.BackColor = System.Drawing.Color.Transparent;
            this.voc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.voc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voc.Location = new System.Drawing.Point(549, 484);
            this.voc.Name = "voc";
            this.voc.Size = new System.Drawing.Size(276, 164);
            this.voc.TabIndex = 1;
            this.voc.UseVisualStyleBackColor = false;
            this.voc.Click += new System.EventHandler(this.Voc_Click);
            // 
            // frases
            // 
            this.frases.BackColor = System.Drawing.Color.Transparent;
            this.frases.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.frases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.frases.Location = new System.Drawing.Point(888, 233);
            this.frases.Name = "frases";
            this.frases.Size = new System.Drawing.Size(276, 164);
            this.frases.TabIndex = 2;
            this.frases.UseVisualStyleBackColor = false;
            this.frases.Click += new System.EventHandler(this.frases_Click);
            // 
            // NomUsu
            // 
            this.NomUsu.AutoSize = true;
            this.NomUsu.Location = new System.Drawing.Point(1283, 24);
            this.NomUsu.Name = "NomUsu";
            this.NomUsu.Size = new System.Drawing.Size(35, 13);
            this.NomUsu.TabIndex = 3;
            this.NomUsu.Text = "label1";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVolver.BackgroundImage")));
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Location = new System.Drawing.Point(50, 590);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(95, 90);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // menu_juegos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.NomUsu);
            this.Controls.Add(this.frases);
            this.Controls.Add(this.voc);
            this.Controls.Add(this.abc);
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
        private System.Windows.Forms.Button btnVolver;
    }
}