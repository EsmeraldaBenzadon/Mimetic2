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
            this.btnBuendia = new System.Windows.Forms.Button();
            this.reproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnBuenosDias = new System.Windows.Forms.Button();
            this.btnBuenastardes = new System.Windows.Forms.Button();
            this.btnBuenasnoches = new System.Windows.Forms.Button();
            this.btnquetal = new System.Windows.Forms.Button();
            this.btnbien = new System.Windows.Forms.Button();
            this.btnMaso = new System.Windows.Forms.Button();
            this.btnMal = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBesos = new System.Windows.Forms.Button();
            this.btnGracias = new System.Windows.Forms.Button();
            this.btnDenada = new System.Windows.Forms.Button();
            this.btnPerdon = new System.Windows.Forms.Button();
            this.btnPermiso = new System.Windows.Forms.Button();
            this.btnMuybien = new System.Windows.Forms.Button();
            this.btnMuymal = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reproductor)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHOLA
            // 
            this.btnHOLA.Location = new System.Drawing.Point(3, 43);
            this.btnHOLA.Name = "btnHOLA";
            this.btnHOLA.Size = new System.Drawing.Size(109, 34);
            this.btnHOLA.TabIndex = 0;
            this.btnHOLA.Text = "HOLA";
            this.btnHOLA.UseVisualStyleBackColor = true;
            this.btnHOLA.Click += new System.EventHandler(this.BtnHOLA_Click);
            // 
            // btnBuendia
            // 
            this.btnBuendia.Location = new System.Drawing.Point(3, 3);
            this.btnBuendia.Name = "btnBuendia";
            this.btnBuendia.Size = new System.Drawing.Size(109, 34);
            this.btnBuendia.TabIndex = 1;
            this.btnBuendia.Text = "BUEN DÍA";
            this.btnBuendia.UseVisualStyleBackColor = true;
            this.btnBuendia.Click += new System.EventHandler(this.btnBuendia_Click);
            // 
            // reproductor
            // 
            this.reproductor.Enabled = true;
            this.reproductor.Location = new System.Drawing.Point(274, 121);
            this.reproductor.Name = "reproductor";
            this.reproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("reproductor.OcxState")));
            this.reproductor.Size = new System.Drawing.Size(497, 285);
            this.reproductor.TabIndex = 2;
            this.reproductor.Enter += new System.EventHandler(this.Reproductor_Enter);
            // 
            // btnBuenosDias
            // 
            this.btnBuenosDias.Location = new System.Drawing.Point(3, 83);
            this.btnBuenosDias.Name = "btnBuenosDias";
            this.btnBuenosDias.Size = new System.Drawing.Size(109, 34);
            this.btnBuenosDias.TabIndex = 3;
            this.btnBuenosDias.Text = "BUENOS DÍAS";
            this.btnBuenosDias.UseVisualStyleBackColor = true;
            this.btnBuenosDias.Click += new System.EventHandler(this.btnBuenosDias_Click);
            // 
            // btnBuenastardes
            // 
            this.btnBuenastardes.Location = new System.Drawing.Point(3, 123);
            this.btnBuenastardes.Name = "btnBuenastardes";
            this.btnBuenastardes.Size = new System.Drawing.Size(109, 34);
            this.btnBuenastardes.TabIndex = 4;
            this.btnBuenastardes.Text = "BUENAS TARDES";
            this.btnBuenastardes.UseVisualStyleBackColor = true;
            this.btnBuenastardes.Click += new System.EventHandler(this.btnBuenastardes_Click);
            // 
            // btnBuenasnoches
            // 
            this.btnBuenasnoches.Location = new System.Drawing.Point(3, 163);
            this.btnBuenasnoches.Name = "btnBuenasnoches";
            this.btnBuenasnoches.Size = new System.Drawing.Size(109, 34);
            this.btnBuenasnoches.TabIndex = 5;
            this.btnBuenasnoches.Text = "BUENAS NOCHES";
            this.btnBuenasnoches.UseVisualStyleBackColor = true;
            this.btnBuenasnoches.Click += new System.EventHandler(this.btnBuenasnoches_Click);
            // 
            // btnquetal
            // 
            this.btnquetal.Location = new System.Drawing.Point(3, 203);
            this.btnquetal.Name = "btnquetal";
            this.btnquetal.Size = new System.Drawing.Size(109, 34);
            this.btnquetal.TabIndex = 6;
            this.btnquetal.Text = "¿CÓMO ESTAS?";
            this.btnquetal.UseVisualStyleBackColor = true;
            this.btnquetal.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnbien
            // 
            this.btnbien.Location = new System.Drawing.Point(3, 243);
            this.btnbien.Name = "btnbien";
            this.btnbien.Size = new System.Drawing.Size(109, 34);
            this.btnbien.TabIndex = 7;
            this.btnbien.Text = "BIEN";
            this.btnbien.UseVisualStyleBackColor = true;
            this.btnbien.Click += new System.EventHandler(this.btnbien_Click);
            // 
            // btnMaso
            // 
            this.btnMaso.Location = new System.Drawing.Point(3, 283);
            this.btnMaso.Name = "btnMaso";
            this.btnMaso.Size = new System.Drawing.Size(75, 34);
            this.btnMaso.TabIndex = 8;
            this.btnMaso.Text = "MÁS O MENOS ";
            this.btnMaso.UseVisualStyleBackColor = true;
            this.btnMaso.Click += new System.EventHandler(this.btnMaso_Click);
            // 
            // btnMal
            // 
            this.btnMal.Location = new System.Drawing.Point(3, 323);
            this.btnMal.Name = "btnMal";
            this.btnMal.Size = new System.Drawing.Size(75, 34);
            this.btnMal.TabIndex = 9;
            this.btnMal.Text = "MAL";
            this.btnMal.UseVisualStyleBackColor = true;
            this.btnMal.Click += new System.EventHandler(this.btnMal_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.btnBuendia);
            this.flowLayoutPanel1.Controls.Add(this.btnHOLA);
            this.flowLayoutPanel1.Controls.Add(this.btnBuenosDias);
            this.flowLayoutPanel1.Controls.Add(this.btnBuenastardes);
            this.flowLayoutPanel1.Controls.Add(this.btnBuenasnoches);
            this.flowLayoutPanel1.Controls.Add(this.btnquetal);
            this.flowLayoutPanel1.Controls.Add(this.btnbien);
            this.flowLayoutPanel1.Controls.Add(this.btnMaso);
            this.flowLayoutPanel1.Controls.Add(this.btnMal);
            this.flowLayoutPanel1.Controls.Add(this.btnBesos);
            this.flowLayoutPanel1.Controls.Add(this.btnGracias);
            this.flowLayoutPanel1.Controls.Add(this.btnDenada);
            this.flowLayoutPanel1.Controls.Add(this.btnPerdon);
            this.flowLayoutPanel1.Controls.Add(this.btnPermiso);
            this.flowLayoutPanel1.Controls.Add(this.btnMuybien);
            this.flowLayoutPanel1.Controls.Add(this.btnMuymal);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 25);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(143, 400);
            this.flowLayoutPanel1.TabIndex = 10;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // btnBesos
            // 
            this.btnBesos.Location = new System.Drawing.Point(3, 363);
            this.btnBesos.Name = "btnBesos";
            this.btnBesos.Size = new System.Drawing.Size(75, 34);
            this.btnBesos.TabIndex = 10;
            this.btnBesos.Text = "BESOS";
            this.btnBesos.UseVisualStyleBackColor = true;
            this.btnBesos.Click += new System.EventHandler(this.btnBesos_Click);
            // 
            // btnGracias
            // 
            this.btnGracias.Location = new System.Drawing.Point(3, 403);
            this.btnGracias.Name = "btnGracias";
            this.btnGracias.Size = new System.Drawing.Size(75, 49);
            this.btnGracias.TabIndex = 11;
            this.btnGracias.Text = "GRACIAS Y MUCHAS GRACIAS";
            this.btnGracias.UseVisualStyleBackColor = true;
            this.btnGracias.Click += new System.EventHandler(this.btnGracias_Click);
            // 
            // btnDenada
            // 
            this.btnDenada.Location = new System.Drawing.Point(3, 458);
            this.btnDenada.Name = "btnDenada";
            this.btnDenada.Size = new System.Drawing.Size(75, 34);
            this.btnDenada.TabIndex = 12;
            this.btnDenada.Text = "DE NADA";
            this.btnDenada.UseVisualStyleBackColor = true;
            this.btnDenada.Click += new System.EventHandler(this.btnDenada_Click);
            // 
            // btnPerdon
            // 
            this.btnPerdon.Location = new System.Drawing.Point(3, 498);
            this.btnPerdon.Name = "btnPerdon";
            this.btnPerdon.Size = new System.Drawing.Size(75, 34);
            this.btnPerdon.TabIndex = 11;
            this.btnPerdon.Text = "PERDÓN";
            this.btnPerdon.UseVisualStyleBackColor = true;
            this.btnPerdon.Click += new System.EventHandler(this.btnPerdon_Click);
            // 
            // btnPermiso
            // 
            this.btnPermiso.Location = new System.Drawing.Point(3, 538);
            this.btnPermiso.Name = "btnPermiso";
            this.btnPermiso.Size = new System.Drawing.Size(75, 34);
            this.btnPermiso.TabIndex = 13;
            this.btnPermiso.Text = "PERMISO";
            this.btnPermiso.UseVisualStyleBackColor = true;
            this.btnPermiso.Click += new System.EventHandler(this.btnPermiso_Click);
            // 
            // btnMuybien
            // 
            this.btnMuybien.Location = new System.Drawing.Point(3, 578);
            this.btnMuybien.Name = "btnMuybien";
            this.btnMuybien.Size = new System.Drawing.Size(75, 34);
            this.btnMuybien.TabIndex = 14;
            this.btnMuybien.Text = "MUY BIEN";
            this.btnMuybien.UseVisualStyleBackColor = true;
            this.btnMuybien.Click += new System.EventHandler(this.btnMuybien_Click);
            // 
            // btnMuymal
            // 
            this.btnMuymal.Location = new System.Drawing.Point(3, 618);
            this.btnMuymal.Name = "btnMuymal";
            this.btnMuymal.Size = new System.Drawing.Size(75, 34);
            this.btnMuymal.TabIndex = 15;
            this.btnMuymal.Text = "MUY MAL";
            this.btnMuymal.UseVisualStyleBackColor = true;
            this.btnMuymal.Click += new System.EventHandler(this.btnMuymal_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Location = new System.Drawing.Point(401, 49);
            this.lbl_titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(45, 13);
            this.lbl_titulo.TabIndex = 11;
            this.lbl_titulo.Text = "lbl_titulo";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVolver.BackgroundImage")));
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Location = new System.Drawing.Point(553, 253);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 66);
            this.btnVolver.TabIndex = 12;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // scroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.reproductor);
            this.Name = "scroll";
            this.Text = "scroll";
            this.Load += new System.EventHandler(this.scroll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reproductor)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHOLA;
        private System.Windows.Forms.Button btnBuendia;
        private AxWMPLib.AxWindowsMediaPlayer reproductor;
        private System.Windows.Forms.Button btnBuenosDias;
        private System.Windows.Forms.Button btnBuenastardes;
        private System.Windows.Forms.Button btnBuenasnoches;
        private System.Windows.Forms.Button btnquetal;
        private System.Windows.Forms.Button btnbien;
        private System.Windows.Forms.Button btnMaso;
        private System.Windows.Forms.Button btnMal;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnBesos;
        private System.Windows.Forms.Button btnGracias;
        private System.Windows.Forms.Button btnDenada;
        private System.Windows.Forms.Button btnPerdon;
        private System.Windows.Forms.Button btnPermiso;
        private System.Windows.Forms.Button btnMuybien;
        private System.Windows.Forms.Button btnMuymal;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btnVolver;
    }
}