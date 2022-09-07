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
            this.txt_repetir.Location = new System.Drawing.Point(213, 295);
            this.txt_repetir.Multiline = true;
            this.txt_repetir.Name = "txt_repetir";
            this.txt_repetir.Size = new System.Drawing.Size(246, 36);
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
            this.btnRegistrarse.Location = new System.Drawing.Point(289, 351);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(234, 48);
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
            this.txt_contraseña.Location = new System.Drawing.Point(213, 207);
            this.txt_contraseña.Multiline = true;
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(246, 36);
            this.txt_contraseña.TabIndex = 5;
            this.txt_contraseña.TextChanged += new System.EventHandler(this.Txt_contraseña_TextChanged);
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(170)))), ((int)(((byte)(102)))));
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.ForeColor = System.Drawing.Color.Black;
            this.txt_nombre.Location = new System.Drawing.Point(213, 121);
            this.txt_nombre.Multiline = true;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(246, 36);
            this.txt_nombre.TabIndex = 6;
            // 
            // Crearcuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.txt_repetir);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Crearcuenta";
            this.Text = "Crearcuenta";
            this.Load += new System.EventHandler(this.Crearcuenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_repetir;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.TextBox txt_nombre;
    }
}