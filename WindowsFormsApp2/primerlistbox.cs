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
    public partial class primerlistbox : Form
    {
        public primerlistbox()
        {
            InitializeComponent();
        }

        private void ListBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Muestra un elemento (Item) en el ListBox
            e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);

            // Muestra una linea separadora
            e.Graphics.DrawLine(Pens.Black, e.Bounds.Left, e.Bounds.Bottom, e.Bounds.Right, e.Bounds.Bottom);
        }
    }
}
