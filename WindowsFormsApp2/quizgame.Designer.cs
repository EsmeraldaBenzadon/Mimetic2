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
            this.IblQuestion = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.prueba = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.prueba)).BeginInit();
            this.SuspendLayout();
            // 
            // IblQuestion
            // 
            this.IblQuestion.Location = new System.Drawing.Point(330, 228);
            this.IblQuestion.Name = "IblQuestion";
            this.IblQuestion.Size = new System.Drawing.Size(151, 21);
            this.IblQuestion.TabIndex = 1;
            this.IblQuestion.Text = "¿CUAL ES LA CORRECTA?";
            this.IblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IblQuestion.Click += new System.EventHandler(this.Label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(484, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 60);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(83, 346);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(222, 56);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(484, 346);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(224, 56);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // prueba
            // 
            this.prueba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prueba.Image = global::WindowsFormsApp2.Properties.Resources.inside_out_joy;
            this.prueba.Location = new System.Drawing.Point(41, 0);
            this.prueba.Name = "prueba";
            this.prueba.Size = new System.Drawing.Size(801, 215);
            this.prueba.TabIndex = 0;
            this.prueba.TabStop = false;
            this.prueba.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // quizgame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IblQuestion);
            this.Controls.Add(this.prueba);
            this.Name = "quizgame";
            this.Text = "quizgame";
            this.Click += new System.EventHandler(this.checkAnswerEvent);
            ((System.ComponentModel.ISupportInitialize)(this.prueba)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox prueba;
        private System.Windows.Forms.Label IblQuestion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}