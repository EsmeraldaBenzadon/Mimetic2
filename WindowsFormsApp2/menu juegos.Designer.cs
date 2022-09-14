namespace WindowsFormsApp2
{
    partial class menu_juegos
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
            this.abc = new System.Windows.Forms.Button();
            this.voc = new System.Windows.Forms.Button();
            this.frases = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // abc
            // 
            this.abc.Location = new System.Drawing.Point(166, 104);
            this.abc.Name = "abc";
            this.abc.Size = new System.Drawing.Size(75, 23);
            this.abc.TabIndex = 0;
            this.abc.Text = "ABC";
            this.abc.UseVisualStyleBackColor = true;
            this.abc.Click += new System.EventHandler(this.Abc_Click);
            // 
            // voc
            // 
            this.voc.Location = new System.Drawing.Point(343, 263);
            this.voc.Name = "voc";
            this.voc.Size = new System.Drawing.Size(104, 41);
            this.voc.TabIndex = 1;
            this.voc.Text = "Vocabulario especifico";
            this.voc.UseVisualStyleBackColor = true;
            // 
            // frases
            // 
            this.frases.Location = new System.Drawing.Point(520, 104);
            this.frases.Name = "frases";
            this.frases.Size = new System.Drawing.Size(96, 44);
            this.frases.TabIndex = 2;
            this.frases.Text = "Fraces cotidianas";
            this.frases.UseVisualStyleBackColor = true;
            // 
            // menu_juegos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.frases);
            this.Controls.Add(this.voc);
            this.Controls.Add(this.abc);
            this.Name = "menu_juegos";
            this.Text = "menu_juegos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button abc;
        private System.Windows.Forms.Button voc;
        private System.Windows.Forms.Button frases;
    }
}