
namespace WindowsFormsApp2
{
    partial class recuperar_contraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(recuperar_contraseña));
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_newcontra = new System.Windows.Forms.TextBox();
            this.txt_repnewcontra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.pbocultar_new = new System.Windows.Forms.PictureBox();
            this.pbocultar_rep = new System.Windows.Forms.PictureBox();
            this.pbmostrar_new = new System.Windows.Forms.PictureBox();
            this.pbmostrar_rep = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbocultar_new)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbocultar_rep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmostrar_new)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmostrar_rep)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(170)))), ((int)(((byte)(102)))));
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre.Location = new System.Drawing.Point(421, 210);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(0);
            this.txt_nombre.Multiline = true;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(543, 53);
            this.txt_nombre.TabIndex = 0;
            // 
            // txt_newcontra
            // 
            this.txt_newcontra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(170)))), ((int)(((byte)(102)))));
            this.txt_newcontra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_newcontra.Location = new System.Drawing.Point(421, 359);
            this.txt_newcontra.Margin = new System.Windows.Forms.Padding(2);
            this.txt_newcontra.Multiline = true;
            this.txt_newcontra.Name = "txt_newcontra";
            this.txt_newcontra.Size = new System.Drawing.Size(543, 53);
            this.txt_newcontra.TabIndex = 1;
            this.txt_newcontra.TextChanged += new System.EventHandler(this.Txt_newcontra_TextChanged);
            // 
            // txt_repnewcontra
            // 
            this.txt_repnewcontra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(170)))), ((int)(((byte)(102)))));
            this.txt_repnewcontra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_repnewcontra.Location = new System.Drawing.Point(421, 496);
            this.txt_repnewcontra.Margin = new System.Windows.Forms.Padding(2);
            this.txt_repnewcontra.Multiline = true;
            this.txt_repnewcontra.Name = "txt_repnewcontra";
            this.txt_repnewcontra.Size = new System.Drawing.Size(543, 53);
            this.txt_repnewcontra.TabIndex = 2;
            this.txt_repnewcontra.TextChanged += new System.EventHandler(this.Txt_repnewcontra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.boton_asignar_contraseña;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(532, 584);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(320, 63);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVolver.BackgroundImage")));
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Location = new System.Drawing.Point(25, 623);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(91, 85);
            this.btnVolver.TabIndex = 12;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // pbocultar_new
            // 
            this.pbocultar_new.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(170)))), ((int)(((byte)(102)))));
            this.pbocultar_new.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.ojo_tachado__1_;
            this.pbocultar_new.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbocultar_new.Location = new System.Drawing.Point(912, 369);
            this.pbocultar_new.Name = "pbocultar_new";
            this.pbocultar_new.Size = new System.Drawing.Size(37, 32);
            this.pbocultar_new.TabIndex = 13;
            this.pbocultar_new.TabStop = false;
            this.pbocultar_new.Click += new System.EventHandler(this.Pbocultar_new_Click);
            // 
            // pbocultar_rep
            // 
            this.pbocultar_rep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(170)))), ((int)(((byte)(102)))));
            this.pbocultar_rep.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.ojo_tachado__1_;
            this.pbocultar_rep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbocultar_rep.Location = new System.Drawing.Point(912, 506);
            this.pbocultar_rep.Name = "pbocultar_rep";
            this.pbocultar_rep.Size = new System.Drawing.Size(37, 32);
            this.pbocultar_rep.TabIndex = 14;
            this.pbocultar_rep.TabStop = false;
            this.pbocultar_rep.Click += new System.EventHandler(this.Pbocultar_rep_Click);
            // 
            // pbmostrar_new
            // 
            this.pbmostrar_new.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(170)))), ((int)(((byte)(102)))));
            this.pbmostrar_new.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.ojo;
            this.pbmostrar_new.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbmostrar_new.Location = new System.Drawing.Point(912, 369);
            this.pbmostrar_new.Name = "pbmostrar_new";
            this.pbmostrar_new.Size = new System.Drawing.Size(37, 32);
            this.pbmostrar_new.TabIndex = 15;
            this.pbmostrar_new.TabStop = false;
            this.pbmostrar_new.Click += new System.EventHandler(this.Pbmostrar_new_Click);
            // 
            // pbmostrar_rep
            // 
            this.pbmostrar_rep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(170)))), ((int)(((byte)(102)))));
            this.pbmostrar_rep.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.ojo;
            this.pbmostrar_rep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbmostrar_rep.Location = new System.Drawing.Point(912, 506);
            this.pbmostrar_rep.Name = "pbmostrar_rep";
            this.pbmostrar_rep.Size = new System.Drawing.Size(37, 32);
            this.pbmostrar_rep.TabIndex = 16;
            this.pbmostrar_rep.TabStop = false;
            this.pbmostrar_rep.Click += new System.EventHandler(this.Pbmostrar_rep_Click);
            // 
            // recuperar_contraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.recuperar_contraseña__olvide_mi_contraseña_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.pbmostrar_rep);
            this.Controls.Add(this.pbmostrar_new);
            this.Controls.Add(this.pbocultar_rep);
            this.Controls.Add(this.pbocultar_new);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_repnewcontra);
            this.Controls.Add(this.txt_newcontra);
            this.Controls.Add(this.txt_nombre);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "recuperar_contraseña";
            this.Text = "recuperar_contraseña";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.recuperar_contraseña_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbocultar_new)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbocultar_rep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmostrar_new)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmostrar_rep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_newcontra;
        private System.Windows.Forms.TextBox txt_repnewcontra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.PictureBox pbocultar_new;
        private System.Windows.Forms.PictureBox pbocultar_rep;
        private System.Windows.Forms.PictureBox pbmostrar_new;
        private System.Windows.Forms.PictureBox pbmostrar_rep;
    }
}