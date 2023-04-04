namespace CatálogoDeComercio
{
    partial class frmMostrarArticulo
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
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.lblCodigoArticulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.lblSinImagen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxArticulo.Location = new System.Drawing.Point(494, 12);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(178, 178);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 1;
            this.pbxArticulo.TabStop = false;
            // 
            // lblCodigoArticulo
            // 
            this.lblCodigoArticulo.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCodigoArticulo.ForeColor = System.Drawing.Color.White;
            this.lblCodigoArticulo.Location = new System.Drawing.Point(8, 20);
            this.lblCodigoArticulo.Name = "lblCodigoArticulo";
            this.lblCodigoArticulo.Size = new System.Drawing.Size(480, 42);
            this.lblCodigoArticulo.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Arial", 12F);
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(8, 62);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(480, 42);
            this.lblNombre.TabIndex = 3;
            // 
            // lblCategoria
            // 
            this.lblCategoria.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCategoria.ForeColor = System.Drawing.Color.White;
            this.lblCategoria.Location = new System.Drawing.Point(8, 104);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(480, 42);
            this.lblCategoria.TabIndex = 4;
            // 
            // lblMarca
            // 
            this.lblMarca.Font = new System.Drawing.Font("Arial", 12F);
            this.lblMarca.ForeColor = System.Drawing.Color.White;
            this.lblMarca.Location = new System.Drawing.Point(8, 146);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(480, 44);
            this.lblMarca.TabIndex = 5;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Font = new System.Drawing.Font("Arial", 12F);
            this.lblDescripcion.ForeColor = System.Drawing.Color.White;
            this.lblDescripcion.Location = new System.Drawing.Point(8, 235);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(664, 113);
            this.lblDescripcion.TabIndex = 6;
            // 
            // lblPrecio
            // 
            this.lblPrecio.Font = new System.Drawing.Font("Arial", 12F);
            this.lblPrecio.ForeColor = System.Drawing.Color.White;
            this.lblPrecio.Location = new System.Drawing.Point(8, 188);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(480, 47);
            this.lblPrecio.TabIndex = 7;
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.Font = new System.Drawing.Font("Arial", 12F);
            this.lblUrlImagen.ForeColor = System.Drawing.Color.White;
            this.lblUrlImagen.Location = new System.Drawing.Point(8, 348);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(664, 54);
            this.lblUrlImagen.TabIndex = 8;
            // 
            // lblSinImagen
            // 
            this.lblSinImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSinImagen.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinImagen.ForeColor = System.Drawing.Color.DimGray;
            this.lblSinImagen.Location = new System.Drawing.Point(494, 12);
            this.lblSinImagen.Name = "lblSinImagen";
            this.lblSinImagen.Size = new System.Drawing.Size(178, 178);
            this.lblSinImagen.TabIndex = 46;
            this.lblSinImagen.Text = "SIN IMAGEN";
            this.lblSinImagen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSinImagen.Visible = false;
            // 
            // frmMostrarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.lblSinImagen);
            this.Controls.Add(this.lblUrlImagen);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigoArticulo);
            this.Controls.Add(this.pbxArticulo);
            this.MaximumSize = new System.Drawing.Size(700, 450);
            this.MinimumSize = new System.Drawing.Size(700, 450);
            this.Name = "frmMostrarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulo ";
            this.Load += new System.EventHandler(this.frmMostrarArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Label lblCodigoArticulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.Label lblSinImagen;
    }
}