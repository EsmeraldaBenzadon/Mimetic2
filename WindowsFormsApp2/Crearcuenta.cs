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
        OleDbConnection DatabaseProyecto;

        public Crearcuenta()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Crearcuenta_Load(object sender, EventArgs e)
        {
            DatabaseProyecto = new OleDbConnection();
            DatabaseProyecto.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = DatabaseProyecto.accdb";
        }

        private void BtnRegistrarse_Click(object sender, EventArgs e)
        {
            Nombre = txt_nombre.Text;
            ContraseñaU = txt_contraseña.Text;
            Repetir = txt_repetir.Text; 

            if (Nombre.Length >= 1 && ContraseñaU.Length >= 1 && ContraseñaU == Repetir)
            {
                DatabaseProyecto.Open();
                OleDbCommand info;
                Class1 a = new Class1();
                a.Contraseña = ContraseñaU;
                a.Usuario = Nombre;
                /* 
                info = new OleDbCommand("SELECT FROM Usuarios WHERE NombreU='" + Nombre + "'");
                OleDbDataReader lector;
                lector = info.ExecuteReader();

                if (!!lector["Nombre"]){
                    MessageBox.Show("Ese nombre ya esta en uso");
                    return;
                } else {
                
                }
                 */
                info = new OleDbCommand("INSERT INTO Usuarios (NombreU, ContraseñaU) VALUES ('" + Nombre + "' , '" + ContraseñaU + "')");
                info.Connection = DatabaseProyecto;
                info.ExecuteNonQuery();
                DatabaseProyecto.Close();
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
