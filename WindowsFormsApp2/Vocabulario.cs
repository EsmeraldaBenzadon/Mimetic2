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
    public partial class Vocabulario : Form
    {
        public string nombreusuario;
        public Vocabulario(string nombre)
        {
            InitializeComponent();
            this.nombreusuario = nombre;
            NomUsu.Text = nombre;
        }
    }
}
