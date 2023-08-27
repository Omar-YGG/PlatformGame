using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace JuegoMeloFinal
{
    public partial class PantallaDJuego : Form
    {
        private string nombreUsuario;
        private int puntuacionAcumulada;
        bool irDerecha, irIzquierda, saltando, esFinDJuego;

        int velSalto, fuerza, puntuacion=0, velJugador=7;
        int horizontalVel = 5, verticalVel = 3;

        SqlConnection cnxn = new SqlConnection("Data Source=DESKTOP-0SGVFRR\\SQLEXPRESS;Initial Catalog=Usuarios;Integrated Security=true");

        //minimizar
        private void pictureBox16_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //volver a menu d jugador
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            MenuUsuario volver = new MenuUsuario(nombreUsuario,puntuacionAcumulada);
            this.Hide();
            volver.Show();
        }

        int enemigo1Vel = 5, enemigo2Vel=3;

        public PantallaDJuego(string nombreUsuario, int puntuacionAcumulada)
        {
            InitializeComponent();
            this.nombreUsuario = nombreUsuario;
            this.puntuacionAcumulada = puntuacionAcumulada;
        }

        private void EventoTImerPrincipalDJuego(object sender, EventArgs e)
        {
            LblPuntuacion.Text = "Puntuacion: "+ puntuacion;

            Personaje.Top += velSalto;

            if (irIzquierda == true)
            {
                Personaje.Left -= velJugador;
            }
            if (irDerecha == true)
            {
                Personaje.Left += velJugador;
            }
            if (saltando==true && fuerza<0)
            {
                saltando = false;
            }
            if (saltando == true)
            {
                velSalto = -8;
                fuerza -= 1;
            }
            else velSalto = 10;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    //colision con plataformas
                    if ((String)x.Tag=="Plataforma")
                    {
                        if (Personaje.Bounds.IntersectsWith(x.Bounds))
                        {
                            fuerza = 8;
                            Personaje.Top = x.Top - Personaje.Height;

                            if ((String)x.Name == "HorizontalPlat" && (irDerecha == false||irIzquierda==false) )
                            {
                                Personaje.Left -= horizontalVel;
                            }
                        }
                        x.BringToFront();
                    }

                    //colision y suma con pizza
                    if ((String)x.Tag=="pizza" && x.Visible==true)
                    {
                        if (Personaje.Bounds.IntersectsWith(x.Bounds))
                        {
                            x.Visible = false;
                            puntuacion++;
                        }
                    }

                    //colision con enemigo
                    if ((String)x.Tag == "enemigo")
                    {
                        if (Personaje.Bounds.IntersectsWith(x.Bounds))
                        {
                            TimerJuego.Stop();
                            esFinDJuego = true;
                        }
                    }
                }
            }

            //movimiento d plataformas 

            HorizontalPlat.Left -= horizontalVel;

            if (HorizontalPlat.Left<0 || HorizontalPlat.Left + HorizontalPlat.Width > this.ClientSize.Width)
            {
                horizontalVel = -horizontalVel;
            }

            VerticalPlat.Top -= verticalVel;

            if (VerticalPlat.Top<100 || VerticalPlat.Top>324)
            {
                verticalVel = -verticalVel;
            }

            //movimiento d enemigos

            //derecha-izquierda
            Enemigo1.Left -= enemigo1Vel;
             if (Enemigo1.Left< pictureBox7.Left || Enemigo1.Left+ Enemigo1.Width > pictureBox7.Left + pictureBox7.Width)
            {
                enemigo1Vel = -enemigo1Vel;
            }

             //izquierda-derecha
            Enemigo2.Left += enemigo2Vel;
            if (Enemigo2.Left < pictureBox6.Left || Enemigo2.Left + Enemigo2.Width > pictureBox6.Left + pictureBox6.Width)
            {
                enemigo2Vel = -enemigo2Vel;
            }

            //se cae del mapa
            if (Personaje.Top + Personaje.Width>this.ClientSize.Height + 50)
            {
                TimerJuego.Stop();
                esFinDJuego = true;

                MessageBox.Show("Perdiste");
            }

            //llega al portal
            if (Personaje.Bounds.IntersectsWith(Portal.Bounds))
            {
                TimerJuego.Stop();
                esFinDJuego = true;
                MessageBox.Show("Ganaste, felicidades");

                SqlCommand cmd = new SqlCommand("UPDATE Useers SET Puntuacion = @Puntuacion WHERE Nombre = @Nombre", cnxn);
                cmd.Parameters.AddWithValue("@Puntuacion", puntuacion);
                cmd.Parameters.AddWithValue("@Nombre", nombreUsuario);
                cnxn.Open();
                cmd.ExecuteNonQuery();
                cnxn.Close();

                this.Hide();

                MenuUsuario irUsuario = new MenuUsuario(nombreUsuario,puntuacion);

                irUsuario.Show();

                //MenuUsuario irUsuario = Application.OpenForms.OfType<MenuUsuario>().FirstOrDefault();
                //if (irUsuario != null)
                //{
                //    irUsuario.Show();
                //}
                this.Close();
            }
        }

        private void TeclaPresionada(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Left)
            {
                irIzquierda = true;
            }
            if (e.KeyCode==Keys.Right)
            {
                irDerecha = true;
            }
            if ((e.KeyCode==Keys.Up|| e.KeyCode==Keys.Space)&&saltando==false)
            {
                saltando = true;
            }
        }

        private void TeclaLibre(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                irIzquierda = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                irDerecha = false;
            }
            if (saltando == true)
            {
                saltando = false;
            }
            if (e.KeyCode==Keys.Enter && esFinDJuego==true)
            {
                ReiniciarJuego();
            }
        }

        //reiniciar
        private void ReiniciarJuego()
        {
            puntuacion = 0;
            irDerecha = false; irIzquierda = false; saltando = false; esFinDJuego = false;
            this.LblPuntuacion.Text = "Puntuacion: " + puntuacion;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Visible ==false)
                {
                    x.Visible = true;
                }
            }

            //para reestablecer las posiciones d los objetos

            Personaje.Left = 16; Personaje.Top = 396;

            Enemigo1.Left= 307; Enemigo1.Top = 178;

            Enemigo2.Left = 16; Enemigo2.Top = 178;

            VerticalPlat.Top = 324;
            HorizontalPlat.Left = 198;

            TimerJuego.Start();
        }
    }
}
