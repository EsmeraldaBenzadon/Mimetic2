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
        public Abecedario()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            bienvenidos Nuevaventana = new bienvenidos ();
            Nuevaventana.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            A Nuevaventana = new A();
            Nuevaventana.Show();
        }
    }
}
