
namespace BibliotecaAppEscritorio
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GBCabecera = new System.Windows.Forms.GroupBox();
            this.miBiblio = new System.Windows.Forms.Label();
            this.GBInsertar = new System.Windows.Forms.GroupBox();
            this.TBApellido = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.LEstado = new System.Windows.Forms.Label();
            this.LPublicacion = new System.Windows.Forms.Label();
            this.LNum = new System.Windows.Forms.Label();
            this.LSerie = new System.Windows.Forms.Label();
            this.LTitulo = new System.Windows.Forms.Label();
            this.LAutor = new System.Windows.Forms.Label();
            this.saveBotton = new System.Windows.Forms.Button();
            this.TBNum = new System.Windows.Forms.TextBox();
            this.TBTitulo = new System.Windows.Forms.TextBox();
            this.TBSerie = new System.Windows.Forms.TextBox();
            this.PBImagen = new System.Windows.Forms.PictureBox();
            this.TBAutor = new System.Windows.Forms.TextBox();
            this.LAñadirL = new System.Windows.Forms.Label();
            this.TBBuscar = new System.Windows.Forms.TextBox();
            this.GBAñadirL = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GBCabecera.SuspendLayout();
            this.GBInsertar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagen)).BeginInit();
            this.GBAñadirL.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBCabecera
            // 
            this.GBCabecera.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBCabecera.BackColor = System.Drawing.Color.Gray;
            this.GBCabecera.Controls.Add(this.miBiblio);
            this.GBCabecera.Location = new System.Drawing.Point(1, 2);
            this.GBCabecera.Name = "GBCabecera";
            this.GBCabecera.Size = new System.Drawing.Size(1317, 82);
            this.GBCabecera.TabIndex = 0;
            this.GBCabecera.TabStop = false;
            // 
            // miBiblio
            // 
            this.miBiblio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.miBiblio.AutoSize = true;
            this.miBiblio.Font = new System.Drawing.Font("Ink Free", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miBiblio.ForeColor = System.Drawing.Color.White;
            this.miBiblio.Location = new System.Drawing.Point(21, 14);
            this.miBiblio.Name = "miBiblio";
            this.miBiblio.Size = new System.Drawing.Size(420, 60);
            this.miBiblio.TabIndex = 0;
            this.miBiblio.Text = "MI BIBLIOTECA";
            this.miBiblio.Click += new System.EventHandler(this.label1_Click);
            // 
            // GBInsertar
            // 
            this.GBInsertar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GBInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GBInsertar.Controls.Add(this.TBApellido);
            this.GBInsertar.Controls.Add(this.dateTimePicker1);
            this.GBInsertar.Controls.Add(this.comboBoxEstado);
            this.GBInsertar.Controls.Add(this.LEstado);
            this.GBInsertar.Controls.Add(this.LPublicacion);
            this.GBInsertar.Controls.Add(this.LNum);
            this.GBInsertar.Controls.Add(this.LSerie);
            this.GBInsertar.Controls.Add(this.LTitulo);
            this.GBInsertar.Controls.Add(this.LAutor);
            this.GBInsertar.Controls.Add(this.saveBotton);
            this.GBInsertar.Controls.Add(this.TBNum);
            this.GBInsertar.Controls.Add(this.TBTitulo);
            this.GBInsertar.Controls.Add(this.TBSerie);
            this.GBInsertar.Controls.Add(this.PBImagen);
            this.GBInsertar.Controls.Add(this.TBAutor);
            this.GBInsertar.Location = new System.Drawing.Point(7, 112);
            this.GBInsertar.Name = "GBInsertar";
            this.GBInsertar.Size = new System.Drawing.Size(376, 624);
            this.GBInsertar.TabIndex = 0;
            this.GBInsertar.TabStop = false;
            // 
            // TBApellido
            // 
            this.TBApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBApellido.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBApellido.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.TBApellido.Location = new System.Drawing.Point(10, 321);
            this.TBApellido.Multiline = true;
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.Size = new System.Drawing.Size(348, 29);
            this.TBApellido.TabIndex = 4;
            this.TBApellido.Text = "Apellido";
            this.TBApellido.TextChanged += new System.EventHandler(this.TBApellido_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(10, 445);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(146, 28);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Value = new System.DateTime(2021, 10, 21, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(196, 444);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(160, 29);
            this.comboBoxEstado.TabIndex = 8;
            // 
            // LEstado
            // 
            this.LEstado.AutoSize = true;
            this.LEstado.BackColor = System.Drawing.Color.Transparent;
            this.LEstado.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEstado.Location = new System.Drawing.Point(192, 417);
            this.LEstado.Name = "LEstado";
            this.LEstado.Size = new System.Drawing.Size(69, 24);
            this.LEstado.TabIndex = 0;
            this.LEstado.Text = "Estado";
            // 
            // LPublicacion
            // 
            this.LPublicacion.AutoSize = true;
            this.LPublicacion.BackColor = System.Drawing.Color.Transparent;
            this.LPublicacion.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPublicacion.Location = new System.Drawing.Point(8, 416);
            this.LPublicacion.Name = "LPublicacion";
            this.LPublicacion.Size = new System.Drawing.Size(148, 24);
            this.LPublicacion.TabIndex = 0;
            this.LPublicacion.Text = "Año Publicación";
            // 
            // LNum
            // 
            this.LNum.AutoSize = true;
            this.LNum.BackColor = System.Drawing.Color.Transparent;
            this.LNum.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNum.Location = new System.Drawing.Point(281, 379);
            this.LNum.Name = "LNum";
            this.LNum.Size = new System.Drawing.Size(23, 24);
            this.LNum.TabIndex = 0;
            this.LNum.Text = "#";
            // 
            // LSerie
            // 
            this.LSerie.AutoSize = true;
            this.LSerie.BackColor = System.Drawing.Color.Transparent;
            this.LSerie.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSerie.Location = new System.Drawing.Point(8, 353);
            this.LSerie.Name = "LSerie";
            this.LSerie.Size = new System.Drawing.Size(54, 24);
            this.LSerie.TabIndex = 0;
            this.LSerie.Text = "Serie";
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LTitulo.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.Location = new System.Drawing.Point(11, 187);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(61, 24);
            this.LTitulo.TabIndex = 0;
            this.LTitulo.Text = "Titulo";
            // 
            // LAutor
            // 
            this.LAutor.AutoSize = true;
            this.LAutor.BackColor = System.Drawing.Color.Transparent;
            this.LAutor.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAutor.Location = new System.Drawing.Point(11, 254);
            this.LAutor.Name = "LAutor";
            this.LAutor.Size = new System.Drawing.Size(60, 24);
            this.LAutor.TabIndex = 9;
            this.LAutor.Text = "Autor";
            // 
            // saveBotton
            // 
            this.saveBotton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.saveBotton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBotton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveBotton.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBotton.ForeColor = System.Drawing.Color.Black;
            this.saveBotton.Location = new System.Drawing.Point(130, 530);
            this.saveBotton.Name = "saveBotton";
            this.saveBotton.Size = new System.Drawing.Size(110, 41);
            this.saveBotton.TabIndex = 9;
            this.saveBotton.Text = "GUARDAR";
            this.saveBotton.UseVisualStyleBackColor = false;
            // 
            // TBNum
            // 
            this.TBNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBNum.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNum.Location = new System.Drawing.Point(310, 377);
            this.TBNum.Multiline = true;
            this.TBNum.Name = "TBNum";
            this.TBNum.Size = new System.Drawing.Size(46, 29);
            this.TBNum.TabIndex = 6;
            this.TBNum.TextChanged += new System.EventHandler(this.TBNum_TextChanged);
            this.TBNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBNum_KeyPress);
            // 
            // TBTitulo
            // 
            this.TBTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBTitulo.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBTitulo.Location = new System.Drawing.Point(10, 211);
            this.TBTitulo.Multiline = true;
            this.TBTitulo.Name = "TBTitulo";
            this.TBTitulo.Size = new System.Drawing.Size(348, 29);
            this.TBTitulo.TabIndex = 2;
            this.TBTitulo.TextChanged += new System.EventHandler(this.TBTitulo_TextChanged);
            this.TBTitulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBTitulo_KeyPress);
            // 
            // TBSerie
            // 
            this.TBSerie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBSerie.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBSerie.Location = new System.Drawing.Point(8, 377);
            this.TBSerie.Multiline = true;
            this.TBSerie.Name = "TBSerie";
            this.TBSerie.Size = new System.Drawing.Size(264, 29);
            this.TBSerie.TabIndex = 5;
            this.TBSerie.TextChanged += new System.EventHandler(this.TBSerie_TextChanged);
            this.TBSerie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBSerie_KeyPress);
            // 
            // PBImagen
            // 
            this.PBImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBImagen.Image = global::BibliotecaAppEscritorio.Properties.Resources.libros;
            this.PBImagen.Location = new System.Drawing.Point(134, 34);
            this.PBImagen.Name = "PBImagen";
            this.PBImagen.Size = new System.Drawing.Size(106, 145);
            this.PBImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBImagen.TabIndex = 0;
            this.PBImagen.TabStop = false;
            this.PBImagen.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TBAutor
            // 
            this.TBAutor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBAutor.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBAutor.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.TBAutor.Location = new System.Drawing.Point(10, 278);
            this.TBAutor.Multiline = true;
            this.TBAutor.Name = "TBAutor";
            this.TBAutor.Size = new System.Drawing.Size(346, 29);
            this.TBAutor.TabIndex = 3;
            this.TBAutor.Text = "Nombre";
            this.TBAutor.TextChanged += new System.EventHandler(this.TBAutor_TextChanged);
            this.TBAutor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBAutor_KeyPress);
            this.TBAutor.StyleChanged += new System.EventHandler(this.TBAutor_StyleChanged);
            // 
            // LAñadirL
            // 
            this.LAñadirL.AutoSize = true;
            this.LAñadirL.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAñadirL.ForeColor = System.Drawing.Color.White;
            this.LAñadirL.Location = new System.Drawing.Point(94, 7);
            this.LAñadirL.Name = "LAñadirL";
            this.LAñadirL.Size = new System.Drawing.Size(174, 29);
            this.LAñadirL.TabIndex = 0;
            this.LAñadirL.Text = "AÑADIR LIBRO";
            this.LAñadirL.Click += new System.EventHandler(this.LAñadirL_Click);
            // 
            // TBBuscar
            // 
            this.TBBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBBuscar.Location = new System.Drawing.Point(10, 34);
            this.TBBuscar.Multiline = true;
            this.TBBuscar.Name = "TBBuscar";
            this.TBBuscar.Size = new System.Drawing.Size(366, 29);
            this.TBBuscar.TabIndex = 1;
            this.TBBuscar.TextChanged += new System.EventHandler(this.TBBuscar_TextChanged);
            // 
            // GBAñadirL
            // 
            this.GBAñadirL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.GBAñadirL.Controls.Add(this.LAñadirL);
            this.GBAñadirL.Location = new System.Drawing.Point(13, 90);
            this.GBAñadirL.Name = "GBAñadirL";
            this.GBAñadirL.Size = new System.Drawing.Size(361, 43);
            this.GBAñadirL.TabIndex = 0;
            this.GBAñadirL.TabStop = false;
            this.GBAñadirL.Enter += new System.EventHandler(this.GBAñadirL_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.TBBuscar);
            this.groupBox1.Location = new System.Drawing.Point(953, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 577);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(405, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(527, 577);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 865);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GBAñadirL);
            this.Controls.Add(this.GBInsertar);
            this.Controls.Add(this.GBCabecera);
            this.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GBCabecera.ResumeLayout(false);
            this.GBCabecera.PerformLayout();
            this.GBInsertar.ResumeLayout(false);
            this.GBInsertar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagen)).EndInit();
            this.GBAñadirL.ResumeLayout(false);
            this.GBAñadirL.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBCabecera;
        private System.Windows.Forms.GroupBox GBInsertar;
        private System.Windows.Forms.Label miBiblio;
        private System.Windows.Forms.Label LAñadirL;
        private System.Windows.Forms.TextBox TBBuscar;
        private System.Windows.Forms.GroupBox GBAñadirL;
        private System.Windows.Forms.Label LEstado;
        private System.Windows.Forms.Label LPublicacion;
        private System.Windows.Forms.Label LNum;
        private System.Windows.Forms.Label LSerie;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Label LAutor;
        private System.Windows.Forms.Button saveBotton;
        private System.Windows.Forms.TextBox TBNum;
        private System.Windows.Forms.TextBox TBTitulo;
        private System.Windows.Forms.TextBox TBSerie;
        private System.Windows.Forms.PictureBox PBImagen;
        private System.Windows.Forms.TextBox TBAutor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.TextBox TBApellido;
    }
}

