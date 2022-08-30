using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp2
{
    public partial class Crearcuenta : Form
    {
        string Nombre;
        string ContraseñaU;
        string Repetir;
        OleDbConnection BaseDeDatosProyecto;

        public Crearcuenta()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Crearcuenta_Load(object sender, EventArgs e)
        {
            BaseDeDatosProyecto = new OleDbConnection();
            BaseDeDatosProyecto.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = BaseDeDatosProyecto.accdb";
        }

        private void BtnRegistrarse_Click(object sender, EventArgs e)
        {
            Nombre = txt_nombre.Text;
            ContraseñaU = txt_contraseña.Text;
            Repetir = txt_repetir.Text;

            if (Nombre.Length >= 1 && ContraseñaU.Length >= 1 && ContraseñaU == Repetir)
            {
                BaseDeDatosProyecto.Open();
                OleDbCommand info;
                Class1 a = new Class1();
                a.Contraseña = ContraseñaU;
                a.Usuario = Nombre;
                info = new OleDbCommand("INSERT INTO BaseDeDatos (NombreU, ContraseñaU) VALUES ('" + Nombre + "' , '" + ContraseñaU + "')");
                info.Connection = BaseDeDatosProyecto;
                info.ExecuteNonQuery();
                BaseDeDatosProyecto.Close();
                MessageBox.Show("Sus datos se han enviado correctamente");
            }
            else
            {
                MessageBox.Show("Complete todas los casilleros");
            }
        }

            public class Class1
        {
            public string Contraseña;
            public string Usuario;
        }
    }
    }
