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
    public partial class bienvenidos : Form
    {
        public string nombreusuario;

        public bienvenidos(string nombre)
        {
            InitializeComponent();
            this.nombreusuario = nombre;
            NomUsu.Text = nombre;
        }

        private void Btnabc_Click(object sender, EventArgs e)
        {
            this.Hide();
            Abecedario Nuevaventana = new Abecedario(this.nombreusuario);
            Nuevaventana.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fondoinicio Nuevaventana = new Fondoinicio();
            Nuevaventana.Show();
        }

        private void BtnJugamos_Click(object sender, EventArgs e)
        {
            this.Hide();
            menujuegos2 Nuevaventana = new menujuegos2(this.nombreusuario);
            Nuevaventana.Show();
        }

        private void Bienvenidos_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btnvocabulario_Click(object sender, EventArgs e)
        {
            this.Hide();
            voc_basico Nuevaventana = new voc_basico(this.nombreusuario);
            Nuevaventana.Show();
        }

        private void Btnfrases_Click(object sender, EventArgs e)
        {
            this.Hide();
            familia Nuevaventana = new familia();
            Nuevaventana.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ABC2 Nuevaventana = new ABC2(this.nombreusuario);
            Nuevaventana.Show();
        }
    }
}
