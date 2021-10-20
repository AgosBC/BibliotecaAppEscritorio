
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
            this.GBInsertar = new System.Windows.Forms.GroupBox();
            this.GBIzq = new System.Windows.Forms.GroupBox();
            this.miBiblio = new System.Windows.Forms.Label();
            this.GBBuscar = new System.Windows.Forms.GroupBox();
            this.LBuscar = new System.Windows.Forms.Label();
            this.TBBuscar = new System.Windows.Forms.TextBox();
            this.LAñadirL = new System.Windows.Forms.Label();
            this.GBCabecera.SuspendLayout();
            this.GBInsertar.SuspendLayout();
            this.GBBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBCabecera
            // 
            this.GBCabecera.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBCabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GBCabecera.Controls.Add(this.miBiblio);
            this.GBCabecera.Location = new System.Drawing.Point(1, 12);
            this.GBCabecera.Name = "GBCabecera";
            this.GBCabecera.Size = new System.Drawing.Size(1317, 87);
            this.GBCabecera.TabIndex = 0;
            this.GBCabecera.TabStop = false;
            // 
            // GBInsertar
            // 
            this.GBInsertar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GBInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GBInsertar.Controls.Add(this.LAñadirL);
            this.GBInsertar.Location = new System.Drawing.Point(1, 153);
            this.GBInsertar.Name = "GBInsertar";
            this.GBInsertar.Size = new System.Drawing.Size(413, 587);
            this.GBInsertar.TabIndex = 1;
            this.GBInsertar.TabStop = false;
            // 
            // GBIzq
            // 
            this.GBIzq.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBIzq.AutoSize = true;
            this.GBIzq.Location = new System.Drawing.Point(423, 139);
            this.GBIzq.Name = "GBIzq";
            this.GBIzq.Size = new System.Drawing.Size(894, 600);
            this.GBIzq.TabIndex = 2;
            this.GBIzq.TabStop = false;
            // 
            // miBiblio
            // 
            this.miBiblio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.miBiblio.AutoSize = true;
            this.miBiblio.Font = new System.Drawing.Font("Bookman Old Style", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miBiblio.Location = new System.Drawing.Point(469, 19);
            this.miBiblio.Name = "miBiblio";
            this.miBiblio.Size = new System.Drawing.Size(403, 58);
            this.miBiblio.TabIndex = 3;
            this.miBiblio.Text = "MI BIBLIOTECA";
            this.miBiblio.Click += new System.EventHandler(this.label1_Click);
            // 
            // GBBuscar
            // 
            this.GBBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBBuscar.Controls.Add(this.TBBuscar);
            this.GBBuscar.Controls.Add(this.LBuscar);
            this.GBBuscar.Location = new System.Drawing.Point(1, 92);
            this.GBBuscar.Name = "GBBuscar";
            this.GBBuscar.Size = new System.Drawing.Size(1316, 55);
            this.GBBuscar.TabIndex = 3;
            this.GBBuscar.TabStop = false;
            // 
            // LBuscar
            // 
            this.LBuscar.AutoSize = true;
            this.LBuscar.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBuscar.Location = new System.Drawing.Point(11, 19);
            this.LBuscar.Name = "LBuscar";
            this.LBuscar.Size = new System.Drawing.Size(80, 23);
            this.LBuscar.TabIndex = 0;
            this.LBuscar.Text = "Buscar";
            // 
            // TBBuscar
            // 
            this.TBBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBBuscar.Location = new System.Drawing.Point(97, 18);
            this.TBBuscar.Multiline = true;
            this.TBBuscar.Name = "TBBuscar";
            this.TBBuscar.Size = new System.Drawing.Size(305, 29);
            this.TBBuscar.TabIndex = 1;
            this.TBBuscar.TextChanged += new System.EventHandler(this.TBBuscar_TextChanged);
            // 
            // LAñadirL
            // 
            this.LAñadirL.AutoSize = true;
            this.LAñadirL.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAñadirL.ForeColor = System.Drawing.Color.Teal;
            this.LAñadirL.Location = new System.Drawing.Point(115, 19);
            this.LAñadirL.Name = "LAñadirL";
            this.LAñadirL.Size = new System.Drawing.Size(159, 28);
            this.LAñadirL.TabIndex = 0;
            this.LAñadirL.Text = "Añadir libro";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 865);
            this.Controls.Add(this.GBBuscar);
            this.Controls.Add(this.GBIzq);
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
            this.GBBuscar.ResumeLayout(false);
            this.GBBuscar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GBCabecera;
        private System.Windows.Forms.GroupBox GBInsertar;
        private System.Windows.Forms.GroupBox GBIzq;
        private System.Windows.Forms.Label miBiblio;
        private System.Windows.Forms.GroupBox GBBuscar;
        private System.Windows.Forms.TextBox TBBuscar;
        private System.Windows.Forms.Label LBuscar;
        private System.Windows.Forms.Label LAñadirL;
    }
}

