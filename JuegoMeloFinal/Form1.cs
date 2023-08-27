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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection cnxn = new SqlConnection("Data Source=DESKTOP-0SGVFRR\\SQLEXPRESS;Initial Catalog=Usuarios;Integrated Security=true");

        private void Form1_Load(object sender, EventArgs e)
        {
            //ConexionDB conectar = new ConexionDB(); /*instacia de la conexion*/
            try
            {
                cnxn.Open();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message, "ERROR ENCONTRADO");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LinkRecContra_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Para recuperar tu contraseña cominicate con Soporte: \n\nsupport@gmail.com \n\nO Crea una nueva cuenta", "Recuperación de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            do
            {
                String usuario, contrasena;
                usuario = this.TxtUser.Text;
                contrasena = this.TxtContra.Text;

                try
                {
                    cnxn.Open();
                    SqlCommand cmd = new SqlCommand("Select * From Useers Where Nombre='" + usuario + "' and Contrasena='" + contrasena + "'", cnxn);
                    SqlDataReader lectura = cmd.ExecuteReader();

                    if (lectura.Read())
                    {
                        MessageBox.Show("Bienvenido " + lectura.GetValue(1));
                        string nombreUsuario = lectura.GetString(1);
                        int puntuacion = lectura.GetInt32(4);

                        if ((int)lectura.GetValue(3) == 1)
                        {
                            MenuAdmin admin = new MenuAdmin();
                            admin.Show();
                        }
                        else
                        {
                            MenuUsuario irusuario = new MenuUsuario(nombreUsuario, puntuacion);
                            irusuario.Show();
                        }
                        this.Hide();
                        break;
                    }
                    else
                        MessageBox.Show("Usuario invalido");
                    
                }
                catch (Exception excep)
                {
                    /*MessageBox.Show(excep.Message, "ERROR ENCONTRADO")*/;
                    break;
                }
                //finally
                //{
                //    cnxn.Close();
                //}

                //DialogResult result = MessageBox.Show("¿Desea volver a intentar ingresar las credenciales?", "Reintentar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //if (result == DialogResult.No)
                //{
                //    break; // Sale del bucle si el usuario no desea volver a intentar
                //}

            } while (true);
            cnxn.Close();
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LinkRegistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registrarse nuevoRegistro = new Registrarse();
            nuevoRegistro.Show();
        }
    }
}
