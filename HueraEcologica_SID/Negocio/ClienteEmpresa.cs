using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HueraEcologica_SID
{
    internal class ClienteEmpresa : Cliente
    {
        public ClienteEmpresa(string tipodedocuemento, int numerodedocumento, string calle, int numero, string esquina, string barrio, string departamento, string email) : base(tipodedocuemento, numerodedocumento, calle, numero, esquina, barrio, departamento, email)
        {
        }   

        private string nombre { get; set; }

        private int rut { get; set; }

    }
}
