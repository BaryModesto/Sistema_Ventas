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
        }
    }
}
