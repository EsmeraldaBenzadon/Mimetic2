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
        string fraces;
        public familia()
        {
            InitializeComponent();
        }

        private void reproductor_Enter(object sender, EventArgs e)
        {
            string dirProyecto = AppContext.BaseDirectory;
            dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
            reproductor.URL = dirProyecto + "Letras\\" + fraces + ".mp4";
            reproductor.Ctlcontrols.play();
        }

        private void btnMama_Click(object sender, EventArgs e)
        {
            fraces = "buenosdias";
        }

        private void btnpadrastro_Click(object sender, EventArgs e)
        {
            fraces = "buenas noches";
        }

        private void btnmadrastra_Click(object sender, EventArgs e)
        {
            fraces = "¿como estas?";
        }

        private void btnhijo_Click(object sender, EventArgs e)
        {
            fraces = "BIEN";
        }

        private void btnhija_Click(object sender, EventArgs e)
        {
            fraces = "mas o menos";
        }

        private void btnbebe_Click(object sender, EventArgs e)
        {
            fraces = "besos";
        }

        private void btnhermanos_Click(object sender, EventArgs e)
        {
            fraces = "gracias"; 
        }

        private void btnHERMANO_Click(object sender, EventArgs e)
        {
            fraces = "buen dia";
        }

        private void btnHermana_Click(object sender, EventArgs e)
        {
            fraces = "buenas tardes";
        }

        private void btnmellizos_Click(object sender, EventArgs e)
        {
            fraces = "¿que tal?";
        }

        private void btngemelos_Click(object sender, EventArgs e)
        {
            fraces = "muy bien";
        }

        private void btnabuelo_Click(object sender, EventArgs e)
        {
            fraces = "todo bien";
        }

        private void btnabuela_Click(object sender, EventArgs e)
        {
            fraces = "muy mal";
        }

        private void btnieto_Click(object sender, EventArgs e)
        {
            fraces = "mal";
        }

        private void btnNieta_Click(object sender, EventArgs e)
        {
            fraces = "de nada";
        }

        private void btnPrimo_Click(object sender, EventArgs e)
        {
            fraces = "no hay de que";
        }

        private void btnPrima_Click(object sender, EventArgs e)
        {
            fraces = "perdon";
        }

        private void btnSobrino_Click(object sender, EventArgs e)
        {
            fraces = "permiso";
        }


        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            //bienvenidos Nuevaventana = new bienvenidos(this.nombreusuario);
            //Nuevaventana.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            fraces = "hola";
        }
    }
}
