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
    public partial class recuperar_contraseña : Form
    {
        string usuario;
        string newcontrasena;
        string rep;
        OleDbConnection DatabaseProyecto;

        public recuperar_contraseña()
        {
            InitializeComponent();
        }

        private void recuperar_contraseña_Load(object sender, EventArgs e)
        {
            DatabaseProyecto = new OleDbConnection();
            DatabaseProyecto.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = DatabaseProyecto.accdb";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuario = txt_nombre.Text;
            usuario = usuario.ToUpper();
            newcontrasena = txt_newcontra.Text;
            rep = txt_repnewcontra.Text;

            if (usuario.Length >= 1 && newcontrasena.Length >= 1 && newcontrasena == rep)
            {
                DatabaseProyecto.Open();
                string consulta = "select NombreU, Pregunta1 from Usuarios where NombreU = '" + usuario + "'";
                OleDbCommand comando = new OleDbCommand(consulta, DatabaseProyecto);
                OleDbDataReader lector;
                lector = comando.ExecuteReader();
                Boolean registroexist = lector.HasRows;

                if (registroexist)
                {
                    string value = "";
                    if (InputBox("Pregunta de seguridad", "¿Cual es el primer nombre de tu mamá?", ref value) == DialogResult.OK)
                    {
                        value = value.ToUpper(); //Solicito pregunta secreta
                        lector.Read();
                        string PregSecreta = lector.GetString(1);
                        if (value == PregSecreta)
                        {
                            //Hacer Update de Contrasenia
                            OleDbCommand info1;
                            value = value.ToUpper();
                            info1 = new OleDbCommand("UPDATE Usuarios SET ContrasenaU = '" + newcontrasena + "' WHERE NombreU = '" + usuario + "'");
                            info1.Connection = DatabaseProyecto;
                            info1.ExecuteNonQuery();
                            DatabaseProyecto.Close();
                            MessageBox.Show("Su clave ha sido modificada", "Mensaje");
                            this.Hide();
                            pantalla_iniciosesion Nuevaventana = new pantalla_iniciosesion();
                            Nuevaventana.Show();
                        }
                        else
                        {
                            DatabaseProyecto.Close();
                            MessageBox.Show("Revise sus datos");
                            return;
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Revise sus datos", "Error !!");
                    return;
                }
            }
        }

        private static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();

            form.Text = title;
            label.Text = promptText;

            buttonOk.Text = "OK";
            buttonOk.DialogResult = DialogResult.OK;

            label.SetBounds(36, 36, 372, 13);
            textBox.SetBounds(36, 86, 700, 20);
            buttonOk.SetBounds(228, 160, 160, 60);

            label.AutoSize = true;
            form.ClientSize = new Size(796, 307);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.BackColor = Color.LemonChiffon;
            form.ForeColor = Color.Black;
            form.Font = new Font("Microsoft YaHei UI", 10);
            buttonOk.BackColor = Color.Peru;

            form.Controls.AddRange(new Control[] { label, textBox, buttonOk,});
            form.AcceptButton = buttonOk;

            DialogResult dialogResult = form.ShowDialog();

            value = textBox.Text;
            return dialogResult;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            pantalla_logueo Nuevaventana = new pantalla_logueo();
            Nuevaventana.Show();

        }

        private void Pbmostrar_new_Click(object sender, EventArgs e)
        {
            pbocultar_new.BringToFront(); //imagen ocultar la mandamos al frente
            txt_newcontra.PasswordChar = '\0'; //mostamos la contraseña
        }

        private void Pbocultar_new_Click(object sender, EventArgs e)
        {
            pbmostrar_new.BringToFront(); // imagen mostrar la mandamos al frente
            txt_newcontra.PasswordChar = '°'; //ocultamos la contraseña
        }

        private void Pbmostrar_rep_Click(object sender, EventArgs e)
        {
            pbocultar_rep.BringToFront();
            txt_repnewcontra.PasswordChar = '\0';
        }

        private void Pbocultar_rep_Click(object sender, EventArgs e)
        {
            pbmostrar_rep.BringToFront();
            txt_repnewcontra.PasswordChar = '°';
        }

        private void Txt_newcontra_TextChanged(object sender, EventArgs e)
        {
            txt_newcontra.PasswordChar = '°';
        }

        private void Txt_repnewcontra_TextChanged(object sender, EventArgs e)
        {
            txt_repnewcontra.PasswordChar = '°';
        }
    }
}
