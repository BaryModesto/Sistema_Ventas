using Capa_Entidad;
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
    public partial class Inicio : Form
    {
        private static Usuario usuario_actual ;
        public Inicio(Usuario _usuario)
        {
            usuario_actual = _usuario;
            InitializeComponent();
        }
        private void Inicio_Load(object sender, EventArgs e)
        {
            label_user_logeado.Text = usuario_actual.nombre_completo;
        }
        private void Abrir_Formulario(Form _form)
        {
            this.Hide();
            _form.Show();
        }
        private void menu_usuario_Click(object sender, EventArgs e)
        {
            Abrir_Formulario(new Form_Usuarios());
        }
        
    }
}
