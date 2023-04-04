namespace CatálogoDeComercio
{
    partial class frmCatalogoComercio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnMostrarArticulo = new System.Windows.Forms.Button();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.btnRecarga = new System.Windows.Forms.Button();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtImagenUrl = new System.Windows.Forms.TextBox();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigoArticulo = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodArticulo = new System.Windows.Forms.Label();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnActualizarBD = new System.Windows.Forms.Button();
            this.btnUrlCarpetaImagen = new System.Windows.Forms.Button();
            this.lblSinImagen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToOrderColumns = true;
            this.dgvArticulos.AllowUserToResizeColumns = false;
            this.dgvArticulos.AllowUserToResizeRows = false;
            this.dgvArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.BackgroundColor = System.Drawing.Color.White;
            this.dgvArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvArticulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvArticulos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArticulos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.EnableHeadersVisualStyles = false;
            this.dgvArticulos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.dgvArticulos.Location = new System.Drawing.Point(19, 97);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(0);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvArticulos.RowHeadersVisible = false;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dgvArticulos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(1000, 610);
            this.dgvArticulos.TabIndex = 20;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // btnMostrarArticulo
            // 
            this.btnMostrarArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMostrarArticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnMostrarArticulo.FlatAppearance.BorderSize = 0;
            this.btnMostrarArticulo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.btnMostrarArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.btnMostrarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarArticulo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnMostrarArticulo.ForeColor = System.Drawing.Color.White;
            this.btnMostrarArticulo.Location = new System.Drawing.Point(725, 39);
            this.btnMostrarArticulo.Name = "btnMostrarArticulo";
            this.btnMostrarArticulo.Size = new System.Drawing.Size(110, 28);
            this.btnMostrarArticulo.TabIndex = 1;
            this.btnMostrarArticulo.Text = "Articulo";
            this.btnMostrarArticulo.UseVisualStyleBackColor = false;
            this.btnMostrarArticulo.Click += new System.EventHandler(this.btnMostrarArticulo_Click);
            // 
            // lblFiltro
            // 
            this.lblFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(17, 42);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(132, 23);
            this.lblFiltro.TabIndex = 37;
            this.lblFiltro.Text = "Filtro Rapido";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltro.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtFiltro.Location = new System.Drawing.Point(163, 42);
            this.txtFiltro.MaxLength = 50;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(528, 22);
            this.txtFiltro.TabIndex = 0;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // lblCampo
            // 
            this.lblCampo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCampo.AutoSize = true;
            this.lblCampo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampo.ForeColor = System.Drawing.Color.White;
            this.lblCampo.Location = new System.Drawing.Point(26, 82);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(64, 18);
            this.lblCampo.TabIndex = 40;
            this.lblCampo.Text = "Campo:";
            // 
            // lblCriterio
            // 
            this.lblCriterio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCriterio.ForeColor = System.Drawing.Color.White;
            this.lblCriterio.Location = new System.Drawing.Point(262, 82);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(64, 18);
            this.lblCriterio.TabIndex = 41;
            this.lblCriterio.Text = "Criterio:";
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Arial", 12F);
            this.lblBusqueda.ForeColor = System.Drawing.Color.White;
            this.lblBusqueda.Location = new System.Drawing.Point(509, 82);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(83, 18);
            this.lblBusqueda.TabIndex = 42;
            this.lblBusqueda.Text = "Busqueda:";
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBusqueda.BackColor = System.Drawing.Color.White;
            this.btnBusqueda.FlatAppearance.BorderSize = 0;
            this.btnBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusqueda.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusqueda.Location = new System.Drawing.Point(921, 77);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(100, 28);
            this.btnBusqueda.TabIndex = 18;
            this.btnBusqueda.Text = "Buscar";
            this.btnBusqueda.UseVisualStyleBackColor = false;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusqueda.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(600, 80);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(297, 22);
            this.txtBusqueda.TabIndex = 17;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // cboCriterio
            // 
            this.cboCriterio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(331, 79);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(160, 24);
            this.cboCriterio.TabIndex = 16;
            // 
            // cboCampo
            // 
            this.cboCampo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(96, 79);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(160, 24);
            this.cboCampo.TabIndex = 15;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // btnRecarga
            // 
            this.btnRecarga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecarga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnRecarga.FlatAppearance.BorderSize = 0;
            this.btnRecarga.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.btnRecarga.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.btnRecarga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecarga.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRecarga.ForeColor = System.Drawing.Color.White;
            this.btnRecarga.Location = new System.Drawing.Point(841, 39);
            this.btnRecarga.Name = "btnRecarga";
            this.btnRecarga.Size = new System.Drawing.Size(110, 28);
            this.btnRecarga.TabIndex = 2;
            this.btnRecarga.Text = "Recarga Art";
            this.btnRecarga.UseVisualStyleBackColor = false;
            this.btnRecarga.Click += new System.EventHandler(this.btnRecarga_Click);
            // 
            // cboMarca
            // 
            this.cboMarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(1035, 338);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(121, 24);
            this.cboMarca.TabIndex = 8;
            // 
            // cboCategoria
            // 
            this.cboCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(1166, 338);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(121, 24);
            this.cboCategoria.TabIndex = 9;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(1254, 157);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(32, 24);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "L";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtImagenUrl
            // 
            this.txtImagenUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImagenUrl.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtImagenUrl.Location = new System.Drawing.Point(1035, 278);
            this.txtImagenUrl.MaxLength = 1000;
            this.txtImagenUrl.Name = "txtImagenUrl";
            this.txtImagenUrl.Size = new System.Drawing.Size(212, 22);
            this.txtImagenUrl.TabIndex = 6;
            this.txtImagenUrl.TextChanged += new System.EventHandler(this.txtImagenUrl_TextChanged);
            this.txtImagenUrl.Leave += new System.EventHandler(this.txtImagenUrl_Leave);
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.Font = new System.Drawing.Font("Arial", 12F);
            this.lblUrlImagen.Location = new System.Drawing.Point(1035, 257);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(82, 18);
            this.lblUrlImagen.TabIndex = 13;
            this.lblUrlImagen.Text = "UrlImagen:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecio.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtPrecio.Location = new System.Drawing.Point(1035, 400);
            this.txtPrecio.MaxLength = 38;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(246, 22);
            this.txtPrecio.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtNombre.Location = new System.Drawing.Point(1035, 218);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(247, 22);
            this.txtNombre.TabIndex = 5;
            // 
            // txtCodigoArticulo
            // 
            this.txtCodigoArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigoArticulo.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtCodigoArticulo.Location = new System.Drawing.Point(1035, 158);
            this.txtCodigoArticulo.MaxLength = 50;
            this.txtCodigoArticulo.Name = "txtCodigoArticulo";
            this.txtCodigoArticulo.Size = new System.Drawing.Size(212, 22);
            this.txtCodigoArticulo.TabIndex = 4;
            // 
            // lblPrecio
            // 
            this.lblPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Arial", 12F);
            this.lblPrecio.Location = new System.Drawing.Point(1035, 379);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(58, 18);
            this.lblPrecio.TabIndex = 7;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCategoria.Location = new System.Drawing.Point(1162, 315);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(85, 18);
            this.lblCategoria.TabIndex = 6;
            this.lblCategoria.Text = "Categoría :";
            // 
            // lblMarca
            // 
            this.lblMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Arial", 12F);
            this.lblMarca.Location = new System.Drawing.Point(1035, 315);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(56, 18);
            this.lblMarca.TabIndex = 5;
            this.lblMarca.Text = "Marca:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Arial", 12F);
            this.lblDescripcion.Location = new System.Drawing.Point(1035, 437);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(96, 18);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnAgregarImagen.FlatAppearance.BorderSize = 0;
            this.btnAgregarImagen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.btnAgregarImagen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.btnAgregarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarImagen.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAgregarImagen.ForeColor = System.Drawing.Color.White;
            this.btnAgregarImagen.Location = new System.Drawing.Point(1255, 277);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(32, 24);
            this.btnAgregarImagen.TabIndex = 7;
            this.btnAgregarImagen.Text = "...";
            this.btnAgregarImagen.UseVisualStyleBackColor = false;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(1035, 197);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 18);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCodArticulo
            // 
            this.lblCodArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodArticulo.AutoSize = true;
            this.lblCodArticulo.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodArticulo.Location = new System.Drawing.Point(1035, 129);
            this.lblCodArticulo.Name = "lblCodArticulo";
            this.lblCodArticulo.Size = new System.Drawing.Size(168, 23);
            this.lblCodArticulo.TabIndex = 2;
            this.lblCodArticulo.Text = "Codigo Articulo :";
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxArticulo.Location = new System.Drawing.Point(1301, 147);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(250, 250);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 1;
            this.pbxArticulo.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 23);
            this.label1.TabIndex = 43;
            this.label1.Text = "Busqueda avanzada a BD";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.cboCriterio);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBusqueda);
            this.panel1.Controls.Add(this.btnBusqueda);
            this.panel1.Controls.Add(this.lblBusqueda);
            this.panel1.Controls.Add(this.lblCampo);
            this.panel1.Controls.Add(this.cboCampo);
            this.panel1.Controls.Add(this.lblCriterio);
            this.panel1.Location = new System.Drawing.Point(-9, 719);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1600, 143);
            this.panel1.TabIndex = 44;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(1035, 604);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(120, 28);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(1164, 604);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(120, 28);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(1290, 604);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 28);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(1035, 458);
            this.txtDescripcion.MaxLength = 150;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(516, 130);
            this.txtDescripcion.TabIndex = 11;
            // 
            // btnActualizarBD
            // 
            this.btnActualizarBD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarBD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnActualizarBD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.btnActualizarBD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.btnActualizarBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarBD.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnActualizarBD.ForeColor = System.Drawing.Color.White;
            this.btnActualizarBD.Location = new System.Drawing.Point(1035, 638);
            this.btnActualizarBD.Name = "btnActualizarBD";
            this.btnActualizarBD.Size = new System.Drawing.Size(145, 28);
            this.btnActualizarBD.TabIndex = 19;
            this.btnActualizarBD.Text = "Actualizar Grilla BD";
            this.btnActualizarBD.UseVisualStyleBackColor = false;
            this.btnActualizarBD.Click += new System.EventHandler(this.btnRecargaBD_Click);
            // 
            // btnUrlCarpetaImagen
            // 
            this.btnUrlCarpetaImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUrlCarpetaImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnUrlCarpetaImagen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.btnUrlCarpetaImagen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.btnUrlCarpetaImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrlCarpetaImagen.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnUrlCarpetaImagen.ForeColor = System.Drawing.Color.White;
            this.btnUrlCarpetaImagen.Location = new System.Drawing.Point(1186, 638);
            this.btnUrlCarpetaImagen.Name = "btnUrlCarpetaImagen";
            this.btnUrlCarpetaImagen.Size = new System.Drawing.Size(100, 28);
            this.btnUrlCarpetaImagen.TabIndex = 20;
            this.btnUrlCarpetaImagen.Text = "Carpeta Img";
            this.btnUrlCarpetaImagen.UseVisualStyleBackColor = false;
            this.btnUrlCarpetaImagen.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSinImagen
            // 
            this.lblSinImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSinImagen.Font = new System.Drawing.Font("Arial Black", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinImagen.ForeColor = System.Drawing.Color.DimGray;
            this.lblSinImagen.Location = new System.Drawing.Point(1301, 147);
            this.lblSinImagen.Name = "lblSinImagen";
            this.lblSinImagen.Size = new System.Drawing.Size(250, 250);
            this.lblSinImagen.TabIndex = 45;
            this.lblSinImagen.Text = "SIN IMAGEN";
            this.lblSinImagen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSinImagen.Visible = false;
            // 
            // frmCatalogoComercio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.lblSinImagen);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.lblCodArticulo);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.btnUrlCarpetaImagen);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnRecarga);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.btnMostrarArticulo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.btnActualizarBD);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.txtCodigoArticulo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblUrlImagen);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtImagenUrl);
            this.Controls.Add(this.btnAgregar);
            this.MinimumSize = new System.Drawing.Size(1600, 900);
            this.Name = "frmCatalogoComercio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cátalogo de Comercio";
            this.Load += new System.EventHandler(this.frmCatalogoComercio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Button btnMostrarArticulo;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.Button btnRecarga;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtImagenUrl;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigoArticulo;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnAgregarImagen;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodArticulo;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnActualizarBD;
        private System.Windows.Forms.Button btnUrlCarpetaImagen;
        private System.Windows.Forms.Label lblSinImagen;
    }
}

