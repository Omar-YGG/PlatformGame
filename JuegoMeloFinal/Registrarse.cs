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
    public partial class Registrarse : Form
    {
        public Registrarse()
        {
            InitializeComponent();
        }

        SqlConnection cnxn = new SqlConnection("Data Source=DESKTOP-0SGVFRR\\SQLEXPRESS;Initial Catalog=Usuarios;Integrated Security=true");

        private void Registrarse_Load(object sender, EventArgs e)
        {
            try
            {
                cnxn.Open();
                //MessageBox.Show("conexion abierta");
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message, "ERROR ENCONTRADO");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            String nombre=TxtUser.Text;
            String contra = TxtContra.Text;

            SqlCommand cmd = new SqlCommand("INSERT INTO Useers (Nombre, Contrasena, Rol, Puntuacion) VALUES (@Nombre, @Contrasena, @Rol, @Puntuacion)", cnxn);
            cmd.Parameters.AddWithValue("@Nombre", nombre);
            cmd.Parameters.AddWithValue("@Contrasena", contra);
            cmd.Parameters.AddWithValue("@Rol", 2);
            cmd.Parameters.AddWithValue("@Puntuacion", 0);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Registro exitoso");
            this.Close();
        }
    }
}