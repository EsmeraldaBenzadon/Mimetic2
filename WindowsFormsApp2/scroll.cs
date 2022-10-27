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
                button.Font = new Font();
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

    }
}
