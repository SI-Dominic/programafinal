using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Negocios
{
    public class Modelo
    {
        public int registro(Usuarios usuario)
        {
            MySqlConnection conexion = Conexion.getConnection();
            conexion.Open();

            string sql = "INSERT INTO usuarios (usuario, password, nombre, id) VALUES(@usuario, @password, @nombre, @id)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            
            comando.Parameters.AddWithValue("@usuario", usuario.usuario);
            comando.Parameters.AddWithValue("@contraseña", usuario.contraseña);
            comando.Parameters.AddWithValue("@id",usuario.id);


            int resultado = comando.ExecuteNonQuery();

            return resultado;
        }
        public Usuarios porUsuarios(string usuario)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConnection();
            conexion.Open();

            string sql = "SELECT id, usuario, contraseña FROM usuarios WHERE usuario LIKE @usuario";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario);

            reader = comando.ExecuteReader();
            Usuarios usr = null;

            while (reader.Read())
            {
                usr = new Usuarios();
                usr.id = int.Parse(reader["id"].ToString());
                usr.usuario = reader["usuario"].ToString();
                usr.contraseña = reader["contraseña"].ToString();

            }
            return usr;


        }

        internal bool existeUsuario(string usuario)
        {
            throw new NotImplementedException();
        }
    }
}
