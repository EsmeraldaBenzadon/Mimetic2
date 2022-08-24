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
    public partial class Fondoinicio : Form
    {
        public Fondoinicio()
        {
            InitializeComponent();
        }

        private void Fondoinicio_Load(object sender, EventArgs e)
        {

        }

        private void BtnComenzar_Click(object sender, EventArgs e)
        {
            this.Hide();
            pantalla_logueo Nuevaventana = new pantalla_logueo();
            Nuevaventana.Show();// esta linea de código para cambiar de pantalla

        }
    }
}
