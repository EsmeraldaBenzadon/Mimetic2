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
    public partial class menujuegos2 : Form
    {
        public string NombreUsu;
        public menujuegos2(string nombre)
        {
            InitializeComponent();
            NomUsu.Text = nombre;
            this.NombreUsu = nombre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ABC2 Nuevaventana = new ABC2(this.NombreUsu);
            Nuevaventana.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            nivelesmemotest Nuevaventana = new nivelesmemotest(this.NombreUsu);
            Nuevaventana.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            quizgame Nuevaventana = new quizgame(this.NombreUsu);
            Nuevaventana.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            bienvenidos Nuevaventana = new bienvenidos(this.NombreUsu);
            Nuevaventana.Show();
        }

        private void NomUsu_Click(object sender, EventArgs e)
        {

        }
    }
}
