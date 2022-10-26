﻿using System;
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
    public partial class quizgame222 : Form
    {
        //quiz variables
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        public quizgame222()
        {
            InitializeComponent();
            askQuestion(questionNumber);
            totalQuestions = 10;

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
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show("Terminaste el juego!" + Environment.NewLine + "TUVISTE " + "RESPUESTAS CORRECTAS" + score + Environment.NewLine
                    + "Tu porsentaje total es de " + percentage + " de 100" + "PRESIONA OK PARA JUGAR DE NUEVO");

                {
                    score = 0;
                    questionNumber = 0;
                    askQuestion(questionNumber);

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
    }
}
        
