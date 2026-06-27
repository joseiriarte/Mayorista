using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayorista.Datos
{
    public class AccesoDatos
    {
        private string CadenaConexion = "Data Source=.\\SQLEXPRESS;Initial Catalog=TUP_PI_1w1_TPI_G18_Mayorista_Fiambres_Lacteos;Integrated Security=True";

        //"Data Source=.\\SQLEXPRESS;Initial Catalog=TUP_PI_1w1_TPI_G18_Mayorista_Fiambres_Lacteos;Integrated Security=True"; 

        //"Data Source= localhost\\SQLEXPRESS01;Initial Catalog=TUP_PI_1w1_TPI_G18_Mayorista_Fiambres_Lacteos;Integrated Security=True";

        private SqlConnection conexion;
        private SqlCommand comando;

        public AccesoDatos()
        {
            conexion = new SqlConnection(CadenaConexion);
        }

        private void Conectar()
        {
            conexion.Open();
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }

        public void Desconectar()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
        }

        public DataTable ConsultarTabla(string nombreTabla)
        {
            DataTable tabla = new DataTable();

            try
            {
                Conectar();

                comando.CommandText = "SELECT * FROM " + nombreTabla;

                tabla.Load(comando.ExecuteReader());

                return tabla;
            }
            finally
            {
                Desconectar();
            }
        }

        public DataTable ConsultarBD(string consultaSQL)
        {
            DataTable tabla = new DataTable();

            try
            {
                Conectar();

                comando.CommandText = consultaSQL;

                tabla.Load(comando.ExecuteReader());

                return tabla;
            }
            finally
            {
                Desconectar();
            }
        }

        public int ActualizarBD(string consultaSQL)
        {
            try
            {
                Conectar();

                comando.CommandText = consultaSQL;

                return comando.ExecuteNonQuery();
            }
            finally
            {
                Desconectar();
            }
        }

        public int ActualizarBD(string consultaSQL, List<Parametro> lista)
        {
            try
            {
                Conectar();

                comando.Parameters.Clear();
                comando.CommandText = consultaSQL;

                foreach (Parametro p in lista)
                {
                    comando.Parameters.AddWithValue(p.Nombre, p.Valor);
                }

                return comando.ExecuteNonQuery();
            }
            finally
            {
                Desconectar();
            }
        }
    }
}
