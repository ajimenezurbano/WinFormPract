using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace WinFormPract
{
    internal class Repository
    {
        public static DataSet ObtenerRestaurantes()
        {
            Conexion conexion = new Conexion();
            SqlCommand comando = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter adaptador = new SqlDataAdapter();

            try
            {
                comando.CommandText = "SELECT * FROM RESTAURANTE";
                comando.Connection = conexion.cnx;
                adaptador.SelectCommand = comando;
                conexion.cnx.Open();
                adaptador.Fill(ds);
                conexion.cnx.Close();

                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }

        public static bool CrearRestaurante(Restaurante r)
        {
            bool todoCorrecto = false;
            Conexion conexion = new Conexion();
            SqlCommand comando = new SqlCommand();

            try
            {
                comando.CommandText = "set dateformat dmy; INSERT INTO RESTAURANTE VALUES ('" + r.nombre + "', '" + r.fechaApertura + "', '" + r.calle + "', '" + r.numero + "', '" + r.opinion + "')";

                comando.Connection = conexion.cnx;
                conexion.cnx.Open();
                comando.ExecuteNonQuery();
                conexion.cnx.Close();

                todoCorrecto = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                todoCorrecto = false;
            }

            return todoCorrecto;
        }

        public static bool EliminarRestaurante(Restaurante r)
        {
            bool todoCorrecto = false;
            Conexion conexion = new Conexion();
            SqlCommand comando = new SqlCommand();

            try
            {
                comando.CommandText = "DELETE FROM RESTAURANTE WHERE ID = '" + r.Id + "'";

                comando.Connection = conexion.cnx;
                conexion.cnx.Open();
                comando.ExecuteNonQuery();
                conexion.cnx.Close();

                todoCorrecto = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                todoCorrecto = false;
            }

            return todoCorrecto;
        }

        public static bool ModificarRestaurante(Restaurante r)
        {
            bool todoCorrecto = false;
            Conexion conexion = new Conexion();
            SqlCommand comando = new SqlCommand();

            try
            {
                comando.CommandText = "set dateformat dmy; UPDATE RESTAURANTE SET NOMBRE = '" + r.nombre + "', FECHAAPERTURA= '" + r.fechaApertura + "', " +
                    "CALLE = '" + r.calle + "', NUMERO = '" + r.numero + "', " + "OPINION = '" + r.opinion + "' " +
                    " WHERE ID = '" + r.Id + "'";

                comando.Connection = conexion.cnx;
                conexion.cnx.Open();
                comando.ExecuteNonQuery();
                conexion.cnx.Close();

                todoCorrecto = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                todoCorrecto = false;
            }

            return todoCorrecto;
        }
    }
}
