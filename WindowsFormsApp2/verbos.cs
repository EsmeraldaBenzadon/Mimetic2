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
    public partial class verbos : Form
    {
        public verbos()
        {
            InitializeComponent();
        }

        public verbos(string titulo)
        {
            this.titulo = titulo;
        }

        string titulo; 

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Muestra un elemento (Item) en el ListBox
            e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);

            // Muestra una linea separadora
            e.Graphics.DrawLine(Pens.Black, e.Bounds.Left, e.Bounds.Bottom, e.Bounds.Right, e.Bounds.Bottom);
           
            listBox1.ForeColor = System.Drawing.Color.Black;
            listBox1.Font = new Font("Microsoft Tai Le", 16);
            listBox1.ItemHeight = 30;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            listBox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#FBFCBB");


            SetStyle(ControlStyles.SupportsTransparentBackColor |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint, true);
            BackColor = Color.FromArgb(100, 255, 255, 255);

        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string text = (Convert.ToString(listBox1.SelectedItem));
                //listBox1.GetItemText(listBox1.SelectedItem);

                //pictureBox1.Image = Properties.Resources.diciembre;
                //pictureBox1.Show(); pictureBox1.Image = Properties.Resources.diciembre;
                //pictureBox1.Show();
                string dirProyecto = AppContext.BaseDirectory;
                dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
                pictureBox1.Image = Image.FromFile(dirProyecto + "Letras\\" + text + ".gif");
                pictureBox1.Show();

            }

        }

        public class MultiLineListBox : System.Windows.Forms.ListBox
        {
            public MultiLineListBox()
            {
                this.DrawMode = DrawMode.OwnerDrawVariable;
                this.ScrollAlwaysVisible = true;
            }
        }
        public class MyListBoxItem
        {
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            scroll Nuevaventana = new scroll(titulo);//para pasar una variable a otro form 
            Nuevaventana.Show();
        }
    }
}
