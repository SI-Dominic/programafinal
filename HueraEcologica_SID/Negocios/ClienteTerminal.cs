using HueraEcologica_SID;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class ClienteTerminal : Cliente
    {
        public ClienteTerminal(string tipodedocuemento, int numerodedocumento, string calle, int numero, string esquina, string barrio, string departamento, string email) : base(tipodedocuemento, numerodedocumento, calle, numero, esquina, barrio, departamento, email)
        {
        }

        private string primernombre { get; set; }
        private string segundonombre { get; set; }
        private string primerapellido { get; set; }

        private string segundoapellido { get; set; }


    }
}
