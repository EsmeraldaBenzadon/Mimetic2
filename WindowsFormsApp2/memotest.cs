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
    public partial class memotest : Form
    {
        bool allowClick = false;
        PictureBox firstGuess;
        Random rnd = new Random();
        Timer clickTimer = new Timer();
        int time = 60;
        Timer timer = new Timer { Interval = 1000 };
        public memotest()
        {
            InitializeComponent();

        }
        private PictureBox[] pictureBoxes
        {
            get { return Controls.OfType<PictureBox>().ToArray(); }
        }

        private static IEnumerable<Image> images
        {
            get
            {
                return new Image[]
                {
                    Properties.Resources.MAL,
                    Properties.Resources.MUYBIEN,
                    Properties.Resources.MUYMALPEOR,
                    Properties.Resources.PERDON_DISCULPAS,
                    Properties.Resources.PERMISO,
                    Properties.Resources.QUETAL,
                    Properties.Resources.TODOBIEN,
                    Properties.Resources.MUYMAL,
                };
            }
        }

        private void startGameTimer()
        {
            timer.Start();//programación del timer 
            timer.Tick += delegate
            {
                time--;
                if (time < 0)
                {
                    timer.Stop();
                    MessageBox.Show("TE QUEDASTE SIN TIEMPO");
                    ResetImages();
                }
                var ssTime = TimeSpan.FromSeconds(time);
                label1.Text = "00: " + time.ToString();
            };
        }
        private void ResetImages()//memotest y la aparición de imagenes
        {
            foreach (var pic in pictureBoxes)
            {
                pic.Tag = null;
                pic.Visible = true;
            }
            HideImages();
            setRandomImages();
            time = 60;
            timer.Start();
        }
        private void HideImages()
        {
            foreach (var pic in pictureBoxes)
            {
                pic.Image = Properties.Resources.question;
            }
        }

        private PictureBox getFreeSlot()
        {
            int num;
            do
            {
                num = rnd.Next(0, pictureBoxes.Count());
            }
            while (pictureBoxes[num].Tag != null);
            return pictureBoxes[num];
        }

        private void setRandomImages()
        {
            foreach (var image in images)
            {

                getFreeSlot().Tag = image;
                getFreeSlot().Tag = image;

            }
        }

        private void CLICKTIMER_TICK(object sender, EventArgs e)
        {
            HideImages();
            allowClick = true;
            clickTimer.Stop();
        }
        private void clickImage(object sender, EventArgs e)
        {
            if (!allowClick) return;
            var pic = (PictureBox)sender;

            if (firstGuess == null)
            {
                firstGuess = pic;
                pic.Image = (Image)pic.Tag;
                return;
            }
            pic.Image = (Image)pic.Tag;

            if (pic.Image == firstGuess.Image && pic != firstGuess)
            {
                pic.Visible = firstGuess.Visible = false;
                {
                    firstGuess = pic;

                }
                HideImages();
            }
            else
            {
                allowClick = false;
                clickTimer.Start();

            }
            firstGuess = null;
            if (pictureBoxes.Any(p => p.Visible)) return;
            MessageBox.Show("GANASTE, ¡PRUEBA DE NUEVO!");
            ResetImages();
        }
        private void startGame(object sender, EventArgs e)
        {
            allowClick = true;
            setRandomImages();
            HideImages();
            startGameTimer();
            clickTimer.Interval = 1000;
            clickTimer.Tick += CLICKTIMER_TICK;
            btnStart.Enabled = false;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            if (!allowClick) return;
            var pic = (PictureBox)sender;

            if (firstGuess == null)
            {
                firstGuess = pic;
                pic.Image = (Image)pic.Tag;
                return;
            }
            pic.Image = (Image)pic.Tag;

            if (pic.Image == firstGuess.Image && pic != firstGuess)
            {
                pic.Visible = firstGuess.Visible = false;
                {
                    firstGuess = pic;

                }
                HideImages();
            }
            else
            {
                allowClick = false;
                clickTimer.Start();

            }
            firstGuess = null;
            if (pictureBoxes.Any(p => p.Visible)) return;
            MessageBox.Show("GANASTE, ¡PRUEBA DE NUEVO!");
            ResetImages();
        }

        private void PictureBox3_Click(object sender, EventArgs e)//programación de las imagenes
        {
            if (!allowClick) return;
            var pic = (PictureBox)sender;

            if (firstGuess == null)
            {
                firstGuess = pic;
                pic.Image = (Image)pic.Tag;
                return;
            }
            pic.Image = (Image)pic.Tag;

            if (pic.Image == firstGuess.Image && pic != firstGuess)
            {
                pic.Visible = firstGuess.Visible = false;
                {
                    firstGuess = pic;

                }
                HideImages();
            }
            else
            {
                allowClick = false;
                clickTimer.Start();

            }
            firstGuess = null;
            if (pictureBoxes.Any(p => p.Visible)) return;
            MessageBox.Show("GANASTE, ¡PRUEBA DE NUEVO!");
            ResetImages();
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            if (!allowClick) return;
            var pic = (PictureBox)sender;

            if (firstGuess == null)
            {
                firstGuess = pic;
                pic.Image = (Image)pic.Tag;
                return;
            }
            pic.Image = (Image)pic.Tag;

            if (pic.Image == firstGuess.Image && pic != firstGuess)
            {
                pic.Visible = firstGuess.Visible = false;
                {
                    firstGuess = pic;

                }
                HideImages();
            }
            else
            {
                allowClick = false;
                clickTimer.Start();

            }
            firstGuess = null;
            if (pictureBoxes.Any(p => p.Visible)) return;
            MessageBox.Show("GANASTE, ¡PRUEBA DE NUEVO!");
            ResetImages();
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            if (!allowClick) return;
            var pic = (PictureBox)sender;

            if (firstGuess == null)
            {
                firstGuess = pic;
                pic.Image = (Image)pic.Tag;
                return;
            }
            pic.Image = (Image)pic.Tag;

            if (pic.Image == firstGuess.Image && pic != firstGuess)
            {
                pic.Visible = firstGuess.Visible = false;
                {
                    firstGuess = pic;

                }
                HideImages();
            }
            else
            {
                allowClick = false;
                clickTimer.Start();

            }
            firstGuess = null;
            if (pictureBoxes.Any(p => p.Visible)) return;
            MessageBox.Show("GANASTE, ¡PRUEBA DE NUEVO!");
            ResetImages();
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            if (!allowClick) return;
            var pic = (PictureBox)sender;

            if (firstGuess == null)
            {
                firstGuess = pic;
                pic.Image = (Image)pic.Tag;
                return;
            }
            pic.Image = (Image)pic.Tag;

            if (pic.Image == firstGuess.Image && pic != firstGuess)
            {
                pic.Visible = firstGuess.Visible = false;
                {
                    firstGuess = pic;

                }
                HideImages();
            }
            else
            {
                allowClick = false;
                clickTimer.Start();

            }
            firstGuess = null;
            if (pictureBoxes.Any(p => p.Visible)) return;
            MessageBox.Show("GANASTE, ¡PRUEBA DE NUEVO!");
            ResetImages();
        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {
            if (!allowClick) return;
            var pic = (PictureBox)sender;

            if (firstGuess == null)
            {
                firstGuess = pic;
                pic.Image = (Image)pic.Tag;
                return;
            }
            pic.Image = (Image)pic.Tag;

            if (pic.Image == firstGuess.Image && pic != firstGuess)
            {
                pic.Visible = firstGuess.Visible = false;
                {
                    firstGuess = pic;

                }
                HideImages();
            }
            else
            {
                allowClick = false;
                clickTimer.Start();

            }
            firstGuess = null;
            if (pictureBoxes.Any(p => p.Visible)) return;
            MessageBox.Show("GANASTE, ¡PRUEBA DE NUEVO!");
            ResetImages();
        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {
            if (!allowClick) return;
            var pic = (PictureBox)sender;

            if (firstGuess == null)
            {
                firstGuess = pic;
                pic.Image = (Image)pic.Tag;
                return;
            }
            pic.Image = (Image)pic.Tag;

            if (pic.Image == firstGuess.Image && pic != firstGuess)
            {
                pic.Visible = firstGuess.Visible = false;
                {
                    firstGuess = pic;

                }
                HideImages();
            }
            else
            {
                allowClick = false;
                clickTimer.Start();

            }
            firstGuess = null;
            if (pictureBoxes.Any(p => p.Visible)) return;
            MessageBox.Show("GANASTE, ¡PRUEBA DE NUEVO!");
            ResetImages();
        }

        private void PictureBox9_Click(object sender, EventArgs e)
        {
            if (!allowClick) return;
            var pic = (PictureBox)sender;

            if (firstGuess == null)
            {
                firstGuess = pic;
                pic.Image = (Image)pic.Tag;
                return;
            }
            pic.Image = (Image)pic.Tag;

            if (pic.Image == firstGuess.Image && pic != firstGuess)
            {
                pic.Visible = firstGuess.Visible = false;
                {
                    firstGuess = pic;

                }
                HideImages();
            }
            else
            {
                allowClick = false;
                clickTimer.Start();

            }
            firstGuess = null;
            if (pictureBoxes.Any(p => p.Visible)) return;
            MessageBox.Show("GANASTE, ¡PRUEBA DE NUEVO!");
            ResetImages();
        }

        private void PictureBox10_Click(object sender, EventArgs e)
        {
            if (!allowClick) return;
            var pic = (PictureBox)sender;

            if (firstGuess == null)
            {
                firstGuess = pic;
                pic.Image = (Image)pic.Tag;
                return;
            }
            pic.Image = (Image)pic.Tag;

            if (pic.Image == firstGuess.Image && pic != firstGuess)
            {
                pic.Visible = firstGuess.Visible = false;
                {
                    firstGuess = pic;

                }
                HideImages();
            }
            else
            {
                allowClick = false;
                clickTimer.Start();

            }
            firstGuess = null;
            if (pictureBoxes.Any(p => p.Visible)) return;
            MessageBox.Show("GANASTE, ¡PRUEBA DE NUEVO!");
            ResetImages();
        }

        private void PictureBox11_Click(object sender, EventArgs e)
        {
            if (!allowClick) return;
            var pic = (PictureBox)sender;

            if (firstGuess == null)
            {
                firstGuess = pic;
                pic.Image = (Image)pic.Tag;
                return;
            }
            pic.Image = (Image)pic.Tag;

            if (pic.Image == firstGuess.Image && pic != firstGuess)
            {
                pic.Visible = firstGuess.Visible = false;
                {
                    firstGuess = pic;

                }
                HideImages();
            }
            else
            {
                allowClick = false;
                clickTimer.Start();

            }
            firstGuess = null;
            if (pictureBoxes.Any(p => p.Visible)) return;
            MessageBox.Show("GANASTE, ¡PRUEBA DE NUEVO!");
            ResetImages();
        }

        private void PictureBox12_Click(object sender, EventArgs e)
        {
            if (!allowClick) return;
            var pic = (PictureBox)sender;

            if (firstGuess == null)
            {
                firstGuess = pic;
                pic.Image = (Image)pic.Tag;
                return;
            }
            pic.Image = (Image)pic.Tag;

            if (pic.Image == firstGuess.Image && pic != firstGuess)
            {
                pic.Visible = firstGuess.Visible = false;
                {
                    firstGuess = pic;

                }
                HideImages();
            }
            else
            {
                allowClick = false;
                clickTimer.Start();

            }
            firstGuess = null;
            if (pictureBoxes.Any(p => p.Visible)) return;
            MessageBox.Show("GANASTE, ¡PRUEBA DE NUEVO!");
            ResetImages();
        }

        private void PictureBox13_Click(object sender, EventArgs e)
        {
            if (!allowClick) return;
            var pic = (PictureBox)sender;

            if (firstGuess == null)
            {
                firstGuess = pic;
                pic.Image = (Image)pic.Tag;
                return;
            }
            pic.Image = (Image)pic.Tag;

            if (pic.Image == firstGuess.Image && pic != firstGuess)
            {
                pic.Visible = firstGuess.Visible = false;
                {
                    firstGuess = pic;

                }
                HideImages();
            }
            else
            {
                allowClick = false;
                clickTimer.Start();

            }
            firstGuess = null;
            if (pictureBoxes.Any(p => p.Visible)) return;
            MessageBox.Show("GANASTE, ¡PRUEBA DE NUEVO!");
            ResetImages();
        }

        private void PictureBox14_Click(object sender, EventArgs e)
        {
            if (!allowClick) return;
            var pic = (PictureBox)sender;

            if (firstGuess == null)
            {
                firstGuess = pic;
                pic.Image = (Image)pic.Tag;
                return;
            }
            pic.Image = (Image)pic.Tag;

            if (pic.Image == firstGuess.Image && pic != firstGuess)
            {
                pic.Visible = firstGuess.Visible = false;
                {
                    firstGuess = pic;

                }
                HideImages();
            }
            else
            {
                allowClick = false;
                clickTimer.Start();

            }
            firstGuess = null;
            if (pictureBoxes.Any(p => p.Visible)) return;
            MessageBox.Show("GANASTE, ¡PRUEBA DE NUEVO!");
            ResetImages();
        }

        private void PictureBox15_Click(object sender, EventArgs e)
        {
            if (!allowClick) return;
            var pic = (PictureBox)sender;

            if (firstGuess == null)
            {
                firstGuess = pic;
                pic.Image = (Image)pic.Tag;
                return;
            }
            pic.Image = (Image)pic.Tag;

            if (pic.Image == firstGuess.Image && pic != firstGuess)
            {
                pic.Visible = firstGuess.Visible = false;
                {
                    firstGuess = pic;

                }
                HideImages();
            }
            else
            {
                allowClick = false;
                clickTimer.Start();

            }
            firstGuess = null;
            if (pictureBoxes.Any(p => p.Visible)) return;
            MessageBox.Show("GANASTE, ¡PRUEBA DE NUEVO!");
            ResetImages();
        }

        private void PictureBox16_Click(object sender, EventArgs e)
        {
            if (!allowClick) return;
            var pic = (PictureBox)sender;

            if (firstGuess == null)
            {
                firstGuess = pic;
                pic.Image = (Image)pic.Tag;
                return;
            }
            pic.Image = (Image)pic.Tag;

            if (pic.Image == firstGuess.Image && pic != firstGuess)
            {
                pic.Visible = firstGuess.Visible = false;
                {
                    firstGuess = pic;

                }
                HideImages();
            }
            else
            {
                allowClick = false;
                clickTimer.Start();

            }
            firstGuess = null;
            if (pictureBoxes.Any(p => p.Visible)) return;
            MessageBox.Show("GANASTE, ¡PRUEBA DE NUEVO!");
            ResetImages();
        }

        private void Memotest_Load(object sender, EventArgs e)
        {

        }
    }
}
