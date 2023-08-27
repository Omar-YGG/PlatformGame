using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace JuegoMeloFinal
{
    class ConexionDB
    {
        SqlConnection cnxn;

        public ConexionDB()
        {
            try
            {
                cnxn = new SqlConnection ("Data Source=DESKTOP-0SGVFRR\\SQLEXPRESS;Initial Catalog=Usuarios;Integrated Security=true");
                cnxn.Open();
                MessageBox.Show("conectado");
            }
            catch (Exception excep)
            {
                MessageBox.Show(""+excep.Message, "ERROR ENCONTRADO" );
            }
        }
    }
}
