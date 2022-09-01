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
        string contraseña;
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
            contraseña = txt_contraseña.Text;
            iniciarsesion.Open();
            string consulta = "select NombreU, ContraseñaU from Usuarios where ContarseñaU = '" + contraseña + "' and  NombreU = '" + nombre + "';";
            OleDbCommand comando = new OleDbCommand(consulta, iniciarsesion);
            OleDbDataReader lector;
            lector = comando.ExecuteReader();
            Boolean registroexist = lector.HasRows;

            if (registroexist)
            {
                MessageBox.Show("Bienvenido a Mimetic");
                menu_principal abrir = new menu_principal();
                this.Hide();
                abrir.Show();
            }
            else
            {
                MessageBox.Show("Revise el usuario y contarseña, intente de nuevo");
                return;
            }
            iniciarsesion.Close();
        }
    }
}
