using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class scroll : Form
    {
        string frases;
        string titulo;

        public scroll(string title)
        {
            InitializeComponent();
            this.titulo = title;
            lbl_titulo.Text = title;
        }

        private void Reproductor_Enter(object sender, EventArgs e)
        {
            string dirProyecto = AppContext.BaseDirectory;
            dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
            reproductor.URL = dirProyecto + "Letras\\" + frases + ".mp4";
            reproductor.Ctlcontrols.play();
        }

        private void BtnHOLA_Click(object sender, EventArgs e)
        {
            frases = "HOLA"; 
        }

        private void btnBuendia_Click(object sender, EventArgs e)
        {
            frases = "BUENDIA";
        }

        private void btnBuenosDias_Click(object sender, EventArgs e)
        {
            frases = "buenosdias";
        }

        private void btnBuenastardes_Click(object sender, EventArgs e)
        {
            frases = "BUENASTARDES";
        }

        private void btnBuenasnoches_Click(object sender, EventArgs e)
        {
            frases = "BUENASNOCHES";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frases = "COMOESTAS";
        }

        private void btnbien_Click(object sender, EventArgs e)
        {
            frases = "BIEN";
        }

        private void btnMaso_Click(object sender, EventArgs e)
        {
            frases = "MASOMENOS";
        }

        private void btnMal_Click(object sender, EventArgs e)
        {
            frases = "MAL";
        }

        private void scroll_Load(object sender, EventArgs e)
        {

        }

        private void btnBesos_Click(object sender, EventArgs e)
        {
            frases = "BESOSMEJILLAS";
        }

        private void btnGracias_Click(object sender, EventArgs e)
        {
            frases = "GRACIAS-MUCHASGRACIAS";
        }

        private void btnDenada_Click(object sender, EventArgs e)
        {
            frases = "DENADA-NOHAYDEQUE";
        }

        private void btnPerdon_Click(object sender, EventArgs e)
        {
            frases = "PERDON-DISCULPAS";
        }

        private void btnPermiso_Click(object sender, EventArgs e)
        {
            frases = "PERMISO";
        }

        private void btnMuybien_Click(object sender, EventArgs e)
        {
            frases = "MUYBIEN";
        }

        private void btnMuymal_Click(object sender, EventArgs e)
        {
            frases = "MUYMAL";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            voc_basico Nuevaventana = new voc_basico();//para pasar una variable a otro form 
            Nuevaventana.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            InitializeMyButton(1);

        }

        private void InitializeMyButton(int but)
        {
            //string nombre_boton = "button" + but.ToString();

            Button button = new Button();
            button.AutoSize = true;
            //button.Text = 
            //button.Location = new System.Drawing.Point();
            //flowLayoutPanel1.Controls.Add(button);
            button.Name = "button" + but;
            // this.Controls.Add(button);

            button.DialogResult = DialogResult.OK;
        }

    }
}
