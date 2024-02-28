namespace FinalProgramacion2023.Windows
{
    partial class frmPrincipal
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
            toolStrip1 = new ToolStrip();
            tsbNuevo = new ToolStripButton();
            tsbBorrar = new ToolStripButton();
            tsbEditar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripSeparator3 = new ToolStripSeparator();
            tsbSalir = new ToolStripButton();
            splitContainer1 = new SplitContainer();
            dgvDatos = new DataGridView();
            ColumnaLadoA = new DataGridViewTextBoxColumn();
            ColumnaLadoB = new DataGridViewTextBoxColumn();
            ColumnaRelleno = new DataGridViewTextBoxColumn();
            ColumnaArea = new DataGridViewTextBoxColumn();
            ColumnaPerimetro = new DataGridViewTextBoxColumn();
            txtCantidad = new TextBox();
            label1 = new Label();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbBorrar, tsbEditar, toolStripSeparator1, toolStripSeparator2, toolStripSeparator3, tsbSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 54);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            tsbNuevo.Image = Properties.Resources.new_copy_32px;
            tsbNuevo.ImageScaling = ToolStripItemImageScaling.None;
            tsbNuevo.ImageTransparentColor = Color.Magenta;
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(46, 51);
            tsbNuevo.Text = "Nuevo";
            tsbNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbNuevo.Click += tsbNuevo_Click;
            // 
            // tsbBorrar
            // 
            tsbBorrar.Image = Properties.Resources.delete_file_32px;
            tsbBorrar.ImageScaling = ToolStripItemImageScaling.None;
            tsbBorrar.ImageTransparentColor = Color.Magenta;
            tsbBorrar.Name = "tsbBorrar";
            tsbBorrar.Size = new Size(43, 51);
            tsbBorrar.Text = "Borrar";
            tsbBorrar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbBorrar.Click += tsbBorrar_Click;
            // 
            // tsbEditar
            // 
            tsbEditar.Image = Properties.Resources.edit_file_32px;
            tsbEditar.ImageScaling = ToolStripItemImageScaling.None;
            tsbEditar.ImageTransparentColor = Color.Magenta;
            tsbEditar.Name = "tsbEditar";
            tsbEditar.Size = new Size(41, 51);
            tsbEditar.Text = "Editar";
            tsbEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbEditar.Click += tsbEditar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 54);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 54);
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 54);
            // 
            // tsbSalir
            // 
            tsbSalir.Image = Properties.Resources.exit_32px;
            tsbSalir.ImageScaling = ToolStripItemImageScaling.None;
            tsbSalir.ImageTransparentColor = Color.Magenta;
            tsbSalir.Name = "tsbSalir";
            tsbSalir.Size = new Size(36, 51);
            tsbSalir.Text = "Salir";
            tsbSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbSalir.Click += tsbSalir_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 54);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvDatos);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(txtCantidad);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Size = new Size(800, 396);
            splitContainer1.SplitterDistance = 330;
            splitContainer1.TabIndex = 1;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { ColumnaLadoA, ColumnaLadoB, ColumnaRelleno, ColumnaArea, ColumnaPerimetro });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowTemplate.Height = 25;
            dgvDatos.Size = new Size(800, 330);
            dgvDatos.TabIndex = 0;
            // 
            // ColumnaLadoA
            // 
            ColumnaLadoA.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnaLadoA.HeaderText = "Lado A:";
            ColumnaLadoA.Name = "ColumnaLadoA";
            ColumnaLadoA.ReadOnly = true;
            // 
            // ColumnaLadoB
            // 
            ColumnaLadoB.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnaLadoB.HeaderText = "Lado B:";
            ColumnaLadoB.Name = "ColumnaLadoB";
            ColumnaLadoB.ReadOnly = true;
            // 
            // ColumnaRelleno
            // 
            ColumnaRelleno.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnaRelleno.HeaderText = "Relleno:";
            ColumnaRelleno.Name = "ColumnaRelleno";
            ColumnaRelleno.ReadOnly = true;
            // 
            // ColumnaArea
            // 
            ColumnaArea.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnaArea.HeaderText = "Area:";
            ColumnaArea.Name = "ColumnaArea";
            ColumnaArea.ReadOnly = true;
            // 
            // ColumnaPerimetro
            // 
            ColumnaPerimetro.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnaPerimetro.HeaderText = "Perimetro";
            ColumnaPerimetro.Name = "ColumnaPerimetro";
            ColumnaPerimetro.ReadOnly = true;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(101, 21);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 24);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Cantidad:";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            Load += frmPrincipal_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsbNuevo;
        private ToolStripButton tsbBorrar;
        private ToolStripButton tsbEditar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton tsbSalir;
        private SplitContainer splitContainer1;
        private DataGridView dgvDatos;
        private TextBox txtCantidad;
        private Label label1;
        private DataGridViewTextBoxColumn ColumnaLadoA;
        private DataGridViewTextBoxColumn ColumnaLadoB;
        private DataGridViewTextBoxColumn ColumnaRelleno;
        private DataGridViewTextBoxColumn ColumnaArea;
        private DataGridViewTextBoxColumn ColumnaPerimetro;
    }
}