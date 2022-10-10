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
            this.reproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbl_letra = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reproductor)).BeginInit();
            this.SuspendLayout();
            // 
            // reproductor
            // 
            this.reproductor.Enabled = true;
            this.reproductor.Location = new System.Drawing.Point(147, 158);
            this.reproductor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reproductor.Name = "reproductor";
            this.reproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("reproductor.OcxState")));
            this.reproductor.Size = new System.Drawing.Size(557, 304);
            this.reproductor.TabIndex = 0;
            this.reproductor.Enter += new System.EventHandler(this.AxWindowsMediaPlayer1_Enter);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1_FileOk);
            // 
            // lbl_letra
            // 
            this.lbl_letra.AutoSize = true;
            this.lbl_letra.Location = new System.Drawing.Point(525, 53);
            this.lbl_letra.Name = "lbl_letra";
            this.lbl_letra.Size = new System.Drawing.Size(51, 20);
            this.lbl_letra.TabIndex = 1;
            this.lbl_letra.Text = "label1";
            // 
            // Letra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1290, 754);
            this.Controls.Add(this.lbl_letra);
            this.Controls.Add(this.reproductor);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Letra";
            this.Load += new System.EventHandler(this.Letra_Load);
            this.Shown += new System.EventHandler(this.Letra_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.reproductor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer reproductor;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lbl_letra;
    }
}