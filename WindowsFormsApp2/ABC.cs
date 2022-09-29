using AxWMPLib;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class ABC : Form
    {
        public string NombreUsu;

        public ABC(string nombre)
        {
            InitializeComponent();
            NomUsu.Text = nombre;
            this.NombreUsu = nombre;
        }

        private void Btn_nom_Click(object sender, EventArgs e)
        {
            string nombre = txt_nombre.Text;
            char letraDelNombre;
            string letra;

            int x = 5;
            int y = 25;


            for (int i = 0; i < nombre.Length; i++)
            {AxWindowsMediaPlayer player = new AxWindowsMediaPlayer();
                string dirProyecto = AppContext.BaseDirectory;
                dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
                letra = nombre [i].ToString();
                if (letra[0] == ' ') continue;
                this.Controls.Add(player);
                player.CreateControl();
                player.URL = dirProyecto + "Letras\\" + letra + ".mp4";
                Size size = new Size(150, 150);
                player.Size = size;
                player.Location = new System.Drawing.Point(x, y);

                letraDelNombre = nombre[i];
                Label label = new Label();
                label.AutoSize = true;
                label.Text = letraDelNombre.ToString();
                label.Location = new System.Drawing.Point(x + 75, y + 160);
                this.Controls.Add(label);

                x += 160;

                if (i > 0 && i % 7 == 0)
                {
                    x = 5;
                    y += 180;
                }

            }
        }

        private void ABC_Load(object sender, EventArgs e)
        {
           
        }
    }
}
