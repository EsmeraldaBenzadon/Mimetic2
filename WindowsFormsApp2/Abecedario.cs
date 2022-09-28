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
    public partial class Abecedario : Form
    {

       public static string letras = "0";
        //variable publica usuario
        public string NombreUsu;

        public Abecedario(string nombre)
        {
            InitializeComponent();
            NomUsu.Text = nombre;
            this.NombreUsu = nombre;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            bienvenidos Nuevaventana = new bienvenidos (this.NombreUsu);
            Nuevaventana.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            letras = "A";
            Letra Nuevaventana = new Letra(letras);//para pasar una variable a otro form 
            Nuevaventana.Show();

        }

        private void BtnB_Click(object sender, EventArgs e)
        {
            this.Hide();
            letras = "B";
            Letra Nuevaventana = new Letra("B");
            Nuevaventana.Show();
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            letras = "C";
            Letra Nuevaventana = new Letra("C");
            Nuevaventana.Show();
        }

        private void BtnCh_Click(object sender, EventArgs e)
        {
            this.Hide();
            Letra Nuevaventana = new Letra("");
            Nuevaventana.Show();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Letra Nuevaventana = new Letra("");
            Nuevaventana.Show();
        }

        private void BtnE_Click(object sender, EventArgs e)
        {
            this.Hide();
            Letra Nuevaventana = new Letra("");
            Nuevaventana.Show();
        }

        private void BtnF_Click(object sender, EventArgs e)
        {
            this.Hide();
            Letra Nuevaventana = new Letra("");
            Nuevaventana.Show();
        }

        private void BtnG_Click(object sender, EventArgs e)
        {
            this.Hide();
            Letra Nuevaventana = new Letra("");
            Nuevaventana.Show();
        }

        private void BtnH_Click(object sender, EventArgs e)
        {
            this.Hide();
            Letra Nuevaventana = new Letra("");
            Nuevaventana.Show();
        }

        private void BtnI_Click(object sender, EventArgs e)
        {
            this.Hide();
            Letra Nuevaventana = new Letra("");
            Nuevaventana.Show();
        }

        private void BtnJ_Click(object sender, EventArgs e)
        {
            this.Hide();
            Letra Nuevaventana = new Letra("");
            Nuevaventana.Show();
        }

        private void BtnK_Click(object sender, EventArgs e)
        {
            this.Hide();
            Letra Nuevaventana = new Letra("");
            Nuevaventana.Show();
        }

        private void BtnL_Click(object sender, EventArgs e)
        {
            this.Hide();
            Letra Nuevaventana = new Letra("");
            Nuevaventana.Show();
        }

        private void Btn2L_Click(object sender, EventArgs e)
        {
            this.Hide();
            Letra Nuevaventana = new Letra("");
            Nuevaventana.Show();
        }

        private void BtnM_Click(object sender, EventArgs e)
        {
            this.Hide();
            Letra Nuevaventana = new Letra("");
            Nuevaventana.Show();
        }

        private void BtnN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Letra Nuevaventana = new Letra("");
            Nuevaventana.Show();
        }

        private void BtnÑ_Click(object sender, EventArgs e)
        {
            this.Hide();
            Letra Nuevaventana = new Letra("");
            Nuevaventana.Show();
        }

        private void BtnO_Click(object sender, EventArgs e)
        {
            this.Hide();
            Letra Nuevaventana = new Letra("");
            Nuevaventana.Show();
        }

        private void BtnP_Click(object sender, EventArgs e)
        {
            this.Hide();
            Letra Nuevaventana = new Letra("");
            Nuevaventana.Show();
        }

        private void BtnQ_Click(object sender, EventArgs e)
        {
            this.Hide();
            Letra Nuevaventana = new Letra("");
            Nuevaventana.Show();
        }

        private void BtnR_Click(object sender, EventArgs e)
        {
            this.Hide();
            Letra Nuevaventana = new Letra("");
            Nuevaventana.Show();
        }

        private void BtnRR_Click(object sender, EventArgs e)
        {
            this.Hide();
            Letra Nuevaventana = new Letra("");
            Nuevaventana.Show();
        }

        private void BtnS_Click(object sender, EventArgs e)
        {
            this.Hide();
            Letra Nuevaventana = new Letra ("");
            Nuevaventana.Show();
        }

        private void BtnT_Click(object sender, EventArgs e)
        {
            this.Hide();
            Letra Nuevaventana = new Letra("");
            Nuevaventana.Show();
        }

        private void BtnU_Click(object sender, EventArgs e)
        {
            this.Hide();
            Letra Nuevaventana = new Letra("");
            Nuevaventana.Show();
        }

        private void BtnV_Click(object sender, EventArgs e)
        {
            this.Hide();
            Letra Nuevaventana = new Letra("");
            Nuevaventana.Show();
        }

        private void Button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Letra Nuevaventana = new Letra("");
            Nuevaventana.Show();
        }

        private void BtnXX_Click(object sender, EventArgs e)
        {
            this.Hide();
            Letra Nuevaventana = new Letra("");
            Nuevaventana.Show();
        }

        private void BtnY_Click(object sender, EventArgs e)
        {
            this.Hide();
            Letra Nuevaventana = new Letra("");
            Nuevaventana.Show();
        }

        private void BtnZ_Click(object sender, EventArgs e)
        {
            this.Hide();
            Letra Nuevaventana = new Letra("");
            Nuevaventana.Show();
        }

        private void Abecedario_Load(object sender, EventArgs e)
        {
           // LogUsu = Class1.Usuario;
            NomUsu.Text = NombreUsu;
        }
    }
}
