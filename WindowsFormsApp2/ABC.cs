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
    public partial class ABC : Form
    {

        public ABC()
        {
            InitializeComponent();
        }
 

        private void Btn_nom_Click(object sender, EventArgs e)
        {
            string nombre = txt_nom.Text;
            int startIndex = txt_nom.TextLength;
            int endIndex = txt_nom.TextLength;
            string letra = nombre.Substring(startIndex, endIndex);
            /*for (int i = 0; i < nombre.Length; i++)
            {
                char letraDelNombre = nombre[i];

            }
            */
        }
    }
}
