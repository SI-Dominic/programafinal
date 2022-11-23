using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HueraEcologica_SID
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (txtcontraseñat.Text == "" || txtnumerodedocumentot.Text == "" || txttipodedocumentot.Text == "" || txtprimernombret.Text == "" || txtprimerapellidot.Text == "" || txtsegundonombret.Text == "" || txtsegundonombret.Text == ""){

                MessageBox.Show("Debe rellenar todos los campos");
            }
            else { 
            ClienteTerminal clienteTerminal = new ClienteTerminal();

            clienteTerminal.Contraseña = txtcontraseñat.Text;
            clienteTerminal.Tipodedocumento = txttipodedocumentot.Text;
            clienteTerminal.Numerodedocumento = Convert.ToInt32(txtnumerodedocumentot.Text);
            clienteTerminal.Primerapellido = txtprimerapellidot.Text;
            clienteTerminal.Primernombre = txtprimernombret.Text;
            clienteTerminal.Segundoapellido = txtsegundoapellidot.Text;
            clienteTerminal.Segundonombre = txtsegundonombret.Text;
            Controlador controlador = new Controlador();
            controlador.ctrlRegistro(clienteTerminal);
            MessageBox.Show("Te has registrado en el sistema exitosamente");


            }
        }
    }
}
