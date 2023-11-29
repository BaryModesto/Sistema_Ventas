namespace Capa_Presentacion
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menu_usuario = new FontAwesome.Sharp.IconMenuItem();
            this.menu_mantenedor = new FontAwesome.Sharp.IconMenuItem();
            this.menu_ventas = new FontAwesome.Sharp.IconMenuItem();
            this.menu_compras = new FontAwesome.Sharp.IconMenuItem();
            this.menu_clientes = new FontAwesome.Sharp.IconMenuItem();
            this.menu_proveedores = new FontAwesome.Sharp.IconMenuItem();
            this.menu_reportes = new FontAwesome.Sharp.IconMenuItem();
            this.menu_acercade = new FontAwesome.Sharp.IconMenuItem();
            this.menu_titulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label_user_logeado = new System.Windows.Forms.Label();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_usuario,
            this.menu_mantenedor,
            this.menu_ventas,
            this.menu_compras,
            this.menu_clientes,
            this.menu_proveedores,
            this.menu_reportes,
            this.menu_acercade});
            this.menu.Location = new System.Drawing.Point(0, 66);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(1098, 64);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menu_usuario
            // 
            this.menu_usuario.AutoSize = false;
            this.menu_usuario.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.menu_usuario.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.menu_usuario.IconColor = System.Drawing.Color.Black;
            this.menu_usuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_usuario.IconSize = 50;
            this.menu_usuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_usuario.Name = "menu_usuario";
            this.menu_usuario.Size = new System.Drawing.Size(60, 60);
            this.menu_usuario.Text = "Usuarios";
            this.menu_usuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menu_usuario.Click += new System.EventHandler(this.menu_usuario_Click);
            // 
            // menu_mantenedor
            // 
            this.menu_mantenedor.AutoSize = false;
            this.menu_mantenedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconMenuItem1,
            this.iconMenuItem2});
            this.menu_mantenedor.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.menu_mantenedor.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.menu_mantenedor.IconColor = System.Drawing.Color.Black;
            this.menu_mantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_mantenedor.IconSize = 50;
            this.menu_mantenedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_mantenedor.Name = "menu_mantenedor";
            this.menu_mantenedor.Size = new System.Drawing.Size(122, 60);
            this.menu_mantenedor.Text = "Mantenedor";
            this.menu_mantenedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menu_ventas
            // 
            this.menu_ventas.AutoSize = false;
            this.menu_ventas.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.menu_ventas.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.menu_ventas.IconColor = System.Drawing.Color.Black;
            this.menu_ventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_ventas.IconSize = 50;
            this.menu_ventas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_ventas.Name = "menu_ventas";
            this.menu_ventas.Size = new System.Drawing.Size(55, 60);
            this.menu_ventas.Text = "Ventas";
            this.menu_ventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menu_compras
            // 
            this.menu_compras.AutoSize = false;
            this.menu_compras.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.menu_compras.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.menu_compras.IconColor = System.Drawing.Color.Black;
            this.menu_compras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_compras.IconSize = 50;
            this.menu_compras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_compras.Name = "menu_compras";
            this.menu_compras.Size = new System.Drawing.Size(55, 60);
            this.menu_compras.Text = "Compras";
            this.menu_compras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menu_clientes
            // 
            this.menu_clientes.AutoSize = false;
            this.menu_clientes.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.menu_clientes.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.menu_clientes.IconColor = System.Drawing.Color.Black;
            this.menu_clientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_clientes.IconSize = 50;
            this.menu_clientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_clientes.Name = "menu_clientes";
            this.menu_clientes.Size = new System.Drawing.Size(60, 60);
            this.menu_clientes.Text = "Clientes";
            this.menu_clientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menu_proveedores
            // 
            this.menu_proveedores.AutoSize = false;
            this.menu_proveedores.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.menu_proveedores.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.menu_proveedores.IconColor = System.Drawing.Color.Black;
            this.menu_proveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_proveedores.IconSize = 50;
            this.menu_proveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_proveedores.Name = "menu_proveedores";
            this.menu_proveedores.Size = new System.Drawing.Size(70, 60);
            this.menu_proveedores.Text = "Proveedores";
            this.menu_proveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menu_reportes
            // 
            this.menu_reportes.AutoSize = false;
            this.menu_reportes.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.menu_reportes.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.menu_reportes.IconColor = System.Drawing.Color.Black;
            this.menu_reportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_reportes.IconSize = 50;
            this.menu_reportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_reportes.Name = "menu_reportes";
            this.menu_reportes.Size = new System.Drawing.Size(70, 60);
            this.menu_reportes.Text = "Reportes";
            this.menu_reportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menu_acercade
            // 
            this.menu_acercade.AutoSize = false;
            this.menu_acercade.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.menu_acercade.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.menu_acercade.IconColor = System.Drawing.Color.Black;
            this.menu_acercade.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_acercade.IconSize = 50;
            this.menu_acercade.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_acercade.Name = "menu_acercade";
            this.menu_acercade.Size = new System.Drawing.Size(70, 60);
            this.menu_acercade.Text = "Acerca de";
            this.menu_acercade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menu_titulo
            // 
            this.menu_titulo.AutoSize = false;
            this.menu_titulo.BackColor = System.Drawing.Color.SteelBlue;
            this.menu_titulo.Location = new System.Drawing.Point(0, 0);
            this.menu_titulo.Name = "menu_titulo";
            this.menu_titulo.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menu_titulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menu_titulo.Size = new System.Drawing.Size(1098, 66);
            this.menu_titulo.TabIndex = 1;
            this.menu_titulo.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema de Ventas";
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 130);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1098, 401);
            this.contenedor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(789, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario:";
            // 
            // label_user_logeado
            // 
            this.label_user_logeado.AutoSize = true;
            this.label_user_logeado.BackColor = System.Drawing.Color.SteelBlue;
            this.label_user_logeado.ForeColor = System.Drawing.Color.White;
            this.label_user_logeado.Location = new System.Drawing.Point(858, 22);
            this.label_user_logeado.Name = "label_user_logeado";
            this.label_user_logeado.Size = new System.Drawing.Size(102, 15);
            this.label_user_logeado.TabIndex = 5;
            this.label_user_logeado.Text = "Usuario Logeado";
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.iconMenuItem1.Text = "Categoria";
            // 
            // iconMenuItem2
            // 
            this.iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem2.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem2.Name = "iconMenuItem2";
            this.iconMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.iconMenuItem2.Text = "Producto";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 531);
            this.Controls.Add(this.label_user_logeado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menu_titulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Inicio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menu_titulo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem menu_usuario;
        private FontAwesome.Sharp.IconMenuItem menu_mantenedor;
        private FontAwesome.Sharp.IconMenuItem menu_ventas;
        private FontAwesome.Sharp.IconMenuItem menu_acercade;
        private FontAwesome.Sharp.IconMenuItem menu_compras;
        private FontAwesome.Sharp.IconMenuItem menu_clientes;
        private FontAwesome.Sharp.IconMenuItem menu_proveedores;
        private FontAwesome.Sharp.IconMenuItem menu_reportes;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_user_logeado;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
    }
}

