using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Negocios
{
    public class Conexion
    {
        public static MySqlConnection getConnection()
        {
            string servidor = "localhost";
            string puerto = "3306";
            string usuario = "root";
            string contra = "";
            string bd = "si_dominic";

            string cadenaConexion = "server=" + servidor + "; port=" + puerto + "; user id=" + usuario + "; password=" + contra + "; database=" + bd;
            MySqlConnection connection = new MySqlConnection(cadenaConexion);
            return connection;
        }
    }
}
