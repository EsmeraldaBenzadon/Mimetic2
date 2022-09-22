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
    public partial class menu_juegos : Form
    {
        public string NombreUsu;

        public menu_juegos(string nombre)
        {
            InitializeComponent();
            NomUsu.Text = nombre;
            this.NombreUsu = nombre;
        }

        private void Abc_Click(object sender, EventArgs e)
        {
            this.Hide();
            ABC Nuevaventana = new ABC(this.NombreUsu);
            Nuevaventana.Show();
        }

        private void Menu_juegos_Load(object sender, EventArgs e)
        {

        }
    }
}
