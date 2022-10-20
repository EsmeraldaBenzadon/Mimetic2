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
    }
}
