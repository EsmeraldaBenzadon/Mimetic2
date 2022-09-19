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
        public bienvenidos()
        {
            InitializeComponent();
        }

        private void Btnabc_Click(object sender, EventArgs e)
        {
            this.Hide();
            Abecedario Nuevaventana = new Abecedario();
            Nuevaventana.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            pantalla_logueo Nuevaventana = new pantalla_logueo();
            Nuevaventana.Show();
        }

        private void BtnJugamos_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu_juegos Nuevaventana = new menu_juegos();
            Nuevaventana.Show();
        }

        private void Bienvenidos_Load(object sender, EventArgs e)
        {
            label1.Text = Crearcuenta.Class1;
        }
    }
}
