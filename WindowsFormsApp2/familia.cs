﻿using System;
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
            //string dirProyecto = AppContext.BaseDirectory;
            //dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
            //reproductor.URL = dirProyecto + "Letras\\" + fraces + ".mp4";
            //reproductor.Ctlcontrols.play();
        }

        private void btnMama_Click(object sender, EventArgs e)
        {
            fraces = "buenosdias";
            string dirProyecto = AppContext.BaseDirectory;
            dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
            player.Image = Image.FromFile(dirProyecto + "Letras\\" + fraces + ".gif");
            player.Show();

        }

        private void btnpadrastro_Click(object sender, EventArgs e)
        {
            fraces = "BUENASNOCHES";
            string dirProyecto = AppContext.BaseDirectory;
            dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
            player.Image = Image.FromFile(dirProyecto + "Letras\\" + fraces + ".gif");
            player.Show();
        }

        private void btnmadrastra_Click(object sender, EventArgs e)
        {
            fraces = "COMOESTAS";
            string dirProyecto = AppContext.BaseDirectory;
            dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
            player.Image = Image.FromFile(dirProyecto + "Letras\\" + fraces + ".gif");
            player.Show();
        }

        private void btnhijo_Click(object sender, EventArgs e)
        {
            fraces = "BIEN";
            string dirProyecto = AppContext.BaseDirectory;
            dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
            player.Image = Image.FromFile(dirProyecto + "Letras\\" + fraces + ".gif");
            player.Show();
        }

        private void btnhija_Click(object sender, EventArgs e)
        {
            fraces = "masomenos2";
            string dirProyecto = AppContext.BaseDirectory;
            dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
            player.Image = Image.FromFile(dirProyecto + "Letras\\" + fraces + ".gif");
            player.Show();
        }

        private void btnbebe_Click(object sender, EventArgs e)
        {
            fraces = "BESOSMEJILLAS";
            string dirProyecto = AppContext.BaseDirectory;
            dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
            player.Image = Image.FromFile(dirProyecto + "Letras\\" + fraces + ".gif");
            player.Show();
        }

        private void btnhermanos_Click(object sender, EventArgs e)
        {
            fraces = "gracias";
            string dirProyecto = AppContext.BaseDirectory;
            dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
            player.Image = Image.FromFile(dirProyecto + "Letras\\" + fraces + ".gif");
            player.Show();
        }

        private void btnHERMANO_Click(object sender, EventArgs e)
        {
            fraces = "BUENDIA";
            string dirProyecto = AppContext.BaseDirectory;
            dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
            player.Image = Image.FromFile(dirProyecto + "Letras\\" + fraces + ".gif");
            player.Show();
        }

        private void btnHermana_Click(object sender, EventArgs e)
        {
            fraces = "BUENASTARDES";
            string dirProyecto = AppContext.BaseDirectory;
            dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
            player.Image = Image.FromFile(dirProyecto + "Letras\\" + fraces + ".gif");
            player.Show();
        }

        private void btnmellizos_Click(object sender, EventArgs e)
        {
            fraces = "QUETAL";
            string dirProyecto = AppContext.BaseDirectory;
            dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
            player.Image = Image.FromFile(dirProyecto + "Letras\\" + fraces + ".gif");
            player.Show();
        }

        private void btngemelos_Click(object sender, EventArgs e)
        {
            fraces = "MUYBIEN";
            string dirProyecto = AppContext.BaseDirectory;
            dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
            player.Image = Image.FromFile(dirProyecto + "Letras\\" + fraces + ".gif");
            player.Show();
        }

        private void btnabuelo_Click(object sender, EventArgs e)
        {
            fraces = "TODOBIEN";
            string dirProyecto = AppContext.BaseDirectory;
            dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
            player.Image = Image.FromFile(dirProyecto + "Letras\\" + fraces + ".gif");
            player.Show();
        }

        private void btnabuela_Click(object sender, EventArgs e)
        {
            fraces = "MUYMAL";
            string dirProyecto = AppContext.BaseDirectory;
            dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
            player.Image = Image.FromFile(dirProyecto + "Letras\\" + fraces + ".gif");
            player.Show();
        }

        private void btnieto_Click(object sender, EventArgs e)
        {
            fraces = "MAL";
            string dirProyecto = AppContext.BaseDirectory;
            dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
            player.Image = Image.FromFile(dirProyecto + "Letras\\" + fraces + ".gif");
            player.Show();
        }

        private void btnNieta_Click(object sender, EventArgs e)
        {
            fraces = "de nada";
            string dirProyecto = AppContext.BaseDirectory;
            dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
            player.Image = Image.FromFile(dirProyecto + "Letras\\" + fraces + ".gif");
            player.Show();
        }

        private void btnPrimo_Click(object sender, EventArgs e)
        {
            fraces = "no hay de que";
            string dirProyecto = AppContext.BaseDirectory;
            dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
            player.Image = Image.FromFile(dirProyecto + "Letras\\" + fraces + ".gif");
            player.Show();
        }

        private void btnPrima_Click(object sender, EventArgs e)
        {
            fraces = "PERDON-DISCULPAS";
            string dirProyecto = AppContext.BaseDirectory;
            dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
            player.Image = Image.FromFile(dirProyecto + "Letras\\" + fraces + ".gif");
            player.Show();
        }

        private void btnSobrino_Click(object sender, EventArgs e)
        {
            fraces = "PERMISO";
            string dirProyecto = AppContext.BaseDirectory;
            dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
            player.Image = Image.FromFile(dirProyecto + "Letras\\" + fraces + ".gif");
            player.Show();
        }


        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            //bienvenidos Nuevaventana = new bienvenidos(this.nombreusuario);
            //Nuevaventana.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            fraces = "HOLA";
            string dirProyecto = AppContext.BaseDirectory;
            dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
            player.Image = Image.FromFile(dirProyecto + "Letras\\" + fraces + ".gif");
            player.Show();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
