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
using FontAwesome.Sharp;

namespace Capa_Presentacion
{
    public partial class Inicio : Form
    {
        private static Usuario usuario_actual ;
        private static IconMenuItem menu_activo = null;
        private static Form formulario_activo = null;
        public Inicio(Usuario _usuario)
        {
            usuario_actual = _usuario;
            InitializeComponent();
        }
        private void Inicio_Load(object sender, EventArgs e)
        {
            label_user_logeado.Text = usuario_actual.nombre_completo;
        }
        private void Abrir_Formulario(IconMenuItem _menu,Form _form)
        {
            if (menu_activo != null)
            {
                menu_activo.BackColor = Color.White;
            }
            _menu.BackColor = Color.Silver;
            menu_activo = _menu;

            if (formulario_activo != null)
            {
                formulario_activo.Close();
            }
            formulario_activo = _form;
            _form.TopLevel = false;
            _form.FormBorderStyle = FormBorderStyle.None;
            _form.Dock = DockStyle.Fill;
            _form.BackColor = Color.SteelBlue;
            contenedor.Controls.Add(_form);
            _form.Show();
        }
        private void menu_usuario_Click(object sender, EventArgs e)
        {
            Abrir_Formulario( (IconMenuItem)sender, new Form_Usuarios());
        }

        private void submenu_categoria_Click(object sender, EventArgs e)
        {
            Abrir_Formulario(menu_mantenedor, new Form_Categoria());
        }

        private void submenu_producto_Click(object sender, EventArgs e)
        {
            Abrir_Formulario(menu_mantenedor, new Form_Producto());
        }

        private void submenu_registrar_venta_Click(object sender, EventArgs e)
        {
            Abrir_Formulario(menu_ventas, new Form_Venta());
        }

        private void submenu_verDetalle_venta_Click(object sender, EventArgs e)
        {
            Abrir_Formulario(menu_ventas, new Form_Venta());
        }
    }
}
