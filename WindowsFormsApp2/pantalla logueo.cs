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
    public partial class pantalla_logueo : Form
    {
        public pantalla_logueo()
        {
            InitializeComponent();
        }

        private void Pantalla_logueo_Load(object sender, EventArgs e)
        {

        }

        private void BtnInicios_Click(object sender, EventArgs e)
        {
            this.Hide();
            Crearcuenta Nuevaventana = new Crearcuenta();
            Nuevaventana.Show();//código para cambiar de pantalla IMPORTANTE
        }

        private void BtnCrearc_Click(object sender, EventArgs e)
        {
            this.Hide();
            Crearcuenta Nuevaventana = new Crearcuenta();
            Nuevaventana.Show();//código para cambiar de pantalla IMPORTANTE
        }
    }
}
