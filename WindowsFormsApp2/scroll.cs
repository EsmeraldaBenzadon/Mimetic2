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
        //string frases;
        string titulo;

        public scroll(string title)
        {
            InitializeComponent();
            this.titulo = title;
            lbl_titulo.Text = title;
        }

        private void Reproductor_Enter(object sender, EventArgs e)
        {
            //string dirProyecto = AppContext.BaseDirectory;
            //dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
            //reproductor.URL = dirProyecto + "Letras\\" + frases + ".mp4";
            //reproductor.Ctlcontrols.play();
        }


        private void scroll_Load(object sender, EventArgs e)
        {
            string[] items = { "Mama", "Papa", "Perro" };

            for (int i = 0; i < items.Length; i++)
            {
                Button button = new Button();
                button.AutoSize = true;
                button.Name = "btn" + items[i];
                button.Text = items[i];
                button.Width = flowLayoutPanel1.Width;
                button.Height = 30;
                //button.Font = new Font();
                //button.FlatAppearance = ;
                //button.BackgroundImage = ;
                //button.BackgroundImage = imageList1.Images[0]; 
                button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;

                flowLayoutPanel1.Controls.Add(button);
                button.Click += btnSide_Click;
                button.DialogResult = DialogResult.OK;
            }

        }
        public void btnSide_Click(object sender, EventArgs e)
        {
            MessageBox.Show(((Button)sender).Text);

            string dirProyecto = AppContext.BaseDirectory;
            dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);

            //pictureBox = Image.FromFile(dirProyecto + "Letras\\" + familia + ".gif");

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            //voc_basico Nuevaventana = new voc_basico(this.nombreusuario);//para pasar una variable a otro form 
            //Nuevaventana.Show();
        }

        private void ListBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Muestra un elemento (Item) en el ListBox
            e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), e.Font, Brushes.Chocolate, e.Bounds, StringFormat.GenericDefault);

            //// Muestra una linea separadora

            e.Graphics.DrawLine(Pens.Chocolate, e.Bounds.Left, e.Bounds.Bottom, e.Bounds.Right, e.Bounds.Bottom);

           // e.DrawBackground();
           // Graphics g = e.Graphics;
           // Brush myBrush = Brushes.Black;
           // Brush myBrush2 = Brushes.Red;
           // e.Graphics.FillRectangle(new SolidBrush(Color.Silver), e.Bounds);
            //e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
           // for (int i = 0; i < listBox1.Items.Count; i++) ;

            //e.DrawBackground();
            //Graphics g = e.Graphics;
            // e.Graphics.FillRectangles(new SolidBrush(Color.Gainsboro)
            //e.DrawBackground();
            //Graphics g = e.Graphics;
            //g.DrawLine(Pens.Chocolate, e.Bounds.Left, e.Bounds.Bottom, e.Bounds.Right, e.Bounds.Bottom);
            //g.DrawString(listBox1.Items[e.Index].ToString(), e.Font, Brushes.Chocolate, e.Bounds, StringFormat.GenericDefault);
            ////Brush myBrush = Brushes.Black;
            ////Brush myBrush2 = Brushes.Red;
            //g.FillRectangle(new SolidBrush(Color.Silver), e.Bounds);
            //e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
            //for (int i = 0; i < listBox1.Items.Count; i++);

        }
        public class MyListBoxItem
        {
        }
    }
}

