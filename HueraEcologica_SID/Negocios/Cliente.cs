using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HueraEcologica_SID
{
    public class Cliente
    {
        public string tipodedocuemento { get; set; }
        public int numerodedocumento { get; set; }
        public string calle { get; set; }
        public int numero { get; set; }
        public string esquina { get; set; }
        public string barrio { get; set; }
        public string departamento { get; set; }
        public string email { get; set; }

        public Cliente(string tipodedocuemento, int numerodedocumento, string calle, int numero, string esquina, string barrio, string departamento, string email)
        {
            this.tipodedocuemento = tipodedocuemento;
            this.numerodedocumento = numerodedocumento;
            this.calle = calle;
            this.numero = numero;
            this.esquina = esquina;
            this.barrio = barrio;
            this.departamento = departamento;
            this.email = email;
        }

        public Cliente()
        {
        }
    }
}
