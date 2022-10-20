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
    public partial class familia : Form
    {
        string famili;
        public familia()
        {
            InitializeComponent();
        }

        private void reproductor_Enter(object sender, EventArgs e)
        {
            string dirProyecto = AppContext.BaseDirectory;
            dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
            reproductor.URL = dirProyecto + "Letras\\" + famili + ".mp4";
            reproductor.Ctlcontrols.play();
        }

        private void btnPapa_Click(object sender, EventArgs e)
        {
            famili = "papa";
        }

        private void btnMama_Click(object sender, EventArgs e)
        {
            famili = "mama";
        }

        private void btnpadrastro_Click(object sender, EventArgs e)
        {
            famili = "padrastro";
        }

        private void btnmadrastra_Click(object sender, EventArgs e)
        {
            famili = "madrastra";
        }

        private void btnhijo_Click(object sender, EventArgs e)
        {
            famili = "hijo";
        }

        private void btnhija_Click(object sender, EventArgs e)
        {
            famili = "hija";
        }

        private void btnbebe_Click(object sender, EventArgs e)
        {
            famili = "bebe";
        }

        private void btnhermanos_Click(object sender, EventArgs e)
        {
            famili = "hermanos"; 
        }

        private void btnHERMANO_Click(object sender, EventArgs e)
        {
            famili = "hermano";
        }

        private void btnHermana_Click(object sender, EventArgs e)
        {
            famili = "hermana";
        }

        private void btnmellizos_Click(object sender, EventArgs e)
        {
            famili = "mellizos";
        }

        private void btngemelos_Click(object sender, EventArgs e)
        {
            famili = "gemelos";
        }

        private void btnabuelo_Click(object sender, EventArgs e)
        {
            famili = "abuelo";
        }

        private void btnabuela_Click(object sender, EventArgs e)
        {
            famili = "abuela";
        }

        private void btnieto_Click(object sender, EventArgs e)
        {
            famili = "nieto";
        }

        private void btnNieta_Click(object sender, EventArgs e)
        {
            famili = "nieta";
        }

        private void btnPrimo_Click(object sender, EventArgs e)
        {
            famili = "primo";
        }

        private void btnPrima_Click(object sender, EventArgs e)
        {
            famili = "prima";
        }

        private void btnSobrino_Click(object sender, EventArgs e)
        {
            famili = "sobrino";
        }

        private void btnSobrina_Click(object sender, EventArgs e)
        {
            famili = "sobrina";
        }

        private void btnCunado_Click(object sender, EventArgs e)
        {
            famili = "cuñado";
        }

        private void btnCunada_Click(object sender, EventArgs e)
        {
            famili = "cuñada";
        }

        private void btnTio_Click(object sender, EventArgs e)
        {
            famili = "tio";
        }

        private void btnSuegro_Click(object sender, EventArgs e)
        {
            famili = "suegro_a";
        }

        private void btnEsposo_Click(object sender, EventArgs e)
        {
            famili = "esposo";
        }

        private void btnMadrina_Click(object sender, EventArgs e)
        {
            famili = "Madrina";
        }

        private void btnPadrino_Click(object sender, EventArgs e)
        {
            famili = "padrino";
        }

        private void btnEsposa_Click(object sender, EventArgs e)
        {
            famili = "esposa";
        }

        private void btnNovios_Click(object sender, EventArgs e)
        {
            famili = "novios";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            famili = "novio";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            famili = "novia";
        }
    }
}
