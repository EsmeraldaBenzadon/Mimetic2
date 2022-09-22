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
        //QUIZ GAME VARIABLES
        int correctQuestion;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestion;

        public quizgame()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {

        }
        private void askQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    prueba.Image = Properties.Resources.inside_out_joy;
                    break;
                    IblQuestion.Text = ("¿CUAL ES LA CORRECTA?");
                    button1.Text = 


            }
           

    }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
