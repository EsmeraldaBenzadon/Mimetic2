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
            Nombre = Nombre.ToUpper();
            ContrasenaU = txt_contraseña.Text;
            Repetir = txt_repetir.Text;

            if (Nombre.Length >= 1 && ContrasenaU.Length >= 1 && ContrasenaU == Repetir)
            {
                {
                    DatabaseProyecto.Open();
                    String preg = ("SELECT NombreU FROM Usuarios WHERE NombreU = '" + Nombre + "'");
                    OleDbCommand comando = new OleDbCommand(preg, DatabaseProyecto);
                    OleDbDataAdapter da = new OleDbDataAdapter(comando);
                    da.Fill(ds, "Usuarios");
                    int contar = ds.Tables["Usuarios"].Rows.Count;

                    {
                        if (contar == 1)
                        {
                            MessageBox.Show("Ese nombre ya esta en uso");
                            ds.Clear(); //limpia el data set para la proxima lectura
                            DatabaseProyecto.Close();
                            return;
                        }

                        else
                        {
                            OleDbCommand info;
                            info = new OleDbCommand("INSERT INTO Usuarios (NombreU, ContrasenaU) VALUES ('" + Nombre + "' , '" + ContrasenaU + "')");
                            info.Connection = DatabaseProyecto;
                            info.ExecuteNonQuery();
                           
                            string value = "";
                            if (InputBox("Pregunta de seguridad", "¿Cual es el primer nombre de tu mamá?", ref value) == DialogResult.OK)
                            {
                                while (value == "")
                                {
                                    MessageBox.Show("Complete la pregunta");

                                if (InputBox("Pregunta de seguridad", "¿Cual es el primer nombre de tu mamá?", ref value) == DialogResult.OK)
                                { 
                                        OleDbCommand info1;
                                        value = value.ToUpper();
                                        info1 = new OleDbCommand("UPDATE Usuarios SET Pregunta1 = '" + value + "' WHERE NombreU = '" + Nombre + "'");
                                        info1.Connection = DatabaseProyecto;
                                        info1.ExecuteNonQuery();
                                }
                                }


                            }

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
        //empieza diseño de pregunta secreta
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
            buttonOk.CausesValidation = true;

            label.SetBounds(26, 36, 186, 7);
            textBox.SetBounds(26, 86, 350, 10);
            buttonOk.SetBounds(160, 130, 80, 30);

            label.AutoSize = true;
            form.ClientSize = new Size(398, 180);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.BackColor = Color.LemonChiffon;
            form.ForeColor = Color.Black;
            form.Font = new Font("Microsoft YaHei UI", 10);

            form.Controls.AddRange(new Control[] {label, textBox, buttonOk});
            form.AcceptButton = buttonOk;

            DialogResult dialogResult = form.ShowDialog();

            value = textBox.Text;
            return dialogResult;
         
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            pantalla_logueo Nuevaventana = new pantalla_logueo();
            Nuevaventana.Show();
        }
    }
    }
