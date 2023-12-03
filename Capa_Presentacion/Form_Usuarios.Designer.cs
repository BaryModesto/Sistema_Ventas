namespace Capa_Presentacion
{
    partial class Form_Usuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.edit_documento = new System.Windows.Forms.TextBox();
            this.edit_correo = new System.Windows.Forms.TextBox();
            this.edit_nombre_completo = new System.Windows.Forms.TextBox();
            this.edit_clave = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.edit_confirmar_clave = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_rol = new System.Windows.Forms.ComboBox();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.boton_guardar = new System.Windows.Forms.Button();
            this.boton_editar = new System.Windows.Forms.Button();
            this.boton_eliminar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dgv_data = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.edit_id = new System.Windows.Forms.TextBox();
            this.btn_seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_completo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 495);
            this.label1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "# Documento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Correo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nombre Completo:";
            // 
            // edit_documento
            // 
            this.edit_documento.Location = new System.Drawing.Point(12, 60);
            this.edit_documento.Name = "edit_documento";
            this.edit_documento.Size = new System.Drawing.Size(139, 20);
            this.edit_documento.TabIndex = 11;
            // 
            // edit_correo
            // 
            this.edit_correo.Location = new System.Drawing.Point(12, 149);
            this.edit_correo.Name = "edit_correo";
            this.edit_correo.Size = new System.Drawing.Size(139, 20);
            this.edit_correo.TabIndex = 12;
            // 
            // edit_nombre_completo
            // 
            this.edit_nombre_completo.Location = new System.Drawing.Point(12, 104);
            this.edit_nombre_completo.Name = "edit_nombre_completo";
            this.edit_nombre_completo.Size = new System.Drawing.Size(139, 20);
            this.edit_nombre_completo.TabIndex = 13;
            // 
            // edit_clave
            // 
            this.edit_clave.Location = new System.Drawing.Point(12, 196);
            this.edit_clave.Name = "edit_clave";
            this.edit_clave.PasswordChar = '*';
            this.edit_clave.Size = new System.Drawing.Size(139, 20);
            this.edit_clave.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Contraseña:";
            // 
            // edit_confirmar_clave
            // 
            this.edit_confirmar_clave.Location = new System.Drawing.Point(12, 243);
            this.edit_confirmar_clave.Name = "edit_confirmar_clave";
            this.edit_confirmar_clave.PasswordChar = '*';
            this.edit_confirmar_clave.Size = new System.Drawing.Size(139, 20);
            this.edit_confirmar_clave.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Confirmar Contraseña:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Rol:";
            // 
            // cb_rol
            // 
            this.cb_rol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_rol.FormattingEnabled = true;
            this.cb_rol.Location = new System.Drawing.Point(12, 288);
            this.cb_rol.Name = "cb_rol";
            this.cb_rol.Size = new System.Drawing.Size(139, 21);
            this.cb_rol.TabIndex = 19;
            // 
            // cb_estado
            // 
            this.cb_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Location = new System.Drawing.Point(12, 330);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(139, 21);
            this.cb_estado.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Estado:";
            // 
            // boton_guardar
            // 
            this.boton_guardar.BackColor = System.Drawing.Color.ForestGreen;
            this.boton_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton_guardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.boton_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_guardar.ForeColor = System.Drawing.Color.White;
            this.boton_guardar.Location = new System.Drawing.Point(12, 370);
            this.boton_guardar.Name = "boton_guardar";
            this.boton_guardar.Size = new System.Drawing.Size(139, 23);
            this.boton_guardar.TabIndex = 22;
            this.boton_guardar.Text = "Guardar";
            this.boton_guardar.UseVisualStyleBackColor = false;
            this.boton_guardar.Click += new System.EventHandler(this.boton_guardar_Click);
            // 
            // boton_editar
            // 
            this.boton_editar.BackColor = System.Drawing.Color.RoyalBlue;
            this.boton_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton_editar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.boton_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_editar.ForeColor = System.Drawing.Color.White;
            this.boton_editar.Location = new System.Drawing.Point(12, 408);
            this.boton_editar.Name = "boton_editar";
            this.boton_editar.Size = new System.Drawing.Size(139, 23);
            this.boton_editar.TabIndex = 23;
            this.boton_editar.Text = "Editar";
            this.boton_editar.UseVisualStyleBackColor = false;
            // 
            // boton_eliminar
            // 
            this.boton_eliminar.BackColor = System.Drawing.Color.Firebrick;
            this.boton_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.boton_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_eliminar.ForeColor = System.Drawing.Color.White;
            this.boton_eliminar.Location = new System.Drawing.Point(12, 444);
            this.boton_eliminar.Name = "boton_eliminar";
            this.boton_eliminar.Size = new System.Drawing.Size(139, 23);
            this.boton_eliminar.TabIndex = 24;
            this.boton_eliminar.Text = "Eliminar";
            this.boton_eliminar.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 25);
            this.label9.TabIndex = 25;
            this.label9.Text = "Detalle Usuario";
            // 
            // dgv_data
            // 
            this.dgv_data.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btn_seleccionar,
            this.id_usuario,
            this.documento,
            this.nombre_completo,
            this.correo,
            this.clave,
            this.id_rol,
            this.rol,
            this.estado_valor,
            this.estado});
            this.dgv_data.Location = new System.Drawing.Point(189, 69);
            this.dgv_data.MultiSelect = false;
            this.dgv_data.Name = "dgv_data";
            this.dgv_data.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_data.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_data.RowTemplate.Height = 28;
            this.dgv_data.Size = new System.Drawing.Size(733, 414);
            this.dgv_data.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(189, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(733, 47);
            this.label10.TabIndex = 27;
            this.label10.Text = "Lista de Usuarios:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // edit_id
            // 
            this.edit_id.Location = new System.Drawing.Point(129, 37);
            this.edit_id.Name = "edit_id";
            this.edit_id.Size = new System.Drawing.Size(22, 20);
            this.edit_id.TabIndex = 28;
            this.edit_id.Text = "0";
            // 
            // btn_seleccionar
            // 
            this.btn_seleccionar.HeaderText = "";
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.ReadOnly = true;
            this.btn_seleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btn_seleccionar.Width = 30;
            // 
            // id_usuario
            // 
            this.id_usuario.HeaderText = "IdUsuario";
            this.id_usuario.Name = "id_usuario";
            this.id_usuario.ReadOnly = true;
            this.id_usuario.Visible = false;
            // 
            // documento
            // 
            this.documento.HeaderText = "# Documento";
            this.documento.Name = "documento";
            this.documento.ReadOnly = true;
            this.documento.Width = 180;
            // 
            // nombre_completo
            // 
            this.nombre_completo.HeaderText = "Nombre Completo";
            this.nombre_completo.Name = "nombre_completo";
            this.nombre_completo.ReadOnly = true;
            this.nombre_completo.Width = 180;
            // 
            // correo
            // 
            this.correo.HeaderText = "Correo";
            this.correo.Name = "correo";
            this.correo.ReadOnly = true;
            this.correo.Width = 180;
            // 
            // clave
            // 
            this.clave.HeaderText = "Clave";
            this.clave.Name = "clave";
            this.clave.ReadOnly = true;
            this.clave.Visible = false;
            // 
            // id_rol
            // 
            this.id_rol.HeaderText = "IdRol";
            this.id_rol.Name = "id_rol";
            this.id_rol.ReadOnly = true;
            this.id_rol.Visible = false;
            // 
            // rol
            // 
            this.rol.HeaderText = "Rol";
            this.rol.Name = "rol";
            this.rol.ReadOnly = true;
            // 
            // estado_valor
            // 
            this.estado_valor.HeaderText = "Estado Valor";
            this.estado_valor.Name = "estado_valor";
            this.estado_valor.ReadOnly = true;
            this.estado_valor.Visible = false;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // Form_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 495);
            this.Controls.Add(this.edit_id);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgv_data);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.boton_eliminar);
            this.Controls.Add(this.boton_editar);
            this.Controls.Add(this.boton_guardar);
            this.Controls.Add(this.cb_estado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cb_rol);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.edit_confirmar_clave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.edit_clave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.edit_nombre_completo);
            this.Controls.Add(this.edit_correo);
            this.Controls.Add(this.edit_documento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Usuarios";
            this.Text = "Form_Usuarios";
            this.Load += new System.EventHandler(this.Form_Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edit_documento;
        private System.Windows.Forms.TextBox edit_correo;
        private System.Windows.Forms.TextBox edit_nombre_completo;
        private System.Windows.Forms.TextBox edit_clave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edit_confirmar_clave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_rol;
        private System.Windows.Forms.ComboBox cb_estado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button boton_guardar;
        private System.Windows.Forms.Button boton_editar;
        private System.Windows.Forms.Button boton_eliminar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgv_data;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox edit_id;
        private System.Windows.Forms.DataGridViewButtonColumn btn_seleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_completo;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}