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
    public partial class pantalla_iniciosesion : Form
    {
        string nombre;
        string contrasena;
        OleDbConnection iniciarsesion;
        

        public pantalla_iniciosesion()
        {
            InitializeComponent();
        }

        private void Pantalla_iniciosesion_Load(object sender, EventArgs e)
        {
            iniciarsesion = new OleDbConnection();
            iniciarsesion.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = DatabaseProyecto.accdb";
        }

        private void Btn_iniciarsesion_Click(object sender, EventArgs e)
        {
            nombre = txt_nombre.Text;
            contrasena = txt_contraseña.Text;
            iniciarsesion.Open();
            string consulta = "select NombreU, ContrasenaU from Usuarios where NombreU = '" + nombre + "' and ContrasenaU = '"+ contrasena  + "';";
            OleDbCommand comando = new OleDbCommand(consulta, iniciarsesion);
            OleDbDataReader lector;
            lector = comando.ExecuteReader();
            Boolean registroexist = lector.HasRows;

            if (registroexist)
            {
                MessageBox.Show("Bienvenido a Mimetic");
                bienvenidos abrir = new bienvenidos();
                this.Hide();
                abrir.Show();
            }
            else
            {
                MessageBox.Show("Revise el usuario y la contarseña, intente de nuevo");
                return;
            }
            iniciarsesion.Close();
        }

        private void Pbocultar_Click(object sender, EventArgs e)
        {
            pbmostrar.BringToFront(); // imagen mostrar la mandamos al frente
            txt_contraseña.PasswordChar = '°'; //ocultamos la contraseña
        }

        private void Pbmostrar_Click(object sender, EventArgs e)
        {
            pbocultar.BringToFront(); //imagen ocultar la mandamos al frente
            txt_contraseña.PasswordChar = '\0'; //mostamos la contraseña
        }

        private void Txt_contraseña_TextChanged(object sender, EventArgs e)
        {
            txt_contraseña.PasswordChar = '°';
        }

        private void Txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}