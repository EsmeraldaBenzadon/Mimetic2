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
    public partial class Letra : Form
    {
        string letra;
        public string NombreUsu;

        public Letra(string le, string nombre)
        {
            InitializeComponent(); 
            letra = le;
            lbl_letra.Text = le;
            this.NombreUsu = nombre;
        }

        private void AxWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Letra_Shown(object sender, EventArgs e)
        {
            string dirProyecto = AppContext.BaseDirectory;
            dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
            player.Image = Image.FromFile(dirProyecto + "Letras\\" + letra + ".gif");
            player.Show();
        }

        private void Letra_Load(object sender, EventArgs e)
        {

        }

        private void Lbl_letra_Click(object sender, EventArgs e)
        {

        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Abecedario Nuevaventana = new Abecedario (NombreUsu);
            Nuevaventana.Show();
        }
    }
}
