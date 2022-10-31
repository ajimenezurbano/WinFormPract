using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormPract
{
    internal class Conexion
    {
        public SqlConnection cnx;

        public Conexion()
        {
            try
            {
                cnx = new SqlConnection("Data Source=WINAPVNQ6JQY1KE\\SQLEXPRESS;Initial Catalog=Restaurantes;Integrated Security=True");
                Console.WriteLine("Éxito al conectar.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar. " + ex.Message);
            }
        }
    }
}
