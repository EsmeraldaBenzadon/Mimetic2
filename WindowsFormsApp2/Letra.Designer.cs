namespace WindowsFormsApp2
{
    partial class Letra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Letra));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbl_letra = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.player = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1_FileOk);
            // 
            // lbl_letra
            // 
            this.lbl_letra.AutoSize = true;
            this.lbl_letra.BackColor = System.Drawing.Color.Transparent;
            this.lbl_letra.Font = new System.Drawing.Font("Ebrima", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_letra.Location = new System.Drawing.Point(645, 32);
            this.lbl_letra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_letra.Name = "lbl_letra";
            this.lbl_letra.Size = new System.Drawing.Size(117, 128);
            this.lbl_letra.TabIndex = 1;
            this.lbl_letra.Text = "A";
            this.lbl_letra.Click += new System.EventHandler(this.Lbl_letra_Click);
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
            this.btnVolver.Location = new System.Drawing.Point(26, 623);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(86, 83);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // player
            // 
            this.player.Location = new System.Drawing.Point(383, 251);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(640, 360);
            this.player.TabIndex = 3;
            this.player.TabStop = false;
            // 
            // Letra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.player);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lbl_letra);
            this.DoubleBuffered = true;
            this.Name = "Letra";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Letra_Load);
            this.Shown += new System.EventHandler(this.Letra_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lbl_letra;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.PictureBox player;
    }
}