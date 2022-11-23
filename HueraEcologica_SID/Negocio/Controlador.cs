using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace Negocios
{
    public class Controlador
    {
        public string ctrlLogin(String usuario, string contraseña)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";
            Usuarios datosUsuario = null;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                respuesta = "Debe llenar todos los campos";

            }
            else
            {
                datosUsuario = modelo.porUsuarios(usuario);

                if (datosUsuario == null)
                {
                    respuesta = "El usuario no existe";
                }
                else
                {
                    if (datosUsuario.contraseña != contraseña)
                    {
                        respuesta = "El usuario y/o contraseña no coincide";
                    }
                }
            }
            return respuesta;
        }
        public string ctrlRegistro(Usuarios usuario)
            {
                Modelo modelo = new Modelo();
                string respuesta = "";

                if (string.IsNullOrEmpty(usuario.usuario) || string.IsNullOrEmpty(usuario.contraseña))
                {
                    respuesta = "Debe llenar todos los campos";
                }
                else
                {
                    if (usuario.contraseña == usuario.contraseña)
                    {
                        if (modelo.existeUsuario(usuario.usuario))
                        {
                            respuesta = "El usuario ya existe";
                        }
                        else
                        {
                            usuario.contraseña = generarSHA1(usuario.contraseña);
                            modelo.registro(usuario);
                        }
                    }
                    else
                    {
                        respuesta = "Las contraseña no coinciden";
                    }
                }
                return respuesta;


            }
        public string generarSHA1(string cadena)
            {
                UTF8Encoding enc = new UTF8Encoding();
                byte[] data = enc.GetBytes(cadena);
                byte[] result;

                SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();

                result = sha.ComputeHash(data);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < result.Length; i++)
                {

                    if (result[i] < 16)
                    {
                        sb.Append("0");
                    }
                    sb.Append(result[i].ToString("x"));
                }

                return sb.ToString();

            }


        
    }
}
