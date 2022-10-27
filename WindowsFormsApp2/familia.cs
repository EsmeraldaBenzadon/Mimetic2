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
        public string nombreusuario;

        public familia(string nombreuser)
        {
            nombreusuario = nombreuser;
            InitializeComponent();
        }

        private void btnMama_Click(object sender, EventArgs e)
        {
            mostrarvideo("buenosdias");

        }

        private void btnpadrastro_Click(object sender, EventArgs e)
        {
            mostrarvideo("BUENASNOCHES");
        }

        private void btnmadrastra_Click(object sender, EventArgs e)
        {
            mostrarvideo("COMOESTAS");
        }

        private void btnhijo_Click(object sender, EventArgs e)
        {
            mostrarvideo("BIEN");
        }

        private void btnhija_Click(object sender, EventArgs e)
        {
            mostrarvideo("masomenos2");
        }

        private void btnbebe_Click(object sender, EventArgs e)
        {
            mostrarvideo("BESOSMEJILLAS");
        }

        private void btnhermanos_Click(object sender, EventArgs e)
        {
            mostrarvideo("gracias-muchasgracias");
        }

        private void btnHERMANO_Click(object sender, EventArgs e)
        {
            mostrarvideo("BUENDIA");
        }

        private void btnHermana_Click(object sender, EventArgs e)
        {
            mostrarvideo("BUENASTARDES");
        }

        private void btnmellizos_Click(object sender, EventArgs e)
        {
            mostrarvideo("QUETAL");
        }

        private void btngemelos_Click(object sender, EventArgs e)
        {
            mostrarvideo("MUYBIEN");
        }

        private void btnabuelo_Click(object sender, EventArgs e)
        {
            mostrarvideo("TODOBIEN");
        }

        private void btnabuela_Click(object sender, EventArgs e)
        {
            mostrarvideo("MUYMAL");
        }

        private void btnieto_Click(object sender, EventArgs e)
        {
            mostrarvideo("MAL");
        }

        private void btnNieta_Click(object sender, EventArgs e)
        {
            mostrarvideo("de nada");
        }

        private void btnPrimo_Click(object sender, EventArgs e)
        {
            mostrarvideo("no hay de que");
        }

        private void btnPrima_Click(object sender, EventArgs e)
        {
            mostrarvideo("PERDON-DISCULPAS");
        }

        private void btnSobrino_Click(object sender, EventArgs e)
        {
            mostrarvideo("PERMISO");
        }


        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            bienvenidos Nuevaventana = new bienvenidos(this.nombreusuario);
            Nuevaventana.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            mostrarvideo("HOLA");
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            mostrarvideo("losiento-lolamento");
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            fraces = "porejemplo";
            string dirProyecto = AppContext.BaseDirectory;
            dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
            player.Image = Image.FromFile(dirProyecto + "Letras\\" + fraces + ".gif");
            player.Show();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            fraces = "nombre";
            string dirProyecto = AppContext.BaseDirectory;
            dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
            player.Image = Image.FromFile(dirProyecto + "Letras\\" + fraces + ".gif");
            player.Show();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            fraces = "edad-o-cumpleaños";
            string dirProyecto = AppContext.BaseDirectory;
            dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
            player.Image = Image.FromFile(dirProyecto + "Letras\\" + fraces + ".gif");
            player.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            mostrarvideo("si");
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            fraces = "comotellamas";
            string dirProyecto = AppContext.BaseDirectory;
            dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
            player.Image = Image.FromFile(dirProyecto + "Letras\\" + fraces + ".gif");
            player.Show();
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            fraces = "repetir";
            string dirProyecto = AppContext.BaseDirectory;
            dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
            player.Image = Image.FromFile(dirProyecto + "Letras\\" + fraces + ".gif");
            player.Show();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            fraces = "felicidades-felicidades";
            string dirProyecto = AppContext.BaseDirectory;
            dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
            player.Image = Image.FromFile(dirProyecto + "Letras\\" + fraces + ".gif");
            player.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            fraces = "no";
            string dirProyecto = AppContext.BaseDirectory;
            dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
            player.Image = Image.FromFile(dirProyecto + "Letras\\" + fraces + ".gif");
            player.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            fraces = "porfavor";
            string dirProyecto = AppContext.BaseDirectory;
            dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
            player.Image = Image.FromFile(dirProyecto + "Letras\\" + fraces + ".gif");
            player.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            mostrarvideo("apellido");
        }

        private void mostrarvideo(string frase)
        {
            string dirProyecto = AppContext.BaseDirectory;
            dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
            player.Image = Image.FromFile(dirProyecto + "Letras\\" + frase + ".gif");
            player.Show();
        }
    }
}
