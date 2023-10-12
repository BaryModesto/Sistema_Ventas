using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void boton_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void boton_ingresar_Click(object sender, EventArgs e)
        {
            Inicio ventana_inicio = new Inicio();
            ventana_inicio.Show();
            this.Hide();
            //---
            ventana_inicio.FormClosing += Cerrando;
        }
        private void Cerrando(object sender, FormClosingEventArgs e)   
        {
            edit_contrasenha.Clear();
            edit_documentacion.Clear();
            this.Show();
        }
    }
}
