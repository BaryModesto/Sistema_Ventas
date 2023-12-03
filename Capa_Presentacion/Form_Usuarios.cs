using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Presentacion.Utilidades;
using Capa_Negocio;
using Capa_Entidad;

namespace Capa_Presentacion
{
    public partial class Form_Usuarios : Form
    {
        public Form_Usuarios()
        {
            InitializeComponent();
        }

        private void Form_Usuarios_Load(object sender, EventArgs e)
        {
            cb_estado.Items.Clear();
            cb_estado.Items.Add
            (
                new Opcion_Combo()
                {
                    valor =1,
                    texto = "Activo"
                }
            );
            cb_estado.Items.Add
            (
                new Opcion_Combo()
                {
                    valor = 0,
                    texto = "No Activo"
                }
            );
            cb_estado.DisplayMember = "texto";
            cb_estado.ValueMember = "valor";
            cb_estado.SelectedIndex = 0;
            //---
            List<Rol> lista_rol = new CN_Rol().Listar();
            foreach (var item in lista_rol)
            {
                cb_rol.Items.Add(
                      new Opcion_Combo()
                      {
                          valor = item.id_rol,
                          texto = item.descripcion
                      }
               );
            }
            cb_rol.DisplayMember = "texto";
            cb_rol.ValueMember = "valor";
            cb_rol.SelectedIndex = 0;
        }

        private void boton_guardar_Click(object sender, EventArgs e)
        {
            dgv_data.Rows.Add(new object[] {"",edit_id.Text,edit_documento.Text,edit_nombre_completo.Text,edit_correo.Text,edit_clave.Text,
                ((Opcion_Combo)cb_rol.SelectedItem).valor.ToString(),
                ((Opcion_Combo)cb_rol.SelectedItem).texto.ToString(),
                ((Opcion_Combo)cb_estado.SelectedItem).valor.ToString(),
                ((Opcion_Combo)cb_estado.SelectedItem).texto.ToString()
            });
            Limpiar();
        }
        private void Limpiar()
        {
            edit_id.Clear();
            edit_documento.Clear();
            edit_nombre_completo.Clear();
            edit_correo.Clear();
            edit_clave.Clear();
            edit_confirmar_clave.Clear();
            cb_rol.SelectedIndex = 0;
            cb_estado.SelectedIndex = 0;
        }
    }
}
