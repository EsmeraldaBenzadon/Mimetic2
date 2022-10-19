﻿using AxWMPLib;
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
        AxWindowsMediaPlayer player;
        Label label;
        string dirProyecto;

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

            //for (int i = Controls.Count - 1; i >= 0; i--)
            //{
            //    Control c = Controls[i];
            //    if (c.Name.StartsWith("L-") || c.Name.StartsWith("V-"))
            //    {
            //        Controls.RemoveAt(i);
            //    }
            //}

            player = new AxWindowsMediaPlayer();

            Controls.Add(player);
            player.Location = new System.Drawing.Point(150, 50);
            player.Ctlenabled = true;
            player.settings.mute = true;
            Size size = new Size(300, 300);
            player.Size = size;
            player.CreateControl();

            checkLetra(); 

            dirProyecto = AppContext.BaseDirectory;
            dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
            player.URL = dirProyecto + "Letras\\" + letra + ".mp4";
            player.Visible = true;
            player.Name = "V-" + i.ToString();
            player.close();

            label = new Label();
            label.AutoSize = true;
            label.Name = "L-" + i.ToString();
            //operador ternario, si es la primer posicion entonces el control va a estar visible, sino todos los demas quedan invisibles.
            label.Visible = true;
            label.Text = letra;
            label.Location = new System.Drawing.Point(150, 380);
            Controls.Add(label);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            nombre = textBox1.Text;
            i++;
            checkLetra();
            player.URL = dirProyecto + "Letras\\" + letra + ".mp4";
            player.Show();
            label.Text = letra;
            if (nombre.Length == (i + 1))
            {
                btnSiguiente.Visible = false;
            }
            btnAtras.Visible = true;
            
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            nombre = textBox1.Text;
            i--;
            checkLetra();
            player.URL = dirProyecto + "Letras\\" + letra + ".mp4";
            player.Show();
            label.Text = letra;
            if (i == 0)
            {
                btnAtras.Visible = false;
            }
            if (nombre.Length > (i + 1))
            {
                btnSiguiente.Visible = true;
            }

        }

        public void checkLetra()
        {
            letra = nombre[i].ToString();

            if (letra == "l" && nombre[i+1] == 'l')
            {
                letra = "ll";
                i += 1;
            }
            else if (letra == "c" && nombre[i + 1] == 'h')
            {
                letra = "ch";
                i += 1;
            }
            else
            {
                letra = nombre[i].ToString();
            }

        }
    }
}
