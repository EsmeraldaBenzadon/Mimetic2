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
        public menu_juegos()
        {
            InitializeComponent();
        }

        private void Abc_Click(object sender, EventArgs e)
        {
            this.Hide();
            ABC Nuevaventana = new ABC();
            Nuevaventana.Show();
        }
    }
}
