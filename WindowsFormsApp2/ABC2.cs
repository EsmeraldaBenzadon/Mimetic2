using AxWMPLib;
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
    public partial class ABC2 : Form
    {
        public int indiceActual;
        public string NombreUsu;

        public ABC2(string NombreU)
        {
            InitializeComponent();
            btnAtras.Visible = false;
            btnSiguiente.Visible = false;
            NombreUsu = NombreU;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            char letraDelNombre;
            List<Label> labels = new List<Label>();

            indiceActual = 0;
            btnAtras.Visible = false;
            btnSiguiente.Visible = true;

            for (int i = Controls.Count - 1; i >= 0; i--)
            {
                Control c = Controls[i];
                if (c.Name.StartsWith("L-") || c.Name.StartsWith("V-"))
                {
                    Controls.RemoveAt(i);
                }
            }


            for (int i = 0; i < nombre.Length; i++)
            {
                AxWindowsMediaPlayer player = new AxWindowsMediaPlayer();
                Controls.Add(player);
                player.CreateControl();
                string dirProyecto = AppContext.BaseDirectory;
                dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
                player.URL = dirProyecto + "Letras\\A.mp4";
                Size size = new Size(300, 300);
                player.Size = size;
                //operador ternario
                player.Visible = (i == 0) ? true : false;
                player.Name = "V-" + i.ToString();
                player.Location = new System.Drawing.Point(150, 50);
                player.Ctlenabled = false;
                player.close();


                letraDelNombre = nombre[i];

                Label label = new Label();
                label.AutoSize = true;
                label.Name = "L-" + i.ToString();
                //operador ternario, si es la primer posicion entonces el control va a estar visible, sino todos los demas quedan invisibles.
                label.Visible = (i == 0) ? true : false;
                label.Text = letraDelNombre.ToString();
                label.Location = new System.Drawing.Point(150, 380);
                Controls.Add(label);

            }

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            Controls.Find("V-" + indiceActual.ToString(), true)[0].Visible = false;
            Controls.Find("L-" + indiceActual.ToString(), true)[0].Visible = false;

            indiceActual = indiceActual + 1;

            Controls.Find("V-" + indiceActual.ToString(), true)[0].Visible = true;
            Controls.Find("L-" + indiceActual.ToString(), true)[0].Visible = true;

            if (nombre.Length == (indiceActual + 1))
            {
                btnSiguiente.Visible = false;
            }
            btnAtras.Visible = true;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            Controls.Find("V-" + indiceActual.ToString(), true)[0].Visible = false;
            Controls.Find("L-" + indiceActual.ToString(), true)[0].Visible = false;

            indiceActual = indiceActual - 1;

            Controls.Find("V-" + indiceActual.ToString(), true)[0].Visible = true;
            Controls.Find("L-" + indiceActual.ToString(), true)[0].Visible = true;

            if (indiceActual == 0)
            {
                btnAtras.Visible = false;
            }
            if (nombre.Length > (indiceActual + 1))
            {
                btnSiguiente.Visible = true;
            }

        }
    }
}
