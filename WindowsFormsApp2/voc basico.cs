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
    public partial class voc_basico : Form
    {

        public string titulo;
        public string nombreusuario;

        public voc_basico(string nombre)
        {
            InitializeComponent();
            this.nombreusuario = nombre;
            NomUsu.Text = nombre;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            titulo = "Meses";
            meses Nuevaventana = new meses(nombreusuario);//para pasar una variable a otro form 
            Nuevaventana.Show();
        }

        private void btn_familia_Click(object sender, EventArgs e)
        {
            this.Hide();
            titulo = "Familia";
            scroll Nuevaventana = new scroll(nombreusuario);//para pasar una variable a otro form 
            Nuevaventana.Show();
        }

        private void btn_dias_Click(object sender, EventArgs e)
        {
            this.Hide();
            titulo = "dias";
            diasdelasemana Nuevaventana = new diasdelasemana(nombreusuario);//para pasar una variable a otro form 
            Nuevaventana.Show();
        }

        private void btn_numeros_Click(object sender, EventArgs e)
        {
            this.Hide();
            titulo = "numeros";
            numeros Nuevaventana = new numeros (nombreusuario);//para pasar una variable a otro form 
            Nuevaventana.Show();
        }

        private void btn_verbos_Click(object sender, EventArgs e)
        {
            this.Hide();
            titulo = "verbos";
            verbos Nuevaventana = new verbos(nombreusuario);//para pasar una variable a otro form 
            Nuevaventana.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            bienvenidos Nuevaventana = new bienvenidos(this.nombreusuario);
            Nuevaventana.Show();
        }

        private void Voc_basico_Load(object sender, EventArgs e)
        {

        }
    }
}
