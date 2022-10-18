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
    public partial class scroll : Form
    {
        string frases;
        public scroll()
        {
            InitializeComponent();
        }

        private void Reproductor_Enter(object sender, EventArgs e)
        {
            string dirProyecto = AppContext.BaseDirectory;
            dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
            reproductor.URL = dirProyecto + "Letras\\" + frases + ".mp4";
            reproductor.Ctlcontrols.play();
        }

        private void BtnHOLA_Click(object sender, EventArgs e)
        {
            frases = "HOLA"; 
        }
    }
}
