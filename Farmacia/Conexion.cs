using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia
{
    internal class Conexion
    {
        SqlConnection conexion = new SqlConnection("Data Source=192.168.10.2;User Id=sa;Password=Hyp3r10nPr0_;DataBase=Sistema_de_Farmacia;TrustServerCertificate=True");
        
        public void Conectar()
        {
            if (conexion.State != System.Data.ConnectionState.Open)
            {
                conexion.Open();
            }
        }
        public void Desconectar()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }
        public SqlConnection ObtenerConexion()
        {
            return conexion;
        }
    }

}
