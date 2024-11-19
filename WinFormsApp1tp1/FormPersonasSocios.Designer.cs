namespace WinFormsApp1tp1
{
    partial class FormPersonasSocios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersonasSocios));
            toolStrip1 = new ToolStrip();
            tsbNuevo = new ToolStripButton();
            tsbBorrar = new ToolStripButton();
            tsbEditar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbFiltrar = new ToolStripButton();
            tsbActualizar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tsbSalir = new ToolStripButton();
            PanelInformacion = new Panel();
            txtCantidad = new TextBox();
            label1 = new Label();
            panelGrilla = new Panel();
            dgcDatos = new DataGridView();
            ColSocios = new DataGridViewTextBoxColumn();
            colEdad = new DataGridViewTextBoxColumn();
            ColCategoria = new DataGridViewTextBoxColumn();
            colGenero = new DataGridViewTextBoxColumn();
            colDNI = new DataGridViewTextBoxColumn();
            tsbDetales = new ToolStripButton();
            toolStrip1.SuspendLayout();
            PanelInformacion.SuspendLayout();
            panelGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgcDatos).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbBorrar, tsbEditar, tsbDetales, toolStripSeparator1, tsbFiltrar, tsbActualizar, toolStripSeparator2, tsbSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(709, 38);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            tsbNuevo.Image = (Image)resources.GetObject("tsbNuevo.Image");
            tsbNuevo.ImageScaling = ToolStripItemImageScaling.None;
            tsbNuevo.ImageTransparentColor = Color.Magenta;
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(46, 35);
            tsbNuevo.Text = "Nuevo";
            tsbNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbNuevo.Click += tbsNuevo_Click;
            // 
            // tsbBorrar
            // 
            tsbBorrar.Image = (Image)resources.GetObject("tsbBorrar.Image");
            tsbBorrar.ImageScaling = ToolStripItemImageScaling.None;
            tsbBorrar.ImageTransparentColor = Color.Magenta;
            tsbBorrar.Name = "tsbBorrar";
            tsbBorrar.Size = new Size(43, 35);
            tsbBorrar.Text = "Borrar";
            tsbBorrar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbBorrar.Click += toolStripButton2_Click;
            // 
            // tsbEditar
            // 
            tsbEditar.Image = (Image)resources.GetObject("tsbEditar.Image");
            tsbEditar.ImageScaling = ToolStripItemImageScaling.None;
            tsbEditar.ImageTransparentColor = Color.Magenta;
            tsbEditar.Name = "tsbEditar";
            tsbEditar.Size = new Size(41, 35);
            tsbEditar.Text = "Editar";
            tsbEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 38);
            // 
            // tsbFiltrar
            // 
            tsbFiltrar.Image = (Image)resources.GetObject("tsbFiltrar.Image");
            tsbFiltrar.ImageScaling = ToolStripItemImageScaling.None;
            tsbFiltrar.ImageTransparentColor = Color.Magenta;
            tsbFiltrar.Name = "tsbFiltrar";
            tsbFiltrar.Size = new Size(41, 35);
            tsbFiltrar.Text = "Filtrar";
            tsbFiltrar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // tsbActualizar
            // 
            tsbActualizar.Image = (Image)resources.GetObject("tsbActualizar.Image");
            tsbActualizar.ImageScaling = ToolStripItemImageScaling.None;
            tsbActualizar.ImageTransparentColor = Color.Magenta;
            tsbActualizar.Name = "tsbActualizar";
            tsbActualizar.Size = new Size(63, 35);
            tsbActualizar.Text = "Actualizar";
            tsbActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 38);
            // 
            // tsbSalir
            // 
            tsbSalir.Image = (Image)resources.GetObject("tsbSalir.Image");
            tsbSalir.ImageScaling = ToolStripItemImageScaling.None;
            tsbSalir.ImageTransparentColor = Color.Magenta;
            tsbSalir.Name = "tsbSalir";
            tsbSalir.Size = new Size(33, 35);
            tsbSalir.Text = "Salir";
            tsbSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbSalir.Click += tsbSalir_Click;
            // 
            // PanelInformacion
            // 
            PanelInformacion.Controls.Add(txtCantidad);
            PanelInformacion.Controls.Add(label1);
            PanelInformacion.Dock = DockStyle.Bottom;
            PanelInformacion.Location = new Point(0, 280);
            PanelInformacion.Name = "PanelInformacion";
            PanelInformacion.Size = new Size(709, 94);
            PanelInformacion.TabIndex = 1;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(135, 13);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.ReadOnly = true;
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 16);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 0;
            label1.Text = "Cantidad De Socios:";
            // 
            // panelGrilla
            // 
            panelGrilla.Controls.Add(dgcDatos);
            panelGrilla.Dock = DockStyle.Fill;
            panelGrilla.Location = new Point(0, 38);
            panelGrilla.Name = "panelGrilla";
            panelGrilla.Size = new Size(709, 242);
            panelGrilla.TabIndex = 2;
            // 
            // dgcDatos
            // 
            dgcDatos.AllowUserToAddRows = false;
            dgcDatos.AllowUserToDeleteRows = false;
            dgcDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgcDatos.Columns.AddRange(new DataGridViewColumn[] { ColSocios, colEdad, ColCategoria, colGenero, colDNI });
            dgcDatos.Dock = DockStyle.Fill;
            dgcDatos.Location = new Point(0, 0);
            dgcDatos.Name = "dgcDatos";
            dgcDatos.ReadOnly = true;
            dgcDatos.Size = new Size(709, 242);
            dgcDatos.TabIndex = 0;
            // 
            // ColSocios
            // 
            ColSocios.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColSocios.HeaderText = "Socios";
            ColSocios.Name = "ColSocios";
            ColSocios.ReadOnly = true;
            // 
            // colEdad
            // 
            colEdad.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colEdad.HeaderText = "Edad";
            colEdad.Name = "colEdad";
            colEdad.ReadOnly = true;
            colEdad.Width = 58;
            // 
            // ColCategoria
            // 
            ColCategoria.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColCategoria.HeaderText = "Categoría";
            ColCategoria.Name = "ColCategoria";
            ColCategoria.ReadOnly = true;
            // 
            // colGenero
            // 
            colGenero.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colGenero.HeaderText = "Género";
            colGenero.Name = "colGenero";
            colGenero.ReadOnly = true;
            // 
            // colDNI
            // 
            colDNI.HeaderText = "DNI";
            colDNI.Name = "colDNI";
            colDNI.ReadOnly = true;
            // 
            // tsbDetales
            // 
            tsbDetales.Image = (Image)resources.GetObject("tsbDetales.Image");
            tsbDetales.ImageTransparentColor = Color.Magenta;
            tsbDetales.Name = "tsbDetales";
            tsbDetales.Size = new Size(52, 35);
            tsbDetales.Text = "Detalles";
            tsbDetales.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // FormPersonasSocios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 374);
            Controls.Add(panelGrilla);
            Controls.Add(PanelInformacion);
            Controls.Add(toolStrip1);
            Name = "FormPersonasSocios";
            Text = "FormPersonasSocios";
            Load += FormPersonasSocios_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            PanelInformacion.ResumeLayout(false);
            PanelInformacion.PerformLayout();
            panelGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgcDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsbNuevo;
        private ToolStripButton tsbBorrar;
        private ToolStripButton tsbEditar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbFiltrar;
        private ToolStripButton tsbActualizar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tsbSalir;
        private Panel PanelInformacion;
        private Label label1;
        private TextBox txtCantidad;
        private Panel panelGrilla;
        private DataGridView dgcDatos;
        private DataGridViewTextBoxColumn ColSocios;
        private DataGridViewTextBoxColumn colEdad;
        private DataGridViewTextBoxColumn ColCategoria;
        private DataGridViewTextBoxColumn colGenero;
        private DataGridViewTextBoxColumn colDNI;
        private ToolStripButton tsbDetales;
    }
}