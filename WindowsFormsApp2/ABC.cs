using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class ABC : Form
    {
        OleDbConnection DatabaseProyecto;
        public string NombreUsu;

        public ABC(string nombre)
        {
            InitializeComponent();
            NomUsu.Text = nombre;
            this.NombreUsu = nombre;
        }

        private void Btn_nom_Click(object sender, EventArgs e)
        {
            string nombre = txt_nom.Text;
            char letraDelNombre;
            DatabaseProyecto.Open();
            for (int i = 0; i < nombre.Length; i++)
            {
                letraDelNombre = nombre[i];
                string consulta = "select letra from abc where letra = '" + letraDelNombre + "';";
                OleDbCommand comando = new OleDbCommand(consulta, DatabaseProyecto);
                OleDbDataReader lector;
                lector = comando.ExecuteReader();
            }


        }

        private void ABC_Load(object sender, EventArgs e)
        {
            DatabaseProyecto = new OleDbConnection();
            DatabaseProyecto.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = DatabaseProyecto.accdb";
        }
    }
}
