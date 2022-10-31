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
    public partial class numeros : Form
    {
        public numeros()
        {
            InitializeComponent();
           
        }
        string numero;

        private void numero_Shown(object sender, EventArgs e)
        {
            string dirProyecto = AppContext.BaseDirectory;
            dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
            pictureBox1.Image = Image.FromFile(dirProyecto + "Letras\\" + numero + ".gif");
            pictureBox1.Show();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            numero = "1";
            string dirProyecto = AppContext.BaseDirectory;
            dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
            pictureBox1.Image = Image.FromFile(dirProyecto + "Letras\\" + numero + ".gif");
            pictureBox1.Show();
        }

        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            //FlowLayoutPanel1_Paint.BackColor = System.Drawing.ColorTranslator.FromHtml("#FBFCBB");
        }
    }
}
