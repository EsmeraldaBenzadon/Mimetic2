namespace WindowsFormsApp2
{
    partial class pantalla_logueo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pantalla_logueo));
            this.btnInicios = new System.Windows.Forms.Button();
            this.btnCrearc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInicios
            // 
            this.btnInicios.BackColor = System.Drawing.Color.Transparent;
            this.btnInicios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInicios.BackgroundImage")));
            this.btnInicios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInicios.FlatAppearance.BorderSize = 0;
            this.btnInicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicios.Location = new System.Drawing.Point(263, 101);
            this.btnInicios.Name = "btnInicios";
            this.btnInicios.Size = new System.Drawing.Size(310, 106);
            this.btnInicios.TabIndex = 0;
            this.btnInicios.UseVisualStyleBackColor = false;
            this.btnInicios.Click += new System.EventHandler(this.BtnInicios_Click);
            // 
            // btnCrearc
            // 
            this.btnCrearc.BackColor = System.Drawing.Color.Transparent;
            this.btnCrearc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCrearc.BackgroundImage")));
            this.btnCrearc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCrearc.FlatAppearance.BorderSize = 0;
            this.btnCrearc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearc.Location = new System.Drawing.Point(263, 293);
            this.btnCrearc.Name = "btnCrearc";
            this.btnCrearc.Size = new System.Drawing.Size(302, 109);
            this.btnCrearc.TabIndex = 1;
            this.btnCrearc.UseVisualStyleBackColor = false;
            // 
            // pantalla_logueo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(821, 480);
            this.Controls.Add(this.btnCrearc);
            this.Controls.Add(this.btnInicios);
            this.DoubleBuffered = true;
            this.Name = "pantalla_logueo";
            this.Text = "pantalla_logueo";
            this.Load += new System.EventHandler(this.Pantalla_logueo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInicios;
        private System.Windows.Forms.Button btnCrearc;
    }
}