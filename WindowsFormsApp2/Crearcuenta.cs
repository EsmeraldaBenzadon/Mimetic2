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
        string ContrasenaU;
        string Repetir;
        OleDbConnection DatabaseProyecto;
        DataSet ds = new DataSet();

        public Crearcuenta()
        {
            InitializeComponent();
        }

        private void Crearcuenta_Load(object sender, EventArgs e)
        {
            DatabaseProyecto = new OleDbConnection();
            DatabaseProyecto.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = DatabaseProyecto.accdb";

        }

        private void BtnRegistrarse_Click(object sender, EventArgs e)
        {
            Nombre = txt_nombre.Text;
            ContrasenaU = txt_contraseña.Text;
            Repetir = txt_repetir.Text;

            if (Nombre.Length >= 1 && ContrasenaU.Length >= 1 && ContrasenaU == Repetir)
            {
                DatabaseProyecto.Open();
                OleDbCommand info;


                {
                    String preg = ("SELECT NombreU FROM Usuarios WHERE NombreU = '" + Nombre + "'");
                    OleDbCommand comando = new OleDbCommand(preg, DatabaseProyecto);
                    OleDbDataAdapter da = new OleDbDataAdapter(comando);
                    da.Fill(ds, "Usuarios");
                    //txt_nombre.Text = ds.Tables["Usuarios"].Rows[0]["NombreU"].ToString();

                    //reader = comando.ExecuteReader();
                    //OleDbDataReader read;
                    //read = comando.ExecuteReader();
                    //OleDbDataReader reader;
                    

                    { if (Nombre == preg)// poner el nombre que sacas de la base de datos
                        {
                            MessageBox.Show("Ese nombre ya esta en uso");
                            return;
                        }

                        else {

                            info = new OleDbCommand("INSERT INTO Usuarios (NombreU, ContrasenaU) VALUES ('" + Nombre + "' , '" + ContrasenaU + "')");
                            info.Connection = DatabaseProyecto;
                            info.ExecuteNonQuery();
                            DatabaseProyecto.Close();
                            MessageBox.Show("Sus datos se han enviado correctamente");
                            this.Hide();
                            bienvenidos Nuevaventana = new bienvenidos(Nombre);
                            Nuevaventana.Show();
                        }
                    }

                }


            }

            else
            {
                MessageBox.Show("Complete todas los casilleros correctamente");
            }
        }


        private void Txt_contraseña_TextChanged(object sender, EventArgs e)
        {
            txt_contraseña.PasswordChar = '°';
        }

        

        private void Txt_repetir_TextChanged(object sender, EventArgs e)
        {
            txt_repetir.PasswordChar = '°';
        }

        private void Pbmostrar_Click(object sender, EventArgs e)
        {
            pbocultar.BringToFront(); //imagen ocultar la mandamos al frente
            txt_contraseña.PasswordChar = '\0'; //mostamos la contraseña
        }

        private void Pbocultar_Click(object sender, EventArgs e)
        {
            pbmostrar.BringToFront(); // imagen mostrar la mandamos al frente
            txt_contraseña.PasswordChar = '°'; //ocultamos la contraseña
        }

        private void Pbmostrar_rep_Click(object sender, EventArgs e)
        {
            pbocultar_rep.BringToFront();
            txt_repetir.PasswordChar = '\0';
        }

        private void Pbocultar_rep_Click(object sender, EventArgs e)
        {
            pbmostrar_rep.BringToFront();
            txt_repetir.PasswordChar = '°';
        }
    }
    }
