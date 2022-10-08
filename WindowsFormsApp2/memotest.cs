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
    public partial class memotest : Form
    {
        bool allowClick = false;
        PictureBox firstGuess;
        Random rnd = new Random();
        Timer clickTimer = new Timer();
        int time = 60;
        Timer timer = new Timer { Interval = 1000 };

        //variables declaradas
        OleDbConnection DatabaseProyecto;
        string NombreU;

        public memotest(string NombreU)
        {
            InitializeComponent();
            this.NombreU = NombreU;
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
                    DatabaseProyecto.Open();
                    OleDbCommand info;
                    info = new OleDbCommand("INSERT INTO Progreso (Id_juego, Fechayhora, Progreso, NombreU) VALUES (1,'" + DateTime.Now +"', 0, '" + NombreU + "')");
                    info.Connection = DatabaseProyecto;
                    info.ExecuteNonQuery();
                    DatabaseProyecto.Close();
                    if (InputBox("Te quedaste sin tiempo", "¿Quieres volverlo a intentar?") == DialogResult.OK)
                    {
                        ResetImages();
                    }
                    else
                    {
                        this.Hide();
                        //menu_juegos abrir = new menu_juegos();
                        //abrir.Show();
                    }
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
            if (pictureBoxes.Any(p => p.Visible))return;
            {
                DatabaseProyecto.Open();
                OleDbCommand info;
                info = new OleDbCommand("INSERT INTO Progreso (Id_juego, Fechayhora, Progreso, NombreU) VALUES (1,'" + DateTime.Now + "', 1, '" + NombreU + "')");
                info.Connection = DatabaseProyecto;
                info.ExecuteNonQuery();
                DatabaseProyecto.Close();
                if (InputBox("Ganaste !!", "¿Quieres volverlo a intentar?") == DialogResult.OK)
                {
                    ResetImages();
                }
                else
                {
                    this.Hide();
                    //menu_juegos abrir = new menu_juegos();
                    //abrir.Show();
                }
            }
            //MessageBox.Show("GANASTE, ¡PRUEBA DE NUEVO!");

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

            label.SetBounds(26, 36, 186, 7);
            buttonOk.SetBounds(160, 130, 80, 30);
            buttoncancel.SetBounds(130, 130, 80, 30);

            label.AutoSize = true;
            form.ClientSize = new Size(398, 180);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;

            form.Controls.AddRange(new Control[] { label, buttonOk, buttoncancel });
            form.AcceptButton = buttonOk;
            form.CancelButton = buttoncancel;

            DialogResult dialogResult = form.ShowDialog();

            return dialogResult;

        }
    }
}

