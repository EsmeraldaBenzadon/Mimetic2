
namespace WindowsFormsApp2
{
    partial class familia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(familia));
            this.reproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPapa = new System.Windows.Forms.Button();
            this.btnHERMANO = new System.Windows.Forms.Button();
            this.btnMama = new System.Windows.Forms.Button();
            this.btnHermana = new System.Windows.Forms.Button();
            this.btnpadrastro = new System.Windows.Forms.Button();
            this.btnmellizos = new System.Windows.Forms.Button();
            this.btnmadrastra = new System.Windows.Forms.Button();
            this.btngemelos = new System.Windows.Forms.Button();
            this.btnhijo = new System.Windows.Forms.Button();
            this.btnabuelo = new System.Windows.Forms.Button();
            this.btnhija = new System.Windows.Forms.Button();
            this.btnDenada = new System.Windows.Forms.Button();
            this.btnbebe = new System.Windows.Forms.Button();
            this.btnPermiso = new System.Windows.Forms.Button();
            this.btnhermanos = new System.Windows.Forms.Button();
            this.btnMuymal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reproductor)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reproductor
            // 
            this.reproductor.Enabled = true;
            this.reproductor.Location = new System.Drawing.Point(270, 66);
            this.reproductor.Margin = new System.Windows.Forms.Padding(4);
            this.reproductor.Name = "reproductor";
            this.reproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("reproductor.OcxState")));
            this.reproductor.Size = new System.Drawing.Size(497, 285);
            this.reproductor.TabIndex = 3;
            this.reproductor.Enter += new System.EventHandler(this.reproductor_Enter);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnPapa);
            this.flowLayoutPanel1.Controls.Add(this.btnHERMANO);
            this.flowLayoutPanel1.Controls.Add(this.btnMama);
            this.flowLayoutPanel1.Controls.Add(this.btnHermana);
            this.flowLayoutPanel1.Controls.Add(this.btnpadrastro);
            this.flowLayoutPanel1.Controls.Add(this.btnmellizos);
            this.flowLayoutPanel1.Controls.Add(this.btnmadrastra);
            this.flowLayoutPanel1.Controls.Add(this.btngemelos);
            this.flowLayoutPanel1.Controls.Add(this.btnhijo);
            this.flowLayoutPanel1.Controls.Add(this.btnabuelo);
            this.flowLayoutPanel1.Controls.Add(this.btnhija);
            this.flowLayoutPanel1.Controls.Add(this.btnDenada);
            this.flowLayoutPanel1.Controls.Add(this.btnbebe);
            this.flowLayoutPanel1.Controls.Add(this.btnPermiso);
            this.flowLayoutPanel1.Controls.Add(this.btnhermanos);
            this.flowLayoutPanel1.Controls.Add(this.btnMuymal);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(179, 426);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // btnPapa
            // 
            this.btnPapa.Location = new System.Drawing.Point(4, 4);
            this.btnPapa.Margin = new System.Windows.Forms.Padding(4);
            this.btnPapa.Name = "btnPapa";
            this.btnPapa.Size = new System.Drawing.Size(100, 42);
            this.btnPapa.TabIndex = 1;
            this.btnPapa.Text = "PAPÁ";
            this.btnPapa.UseVisualStyleBackColor = true;
            this.btnPapa.Click += new System.EventHandler(this.btnPapa_Click);
            // 
            // btnHERMANO
            // 
            this.btnHERMANO.Location = new System.Drawing.Point(4, 54);
            this.btnHERMANO.Margin = new System.Windows.Forms.Padding(4);
            this.btnHERMANO.Name = "btnHERMANO";
            this.btnHERMANO.Size = new System.Drawing.Size(100, 42);
            this.btnHERMANO.TabIndex = 0;
            this.btnHERMANO.Text = "HERMANO";
            this.btnHERMANO.UseVisualStyleBackColor = true;
            this.btnHERMANO.Click += new System.EventHandler(this.btnHERMANO_Click);
            // 
            // btnMama
            // 
            this.btnMama.Location = new System.Drawing.Point(4, 104);
            this.btnMama.Margin = new System.Windows.Forms.Padding(4);
            this.btnMama.Name = "btnMama";
            this.btnMama.Size = new System.Drawing.Size(100, 42);
            this.btnMama.TabIndex = 3;
            this.btnMama.Text = "MAMÁ";
            this.btnMama.UseVisualStyleBackColor = true;
            this.btnMama.Click += new System.EventHandler(this.btnMama_Click);
            // 
            // btnHermana
            // 
            this.btnHermana.Location = new System.Drawing.Point(4, 154);
            this.btnHermana.Margin = new System.Windows.Forms.Padding(4);
            this.btnHermana.Name = "btnHermana";
            this.btnHermana.Size = new System.Drawing.Size(100, 42);
            this.btnHermana.TabIndex = 4;
            this.btnHermana.Text = "HERMANA";
            this.btnHermana.UseVisualStyleBackColor = true;
            this.btnHermana.Click += new System.EventHandler(this.btnHermana_Click);
            // 
            // btnpadrastro
            // 
            this.btnpadrastro.Location = new System.Drawing.Point(4, 204);
            this.btnpadrastro.Margin = new System.Windows.Forms.Padding(4);
            this.btnpadrastro.Name = "btnpadrastro";
            this.btnpadrastro.Size = new System.Drawing.Size(105, 42);
            this.btnpadrastro.TabIndex = 5;
            this.btnpadrastro.Text = "PADRASTRO";
            this.btnpadrastro.UseVisualStyleBackColor = true;
            this.btnpadrastro.Click += new System.EventHandler(this.btnpadrastro_Click);
            // 
            // btnmellizos
            // 
            this.btnmellizos.Location = new System.Drawing.Point(4, 254);
            this.btnmellizos.Margin = new System.Windows.Forms.Padding(4);
            this.btnmellizos.Name = "btnmellizos";
            this.btnmellizos.Size = new System.Drawing.Size(100, 42);
            this.btnmellizos.TabIndex = 6;
            this.btnmellizos.Text = "MELLIZOS";
            this.btnmellizos.UseVisualStyleBackColor = true;
            this.btnmellizos.Click += new System.EventHandler(this.btnmellizos_Click);
            // 
            // btnmadrastra
            // 
            this.btnmadrastra.Location = new System.Drawing.Point(4, 304);
            this.btnmadrastra.Margin = new System.Windows.Forms.Padding(4);
            this.btnmadrastra.Name = "btnmadrastra";
            this.btnmadrastra.Size = new System.Drawing.Size(105, 42);
            this.btnmadrastra.TabIndex = 7;
            this.btnmadrastra.Text = "MADRASTRA";
            this.btnmadrastra.UseVisualStyleBackColor = true;
            this.btnmadrastra.Click += new System.EventHandler(this.btnmadrastra_Click);
            // 
            // btngemelos
            // 
            this.btngemelos.Location = new System.Drawing.Point(4, 354);
            this.btngemelos.Margin = new System.Windows.Forms.Padding(4);
            this.btngemelos.Name = "btngemelos";
            this.btngemelos.Size = new System.Drawing.Size(100, 42);
            this.btngemelos.TabIndex = 8;
            this.btngemelos.Text = "GEMELOS";
            this.btngemelos.UseVisualStyleBackColor = true;
            this.btngemelos.Click += new System.EventHandler(this.btngemelos_Click);
            // 
            // btnhijo
            // 
            this.btnhijo.Location = new System.Drawing.Point(4, 404);
            this.btnhijo.Margin = new System.Windows.Forms.Padding(4);
            this.btnhijo.Name = "btnhijo";
            this.btnhijo.Size = new System.Drawing.Size(100, 42);
            this.btnhijo.TabIndex = 9;
            this.btnhijo.Text = "HIJO";
            this.btnhijo.UseVisualStyleBackColor = true;
            this.btnhijo.Click += new System.EventHandler(this.btnhijo_Click);
            // 
            // btnabuelo
            // 
            this.btnabuelo.Location = new System.Drawing.Point(4, 454);
            this.btnabuelo.Margin = new System.Windows.Forms.Padding(4);
            this.btnabuelo.Name = "btnabuelo";
            this.btnabuelo.Size = new System.Drawing.Size(100, 42);
            this.btnabuelo.TabIndex = 10;
            this.btnabuelo.Text = "ABUELO";
            this.btnabuelo.UseVisualStyleBackColor = true;
            this.btnabuelo.Click += new System.EventHandler(this.btnabuelo_Click);
            // 
            // btnhija
            // 
            this.btnhija.Location = new System.Drawing.Point(4, 504);
            this.btnhija.Margin = new System.Windows.Forms.Padding(4);
            this.btnhija.Name = "btnhija";
            this.btnhija.Size = new System.Drawing.Size(100, 60);
            this.btnhija.TabIndex = 11;
            this.btnhija.Text = "HIJA";
            this.btnhija.UseVisualStyleBackColor = true;
            this.btnhija.Click += new System.EventHandler(this.btnhija_Click);
            // 
            // btnDenada
            // 
            this.btnDenada.Location = new System.Drawing.Point(4, 572);
            this.btnDenada.Margin = new System.Windows.Forms.Padding(4);
            this.btnDenada.Name = "btnDenada";
            this.btnDenada.Size = new System.Drawing.Size(100, 42);
            this.btnDenada.TabIndex = 12;
            this.btnDenada.Text = "DE NADA";
            this.btnDenada.UseVisualStyleBackColor = true;
            // 
            // btnbebe
            // 
            this.btnbebe.Location = new System.Drawing.Point(4, 622);
            this.btnbebe.Margin = new System.Windows.Forms.Padding(4);
            this.btnbebe.Name = "btnbebe";
            this.btnbebe.Size = new System.Drawing.Size(100, 42);
            this.btnbebe.TabIndex = 11;
            this.btnbebe.Text = "BEBÉ";
            this.btnbebe.UseVisualStyleBackColor = true;
            this.btnbebe.Click += new System.EventHandler(this.btnbebe_Click);
            // 
            // btnPermiso
            // 
            this.btnPermiso.Location = new System.Drawing.Point(4, 672);
            this.btnPermiso.Margin = new System.Windows.Forms.Padding(4);
            this.btnPermiso.Name = "btnPermiso";
            this.btnPermiso.Size = new System.Drawing.Size(100, 42);
            this.btnPermiso.TabIndex = 13;
            this.btnPermiso.Text = "PERMISO";
            this.btnPermiso.UseVisualStyleBackColor = true;
            // 
            // btnhermanos
            // 
            this.btnhermanos.Location = new System.Drawing.Point(4, 722);
            this.btnhermanos.Margin = new System.Windows.Forms.Padding(4);
            this.btnhermanos.Name = "btnhermanos";
            this.btnhermanos.Size = new System.Drawing.Size(100, 42);
            this.btnhermanos.TabIndex = 14;
            this.btnhermanos.Text = "HERMANOS";
            this.btnhermanos.UseVisualStyleBackColor = true;
            this.btnhermanos.Click += new System.EventHandler(this.btnhermanos_Click);
            // 
            // btnMuymal
            // 
            this.btnMuymal.Location = new System.Drawing.Point(4, 772);
            this.btnMuymal.Margin = new System.Windows.Forms.Padding(4);
            this.btnMuymal.Name = "btnMuymal";
            this.btnMuymal.Size = new System.Drawing.Size(100, 42);
            this.btnMuymal.TabIndex = 15;
            this.btnMuymal.Text = "MUY MAL";
            this.btnMuymal.UseVisualStyleBackColor = true;
            // 
            // familia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.reproductor);
            this.Name = "familia";
            this.Text = "familia";
            ((System.ComponentModel.ISupportInitialize)(this.reproductor)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer reproductor;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnPapa;
        private System.Windows.Forms.Button btnHERMANO;
        private System.Windows.Forms.Button btnMama;
        private System.Windows.Forms.Button btnHermana;
        private System.Windows.Forms.Button btnpadrastro;
        private System.Windows.Forms.Button btnmellizos;
        private System.Windows.Forms.Button btnmadrastra;
        private System.Windows.Forms.Button btngemelos;
        private System.Windows.Forms.Button btnhijo;
        private System.Windows.Forms.Button btnabuelo;
        private System.Windows.Forms.Button btnhija;
        private System.Windows.Forms.Button btnDenada;
        private System.Windows.Forms.Button btnbebe;
        private System.Windows.Forms.Button btnPermiso;
        private System.Windows.Forms.Button btnhermanos;
        private System.Windows.Forms.Button btnMuymal;
    }
}