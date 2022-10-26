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
     
    public partial class nivelesquiz : Form
    {
        public string NombreUsu;

        public nivelesquiz(string nombre)
        {
            InitializeComponent();
            NomUsu.Text = nombre;
            this.NombreUsu = nombre;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            quizgame222 Nuevaventana = new quizgame222(this.NombreUsu);
            Nuevaventana.Show();
        }
    }
}
