using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia.Modelo
{
    internal class Empleado
    {
        public static DataTable obtener()
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                string consulta = "select * from Empleado order by id desc";
                SqlCommand cmd = new SqlCommand(consulta, cnn.ObtenerConexion());
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                return tabla;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                cnn.Desconectar();
            }
        }
        public static bool guardar(string nombres, string email, string telefono)
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                string consulta = "insert into Empleado(nombre,email,telefono) values(@nombre,@email,@telefono)";
                SqlCommand cmd = new SqlCommand(consulta, cnn.ObtenerConexion());
                cmd.Parameters.AddWithValue("@nombre", nombres);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eror" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            finally
            {
                cnn.Desconectar();
            }
        }
        public static bool editar(string nombres, string email, string telefono, int id)
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                string consulta = "update Empleado set nombre=@nombre,email=@email,telefono=@telefono where id=@id";
                SqlCommand cmd = new SqlCommand(consulta, cnn.ObtenerConexion());
                cmd.Parameters.AddWithValue("@nombre", nombres);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eror" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            finally
            {
                cnn.Desconectar();
            }
        }
        public static bool eliminar(int id)
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                string consulta = "delete from Empleado where id=@id";
                SqlCommand cmd = new SqlCommand(consulta, cnn.ObtenerConexion());
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eror" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            finally
            {
                cnn.Desconectar();
            }
        }
    } 
}

