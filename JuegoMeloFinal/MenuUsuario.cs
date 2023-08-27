using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoMeloFinal
{
    

    public partial class MenuUsuario : Form
    {
        private string nombreUsuario;
        private int puntuacion;
        public MenuUsuario(string nombreUsuario, int puntuacion)
        {
            InitializeComponent();
            this.nombreUsuario = nombreUsuario;
            this.puntuacion = puntuacion;
        }

        //ir a pantalla d login
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1();
            this.Hide();
            inicio.Show();
        }
        //minimizar
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            PantallaDJuego jugar = new PantallaDJuego(nombreUsuario,puntuacion);
            this.Hide();
            jugar.Show();
        }

        private void MenuUsuario_Load(object sender, EventArgs e)
        {
            lblPuntuacion.Text = $"Mi puntuacion {puntuacion}";
        }
    }
}
