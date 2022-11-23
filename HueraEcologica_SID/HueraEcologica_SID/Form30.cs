using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;

namespace HueraEcologica_SID {
    public partial class Form30 : Form
    {
        public Form30()
        {
            InitializeComponent();
        }

        private void Form30_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
           

            Controlador ctrlControlador = new Controlador();
            string Usuario = txtUsuario.Text;
            string Contraseña = txtContraseña.Text;
            string RespuestaE = ctrlControlador.ctrlLogin(Usuario, Contraseña);
            try
            {

                string RespuestaT = ctrlControlador.ctrlLogin(Usuario, Contraseña);


                if (RespuestaE.Length > 0)
                {
                    MessageBox.Show(RespuestaE, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    this.Hide();
                    form10.ShowDialog();
                    this.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }
    }
}
