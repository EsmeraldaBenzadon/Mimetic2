﻿using System;
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
    public partial class Letra : Form
    {
        string letra;

        public Letra(string le)
        {
            InitializeComponent();
            letra = le;
            lbl_letra.Text = le;
        }

        private void AxWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Letra_Shown(object sender, EventArgs e)
        {
            string dirProyecto = AppContext.BaseDirectory;
            dirProyecto = dirProyecto.Substring(0, dirProyecto.Length - 10);
            reproductor.URL = dirProyecto + "Letras\\" + letra + ".mp4";
            reproductor.Ctlcontrols.play();
        }

        private void Letra_Load(object sender, EventArgs e)
        {

        }
    }
}
