using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public quizgame()
        {
            InitializeComponent();
            askQuestion(questionNumber);
            totalQuestions = 10;
        }

        private void checkAswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
            }

            if (questionNumber == totalQuestions)
            {
                //porcentaje de respuestas correctas 
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);
                MessageBox.Show (
                    
                    "¡TERMINASTE EL CUESTIONARIO!" + Environment.NewLine + 
                    "OBTUVISTE  " + score + " RESPUESTAS CORRECTAS  " + Environment.NewLine + 
                    "TU PORCENTAJE TOTAL ES " + percentage + " de 100" + Environment.NewLine + 
                    "PRESIONA OK PARA JUGARLO DE NUEVO"
                    );
                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);

            }
            questionNumber++;
            askQuestion(questionNumber);
        }
        private void askQuestion (int qnum)
        {
           /* switch(qnum)
            {
                case 1:
                    pictureBox2.Image = Properties.Resources.PAPASINCO;
                    lblQuestion.Text = "¿CUAL ES LA CORRECTA?";
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
                    button3.Text = "PLANRA";
                    button4.Text = "AZUL";

                    correctAnswer = 1;
                    break;

                case 3:
                    pictureBox2.Image = Properties.Resources.hijosinco;
                    lblQuestion.Text = "¿CUAL ES LA CORRECTA?";
                    button1.Text = "HERMANA";
                    button2.Text = "PAPA";
                    button3.Text = "AMIGO";
                    button4.Text = "HIJO";

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

            } */
        }

        private void Quizgame_Load(object sender, EventArgs e)
        {

        }
    }
}
