using HueraEcologica_SID;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class ClienteTerminal 
    {
       
        private string primernombre;
        private string segundonombre;
        private string primerapellido;
        private string segundoapellido;
        private string email;
        private int telefono;
        private string calle;
        private int numero;
        private string departamento;
        private string esquina;

        private string nombreusuario;
        private string contraseña;
        private string tipodedocumento;
        private int numerodedocumento;



        public string Primernombre { get => primernombre; set => primernombre = value; }
        public string Segundonombre { get => segundonombre; set => segundonombre = value; }
        public string Primerapellido { get => primerapellido; set => primerapellido = value; }
        public string Segundoapellido { get => segundoapellido; set => segundoapellido = value; }
        public string Email { get => email; set => email = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Calle { get => calle; set => calle = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Departamento { get => departamento; set => departamento = value; }
        public string Esquina { get => esquina; set => esquina = value; }
        public string Nombreusuario { get => nombreusuario; set => nombreusuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Tipodedocumento { get => tipodedocumento; set => tipodedocumento = value; }
        public int Numerodedocumento { get => numerodedocumento; set => numerodedocumento = value; }




        public ClienteTerminal()
        {

        }

        public ClienteTerminal(string primernombre, string segundonombre, string primerapellido, string segundoapellido, string email, int telefono, string calle, int numero, string departamento, string esquina, string nombreusuario, string contraseña, string tipodedocumento, int numerodedocumento)
        {
            Primernombre = primernombre;
            Segundonombre = segundonombre;
            Primerapellido = primerapellido;
            Segundoapellido = segundoapellido;
            Email = email;
            Telefono = telefono;
            Calle = calle;
            Numero = numero;
            Departamento = departamento;
            Esquina = esquina;
            Nombreusuario = nombreusuario;
            Contraseña = contraseña;
            Tipodedocumento = tipodedocumento;
            Numerodedocumento = numerodedocumento;
        }
    }
}
