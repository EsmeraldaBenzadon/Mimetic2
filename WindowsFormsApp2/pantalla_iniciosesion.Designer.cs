namespace WindowsFormsApp2
{
    partial class pantalla_iniciosesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pantalla_iniciosesion));
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.btn_iniciarsesion = new System.Windows.Forms.Button();
            this.btn_recupcontra = new System.Windows.Forms.Button();
            this.pbocultar = new System.Windows.Forms.PictureBox();
            this.pbmostrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbocultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(170)))), ((int)(((byte)(102)))));
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nombre.Location = new System.Drawing.Point(246, 163);
            this.txt_nombre.Multiline = true;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(315, 33);
            this.txt_nombre.TabIndex = 2;
            this.txt_nombre.TextChanged += new System.EventHandler(this.Txt_nombre_TextChanged);
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(170)))), ((int)(((byte)(102)))));
            this.txt_contraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_contraseña.Location = new System.Drawing.Point(246, 271);
            this.txt_contraseña.Multiline = true;
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(315, 34);
            this.txt_contraseña.TabIndex = 3;
            this.txt_contraseña.TextChanged += new System.EventHandler(this.Txt_contraseña_TextChanged);
            // 
            // btn_iniciarsesion
            // 
            this.btn_iniciarsesion.BackColor = System.Drawing.Color.Transparent;
            this.btn_iniciarsesion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_iniciarsesion.BackgroundImage")));
            this.btn_iniciarsesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_iniciarsesion.FlatAppearance.BorderSize = 0;
            this.btn_iniciarsesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iniciarsesion.Location = new System.Drawing.Point(305, 329);
            this.btn_iniciarsesion.Name = "btn_iniciarsesion";
            this.btn_iniciarsesion.Size = new System.Drawing.Size(200, 46);
            this.btn_iniciarsesion.TabIndex = 4;
            this.btn_iniciarsesion.UseVisualStyleBackColor = false;
            this.btn_iniciarsesion.Click += new System.EventHandler(this.Btn_iniciarsesion_Click);
            // 
            // btn_recupcontra
            // 
            this.btn_recupcontra.BackColor = System.Drawing.Color.Transparent;
            this.btn_recupcontra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_recupcontra.BackgroundImage")));
            this.btn_recupcontra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_recupcontra.FlatAppearance.BorderSize = 0;
            this.btn_recupcontra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_recupcontra.Location = new System.Drawing.Point(323, 380);
            this.btn_recupcontra.Name = "btn_recupcontra";
            this.btn_recupcontra.Size = new System.Drawing.Size(163, 12);
            this.btn_recupcontra.TabIndex = 5;
            this.btn_recupcontra.UseVisualStyleBackColor = false;
            // 
            // pbocultar
            // 
            this.pbocultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(170)))), ((int)(((byte)(102)))));
            this.pbocultar.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.ojo_tachado__1_;
            this.pbocultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbocultar.Location = new System.Drawing.Point(526, 278);
            this.pbocultar.Name = "pbocultar";
            this.pbocultar.Size = new System.Drawing.Size(26, 20);
            this.pbocultar.TabIndex = 11;
            this.pbocultar.TabStop = false;
            this.pbocultar.Click += new System.EventHandler(this.Pbocultar_Click);
            // 
            // pbmostrar
            // 
            this.pbmostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(170)))), ((int)(((byte)(102)))));
            this.pbmostrar.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.ojo;
            this.pbmostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbmostrar.Location = new System.Drawing.Point(526, 278);
            this.pbmostrar.Name = "pbmostrar";
            this.pbmostrar.Size = new System.Drawing.Size(26, 20);
            this.pbmostrar.TabIndex = 12;
            this.pbmostrar.TabStop = false;
            this.pbmostrar.Click += new System.EventHandler(this.Pbmostrar_Click);
            // 
            // pantalla_iniciosesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbmostrar);
            this.Controls.Add(this.pbocultar);
            this.Controls.Add(this.btn_recupcontra);
            this.Controls.Add(this.btn_iniciarsesion);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.txt_nombre);
            this.DoubleBuffered = true;
            this.Name = "pantalla_iniciosesion";
            this.Text = "m   --m";
            this.Load += new System.EventHandler(this.Pantalla_iniciosesion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbocultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.Button btn_iniciarsesion;
        private System.Windows.Forms.Button btn_recupcontra;
        private System.Windows.Forms.PictureBox pbocultar;
        private System.Windows.Forms.PictureBox pbmostrar;
    }
}