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
            //Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;

            buttonOk.Text = "OK";
            //buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            //buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(36, 36, 372, 13);
            textBox.SetBounds(36, 86, 700, 20);
            buttonOk.SetBounds(228, 160, 160, 60);
            //buttonCancel.SetBounds(400, 160, 160, 60);

            label.AutoSize = true;
            form.ClientSize = new Size(796, 307);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;

            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, /*buttonCancel*/ });
            form.AcceptButton = buttonOk;
            //form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();

            value = textBox.Text;
            return dialogResult;
        }
    }
}
