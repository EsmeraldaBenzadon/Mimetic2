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
    public partial class quizgame222 : Form
    {
        //quiz variables
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;

        // db variables
        public string NombreUsu;
        OleDbConnection DatabaseProyecto;

        public quizgame222(string nombre)
        {
            InitializeComponent();
            askQuestion(questionNumber);
            totalQuestions = 10;
            NomUsu.Text = nombre;
            this.NombreUsu = nombre;

        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
            }

            if (questionNumber == totalQuestions)
            {
                DatabaseProyecto.Open();
                OleDbCommand info;
                info = new OleDbCommand("INSERT INTO Progreso (Id_juego, Fechayhora, Progreso, NombreU) VALUES (4,'" + DateTime.Now + "', 1, '" + NombreUsu + "')");
                info.Connection = DatabaseProyecto;
                info.ExecuteNonQuery();


                //Búsqueda de Juegos
                string consulta = "select sum(Progreso) from Progreso where NombreU = '" + NombreUsu + "' and Progreso = " + 1 + " and Id_juego = " + 4 + " ;";
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

        private void askQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    pictureBox2.Image = Properties.Resources.ener;
                    lblQuestion.Text = "ELIGE LA OPCION CORRECTA";
                    button1.Text = "MARZO";
                    button2.Text = "ENERO";
                    button3.Text = "JULIO";
                    button4.Text = "AGOSTO";

                    correctAnswer = 2;
                    break;

                case 2:
                    pictureBox2.Image = Properties.Resources.abril;
                    lblQuestion.Text = "¿CUAL ES LA CORRECTA?";
                    button1.Text = "ABRIL";
                    button2.Text = "ENERO";
                    button3.Text = "OCTUBRE";
                    button4.Text = "JUNIO";

                    correctAnswer = 1;
                    break;

                case 3:
                    pictureBox2.Image = Properties.Resources.agosto;
                    lblQuestion.Text = "¿CUAL ES LA CORRECTA?";
                    button1.Text = "MARZO";
                    button2.Text = "NOVIEMBRE";
                    button3.Text = "DICIEMBRE";
                    button4.Text = "AGOSTO";

                    correctAnswer = 4;
                    break;

                case 4:
                    pictureBox2.Image = Properties.Resources.noviembre;
                    lblQuestion.Text = "¿CUAL ES LA CORRECTA?";
                    button1.Text = "NOVIEMBRE";
                    button2.Text = "ABRIL";
                    button3.Text = "JULIO";
                    button4.Text = "MAYO";

                    correctAnswer = 2;
                    break;

                case 5:
                    pictureBox2.Image = Properties.Resources.febrero;
                    lblQuestion.Text = "¿CUAL ES LA CORRECTA?";
                    button1.Text = "FEBRERO";
                    button2.Text = "DICIEMBRE";
                    button3.Text = "MAYO";
                    button4.Text = "ABRIL";

                    correctAnswer = 1;
                    break;

                case 6:
                    pictureBox2.Image = Properties.Resources.junio;
                    lblQuestion.Text = "¿CUAL ES LA CORRECTA?";
                    button1.Text = "ENERO";
                    button2.Text = "OCTUBRE";
                    button3.Text = "JUNIO";
                    button4.Text = "JULIO";

                    correctAnswer = 3;
                    break;

                case 7:
                    pictureBox2.Image = Properties.Resources.septiembre;
                    lblQuestion.Text = "¿CUAL ES LA CORRECTA?";
                    button1.Text = "SEPTIEMBRE";
                    button2.Text = "OCTUBRE";
                    button3.Text = "FEBRERO";
                    button4.Text = "ABRIL";

                    correctAnswer = 1;
                    break;

                case 8:
                    pictureBox2.Image = Properties.Resources.mayo;
                    lblQuestion.Text = "¿CUAL ES LA CORRECTA?";
                    button1.Text = "MAYO";
                    button2.Text = "JULIO";
                    button3.Text = "DICIEMBRE";
                    button4.Text = "MARZO";

                    correctAnswer = 1;
                    break;

                case 9:
                    pictureBox2.Image = Properties.Resources.marzo;
                    lblQuestion.Text = "¿CUAL ES LA CORRECTA?";
                    button1.Text = "JULIO";
                    button2.Text = "MARZO";
                    button3.Text = "FEBRERO";
                    button4.Text = "DICIEMBRE";

                    correctAnswer = 2;
                    break;

                case 10:
                    pictureBox2.Image = Properties.Resources.diciembre;
                    lblQuestion.Text = "¿CUAL ES LA CORRECTA?";
                    button1.Text = "MAYO";
                    button2.Text = "ENERO";
                    button3.Text = "JULIO";
                    button4.Text = "DICIEMBRE";

                    correctAnswer = 4;
                    break;
            }
        }

        private void Quizgame222_Load(object sender, EventArgs e)
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

        
