namespace WindowsFormsApp2
{
    partial class ABC
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
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.btn_nom = new System.Windows.Forms.Button();
            this.NomUsu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(143, 378);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(614, 20);
            this.txt_nombre.TabIndex = 0;
            // 
            // btn_nom
            // 
            this.btn_nom.Location = new System.Drawing.Point(395, 418);
            this.btn_nom.Name = "btn_nom";
            this.btn_nom.Size = new System.Drawing.Size(75, 23);
            this.btn_nom.TabIndex = 1;
            this.btn_nom.Text = "mostar";
            this.btn_nom.UseVisualStyleBackColor = true;
            this.btn_nom.Click += new System.EventHandler(this.Btn_nom_Click);
            // 
            // NomUsu
            // 
            this.NomUsu.AutoSize = true;
            this.NomUsu.Location = new System.Drawing.Point(1133, 20);
            this.NomUsu.Name = "NomUsu";
            this.NomUsu.Size = new System.Drawing.Size(35, 13);
            this.NomUsu.TabIndex = 4;
            this.NomUsu.Text = "label1";
            // 
            // ABC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 497);
            this.Controls.Add(this.NomUsu);
            this.Controls.Add(this.btn_nom);
            this.Controls.Add(this.txt_nombre);
            this.Name = "ABC";
            this.Text = "ABC juego";
            this.Load += new System.EventHandler(this.ABC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Button btn_nom;
        private System.Windows.Forms.Label NomUsu;
    }
}