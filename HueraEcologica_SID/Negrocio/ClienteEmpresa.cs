using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HueraEcologica_SID
{
    internal class ClienteEmpresa : Cliente
    {


        private string email;
        private int telefono;
        private string calle;
        private int numero;
        private string departamento;
        private string barrio;
        private string nombreusuario;
        private string contraseña;
        private string tipodedocumento;
        private int numerodedocumento;
        private int rut;

        public string Email { get => email; set => email = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Calle { get => calle; set => calle = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Departamento { get => departamento; set => departamento = value; }
        public string Barrio { get => barrio; set => barrio = value; }
        public string Nombreusuario { get => nombreusuario; set => nombreusuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Tipodedocumento { get => tipodedocumento; set => tipodedocumento = value; }
        public int Numerodedocumento { get => numerodedocumento; set => numerodedocumento = value; }
        public int Rut { get => rut; set => rut = value; }

        public ClienteEmpresa()
        {

        }

        public ClienteEmpresa(string email, int telefono, string calle, int numero, string departamento, string barrio, string nombreusuario, string contraseña, string tipodedocumento, int numerodedocumento, int rut)
        {
            Email = email;
            Telefono = telefono;
            Calle = calle;
            Numero = numero;
            Departamento = departamento;
            Barrio = barrio;
            Nombreusuario = nombreusuario;
            Contraseña = contraseña;
            Tipodedocumento = tipodedocumento;
            Numerodedocumento = numerodedocumento;
            Rut = rut;
        }
    }
}
