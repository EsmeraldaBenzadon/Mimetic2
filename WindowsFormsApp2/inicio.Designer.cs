namespace WindowsFormsApp2
{
    partial class Fondoinicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fondoinicio));
            this.btnComenzar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnComenzar
            // 
            this.btnComenzar.BackColor = System.Drawing.Color.Transparent;
            this.btnComenzar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnComenzar.BackgroundImage")));
            this.btnComenzar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnComenzar.FlatAppearance.BorderSize = 0;
            this.btnComenzar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnComenzar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnComenzar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComenzar.Location = new System.Drawing.Point(498, 537);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(359, 121);
            this.btnComenzar.TabIndex = 0;
            this.btnComenzar.UseVisualStyleBackColor = false;
            this.btnComenzar.Click += new System.EventHandler(this.BtnComenzar_Click);
            // 
            // Fondoinicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btnComenzar);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.HelpButton = true;
            this.Name = "Fondoinicio";
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Fondoinicio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnComenzar;
    }
}

