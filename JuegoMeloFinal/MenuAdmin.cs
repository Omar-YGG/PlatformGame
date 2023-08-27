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
using System.IO;

namespace JuegoMeloFinal
{
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        SqlConnection cnxn = new SqlConnection("Data Source=DESKTOP-0SGVFRR\\SQLEXPRESS;Initial Catalog=Usuarios;Integrated Security=true");

        private void MenuAdmin_Load(object sender, EventArgs e)
        {
            VerDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            String nombre = TxtUser.Text;
            String contra = TxtContra.Text;
            int rol;

            if ((String)cbRol.SelectedItem == "1. Administrador")
            {
                rol = 1;
            }
            else rol = 2;

            SqlCommand cmd = new SqlCommand("INSERT INTO Useers (Nombre, Contrasena, Rol, Puntuacion) VALUES (@Nombre, @Contrasena, @Rol, @Puntuacion)", cnxn);
            cmd.Parameters.AddWithValue("@Nombre", nombre);
            cmd.Parameters.AddWithValue("@Contrasena", contra);
            cmd.Parameters.AddWithValue("@Rol", rol);
            cmd.Parameters.AddWithValue("@Puntuacion", 0);

            try
            {
                if (string.IsNullOrEmpty(TxtUser.Text) || string.IsNullOrEmpty(TxtContra.Text))
                {
                    MessageBox.Show("Por favor, ingresa credenciales validas");
                    //return; // Detener la ejecución del método
                }
                else
                {
                    cnxn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro Exitoso");
                }
            }
            catch(Exception excep)
            {
                MessageBox.Show(excep.Message, "ERROR ENCONTRADO");
            }
            finally
            {
                cnxn.Close();
                VerDatos();
                LimpiarCasillas();
            }
        }

        //para mantener actualizado el dgv
        private void VerDatos()
        {
            try
            {
                cnxn.Open();
                //mostrar datos en datagridview
                SqlDataAdapter datosAdap = new SqlDataAdapter("Select * From Useers", cnxn);
                DataTable tablita = new DataTable();
                datosAdap.Fill(tablita);
                dgvCuentas.DataSource = tablita;
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message, "ERROR ENCONTRADO");
            }
            finally
            {
                cnxn.Close();
            }
        }

        //boton d actualizar/modificar
        private void button2_Click(object sender, EventArgs e)
        {
            String nombre = TxtUser.Text;
            String contra = TxtContra.Text;
            int id = int.Parse(txtId.Text);
            int rol, puntuacion;

            if ((String)cbRol.SelectedItem == "1. Administrador")
            {
                rol = 1;
            }
            else rol = 2;

            SqlCommand cmd = new SqlCommand("UPDATE Useers SET Nombre = @Nombre, Contrasena = @Contrasena, Rol = @Rol, Puntuacion = @Puntuacion WHERE Id = @Id", cnxn);
            cmd.Parameters.AddWithValue("@Nombre", nombre);
            cmd.Parameters.AddWithValue("@Contrasena", contra);
            cmd.Parameters.AddWithValue("@Rol", rol);
            cmd.Parameters.AddWithValue("@Puntuacion", 0);
            cmd.Parameters.AddWithValue("@Id", id);

            try
            {
                if (string.IsNullOrEmpty(TxtUser.Text) || string.IsNullOrEmpty(TxtContra.Text) || !int.TryParse(txtId.Text, out id) || !int.TryParse(txtPuntuacion.Text, out puntuacion))
                {
                    MessageBox.Show("Por favor, ingresa credenciales validas");
                }
                else
                {
                    cnxn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuario actualizado");
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message, "ERROR ENCONTRADO");
            }
            finally
            {
                cnxn.Close();
                VerDatos();
                LimpiarCasillas();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);

            SqlCommand cmd = new SqlCommand("DELETE FROM Useers Where Id = @Id", cnxn);
            cmd.Parameters.AddWithValue("@Id", id);

            try
            {
                cnxn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario Eliminado");
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message, "ERROR ENCONTRADO");
            }
            finally
            {
                cnxn.Close();
                VerDatos();
                LimpiarCasillas();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvCuentas.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos que exportar");
                return;
            }

            // llama la clase savefiledialog para pedir la ubicaion d guardado
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos CSV (*.csv)|*.csv";
            saveFileDialog.Title = "Exportar a CSV";
            saveFileDialog.FileName = "datos.csv";

            // Mostrar el cuadro d diálogo para guardar el archivo
            DialogResult seExporto = saveFileDialog.ShowDialog();

            if (seExporto == DialogResult.OK)
            {
                try
                {
                    // ruta completa del archivo seleccionado
                    string filePath = saveFileDialog.FileName;

                    // crear el archivo CSV
                    StringBuilder csvContenido = new StringBuilder();
                    //escribir los encabezados d columna
                    for (int i = 0; i < dgvCuentas.Columns.Count; i++)
                    {
                        csvContenido.Append(dgvCuentas.Columns[i].HeaderText);
                        if (i < dgvCuentas.Columns.Count - 1)
                        {
                            csvContenido.Append(";");
                        }
                    }
                    csvContenido.AppendLine();

                    // escribir datos d cada fila en CSV
                    foreach (DataGridViewRow row in dgvCuentas.Rows)
                    {
                        for (int i = 0; i < dgvCuentas.Columns.Count; i++)
                        {
                            csvContenido.Append(row.Cells[i].Value);
                            if (i < dgvCuentas.Columns.Count - 1)
                            {
                                csvContenido.Append(";");
                            }
                        }
                        csvContenido.AppendLine();
                    }

                    // guardar el contenido dl archivo CSV el archivo
                    File.WriteAllText(filePath, csvContenido.ToString());

                    MessageBox.Show("Exportacion exitosa");
                }
                catch (Exception excep)
                {
                    MessageBox.Show(excep.Message, "ERROR DE EXPORTACION");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1();
            this.Hide();
            inicio.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LimpiarCasillas()
        {
            txtId.Text="";
            TxtContra.Text = "";
            TxtUser.Text = "";
            txtPuntuacion.Text ="0";
        }

    }
}