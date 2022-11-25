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
            this.NombreUsu = nombre;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            bienvenidos Nuevaventana = new bienvenidos (NombreUsu);
            Nuevaventana.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            letras = "A";
            Letra Nuevaventana = new Letra(letras, NombreUsu);//para pasar una variable a otro form 
            Nuevaventana.Show();

        }

        private void BtnB_Click(object sender, EventArgs e)
        {
            this.Hide();
            letras = "B";
            Letra Nuevaventana = new Letra("B", NombreUsu);
            Nuevaventana.Show();
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            letras = "C";
            Letra Nuevaventana = new Letra("C", NombreUsu);
            Nuevaventana.Show();
        }

        private void BtnCh_Click(object sender, EventArgs e)
        {
            this.Hide();
            letras = "CH";
            Letra Nuevaventana = new Letra("CH", NombreUsu);
            Nuevaventana.Show();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            letras = "D"; 
            Letra Nuevaventana = new Letra("D", NombreUsu);
            Nuevaventana.Show();
        }

        private void BtnE_Click(object sender, EventArgs e)
        {
            this.Hide();
            letras = "E";
            Letra Nuevaventana = new Letra("E", NombreUsu);
            Nuevaventana.Show();
        }

        private void BtnF_Click(object sender, EventArgs e)
        {
            this.Hide();
            letras = "F";
            Letra Nuevaventana = new Letra("F", NombreUsu);
            Nuevaventana.Show();
        }

        private void BtnG_Click(object sender, EventArgs e)
        {
            this.Hide();
            letras = "G";
            Letra Nuevaventana = new Letra("G", NombreUsu);
            Nuevaventana.Show();
        }

        private void BtnH_Click(object sender, EventArgs e)
        {
            this.Hide();
            letras = "H";
            Letra Nuevaventana = new Letra("H", NombreUsu);
            Nuevaventana.Show();
        }

        private void BtnI_Click(object sender, EventArgs e)
        {
            this.Hide();
            letras = "I";
            Letra Nuevaventana = new Letra("I", NombreUsu);
            Nuevaventana.Show();
        }

        private void BtnJ_Click(object sender, EventArgs e)
        {
            this.Hide();
            letras = "J";
            Letra Nuevaventana = new Letra("J", NombreUsu);
            Nuevaventana.Show();
        }

        private void BtnK_Click(object sender, EventArgs e)
        {
            this.Hide();
            letras = "K";
            Letra Nuevaventana = new Letra("K", NombreUsu);
            Nuevaventana.Show();
        }

        private void BtnL_Click(object sender, EventArgs e)
        {
            this.Hide();
            letras = "L";
            Letra Nuevaventana = new Letra("L", NombreUsu);
            Nuevaventana.Show();
        }

        private void Btn2L_Click(object sender, EventArgs e)
        {
            this.Hide();
            letras = "LL";
            Letra Nuevaventana = new Letra("LL", NombreUsu);
            Nuevaventana.Show();
        }

        private void BtnM_Click(object sender, EventArgs e)
        {
            this.Hide();
            letras = "M";
            Letra Nuevaventana = new Letra("M", NombreUsu);
            Nuevaventana.Show();
        }

        private void BtnN_Click(object sender, EventArgs e)
        {
            this.Hide();
            letras = "N";
            Letra Nuevaventana = new Letra("N", NombreUsu);
            Nuevaventana.Show();
        }

        private void BtnÑ_Click(object sender, EventArgs e)
        {
            this.Hide();
            letras = "Ñ";
            Letra Nuevaventana = new Letra("Ñ", NombreUsu);
            Nuevaventana.Show();
        }

        private void BtnO_Click(object sender, EventArgs e)
        {
            this.Hide();
            letras = "O";
            Letra Nuevaventana = new Letra("O", NombreUsu);
            Nuevaventana.Show();
        }

        private void BtnP_Click(object sender, EventArgs e)
        {
            this.Hide();
            letras = "P";
            Letra Nuevaventana = new Letra("P", NombreUsu);
            Nuevaventana.Show();
        }

        private void BtnQ_Click(object sender, EventArgs e)
        {
            this.Hide();
            letras = "Q";
            Letra Nuevaventana = new Letra("Q", NombreUsu);
            Nuevaventana.Show();
        }

        private void BtnR_Click(object sender, EventArgs e)
        {
            this.Hide();
            letras = "R";
            Letra Nuevaventana = new Letra("R", NombreUsu);
            Nuevaventana.Show();
        }

        private void BtnRR_Click(object sender, EventArgs e)
        {
            this.Hide();
            letras = "RR";
            Letra Nuevaventana = new Letra("RR", NombreUsu);
            Nuevaventana.Show();
        }

        private void BtnS_Click(object sender, EventArgs e)
        {
            this.Hide();
            letras = "S";
            Letra Nuevaventana = new Letra ("S", NombreUsu);
            Nuevaventana.Show();
        }

        private void BtnT_Click(object sender, EventArgs e)
        {
            this.Hide();
            letras = "T";
            Letra Nuevaventana = new Letra("T", NombreUsu);
            Nuevaventana.Show();
        }

        private void BtnU_Click(object sender, EventArgs e)
        {
            this.Hide();
            letras = "U";
            Letra Nuevaventana = new Letra("U", NombreUsu);
            Nuevaventana.Show();
        }

        private void BtnV_Click(object sender, EventArgs e)
        {
            this.Hide();
            letras = "V";
            Letra Nuevaventana = new Letra("V", NombreUsu);
            Nuevaventana.Show();
        }

        private void Button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            letras = "W";
            Letra Nuevaventana = new Letra("W", NombreUsu);
            Nuevaventana.Show();
        }

        private void BtnXX_Click(object sender, EventArgs e)
        {
            this.Hide();
            letras = "X";
            Letra Nuevaventana = new Letra("X", NombreUsu);
            Nuevaventana.Show();
        }

        private void BtnY_Click(object sender, EventArgs e)
        {
            this.Hide();
            letras = "Y";
            Letra Nuevaventana = new Letra("Y", NombreUsu);
            Nuevaventana.Show();
        }

        private void BtnZ_Click(object sender, EventArgs e)
        {
            this.Hide();
            letras = "Z";
            Letra Nuevaventana = new Letra("Z", NombreUsu);
            Nuevaventana.Show();
        }

        private void Abecedario_Load(object sender, EventArgs e)
        {
        }
    }
}
