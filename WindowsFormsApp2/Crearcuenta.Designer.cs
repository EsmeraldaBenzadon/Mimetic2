namespace WindowsFormsApp2
{
    partial class Crearcuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crearcuenta));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_repetir = new System.Windows.Forms.TextBox();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.pbocultar = new System.Windows.Forms.PictureBox();
            this.pbocultar_rep = new System.Windows.Forms.PictureBox();
            this.pbmostrar = new System.Windows.Forms.PictureBox();
            this.pbmostrar_rep = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbocultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbocultar_rep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmostrar_rep)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // txt_repetir
            // 
            this.txt_repetir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(170)))), ((int)(((byte)(102)))));
            this.txt_repetir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_repetir.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.txt_repetir.ForeColor = System.Drawing.Color.Black;
            this.txt_repetir.Location = new System.Drawing.Point(362, 478);
            this.txt_repetir.Multiline = true;
            this.txt_repetir.Name = "txt_repetir";
            this.txt_repetir.Size = new System.Drawing.Size(640, 54);
            this.txt_repetir.TabIndex = 3;
            this.txt_repetir.TextChanged += new System.EventHandler(this.Txt_repetir_TextChanged);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrarse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegistrarse.BackgroundImage")));
            this.btnRegistrarse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistrarse.FlatAppearance.BorderSize = 0;
            this.btnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarse.Location = new System.Drawing.Point(484, 567);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(396, 78);
            this.btnRegistrarse.TabIndex = 4;
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.BtnRegistrarse_Click);
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(170)))), ((int)(((byte)(102)))));
            this.txt_contraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_contraseña.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F);
            this.txt_contraseña.ForeColor = System.Drawing.Color.Black;
            this.txt_contraseña.Location = new System.Drawing.Point(362, 337);
            this.txt_contraseña.Multiline = true;
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(640, 55);
            this.txt_contraseña.TabIndex = 5;
            this.txt_contraseña.TextChanged += new System.EventHandler(this.Txt_contraseña_TextChanged);
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(170)))), ((int)(((byte)(102)))));
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.ForeColor = System.Drawing.Color.Black;
            this.txt_nombre.Location = new System.Drawing.Point(362, 196);
            this.txt_nombre.Multiline = true;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(640, 60);
            this.txt_nombre.TabIndex = 6;
            // 
            // pbocultar
            // 
            this.pbocultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(170)))), ((int)(((byte)(102)))));
            this.pbocultar.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.ojo_tachado__1_;
            this.pbocultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbocultar.Location = new System.Drawing.Point(951, 347);
            this.pbocultar.Name = "pbocultar";
            this.pbocultar.Size = new System.Drawing.Size(37, 32);
            this.pbocultar.TabIndex = 7;
            this.pbocultar.TabStop = false;
            this.pbocultar.Click += new System.EventHandler(this.Pbocultar_Click);
            // 
            // pbocultar_rep
            // 
            this.pbocultar_rep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(170)))), ((int)(((byte)(102)))));
            this.pbocultar_rep.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.ojo_tachado__1_;
            this.pbocultar_rep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbocultar_rep.Location = new System.Drawing.Point(951, 486);
            this.pbocultar_rep.Name = "pbocultar_rep";
            this.pbocultar_rep.Size = new System.Drawing.Size(37, 32);
            this.pbocultar_rep.TabIndex = 8;
            this.pbocultar_rep.TabStop = false;
            this.pbocultar_rep.Click += new System.EventHandler(this.Pbocultar_rep_Click);
            // 
            // pbmostrar
            // 
            this.pbmostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(170)))), ((int)(((byte)(102)))));
            this.pbmostrar.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.ojo;
            this.pbmostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbmostrar.Location = new System.Drawing.Point(951, 347);
            this.pbmostrar.Name = "pbmostrar";
            this.pbmostrar.Size = new System.Drawing.Size(37, 32);
            this.pbmostrar.TabIndex = 9;
            this.pbmostrar.TabStop = false;
            this.pbmostrar.Click += new System.EventHandler(this.Pbmostrar_Click);
            // 
            // pbmostrar_rep
            // 
            this.pbmostrar_rep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(170)))), ((int)(((byte)(102)))));
            this.pbmostrar_rep.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.ojo;
            this.pbmostrar_rep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbmostrar_rep.Location = new System.Drawing.Point(951, 486);
            this.pbmostrar_rep.Name = "pbmostrar_rep";
            this.pbmostrar_rep.Size = new System.Drawing.Size(37, 32);
            this.pbmostrar_rep.TabIndex = 10;
            this.pbmostrar_rep.TabStop = false;
            this.pbmostrar_rep.Click += new System.EventHandler(this.Pbmostrar_rep_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVolver.BackgroundImage")));
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Location = new System.Drawing.Point(24, 647);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 70);
            this.btnVolver.TabIndex = 11;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Crearcuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.pbmostrar_rep);
            this.Controls.Add(this.pbmostrar);
            this.Controls.Add(this.pbocultar_rep);
            this.Controls.Add(this.pbocultar);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.txt_repetir);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Crearcuenta";
            this.Text = "Crearcuenta";
            this.Load += new System.EventHandler(this.Crearcuenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbocultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbocultar_rep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmostrar_rep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_repetir;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.PictureBox pbocultar;
        private System.Windows.Forms.PictureBox pbocultar_rep;
        private System.Windows.Forms.PictureBox pbmostrar;
        private System.Windows.Forms.PictureBox pbmostrar_rep;
        private System.Windows.Forms.Button btnVolver;
    }
}