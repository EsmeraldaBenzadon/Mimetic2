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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.btn_iniciarsesion = new System.Windows.Forms.Button();
            this.btn_recupcontra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(321, 82);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 2;
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Location = new System.Drawing.Point(321, 126);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(100, 20);
            this.txt_contraseña.TabIndex = 3;
            // 
            // btn_iniciarsesion
            // 
            this.btn_iniciarsesion.Location = new System.Drawing.Point(457, 107);
            this.btn_iniciarsesion.Name = "btn_iniciarsesion";
            this.btn_iniciarsesion.Size = new System.Drawing.Size(119, 32);
            this.btn_iniciarsesion.TabIndex = 4;
            this.btn_iniciarsesion.Text = "INICIAR SESION";
            this.btn_iniciarsesion.UseVisualStyleBackColor = true;
            this.btn_iniciarsesion.Click += new System.EventHandler(this.Btn_iniciarsesion_Click);
            // 
            // btn_recupcontra
            // 
            this.btn_recupcontra.Location = new System.Drawing.Point(583, 107);
            this.btn_recupcontra.Name = "btn_recupcontra";
            this.btn_recupcontra.Size = new System.Drawing.Size(145, 23);
            this.btn_recupcontra.TabIndex = 5;
            this.btn_recupcontra.Text = "Recuperar contarseña";
            this.btn_recupcontra.UseVisualStyleBackColor = true;
            // 
            // pantalla_iniciosesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_recupcontra);
            this.Controls.Add(this.btn_iniciarsesion);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "pantalla_iniciosesion";
            this.Text = "pantalla_iniciosesion";
            this.Load += new System.EventHandler(this.Pantalla_iniciosesion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.Button btn_iniciarsesion;
        private System.Windows.Forms.Button btn_recupcontra;
    }
}