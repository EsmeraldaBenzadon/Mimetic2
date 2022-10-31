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
        public numeros(string titulo)
        {
            InitializeComponent();
           
        }
        string numero;

        private void numero_Shown(object sender, EventArgs e)
        {
            string dirProyecto = AppContext.BaseDirectory;
            dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
            pictureBox2.Image = Image.FromFile(dirProyecto + "Letras\\" + numero + ".gif");
            pictureBox2.Show();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            numero = "1";
            string dirProyecto = AppContext.BaseDirectory;
            dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
            pictureBox2.Image = Image.FromFile(dirProyecto + "Letras\\" + numero + ".gif");
            pictureBox2.Show();
        }

        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            //FlowLayoutPanel1_Paint.BackColor = System.Drawing.ColorTranslator.FromHtml("#FBFCBB");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            numero = "2";
            string dirProyecto = AppContext.BaseDirectory;
            dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
            pictureBox2.Image = Image.FromFile(dirProyecto + "Letras\\" + numero + ".gif");
            pictureBox2.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            numero = "3";
            string dirProyecto = AppContext.BaseDirectory;
            dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
            pictureBox2.Image = Image.FromFile(dirProyecto + "Letras\\" + numero + ".gif");
            pictureBox2.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            numero = "4";
            string dirProyecto = AppContext.BaseDirectory;
            dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
            pictureBox2.Image = Image.FromFile(dirProyecto + "Letras\\" + numero + ".gif");
            pictureBox2.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            numero = "5";
            string dirProyecto = AppContext.BaseDirectory;
            dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
            pictureBox2.Image = Image.FromFile(dirProyecto + "Letras\\" + numero + ".gif");
            pictureBox2.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            numero = "6";
            string dirProyecto = AppContext.BaseDirectory;
            dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
            pictureBox2.Image = Image.FromFile(dirProyecto + "Letras\\" + numero + ".gif");
            pictureBox2.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            numero = "7";
            string dirProyecto = AppContext.BaseDirectory;
            dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
            pictureBox2.Image = Image.FromFile(dirProyecto + "Letras\\" + numero + ".gif");
            pictureBox2.Show();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            numero = "8";
            string dirProyecto = AppContext.BaseDirectory;
            dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
            pictureBox2.Image = Image.FromFile(dirProyecto + "Letras\\" + numero + ".gif");
            pictureBox2.Show();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            numero = "9";
            string dirProyecto = AppContext.BaseDirectory;
            dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
            pictureBox2.Image = Image.FromFile(dirProyecto + "Letras\\" + numero + ".gif");
            pictureBox2.Show();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            numero = "10";
            string dirProyecto = AppContext.BaseDirectory;
            dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
            pictureBox2.Image = Image.FromFile(dirProyecto + "Letras\\" + numero + ".gif");
            pictureBox2.Show();
        }
    }
}
