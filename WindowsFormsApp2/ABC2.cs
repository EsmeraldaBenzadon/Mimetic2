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
        public string NombreUsu, nombre;
        int i = 0;
        string letra;
        PictureBox player;
        Label label;
        string dirProyecto;
        List<string> nombre_lista;

        public ABC2(string NombreU)
        {
            InitializeComponent();
            btnAtras.Visible = false;
            btnSiguiente.Visible = false;
            NombreUsu = NombreU;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nombre = textBox1.Text.Replace(" ", "");
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

            player = new PictureBox();
            Controls.Add(player);
            player.Location = new System.Drawing.Point(339, 180);
            //player.Ctlenabled = true;
            Size size = new Size(640, 360);
            player.Size = size;
            player.CreateControl();
            dirProyecto = AppContext.BaseDirectory;

            nombre = textBox1.Text;
            nombre_lista = strToArr(nombre);
            letra = nombre_lista[i];
            dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
            player.Image = Image.FromFile(dirProyecto + "Letras\\" + letra + ".gif");
            player.Show();

            player.Visible = true;
            player.Name = "V-" + i.ToString();
            player.Show();

            label = new Label();
            label.AutoSize = true;
            label.Name = "L-" + i.ToString();
            //operador ternario, si es la primer posicion entonces el control va a estar visible, sino todos los demas quedan invisibles.
            label.Visible = true;
            label.Text = letra;
            label.Location = new System.Drawing.Point(640, 575);
            label.BackColor = Color.Transparent;
            label.Font = new Font("", 20);
            Controls.Add(label);
            label.Text = letra;

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            nombre = textBox1.Text;
            nombre_lista = strToArr(nombre);
            i++;
            letra = nombre_lista[i];
            player.Image = Image.FromFile(dirProyecto + "Letras\\" + letra + ".gif");
            player.Show();
            label.Text = letra;
            if (nombre_lista.Count == (i + 1))
            {
                btnSiguiente.Visible = false;
            }
            btnAtras.Visible = true;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            nombre = textBox1.Text;
            nombre_lista = strToArr(nombre);
            i--;
            letra = nombre_lista[i];
            player.Image = Image.FromFile(dirProyecto + "Letras\\" + letra + ".gif");
            player.Show();
            label.Text = letra;
            if (i == 0)
            {
                btnAtras.Visible = false;
            }
            if (nombre_lista.Count > (i + 1))
            {
                btnSiguiente.Visible = true;
            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            menujuegos2 Nuevaventana = new menujuegos2(this.NombreUsu);
            Nuevaventana.Show();
        }

        public List<string> strToArr(string palabra)
        {
            List<string> resultado = new List<string>();
            for (int i = 0; i < palabra.Length; i++)
            {
                if (palabra[i] == 'l' && palabra[i+1] == 'l')
                {
                    resultado.Add("ll");
                    i++;
                }
                else if (palabra[i] == 'c' && palabra[i + 1] == 'h')
                {
                    resultado.Add("ch");
                    i++;
                }
                else
                {
                    resultado.Add(palabra[i].ToString());
                }
            }
            return resultado;
        }
    }
}
