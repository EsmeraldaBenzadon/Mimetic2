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

    public partial class memotest222 : Form
    {

        bool allowClick = false;
        PictureBox firstGuess;
        Random rnd = new Random();
        Timer clickTimer = new Timer();
        //int time = 60;
        int time = 5;
        Timer timer = new Timer { Interval = 1000 };

        //variables declaradas
        OleDbConnection DatabaseProyecto;
        string NombreU;
        public string NombreUsu;
        

        public memotest222(string NombreU)
        {
            InitializeComponent();
            this.NombreU = NombreU;
            NomUsu.Text = NombreU;
        }
        


        private PictureBox[] pictureBoxes
        {
            get { return Controls.OfType<PictureBox>().ToArray(); } //insertar las picture box en un array 
        }

        private static IEnumerable<Image> images
        {
            get
            {
                return new Image[]
                {
                    Properties.Resources.lunes,
                    Properties.Resources.martes,
                    Properties.Resources.miercoles,
                    Properties.Resources.jueves,
                    Properties.Resources.viernes,
                    Properties.Resources.sabado,
                    Properties.Resources.domingo,
                    Properties.Resources.semana,
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
                    info = new OleDbCommand("INSERT INTO Progreso (Id_juego, Fechayhora, Progreso, NombreU) VALUES (2,'" + DateTime.Now + "', 0, '" + NombreU + "')");
                    info.Connection = DatabaseProyecto;
                    info.ExecuteNonQuery();

                    //Búsqueda de Juegos Ganados
                    string consulta = "select sum(Progreso) from Progreso where NombreU = '" + NombreU + "' and Progreso = " + 1 + " and Id_juego = " + 2 + ";";
                    int juegoswin = accesobd(consulta);


                    //Búsqueda de Juegos Perdidos
                    consulta = "select count(Progreso) from Progreso where NombreU = '" + NombreU + "' and Progreso = " + 0 + " and Id_juego = " + 2 + ";";
                    int juegoslose = accesobd(consulta);

                    //Calculo Juegos Perdidos
                    double PorPer;
                    PorPer = ((double)juegoslose) / ((double)juegoslose + (double)juegoswin) * 100;
                    string juegoper = juegoslose.ToString() + " Juegos (" + PorPer.ToString("N1") + "%)";

                    //Calculo Juegos Ganados
                    double PorGan = (double)juegoswin / ((double)juegoslose + (double)juegoswin) * 100;
                    string juegowin = juegoswin.ToString() + " Juegos (" + PorGan.ToString("N1") + "%)";
                    DatabaseProyecto.Close();

                    if (InputBox("Te quedaste sin tiempo", "Has ganado " + juegowin + " y has perdido " + juegoper + "\n\n" + "¿Quieres volverlo a intentar?") == DialogResult.OK)
                    {
                        ResetImages();
                    }
                    else
                    {
                        this.Hide();
                        nivelesmemotest abrir = new nivelesmemotest(NombreU);
                        abrir.Show();
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

        private void pictureBox1_Click(object sender, EventArgs e)
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
            {
                timer.Stop();
                DatabaseProyecto.Open();
                OleDbCommand info;
                info = new OleDbCommand("INSERT INTO Progreso (Id_juego, Fechayhora, Progreso, NombreU) VALUES (2,'" + DateTime.Now + "', 1, '" + NombreU + "')");
                info.Connection = DatabaseProyecto;
                info.ExecuteNonQuery();

                //Búsqueda de Juegos Ganados
                string consulta = "select sum(Progreso) from Progreso where NombreU = '" + NombreU + "' and Progreso = " + 1 + " and Id_juego = " + 2 + ";";
                int juegoswin = accesobd(consulta);


                //Búsqueda de Juegos Perdidos
                consulta = "select count(Progreso) from Progreso where NombreU = '" + NombreU + "' and Progreso = " + 0 + " and Id_juego = " + 2 + ";";
                int juegoslose = accesobd(consulta);

                //Calculo Juegos Perdidos
                double PorPer;
                PorPer = ((double)juegoslose) / ((double)juegoslose + (double)juegoswin) * 100;
                string juegoper = juegoslose.ToString() + " Juegos (" + PorPer.ToString("N1") + "%)";

                //Calculo Juegos Ganados
                double PorGan = (double)juegoswin / ((double)juegoslose + (double)juegoswin) * 100;
                string juegowin = juegoswin.ToString() + " Juegos (" + PorGan.ToString("N1") + "%)";
                DatabaseProyecto.Close();

                if (InputBox("Ganaste !!", "Has ganado " + juegowin + " y has perdido " + juegoper + "\n\n" + "¿Quieres volverlo a intentar?") == DialogResult.OK)
                {
                    ResetImages();
                }
                else
                {
                    this.Hide();
                    nivelesmemotest abrir = new nivelesmemotest(NombreU);
                    abrir.Show();
                }
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
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
            {
                timer.Stop();
                DatabaseProyecto.Open();
                OleDbCommand info;
                info = new OleDbCommand("INSERT INTO Progreso (Id_juego, Fechayhora, Progreso, NombreU) VALUES (2,'" + DateTime.Now + "', 1, '" + NombreU + "')");
                info.Connection = DatabaseProyecto;
                info.ExecuteNonQuery();

                //Búsqueda de Juegos Ganados
                string consulta = "select sum(Progreso) from Progreso where NombreU = '" + NombreU + "' and Progreso = " + 1 + "and Id_juego = " + 2 + ";";
                int juegoswin = accesobd(consulta);


                //Búsqueda de Juegos Perdidos
                consulta = "select count(Progreso) from Progreso where NombreU = '" + NombreU + "' and Progreso = " + 0 + "and Id_juego = " + 2 + ";";
                int juegoslose = accesobd(consulta);

                //Calculo Juegos Perdidos
                double PorPer;
                PorPer = ((double)juegoslose) / ((double)juegoslose + (double)juegoswin) * 100;
                string juegoper = juegoslose.ToString() + " Juegos (" + PorPer.ToString("N1") + "%)";

                //Calculo Juegos Ganados
                double PorGan = (double)juegoswin / ((double)juegoslose + (double)juegoswin) * 100;
                string juegowin = juegoswin.ToString() + " Juegos (" + PorGan.ToString("N1") + "%)";
                DatabaseProyecto.Close();

                if (InputBox("Ganaste !!", "Has ganado " + juegowin + " y has perdido " + juegoper + "\n\n" + "¿Quieres volverlo a intentar?") == DialogResult.OK)
                {
                    ResetImages();
                }
                else
                {
                    this.Hide();
                    nivelesmemotest abrir = new nivelesmemotest(NombreU);
                    abrir.Show();
                }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
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

            {
                timer.Stop();
                DatabaseProyecto.Open();
                OleDbCommand info;
                info = new OleDbCommand("INSERT INTO Progreso (Id_juego, Fechayhora, Progreso, NombreU) VALUES (2,'" + DateTime.Now + "', 1, '" + NombreU + "')");
                info.Connection = DatabaseProyecto;
                info.ExecuteNonQuery();

                //Búsqueda de Juegos Ganados
                string consulta = "select sum(Progreso) from Progreso where NombreU = '" + NombreU + "' and Progreso = " + 1 + " and Id_juego = " + 2 + ";";
                int juegoswin = accesobd(consulta);


                //Búsqueda de Juegos Perdidos
                consulta = "select count(Progreso) from Progreso where NombreU = '" + NombreU + "' and Progreso = " + 0 + "and Id_juego = " + 2 + ";";
                int juegoslose = accesobd(consulta);

                //Calculo Juegos Perdidos
                double PorPer;
                PorPer = ((double)juegoslose) / ((double)juegoslose + (double)juegoswin) * 100;
                string juegoper = juegoslose.ToString() + " Juegos (" + PorPer.ToString("N1") + "%)";

                //Calculo Juegos Ganados
                double PorGan = (double)juegoswin / ((double)juegoslose + (double)juegoswin) * 100;
                string juegowin = juegoswin.ToString() + " Juegos (" + PorGan.ToString("N1") + "%)";
                DatabaseProyecto.Close();

                if (InputBox("Ganaste !!", "Has ganado " + juegowin + " y has perdido " + juegoper + "\n\n" + "¿Quieres volverlo a intentar?") == DialogResult.OK)
                {
                    ResetImages();
                }
                else
                {
                    this.Hide();
                    nivelesmemotest abrir = new nivelesmemotest(NombreU);
                    abrir.Show();
                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
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
            {
                timer.Stop();
                DatabaseProyecto.Open();
                OleDbCommand info;
                info = new OleDbCommand("INSERT INTO Progreso (Id_juego, Fechayhora, Progreso, NombreU) VALUES (2,'" + DateTime.Now + "', 1, '" + NombreU + "')");
                info.Connection = DatabaseProyecto;
                info.ExecuteNonQuery();

                //Búsqueda de Juegos Ganados
                string consulta = "select sum(Progreso) from Progreso where NombreU = '" + NombreU + "' and Progreso = " + 1 + " and Id_juego = " + 2 + ";";
                int juegoswin = accesobd(consulta);


                //Búsqueda de Juegos Perdidos
                consulta = "select count(Progreso) from Progreso where NombreU = '" + NombreU + "' and Progreso = " + 0 + "and Id_juego = " + 2 + ";";
                int juegoslose = accesobd(consulta);

                //Calculo Juegos Perdidos
                double PorPer;
                PorPer = ((double)juegoslose) / ((double)juegoslose + (double)juegoswin) * 100;
                string juegoper = juegoslose.ToString() + " Juegos (" + PorPer.ToString("N1") + "%)";

                //Calculo Juegos Ganados
                double PorGan = (double)juegoswin / ((double)juegoslose + (double)juegoswin) * 100;
                string juegowin = juegoswin.ToString() + " Juegos (" + PorGan.ToString("N1") + "%)";
                DatabaseProyecto.Close();

                if (InputBox("Ganaste !!", "Has ganado " + juegowin + " y has perdido " + juegoper + "\n\n" + "¿Quieres volverlo a intentar?") == DialogResult.OK)
                {
                    ResetImages();
                }
                else
                {
                    this.Hide();
                    nivelesmemotest abrir = new nivelesmemotest(NombreU);
                    abrir.Show();
                }
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
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
            {
                timer.Stop();
                DatabaseProyecto.Open();
                OleDbCommand info;
                info = new OleDbCommand("INSERT INTO Progreso (Id_juego, Fechayhora, Progreso, NombreU) VALUES (2,'" + DateTime.Now + "', 1, '" + NombreU + "')");
                info.Connection = DatabaseProyecto;
                info.ExecuteNonQuery();

                //Búsqueda de Juegos Ganados
                string consulta = "select sum(Progreso) from Progreso where NombreU = '" + NombreU + "' and Progreso = " + 1 + "and Id_juego = " + 2 + ";";
                int juegoswin = accesobd(consulta);


                //Búsqueda de Juegos Perdidos
                consulta = "select count(Progreso) from Progreso where NombreU = '" + NombreU + "' and Progreso = " + 0 + "and Id_juego = " + 2 + ";";
                int juegoslose = accesobd(consulta);

                //Calculo Juegos Perdidos
                double PorPer;
                PorPer = ((double)juegoslose) / ((double)juegoslose + (double)juegoswin) * 100;
                string juegoper = juegoslose.ToString() + " Juegos (" + PorPer.ToString("N1") + "%)";

                //Calculo Juegos Ganados
                double PorGan = (double)juegoswin / ((double)juegoslose + (double)juegoswin) * 100;
                string juegowin = juegoswin.ToString() + " Juegos (" + PorGan.ToString("N1") + "%)";
                DatabaseProyecto.Close();

                if (InputBox("Ganaste !!", "Has ganado " + juegowin + " y has perdido " + juegoper + "\n\n" + "¿Quieres volverlo a intentar?") == DialogResult.OK)
                {
                    ResetImages();
                }
                else
                {
                    this.Hide();
                    nivelesmemotest abrir = new nivelesmemotest(NombreU);
                    abrir.Show();
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
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

            {
                timer.Stop();
                DatabaseProyecto.Open();
                OleDbCommand info;
                info = new OleDbCommand("INSERT INTO Progreso (Id_juego, Fechayhora, Progreso, NombreU) VALUES (2,'" + DateTime.Now + "', 1, '" + NombreU + "')");
                info.Connection = DatabaseProyecto;
                info.ExecuteNonQuery();

                //Búsqueda de Juegos Ganados
                string consulta = "select sum(Progreso) from Progreso where NombreU = '" + NombreU + "' and Progreso = " + 1 + " and Id_juego = " + 2 + ";";
                int juegoswin = accesobd(consulta);


                //Búsqueda de Juegos Perdidos
                consulta = "select count(Progreso) from Progreso where NombreU = '" + NombreU + "' and Progreso = " + 0 + " and Id_juego = " + 2 + ";";
                int juegoslose = accesobd(consulta);

                //Calculo Juegos Perdidos
                double PorPer;
                PorPer = ((double)juegoslose) / ((double)juegoslose + (double)juegoswin) * 100;
                string juegoper = juegoslose.ToString() + " Juegos (" + PorPer.ToString("N1") + "%)";

                //Calculo Juegos Ganados
                double PorGan = (double)juegoswin / ((double)juegoslose + (double)juegoswin) * 100;
                string juegowin = juegoswin.ToString() + " Juegos (" + PorGan.ToString("N1") + "%)";
                DatabaseProyecto.Close();

                if (InputBox("Ganaste !!", "Has ganado " + juegowin + " y has perdido " + juegoper + "\n\n" + "¿Quieres volverlo a intentar?") == DialogResult.OK)
                {
                    ResetImages();
                }
                else
                {
                    this.Hide();
                    nivelesmemotest abrir = new nivelesmemotest(NombreU);
                    abrir.Show();
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
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

            {
                timer.Stop();
                DatabaseProyecto.Open();
                OleDbCommand info;
                info = new OleDbCommand("INSERT INTO Progreso (Id_juego, Fechayhora, Progreso, NombreU) VALUES (2,'" + DateTime.Now + "', 1, '" + NombreU + "')");
                info.Connection = DatabaseProyecto;
                info.ExecuteNonQuery();

                //Búsqueda de Juegos Ganados
                string consulta = "select sum(Progreso) from Progreso where NombreU = '" + NombreU + "' and Progreso = " + 1 + "and Id_juego = " + 2 + ";";
                int juegoswin = accesobd(consulta);


                //Búsqueda de Juegos Perdidos
                consulta = "select count(Progreso) from Progreso where NombreU = '" + NombreU + "' and Progreso = " + 0 + "and Id_juego = " + 2 + ";";
                int juegoslose = accesobd(consulta);

                //Calculo Juegos Perdidos
                double PorPer;
                PorPer = ((double)juegoslose) / ((double)juegoslose + (double)juegoswin) * 100;
                string juegoper = juegoslose.ToString() + " Juegos (" + PorPer.ToString("N1") + "%)";

                //Calculo Juegos Ganados
                double PorGan = (double)juegoswin / ((double)juegoslose + (double)juegoswin) * 100;
                string juegowin = juegoswin.ToString() + " Juegos (" + PorGan.ToString("N1") + "%)";
                DatabaseProyecto.Close();

                if (InputBox("Ganaste !!", "Has ganado " + juegowin + " y has perdido " + juegoper + "\n\n" + "¿Quieres volverlo a intentar?") == DialogResult.OK)
                {
                    ResetImages();
                }
                else
                {
                    this.Hide();
                    nivelesmemotest abrir = new nivelesmemotest(NombreU);
                    abrir.Show();
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
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

            {
                timer.Stop();
                DatabaseProyecto.Open();
                OleDbCommand info;
                info = new OleDbCommand("INSERT INTO Progreso (Id_juego, Fechayhora, Progreso, NombreU) VALUES (2,'" + DateTime.Now + "', 1, '" + NombreU + "')");
                info.Connection = DatabaseProyecto;
                info.ExecuteNonQuery();

                //Búsqueda de Juegos Ganados
                string consulta = "select sum(Progreso) from Progreso where NombreU = '" + NombreU + "' and Progreso = " + 1 + " and Id_juego = " + 2 + ";";
                int juegoswin = accesobd(consulta);


                //Búsqueda de Juegos Perdidos
                consulta = "select count(Progreso) from Progreso where NombreU = '" + NombreU + "' and Progreso = " + 0 + " and Id_juego = " + 2 + ";";
                int juegoslose = accesobd(consulta);

                //Calculo Juegos Perdidos
                double PorPer;
                PorPer = ((double)juegoslose) / ((double)juegoslose + (double)juegoswin) * 100;
                string juegoper = juegoslose.ToString() + " Juegos (" + PorPer.ToString("N1") + "%)";

                //Calculo Juegos Ganados
                double PorGan = (double)juegoswin / ((double)juegoslose + (double)juegoswin) * 100;
                string juegowin = juegoswin.ToString() + " Juegos (" + PorGan.ToString("N1") + "%)";
                DatabaseProyecto.Close();

                if (InputBox("Ganaste !!", "Has ganado " + juegowin + " y has perdido " + juegoper + "\n\n" + "¿Quieres volverlo a intentar?") == DialogResult.OK)
                {
                    ResetImages();
                }
                else
                {
                    this.Hide();
                    nivelesmemotest abrir = new nivelesmemotest(NombreU);
                    abrir.Show();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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

            {
                timer.Stop();
                DatabaseProyecto.Open();
                OleDbCommand info;
                info = new OleDbCommand("INSERT INTO Progreso (Id_juego, Fechayhora, Progreso, NombreU) VALUES (2,'" + DateTime.Now + "', 1, '" + NombreU + "')");
                info.Connection = DatabaseProyecto;
                info.ExecuteNonQuery();

                //Búsqueda de Juegos Ganados
                string consulta = "select sum(Progreso) from Progreso where NombreU = '" + NombreU + "' and Progreso = " + 1 + " and Id_juego = " + 2 + ";";
                int juegoswin = accesobd(consulta);


                //Búsqueda de Juegos Perdidos
                consulta = "select count(Progreso) from Progreso where NombreU = '" + NombreU + "' and Progreso = " + 0 + "and Id_juego = " + 2 + ";";
                int juegoslose = accesobd(consulta);

                //Calculo Juegos Perdidos
                double PorPer;
                PorPer = ((double)juegoslose) / ((double)juegoslose + (double)juegoswin) * 100;
                string juegoper = juegoslose.ToString() + " Juegos (" + PorPer.ToString("N1") + "%)";

                //Calculo Juegos Ganados
                double PorGan = (double)juegoswin / ((double)juegoslose + (double)juegoswin) * 100;
                string juegowin = juegoswin.ToString() + " Juegos (" + PorGan.ToString("N1") + "%)";
                DatabaseProyecto.Close();

                if (InputBox("Ganaste !!", "Has ganado " + juegowin + " y has perdido " + juegoper + "\n\n" + "¿Quieres volverlo a intentar?") == DialogResult.OK)
                {
                    ResetImages();
                }
                else
                {
                    this.Hide();
                    nivelesmemotest abrir = new nivelesmemotest(NombreU);
                    abrir.Show();
                }
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
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

            {
                timer.Stop();
                DatabaseProyecto.Open();
                OleDbCommand info;
                info = new OleDbCommand("INSERT INTO Progreso (Id_juego, Fechayhora, Progreso, NombreU) VALUES (2,'" + DateTime.Now + "', 1, '" + NombreU + "')");
                info.Connection = DatabaseProyecto;
                info.ExecuteNonQuery();

                //Búsqueda de Juegos Ganados
                string consulta = "select sum(Progreso) from Progreso where NombreU = '" + NombreU + "' and Progreso = " + 1 + "and Id_juego = " + 2 + ";";
                int juegoswin = accesobd(consulta);


                //Búsqueda de Juegos Perdidos
                consulta = "select count(Progreso) from Progreso where NombreU = '" + NombreU + "' and Progreso = " + 0 + "and Id_juego = " + 2 + ";";
                int juegoslose = accesobd(consulta);

                //Calculo Juegos Perdidos
                double PorPer;
                PorPer = ((double)juegoslose) / ((double)juegoslose + (double)juegoswin) * 100;
                string juegoper = juegoslose.ToString() + " Juegos (" + PorPer.ToString("N1") + "%)";

                //Calculo Juegos Ganados
                double PorGan = (double)juegoswin / ((double)juegoslose + (double)juegoswin) * 100;
                string juegowin = juegoswin.ToString() + " Juegos (" + PorGan.ToString("N1") + "%)";
                DatabaseProyecto.Close();

                if (InputBox("Ganaste !!", "Has ganado " + juegowin + " y has perdido " + juegoper + "\n\n" + "¿Quieres volverlo a intentar?") == DialogResult.OK)
                {
                    ResetImages();
                }
                else
                {
                    this.Hide();
                    nivelesmemotest abrir = new nivelesmemotest(NombreU);
                    abrir.Show();
                }
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
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

            {
                timer.Stop();
                DatabaseProyecto.Open();
                OleDbCommand info;
                info = new OleDbCommand("INSERT INTO Progreso (Id_juego, Fechayhora, Progreso, NombreU) VALUES (2,'" + DateTime.Now + "', 1, '" + NombreU + "')");
                info.Connection = DatabaseProyecto;
                info.ExecuteNonQuery();

                //Búsqueda de Juegos Ganados
                string consulta = "select sum(Progreso) from Progreso where NombreU = '" + NombreU + "' and Progreso = " + 1 + "and Id_juego = " + 2 + ";";
                int juegoswin = accesobd(consulta);


                //Búsqueda de Juegos Perdidos
                consulta = "select count(Progreso) from Progreso where NombreU = '" + NombreU + "' and Progreso = " + 0 + "and Id_juego = " + 2 + ";";
                int juegoslose = accesobd(consulta);

                //Calculo Juegos Perdidos
                double PorPer;
                PorPer = ((double)juegoslose) / ((double)juegoslose + (double)juegoswin) * 100;
                string juegoper = juegoslose.ToString() + " Juegos (" + PorPer.ToString("N1") + "%)";

                //Calculo Juegos Ganados
                double PorGan = (double)juegoswin / ((double)juegoslose + (double)juegoswin) * 100;
                string juegowin = juegoswin.ToString() + " Juegos (" + PorGan.ToString("N1") + "%)";
                DatabaseProyecto.Close();

                if (InputBox("Ganaste !!", "Has ganado " + juegowin + " y has perdido " + juegoper + "\n\n" + "¿Quieres volverlo a intentar?") == DialogResult.OK)
                {
                    ResetImages();
                }
                else
                {
                    this.Hide();
                    nivelesmemotest abrir = new nivelesmemotest(NombreU);
                    abrir.Show();
                }
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
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

            {
                timer.Stop();
                DatabaseProyecto.Open();
                OleDbCommand info;
                info = new OleDbCommand("INSERT INTO Progreso (Id_juego, Fechayhora, Progreso, NombreU) VALUES (2,'" + DateTime.Now + "', 1, '" + NombreU + "')");
                info.Connection = DatabaseProyecto;
                info.ExecuteNonQuery();

                //Búsqueda de Juegos Ganados
                string consulta = "select sum(Progreso) from Progreso where NombreU = '" + NombreU + "' and Progreso = " + 1 + "and Id_juego = " + 2 + ";";
                int juegoswin = accesobd(consulta);


                //Búsqueda de Juegos Perdidos
                consulta = "select count(Progreso) from Progreso where NombreU = '" + NombreU + "' and Progreso = " + 0 + "and Id_juego = " + 2 + ";";
                int juegoslose = accesobd(consulta);

                //Calculo Juegos Perdidos
                double PorPer;
                PorPer = ((double)juegoslose) / ((double)juegoslose + (double)juegoswin) * 100;
                string juegoper = juegoslose.ToString() + " Juegos (" + PorPer.ToString("N1") + "%)";

                //Calculo Juegos Ganados
                double PorGan = (double)juegoswin / ((double)juegoslose + (double)juegoswin) * 100;
                string juegowin = juegoswin.ToString() + " Juegos (" + PorGan.ToString("N1") + "%)";
                DatabaseProyecto.Close();

                if (InputBox("Ganaste !!", "Has ganado " + juegowin + " y has perdido " + juegoper + "\n\n" + "¿Quieres volverlo a intentar?") == DialogResult.OK)
                {
                    ResetImages();
                }
                else
                {
                    this.Hide();
                    nivelesmemotest abrir = new nivelesmemotest(NombreU);
                    abrir.Show();
                }
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
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

            {
                timer.Stop();
                DatabaseProyecto.Open();
                OleDbCommand info;
                info = new OleDbCommand("INSERT INTO Progreso (Id_juego, Fechayhora, Progreso, NombreU) VALUES (2,'" + DateTime.Now + "', 1, '" + NombreU + "')");
                info.Connection = DatabaseProyecto;
                info.ExecuteNonQuery();

                //Búsqueda de Juegos Ganados
                string consulta = "select sum(Progreso) from Progreso where NombreU = '" + NombreU + "' and Progreso = " + 1 + "and Id_juego = " + 2 + ";";
                int juegoswin = accesobd(consulta);


                //Búsqueda de Juegos Perdidos
                consulta = "select count(Progreso) from Progreso where NombreU = '" + NombreU + "' and Progreso = " + 0 + "and Id_juego = " + 2 + ";";
                int juegoslose = accesobd(consulta);

                //Calculo Juegos Perdidos
                double PorPer;
                PorPer = ((double)juegoslose) / ((double)juegoslose + (double)juegoswin) * 100;
                string juegoper = juegoslose.ToString() + " Juegos (" + PorPer.ToString("N1") + "%)";

                //Calculo Juegos Ganados
                double PorGan = (double)juegoswin / ((double)juegoslose + (double)juegoswin) * 100;
                string juegowin = juegoswin.ToString() + " Juegos (" + PorGan.ToString("N1") + "%)";
                DatabaseProyecto.Close();

                if (InputBox("Ganaste !!", "Has ganado " + juegowin + " y has perdido " + juegoper + "\n\n" + "¿Quieres volverlo a intentar?") == DialogResult.OK)
                {
                    ResetImages();
                }
                else
                {
                    this.Hide();
                    nivelesmemotest abrir = new nivelesmemotest(NombreU);
                    abrir.Show();
                }
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
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

            {
                timer.Stop();
                DatabaseProyecto.Open();
                OleDbCommand info;
                info = new OleDbCommand("INSERT INTO Progreso (Id_juego, Fechayhora, Progreso, NombreU) VALUES (2,'" + DateTime.Now + "', 1, '" + NombreU + "')");
                info.Connection = DatabaseProyecto;
                info.ExecuteNonQuery();

                //Búsqueda de Juegos Ganados
                string consulta = "select sum(Progreso) from Progreso where NombreU = '" + NombreU + "' and Progreso = " + 1 + "and Id_juego = " + 2 + ";";
                int juegoswin = accesobd(consulta);


                //Búsqueda de Juegos Perdidos
                consulta = "select count(Progreso) from Progreso where NombreU = '" + NombreU + "' and Progreso = " + 0 + "and Id_juego = " + 2 + ";";
                int juegoslose = accesobd(consulta);

                //Calculo Juegos Perdidos
                double PorPer;
                PorPer = ((double)juegoslose) / ((double)juegoslose + (double)juegoswin) * 100;
                string juegoper = juegoslose.ToString() + " Juegos (" + PorPer.ToString("N1") + "%)";

                //Calculo Juegos Ganados
                double PorGan = (double)juegoswin / ((double)juegoslose + (double)juegoswin) * 100;
                string juegowin = juegoswin.ToString() + " Juegos (" + PorGan.ToString("N1") + "%)";
                DatabaseProyecto.Close();

                if (InputBox("Ganaste !!", "Has ganado " + juegowin + " y has perdido " + juegoper + "\n\n" + "¿Quieres volverlo a intentar?") == DialogResult.OK)
                {
                    ResetImages();
                }
                else
                {
                    this.Hide();
                    nivelesmemotest abrir = new nivelesmemotest(NombreU);
                    abrir.Show();
                }
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
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

            {
                timer.Stop();
                DatabaseProyecto.Open();
                OleDbCommand info;
                info = new OleDbCommand("INSERT INTO Progreso (Id_juego, Fechayhora, Progreso, NombreU) VALUES (2,'" + DateTime.Now + "', 1, '" + NombreU + "')");
                info.Connection = DatabaseProyecto;
                info.ExecuteNonQuery();

                //Búsqueda de Juegos Ganados
                string consulta = "select sum(Progreso) from Progreso where NombreU = '" + NombreU + "' and Progreso = " + 1 + "and Id_juego = " + 2 + ";";
                int juegoswin = accesobd(consulta);


                //Búsqueda de Juegos Perdidos
                consulta = "select count(Progreso) from Progreso where NombreU = '" + NombreU + "' and Progreso = " + 0 + "and Id_juego = " + 2 + ";";
                int juegoslose = accesobd(consulta);

                //Calculo Juegos Perdidos
                double PorPer;
                PorPer = ((double)juegoslose) / ((double)juegoslose + (double)juegoswin) * 100;
                string juegoper = juegoslose.ToString() + " Juegos (" + PorPer.ToString("N1") + "%)";

                //Calculo Juegos Ganados
                double PorGan = (double)juegoswin / ((double)juegoslose + (double)juegoswin) * 100;
                string juegowin = juegoswin.ToString() + " Juegos (" + PorGan.ToString("N1") + "%)";
                DatabaseProyecto.Close();

                if (InputBox("Ganaste !!", "Has ganado " + juegowin + " y has perdido " + juegoper + "\n\n" + "¿Quieres volverlo a intentar?") == DialogResult.OK)
                {
                    ResetImages();
                }
                else
                {
                    this.Hide();
                    nivelesmemotest abrir = new nivelesmemotest(NombreU);
                    abrir.Show();
                }
            }
        }
        private void pictureBox16_Click(object sender, EventArgs e)
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

            {
                timer.Stop();
                DatabaseProyecto.Open();
                OleDbCommand info;
                info = new OleDbCommand("INSERT INTO Progreso (Id_juego, Fechayhora, Progreso, NombreU) VALUES (2,'" + DateTime.Now + "', 1, '" + NombreU + "')");
                info.Connection = DatabaseProyecto;
                info.ExecuteNonQuery();

                //Búsqueda de Juegos Ganados
                string consulta = "select sum(Progreso) from Progreso where NombreU = '" + NombreU + "' and Progreso = " + 1 + "and Id_juego = " + 2 + ";";
                int juegoswin = accesobd(consulta);


                //Búsqueda de Juegos Perdidos
                consulta = "select count(Progreso) from Progreso where NombreU = '" + NombreU + "' and Progreso = " + 0 + "and Id_juego = " + 2 + ";";
                int juegoslose = accesobd(consulta);

                //Calculo Juegos Perdidos
                double PorPer;
                PorPer = ((double)juegoslose) / ((double)juegoslose + (double)juegoswin) * 100;
                string juegoper = juegoslose.ToString() + " Juegos (" + PorPer.ToString("N1") + "%)";

                //Calculo Juegos Ganados
                double PorGan = (double)juegoswin / ((double)juegoslose + (double)juegoswin) * 100;
                string juegowin = juegoswin.ToString() + " Juegos (" + PorGan.ToString("N1") + "%)";
                DatabaseProyecto.Close();

                if (InputBox("Ganaste !!", "Has ganado " + juegowin + " y has perdido " + juegoper + "\n\n" + "¿Quieres volverlo a intentar?") == DialogResult.OK)
                {
                    ResetImages();
                }
                else
                {
                    this.Hide();
                    nivelesmemotest abrir = new nivelesmemotest(NombreU);
                    abrir.Show();
                }
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            allowClick = true;
            setRandomImages();
            HideImages();
            startGameTimer();
            clickTimer.Interval = 1000;
            clickTimer.Tick += CLICKTIMER_TICK;
            btnStart.Enabled = false;
        }

        private void memotest222_Load(object sender, EventArgs e)
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
            buttonOk.SetBounds(220, 100, 80, 30);
            buttoncancel.SetBounds(100, 100, 80, 30);

            label.AutoSize = true;
            form.ClientSize = new Size(398, 150);
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
        private int accesobd(string consulta)
        {
            //Búsqueda de Juegos 
            OleDbCommand comando = new OleDbCommand(consulta, DatabaseProyecto);
            string datosjuego = comando.ExecuteScalar().ToString();
            if (datosjuego == "")
            {
                datosjuego = "0";
            }
            int juegoswin = Convert.ToInt32(datosjuego);
            return juegoswin;
        }
    }
}
