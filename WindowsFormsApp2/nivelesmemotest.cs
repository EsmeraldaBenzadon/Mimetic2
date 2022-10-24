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
    public partial class nivelesmemotest : Form
    {
        public string NombreUsu;

        public nivelesmemotest(string NombreU)
        {
            InitializeComponent();
            this.NombreUsu = NombreU;
            NomUsu.Text = NombreU;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            memotest Nuevaventana = new memotest(this.NombreUsu);
            Nuevaventana.Show();
        }

        private void nivelesmemotest_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            memotest222 Nuevaventana = new memotest222(this.NombreUsu);
            Nuevaventana.Show();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            menujuegos2 Nuevaventana = new menujuegos2 (this.NombreUsu);
            Nuevaventana.Show();
        }
    }
}
