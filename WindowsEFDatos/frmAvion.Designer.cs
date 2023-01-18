namespace WindowsEFDatos
{
    partial class frmAvion
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
            this.GridAviones = new System.Windows.Forms.DataGridView();
            this.btinsertar = new System.Windows.Forms.Button();
            this.txtcapacidad = new System.Windows.Forms.TextBox();
            this.txtdenominacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bteliminar = new System.Windows.Forms.Button();
            this.bttraer = new System.Windows.Forms.Button();
            this.bteditar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridAviones)).BeginInit();
            this.SuspendLayout();
            // 
            // GridAviones
            // 
            this.GridAviones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAviones.Location = new System.Drawing.Point(35, 87);
            this.GridAviones.Name = "GridAviones";
            this.GridAviones.Size = new System.Drawing.Size(423, 238);
            this.GridAviones.TabIndex = 0;
            // 
            // btinsertar
            // 
            this.btinsertar.Location = new System.Drawing.Point(509, 259);
            this.btinsertar.Name = "btinsertar";
            this.btinsertar.Size = new System.Drawing.Size(124, 23);
            this.btinsertar.TabIndex = 1;
            this.btinsertar.Text = "Insertar Avion";
            this.btinsertar.UseVisualStyleBackColor = true;
            this.btinsertar.Click += new System.EventHandler(this.btinsertar_Click);
            // 
            // txtcapacidad
            // 
            this.txtcapacidad.Location = new System.Drawing.Point(586, 119);
            this.txtcapacidad.Name = "txtcapacidad";
            this.txtcapacidad.Size = new System.Drawing.Size(100, 20);
            this.txtcapacidad.TabIndex = 2;
            // 
            // txtdenominacion
            // 
            this.txtdenominacion.Location = new System.Drawing.Point(586, 153);
            this.txtdenominacion.Name = "txtdenominacion";
            this.txtdenominacion.Size = new System.Drawing.Size(100, 20);
            this.txtdenominacion.TabIndex = 3;
            this.txtdenominacion.TextChanged += new System.EventHandler(this.txtdenominacion_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(491, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Capacidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(491, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Denominación";
            // 
            // bteliminar
            // 
            this.bteliminar.Location = new System.Drawing.Point(664, 318);
            this.bteliminar.Name = "bteliminar";
            this.bteliminar.Size = new System.Drawing.Size(124, 23);
            this.bteliminar.TabIndex = 6;
            this.bteliminar.Text = "Eliminar por ID";
            this.bteliminar.UseVisualStyleBackColor = true;
            this.bteliminar.Click += new System.EventHandler(this.bteliminar_Click);
            // 
            // bttraer
            // 
            this.bttraer.Location = new System.Drawing.Point(509, 318);
            this.bttraer.Name = "bttraer";
            this.bttraer.Size = new System.Drawing.Size(124, 23);
            this.bttraer.TabIndex = 7;
            this.bttraer.Text = "Traer por ID";
            this.bttraer.UseVisualStyleBackColor = true;
            this.bttraer.Click += new System.EventHandler(this.bttraer_Click);
            // 
            // bteditar
            // 
            this.bteditar.Location = new System.Drawing.Point(664, 259);
            this.bteditar.Name = "bteditar";
            this.bteditar.Size = new System.Drawing.Size(124, 23);
            this.bteditar.TabIndex = 8;
            this.bteditar.Text = "Editar";
            this.bteditar.UseVisualStyleBackColor = true;
            this.bteditar.Click += new System.EventHandler(this.bteditar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(494, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(586, 84);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 10;
            // 
            // frmAvion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bteditar);
            this.Controls.Add(this.bttraer);
            this.Controls.Add(this.bteliminar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdenominacion);
            this.Controls.Add(this.txtcapacidad);
            this.Controls.Add(this.btinsertar);
            this.Controls.Add(this.GridAviones);
            this.Name = "frmAvion";
            this.Text = "frmAvion";
            this.Load += new System.EventHandler(this.frmAvion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridAviones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridAviones;
        private System.Windows.Forms.Button btinsertar;
        private System.Windows.Forms.TextBox txtcapacidad;
        private System.Windows.Forms.TextBox txtdenominacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bteliminar;
        private System.Windows.Forms.Button bttraer;
        private System.Windows.Forms.Button bteditar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
    }
}