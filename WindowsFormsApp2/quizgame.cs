using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class quizgame : Form
    {
        //quiz variables
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;


        OleDbConnection DatabaseProyecto;
        public string NombreUsu;

        public quizgame(string nombre)
        {
            InitializeComponent();
            askQuestion(questionNumber);
            totalQuestions = 10;
            NomUsu.Text = nombre;
            this.NombreUsu = nombre;
        }

        private void checkAswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
            }

            if(questionNumber == totalQuestions)
            {
                DatabaseProyecto.Open();
                OleDbCommand info;
                info = new OleDbCommand("INSERT INTO Progreso (Id_juego, Fechayhora, Progreso, NombreU) VALUES (3,'" + DateTime.Now + "', 1, '" + NombreUsu + "')");
                info.Connection = DatabaseProyecto;
                info.ExecuteNonQuery();


                //Búsqueda de Juegos
                string consulta = "select sum(Progreso) from Progreso where NombreU = '" + NombreUsu + "' and Progreso = " + 1 + " and Id_juego = " + 3 + " ;";
                int juegos = accesobd(consulta);
                DatabaseProyecto.Close();

                //porcentaje de respuestas correctas 
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                if 
                    (InputBox("¡Terminaste el juego!", "Tuviste  " + score + " de respuestas correctas. Muy bien!  " + "\n" +
                    "Tu porsentaje total es de " + percentage + " de 100" + Environment.NewLine +
                    " Ya has jugado " + juegos + " veces" + "\n" + "Si quieres intentarlo una vez mas hace click en aceptar") == DialogResult.OK)
                {
                    score = 0;
                    questionNumber = 0;
                    askQuestion(questionNumber);
                }
                else
                {
                    this.Hide();
                    nivelesquiz abrir = new nivelesquiz(NombreUsu);
                    abrir.Show();
                }             
            }
            questionNumber++;
            askQuestion(questionNumber);
        }
        private void askQuestion (int qnum)
        {
          switch(qnum)
            {
                case 1:
                    pictureBox2.Image = Properties.Resources.PAPASINCO;
                    lblQuestion.Text = "ELIGE LA OPCION CORRECTA";
                    button1.Text = "MAMÁ";
                    button2.Text = "PAPÁ";
                    button3.Text = "HERMANA";
                    button4.Text = "PRIMO";

                    correctAnswer = 2;
                    break;


                case 2:
                    pictureBox2.Image = Properties.Resources.mamasinco;
                    lblQuestion.Text = "¿CUAL ES LA CORRECTA?";
                    button1.Text = "MAMÁ";
                    button2.Text = "PERRO";
                    button3.Text = "PLANTA";
                    button4.Text = "AZUL";

                    correctAnswer = 1;
                    break;

                case 3:
                    pictureBox2.Image = Properties.Resources.hijosinco;
                    lblQuestion.Text = "¿CUAL ES LA CORRECTA?";
                    button1.Text = "HERMANA";
                    button2.Text = "HIJO";
                    button3.Text = "AMIGO";
                    button4.Text = "HOMBRE";

                    correctAnswer = 4;
                    break;

                case 4:
                    pictureBox2.Image = Properties.Resources.bebesinco;
                    lblQuestion.Text = "¿CUAL ES LA CORRECTA?";
                    button1.Text = "HIJA";
                    button2.Text = "BEBE";
                    button3.Text = "PRIMA";
                    button4.Text = "NOVIO";

                    correctAnswer = 2;
                    break;

                case 5:
                    pictureBox2.Image = Properties.Resources.hijasinco;
                    lblQuestion.Text = "¿CUAL ES LA CORRECTA?";
                    button1.Text = "HIJA";
                    button2.Text = "PAPÁ";
                    button3.Text = "NOVIA";
                    button4.Text = "GATO";

                    correctAnswer = 1;
                    break;

                case 6:
                    pictureBox2.Image = Properties.Resources.hermanossinco;
                    lblQuestion.Text = "¿CUAL ES LA CORRECTA?";
                    button1.Text = "PRIMO";
                    button2.Text = "ABUELA";
                    button3.Text = "HERMANOS";
                    button4.Text = "PRIMO";

                    correctAnswer = 3;
                    break;

                case 7:
                    pictureBox2.Image = Properties.Resources.mellizossinco;
                    lblQuestion.Text = "¿CUAL ES LA CORRECTA?";
                    button1.Text = "MELLIZOS";
                    button2.Text = "AMIGOS";
                    button3.Text = "HERMANA";
                    button4.Text = "DORMIR";

                    correctAnswer = 1;
                    break;

                case 8:
                    pictureBox2.Image = Properties.Resources.abuelasinco;
                    lblQuestion.Text = "¿CUAL ES LA CORRECTA?";
                    button1.Text = "ABUELA";
                    button2.Text = "TIO";
                    button3.Text = "HERMANA";
                    button4.Text = "PRIMO";

                    correctAnswer = 1;
                    break;

                case 9:
                    pictureBox2.Image = Properties.Resources.sobrinosinco;
                    lblQuestion.Text = "¿CUAL ES LA CORRECTA?";
                    button1.Text = "TIO";
                    button2.Text = "SOBRINO";
                    button3.Text = "TIA";
                    button4.Text = "PRIMO";

                    correctAnswer = 2;
                    break;

                case 10:
                    pictureBox2.Image = Properties.Resources.esposasinco;
                    lblQuestion.Text = "¿CUAL ES LA CORRECTA?";
                    button1.Text = "ESPOSO";
                    button2.Text = "MARIDO";
                    button3.Text = "NOVIA";
                    button4.Text = "ESPOSA";

                    correctAnswer = 4;
                    break;                   

          }
        }

        private void Quizgame_Load(object sender, EventArgs e)
        {
            DatabaseProyecto = new OleDbConnection();
            DatabaseProyecto.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = DatabaseProyecto.accdb";
        }

        private static DialogResult InputBox(string title, string promptText)
        {
            Form form = new Form();
            Label label = new Label();
            Button buttonOk = new Button();
            Button buttoncancel = new Button();

            form.Text = title;
            label.Text = promptText;

            buttonOk.Text = "OK";
            buttonOk.DialogResult = DialogResult.OK;
            buttonOk.CausesValidation = true;
            buttoncancel.Text = "Salir";
            buttoncancel.DialogResult = DialogResult.Cancel;
            buttoncancel.CausesValidation = true;

            label.SetBounds(26, 32, 186, 7);
            buttonOk.SetBounds(220, 100, 80, 30);
            buttoncancel.SetBounds(100, 100, 80, 30);

            label.AutoSize = true;
            form.ClientSize = new Size(398, 150);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.BackColor = Color.LightSalmon;
            form.ForeColor = Color.Black;
            form.Font = new Font("Microsoft Sans Serif", 9);
            buttonOk.BackColor = Color.White;
            buttoncancel.BackColor = Color.White;


            form.Controls.AddRange(new Control[] { label, buttonOk, buttoncancel });
            form.AcceptButton = buttonOk;
            form.CancelButton = buttoncancel;

            DialogResult dialogResult = form.ShowDialog();

            return dialogResult;
        }

            private int accesobd(string consulta)
        {
            //Búsqueda de Juegos 
            OleDbCommand comando = new OleDbCommand(consulta, DatabaseProyecto);
            string datosjuego = comando.ExecuteScalar().ToString();
            int juegos = Convert.ToInt32(datosjuego);
            return juegos;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            nivelesquiz abrir = new nivelesquiz(NombreUsu);
            abrir.Show();
        }
    }
}
