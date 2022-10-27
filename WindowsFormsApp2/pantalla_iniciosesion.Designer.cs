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
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbocultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(170)))), ((int)(((byte)(102)))));
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(415, 267);
            this.txt_nombre.Multiline = true;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(535, 46);
            this.txt_nombre.TabIndex = 2;
            this.txt_nombre.TextChanged += new System.EventHandler(this.Txt_nombre_TextChanged);
            this.txt_nombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_nombre_KeyUp);
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(170)))), ((int)(((byte)(102)))));
            this.txt_contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contraseña.Location = new System.Drawing.Point(415, 437);
            this.txt_contraseña.Multiline = true;
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(527, 47);
            this.txt_contraseña.TabIndex = 3;
            this.txt_contraseña.TextChanged += new System.EventHandler(this.Txt_contraseña_TextChanged);
            this.txt_contraseña.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_contraseña_KeyUp);
            // 
            // btn_iniciarsesion
            // 
            this.btn_iniciarsesion.BackColor = System.Drawing.Color.Transparent;
            this.btn_iniciarsesion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_iniciarsesion.BackgroundImage")));
            this.btn_iniciarsesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_iniciarsesion.FlatAppearance.BorderSize = 0;
            this.btn_iniciarsesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_iniciarsesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_iniciarsesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iniciarsesion.Location = new System.Drawing.Point(515, 534);
            this.btn_iniciarsesion.Name = "btn_iniciarsesion";
            this.btn_iniciarsesion.Size = new System.Drawing.Size(333, 74);
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
            this.btn_recupcontra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_recupcontra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_recupcontra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_recupcontra.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recupcontra.Location = new System.Drawing.Point(583, 617);
            this.btn_recupcontra.Name = "btn_recupcontra";
            this.btn_recupcontra.Size = new System.Drawing.Size(205, 18);
            this.btn_recupcontra.TabIndex = 5;
            this.btn_recupcontra.UseVisualStyleBackColor = false;
            this.btn_recupcontra.Click += new System.EventHandler(this.btn_recupcontra_Click);
            // 
            // pbocultar
            // 
            this.pbocultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(170)))), ((int)(((byte)(102)))));
            this.pbocultar.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.ojo_tachado__1_;
            this.pbocultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbocultar.Location = new System.Drawing.Point(891, 446);
            this.pbocultar.Name = "pbocultar";
            this.pbocultar.Size = new System.Drawing.Size(37, 28);
            this.pbocultar.TabIndex = 11;
            this.pbocultar.TabStop = false;
            this.pbocultar.Click += new System.EventHandler(this.Pbocultar_Click);
            // 
            // pbmostrar
            // 
            this.pbmostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(170)))), ((int)(((byte)(102)))));
            this.pbmostrar.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.ojo;
            this.pbmostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbmostrar.Location = new System.Drawing.Point(891, 446);
            this.pbmostrar.Name = "pbmostrar";
            this.pbmostrar.Size = new System.Drawing.Size(37, 28);
            this.pbmostrar.TabIndex = 12;
            this.pbmostrar.TabStop = false;
            this.pbmostrar.Click += new System.EventHandler(this.Pbmostrar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVolver.BackgroundImage")));
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Location = new System.Drawing.Point(31, 632);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(93, 85);
            this.btnVolver.TabIndex = 13;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // pantalla_iniciosesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.pbmostrar);
            this.Controls.Add(this.pbocultar);
            this.Controls.Add(this.btn_recupcontra);
            this.Controls.Add(this.btn_iniciarsesion);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.txt_nombre);
            this.DoubleBuffered = true;
            this.Name = "pantalla_iniciosesion";
            this.Text = "log in";
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
        private System.Windows.Forms.Button btnVolver;
    }
}