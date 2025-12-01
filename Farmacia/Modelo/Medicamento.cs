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
    internal class Medicamento
    {
        public static DataTable obtener()
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                string consulta = "select * from Medicamentos order by id desc";
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
        public static bool guardar(string nombres, string principio_activo, string concentracion, string presentacion, string laboratorio, string registro_sanitario, string requiere_receta)
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                string consulta = "insert into Medicamentos(nombre,principio_activo, concentracion, presentacion,laboratorio,registro_sanitario,requiere_receta) values(@nombre,@principio_activo,@concentración,@presentacion,@laboratorio,@registro_sanitario,@requiere_receta)";
                SqlCommand cmd = new SqlCommand(consulta, cnn.ObtenerConexion());
                cmd.Parameters.AddWithValue("@nombre", nombres);
                cmd.Parameters.AddWithValue("@principio_activo", principio_activo);
                cmd.Parameters.AddWithValue("@concentración", concentracion);
                cmd.Parameters.AddWithValue("@presentacion", presentacion);
                cmd.Parameters.AddWithValue("@laboratorio", laboratorio);
                cmd.Parameters.AddWithValue("@registro_sanitario", registro_sanitario);
                cmd.Parameters.AddWithValue("@requiere_receta", requiere_receta);
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
        public static bool editar(string nombres, string principio_activo, string concentracion, string presentacion, string laboratorio, string registro_sanitario, string requiere_receta, int id)
        {
            Conexion cnn = new Conexion();
            try
            {
                cnn.Conectar();
                string consulta = "update Medicamentos set nombre=@nombre,principio_activo=@principio_activo,concentracion=@concentracion, laboratorio=@laboratorio, registro_sanitario=@registro_sanitario,requiere_receta=@requiere_receta where id=@id";
                SqlCommand cmd = new SqlCommand(consulta, cnn.ObtenerConexion());
                cmd.Parameters.AddWithValue("@nombre", nombres);
                cmd.Parameters.AddWithValue("@principio_activo", principio_activo);
                cmd.Parameters.AddWithValue("@concentracion", concentracion);
                cmd.Parameters.AddWithValue("@presentacion", presentacion); 
                cmd.Parameters.AddWithValue("@laboratorio", laboratorio);
                cmd.Parameters.AddWithValue("@registro_sanitario", registro_sanitario);
                cmd.Parameters.AddWithValue("@requiere_receta", requiere_receta);
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
                string consulta = "delete from Medicamentos where id=@id";
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
