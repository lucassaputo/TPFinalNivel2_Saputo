namespace presentacion
{
    partial class frmArticulos
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.dtgArticulos = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.lblFiltroAvanzado = new System.Windows.Forms.Label();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.lblCampo = new System.Windows.Forms.Label();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.btnRecarga = new System.Windows.Forms.Button();
            this.gbFiltroAvanzado = new System.Windows.Forms.GroupBox();
            this.gbAcciones = new System.Windows.Forms.GroupBox();
            this.gbFiltro = new System.Windows.Forms.GroupBox();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.gbFiltroAvanzado.SuspendLayout();
            this.gbAcciones.SuspendLayout();
            this.gbFiltro.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(109, 22);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dtgArticulos
            // 
            this.dtgArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgArticulos.Location = new System.Drawing.Point(21, 29);
            this.dtgArticulos.MultiSelect = false;
            this.dtgArticulos.Name = "dtgArticulos";
            this.dtgArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgArticulos.Size = new System.Drawing.Size(598, 232);
            this.dtgArticulos.TabIndex = 0;
            this.dtgArticulos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgArticulos_CellFormatting);
            this.dtgArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(190, 23);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(104, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(27, 22);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtFiltroAvanzado
            // 
            this.txtFiltroAvanzado.Location = new System.Drawing.Point(466, 23);
            this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            this.txtFiltroAvanzado.Size = new System.Drawing.Size(100, 20);
            this.txtFiltroAvanzado.TabIndex = 2;
            // 
            // lblFiltroAvanzado
            // 
            this.lblFiltroAvanzado.AutoSize = true;
            this.lblFiltroAvanzado.Location = new System.Drawing.Point(410, 26);
            this.lblFiltroAvanzado.Name = "lblFiltroAvanzado";
            this.lblFiltroAvanzado.Size = new System.Drawing.Size(29, 13);
            this.lblFiltroAvanzado.TabIndex = 20;
            this.lblFiltroAvanzado.Text = "Filtro";
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(270, 22);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(121, 21);
            this.cboCriterio.TabIndex = 1;
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(214, 26);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(42, 13);
            this.lblCriterio.TabIndex = 18;
            this.lblCriterio.Text = "Criterio:";
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(74, 22);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(121, 21);
            this.cboCampo.TabIndex = 0;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(18, 26);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(43, 13);
            this.lblCampo.TabIndex = 16;
            this.lblCampo.Text = "Campo:";
            // 
            // btnFiltro
            // 
            this.btnFiltro.Location = new System.Drawing.Point(586, 20);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnFiltro.TabIndex = 3;
            this.btnFiltro.Text = "Buscar";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(648, 29);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(240, 232);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 22;
            this.pbxArticulo.TabStop = false;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(181, 26);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(242, 20);
            this.txtFiltro.TabIndex = 1;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(18, 28);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(157, 13);
            this.lblFiltro.TabIndex = 23;
            this.lblFiltro.Text = "Filtro Rápido (Nombre o Marca):";
            // 
            // btnRecarga
            // 
            this.btnRecarga.Location = new System.Drawing.Point(304, 22);
            this.btnRecarga.Name = "btnRecarga";
            this.btnRecarga.Size = new System.Drawing.Size(138, 23);
            this.btnRecarga.TabIndex = 3;
            this.btnRecarga.Text = "Refrescar listado articulos";
            this.btnRecarga.UseVisualStyleBackColor = true;
            this.btnRecarga.Click += new System.EventHandler(this.btnRecarga_Click);
            // 
            // gbFiltroAvanzado
            // 
            this.gbFiltroAvanzado.Controls.Add(this.lblCampo);
            this.gbFiltroAvanzado.Controls.Add(this.btnFiltro);
            this.gbFiltroAvanzado.Controls.Add(this.cboCampo);
            this.gbFiltroAvanzado.Controls.Add(this.lblCriterio);
            this.gbFiltroAvanzado.Controls.Add(this.cboCriterio);
            this.gbFiltroAvanzado.Controls.Add(this.txtFiltroAvanzado);
            this.gbFiltroAvanzado.Controls.Add(this.lblFiltroAvanzado);
            this.gbFiltroAvanzado.Location = new System.Drawing.Point(12, 362);
            this.gbFiltroAvanzado.Name = "gbFiltroAvanzado";
            this.gbFiltroAvanzado.Size = new System.Drawing.Size(912, 55);
            this.gbFiltroAvanzado.TabIndex = 3;
            this.gbFiltroAvanzado.TabStop = false;
            this.gbFiltroAvanzado.Text = "Filtro avanzado";
            // 
            // gbAcciones
            // 
            this.gbAcciones.Controls.Add(this.btnAgregar);
            this.gbAcciones.Controls.Add(this.btnModificar);
            this.gbAcciones.Controls.Add(this.btnRecarga);
            this.gbAcciones.Controls.Add(this.btnEliminar);
            this.gbAcciones.Location = new System.Drawing.Point(447, 14);
            this.gbAcciones.Name = "gbAcciones";
            this.gbAcciones.Size = new System.Drawing.Size(477, 58);
            this.gbAcciones.TabIndex = 1;
            this.gbAcciones.TabStop = false;
            this.gbAcciones.Text = "Acciones";
            // 
            // gbFiltro
            // 
            this.gbFiltro.Controls.Add(this.lblFiltro);
            this.gbFiltro.Controls.Add(this.txtFiltro);
            this.gbFiltro.Location = new System.Drawing.Point(12, 14);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Size = new System.Drawing.Size(429, 60);
            this.gbFiltro.TabIndex = 0;
            this.gbFiltro.TabStop = false;
            this.gbFiltro.Text = "Filtro rapido";
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.dtgArticulos);
            this.gbDatos.Controls.Add(this.pbxArticulo);
            this.gbDatos.Location = new System.Drawing.Point(12, 78);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(912, 278);
            this.gbDatos.TabIndex = 2;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 430);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.gbFiltro);
            this.Controls.Add(this.gbAcciones);
            this.Controls.Add(this.gbFiltroAvanzado);
            this.Name = "frmArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.frmArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.gbFiltroAvanzado.ResumeLayout(false);
            this.gbFiltroAvanzado.PerformLayout();
            this.gbAcciones.ResumeLayout(false);
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            this.gbDatos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dtgArticulos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtFiltroAvanzado;
        private System.Windows.Forms.Label lblFiltroAvanzado;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Button btnRecarga;
        private System.Windows.Forms.GroupBox gbFiltroAvanzado;
        private System.Windows.Forms.GroupBox gbAcciones;
        private System.Windows.Forms.GroupBox gbFiltro;
        private System.Windows.Forms.GroupBox gbDatos;
    }
}