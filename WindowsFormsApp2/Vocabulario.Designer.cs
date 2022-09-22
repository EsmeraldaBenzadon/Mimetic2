namespace WindowsFormsApp2
{
    partial class Vocabulario
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
            this.NomUsu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NomUsu
            // 
            this.NomUsu.AutoSize = true;
            this.NomUsu.Location = new System.Drawing.Point(723, 22);
            this.NomUsu.Name = "NomUsu";
            this.NomUsu.Size = new System.Drawing.Size(35, 13);
            this.NomUsu.TabIndex = 0;
            this.NomUsu.Text = "label1";
            // 
            // Vocabulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NomUsu);
            this.Name = "Vocabulario";
            this.Text = "Vocabulario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NomUsu;
    }
}