namespace WindowsFormsApp2
{
    partial class scroll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(scroll));
            this.btnHOLA = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.reproductor = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.reproductor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHOLA
            // 
            this.btnHOLA.Location = new System.Drawing.Point(29, 95);
            this.btnHOLA.Name = "btnHOLA";
            this.btnHOLA.Size = new System.Drawing.Size(75, 34);
            this.btnHOLA.TabIndex = 0;
            this.btnHOLA.Text = "HOLA";
            this.btnHOLA.UseVisualStyleBackColor = true;
            this.btnHOLA.Click += new System.EventHandler(this.BtnHOLA_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // reproductor
            // 
            this.reproductor.Enabled = true;
            this.reproductor.Location = new System.Drawing.Point(163, 35);
            this.reproductor.Name = "reproductor";
            this.reproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("reproductor.OcxState")));
            this.reproductor.Size = new System.Drawing.Size(497, 285);
            this.reproductor.TabIndex = 2;
            this.reproductor.Enter += new System.EventHandler(this.Reproductor_Enter);
            // 
            // scroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reproductor);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnHOLA);
            this.Name = "scroll";
            this.Text = "scroll";
            ((System.ComponentModel.ISupportInitialize)(this.reproductor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHOLA;
        private System.Windows.Forms.Button button2;
        private AxWMPLib.AxWindowsMediaPlayer reproductor;
    }
}