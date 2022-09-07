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
    }
}
