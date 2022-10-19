namespace WindowsFormsApp2
{
    partial class quizgame
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.NomUsu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.Location = new System.Drawing.Point(158, 345);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(390, 44);
            this.lblQuestion.TabIndex = 2;
            this.lblQuestion.Text = "¿CUAL ES LA CORRECTA?";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 61);
            this.button1.TabIndex = 3;
            this.button1.Tag = "1";
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.checkAswerEvent);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(402, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(253, 61);
            this.button2.TabIndex = 4;
            this.button2.Tag = "2";
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.checkAswerEvent);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(27, 476);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(253, 61);
            this.button3.TabIndex = 5;
            this.button3.Tag = "3";
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.checkAswerEvent);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(402, 476);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(253, 61);
            this.button4.TabIndex = 6;
            this.button4.Tag = "4";
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.checkAswerEvent);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(27, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(648, 330);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // NomUsu
            // 
            this.NomUsu.AutoSize = true;
            this.NomUsu.Location = new System.Drawing.Point(682, 13);
            this.NomUsu.Name = "NomUsu";
            this.NomUsu.Size = new System.Drawing.Size(35, 13);
            this.NomUsu.TabIndex = 7;
            this.NomUsu.Text = "label1";
            // 
            // quizgame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 549);
            this.Controls.Add(this.NomUsu);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.pictureBox2);
            this.Name = "quizgame";
            this.Text = "quizgame";
            this.Load += new System.EventHandler(this.Quizgame_Load);
            this.Click += new System.EventHandler(this.checkAswerEvent);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label NomUsu;
    }
}