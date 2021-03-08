namespace LibFormularios
{
    partial class frmDirector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDirector));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDocentes = new System.Windows.Forms.Button();
            this.btnRegistrarAsistencia = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarAsistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarIncidenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesDeAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesDeDocentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Docentes = new System.Windows.Forms.TabPage();
            this.AlumnosAsistencia = new System.Windows.Forms.TabPage();
            this.AlumnosIncidencia = new System.Windows.Forms.TabPage();
            this.Reportes = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDocentes = new System.Windows.Forms.DataGridView();
            this.Bienvenida = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAlumnos = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.displayAsistencia = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Docentes.SuspendLayout();
            this.AlumnosAsistencia.SuspendLayout();
            this.AlumnosIncidencia.SuspendLayout();
            this.Reportes.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).BeginInit();
            this.Bienvenida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1137, 631);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(391, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(90, 77);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(22, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 71);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnDocentes
            // 
            this.btnDocentes.AutoSize = true;
            this.btnDocentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocentes.Location = new System.Drawing.Point(506, 72);
            this.btnDocentes.Name = "btnDocentes";
            this.btnDocentes.Size = new System.Drawing.Size(149, 32);
            this.btnDocentes.TabIndex = 3;
            this.btnDocentes.Text = "Docentes";
            this.btnDocentes.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarAsistencia
            // 
            this.btnRegistrarAsistencia.AutoSize = true;
            this.btnRegistrarAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarAsistencia.Location = new System.Drawing.Point(487, 65);
            this.btnRegistrarAsistencia.Name = "btnRegistrarAsistencia";
            this.btnRegistrarAsistencia.Size = new System.Drawing.Size(183, 32);
            this.btnRegistrarAsistencia.TabIndex = 5;
            this.btnRegistrarAsistencia.Text = "Registrar Asistencia";
            this.btnRegistrarAsistencia.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.alumnosToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1137, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.inicioToolStripMenuItem.Text = "Docentes";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarAsistenciaToolStripMenuItem,
            this.registrarIncidenteToolStripMenuItem});
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            // 
            // registrarAsistenciaToolStripMenuItem
            // 
            this.registrarAsistenciaToolStripMenuItem.Name = "registrarAsistenciaToolStripMenuItem";
            this.registrarAsistenciaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarAsistenciaToolStripMenuItem.Text = "Registrar asistencia";
            this.registrarAsistenciaToolStripMenuItem.Click += new System.EventHandler(this.registrarAsistenciaToolStripMenuItem_Click);
            // 
            // registrarIncidenteToolStripMenuItem
            // 
            this.registrarIncidenteToolStripMenuItem.Name = "registrarIncidenteToolStripMenuItem";
            this.registrarIncidenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarIncidenteToolStripMenuItem.Text = "Registrar incidente";
            this.registrarIncidenteToolStripMenuItem.Click += new System.EventHandler(this.registrarIncidenteToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesDeAlumnosToolStripMenuItem,
            this.reportesDeDocentesToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reportesDeAlumnosToolStripMenuItem
            // 
            this.reportesDeAlumnosToolStripMenuItem.Name = "reportesDeAlumnosToolStripMenuItem";
            this.reportesDeAlumnosToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.reportesDeAlumnosToolStripMenuItem.Text = "Reportes de alumnos";
            this.reportesDeAlumnosToolStripMenuItem.Click += new System.EventHandler(this.reportesDeAlumnosToolStripMenuItem_Click);
            // 
            // reportesDeDocentesToolStripMenuItem
            // 
            this.reportesDeDocentesToolStripMenuItem.Name = "reportesDeDocentesToolStripMenuItem";
            this.reportesDeDocentesToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.reportesDeDocentesToolStripMenuItem.Text = "Reportes de docentes";
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listarToolStripMenuItem.Text = "Listar";
            this.listarToolStripMenuItem.Click += new System.EventHandler(this.listarToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Docentes);
            this.tabControl1.Controls.Add(this.AlumnosAsistencia);
            this.tabControl1.Controls.Add(this.AlumnosIncidencia);
            this.tabControl1.Controls.Add(this.Reportes);
            this.tabControl1.Controls.Add(this.Bienvenida);
            this.tabControl1.Location = new System.Drawing.Point(3, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1197, 631);
            this.tabControl1.TabIndex = 11;
            // 
            // Docentes
            // 
            this.Docentes.Controls.Add(this.dgvDocentes);
            this.Docentes.Controls.Add(this.pictureBox1);
            this.Docentes.Controls.Add(this.btnDocentes);
            this.Docentes.Location = new System.Drawing.Point(4, 22);
            this.Docentes.Name = "Docentes";
            this.Docentes.Padding = new System.Windows.Forms.Padding(3);
            this.Docentes.Size = new System.Drawing.Size(1189, 605);
            this.Docentes.TabIndex = 0;
            this.Docentes.Text = "Docentes";
            this.Docentes.UseVisualStyleBackColor = true;
            // 
            // AlumnosAsistencia
            // 
            this.AlumnosAsistencia.Controls.Add(this.displayAsistencia);
            this.AlumnosAsistencia.Controls.Add(this.btnRegistrarAsistencia);
            this.AlumnosAsistencia.Controls.Add(this.pictureBox3);
            this.AlumnosAsistencia.Location = new System.Drawing.Point(4, 22);
            this.AlumnosAsistencia.Name = "AlumnosAsistencia";
            this.AlumnosAsistencia.Padding = new System.Windows.Forms.Padding(3);
            this.AlumnosAsistencia.Size = new System.Drawing.Size(1189, 605);
            this.AlumnosAsistencia.TabIndex = 1;
            this.AlumnosAsistencia.Text = "AlumnosAsistencia";
            this.AlumnosAsistencia.UseVisualStyleBackColor = true;
            // 
            // AlumnosIncidencia
            // 
            this.AlumnosIncidencia.Controls.Add(this.btnAlumnos);
            this.AlumnosIncidencia.Controls.Add(this.pictureBox2);
            this.AlumnosIncidencia.Controls.Add(this.label1);
            this.AlumnosIncidencia.Location = new System.Drawing.Point(4, 22);
            this.AlumnosIncidencia.Name = "AlumnosIncidencia";
            this.AlumnosIncidencia.Size = new System.Drawing.Size(1189, 605);
            this.AlumnosIncidencia.TabIndex = 2;
            this.AlumnosIncidencia.Text = "AlumnosIncidencia";
            this.AlumnosIncidencia.UseVisualStyleBackColor = true;
            // 
            // Reportes
            // 
            this.Reportes.Controls.Add(this.label2);
            this.Reportes.Location = new System.Drawing.Point(4, 22);
            this.Reportes.Name = "Reportes";
            this.Reportes.Size = new System.Drawing.Size(1189, 605);
            this.Reportes.TabIndex = 3;
            this.Reportes.Text = "Reportes";
            this.Reportes.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1137, 35);
            this.panel2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Incidencias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Reportes";
            // 
            // dgvDocentes
            // 
            this.dgvDocentes.AllowUserToAddRows = false;
            this.dgvDocentes.AllowUserToDeleteRows = false;
            this.dgvDocentes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDocentes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDocentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NombreApellidos,
            this.DNI,
            this.Direccion,
            this.Telefono});
            this.dgvDocentes.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dgvDocentes.Location = new System.Drawing.Point(22, 128);
            this.dgvDocentes.Name = "dgvDocentes";
            this.dgvDocentes.RowHeadersVisible = false;
            this.dgvDocentes.Size = new System.Drawing.Size(1064, 412);
            this.dgvDocentes.TabIndex = 7;
            // 
            // Bienvenida
            // 
            this.Bienvenida.Controls.Add(this.chart1);
            this.Bienvenida.Controls.Add(this.label3);
            this.Bienvenida.Location = new System.Drawing.Point(4, 22);
            this.Bienvenida.Name = "Bienvenida";
            this.Bienvenida.Size = new System.Drawing.Size(1189, 605);
            this.Bienvenida.TabIndex = 4;
            this.Bienvenida.Text = "tabPage1";
            this.Bienvenida.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bienvenido, ";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(97, 177);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(364, 276);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // ID
            // 
            this.ID.HeaderText = "Id";
            this.ID.Name = "ID";
            this.ID.Width = 60;
            // 
            // NombreApellidos
            // 
            this.NombreApellidos.HeaderText = "Nombre y Apellidos";
            this.NombreApellidos.Name = "NombreApellidos";
            this.NombreApellidos.Width = 300;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.Width = 200;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.Width = 300;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.Width = 200;
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.AutoSize = true;
            this.btnAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlumnos.Location = new System.Drawing.Point(342, 85);
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.Size = new System.Drawing.Size(159, 32);
            this.btnAlumnos.TabIndex = 8;
            this.btnAlumnos.Text = "Alumnos";
            this.btnAlumnos.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(342, 85);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(319, 162);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // displayAsistencia
            // 
            this.displayAsistencia.Location = new System.Drawing.Point(0, 101);
            this.displayAsistencia.Name = "displayAsistencia";
            this.displayAsistencia.Size = new System.Drawing.Size(1130, 498);
            this.displayAsistencia.TabIndex = 9;
            // 
            // frmDirector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 631);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDirector";
            this.Opacity = 0.9D;
            this.Text = "frmDirector";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Docentes.ResumeLayout(false);
            this.Docentes.PerformLayout();
            this.AlumnosAsistencia.ResumeLayout(false);
            this.AlumnosAsistencia.PerformLayout();
            this.AlumnosIncidencia.ResumeLayout(false);
            this.AlumnosIncidencia.PerformLayout();
            this.Reportes.ResumeLayout(false);
            this.Reportes.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).EndInit();
            this.Bienvenida.ResumeLayout(false);
            this.Bienvenida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDocentes;
        private System.Windows.Forms.Button btnRegistrarAsistencia;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarAsistenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarIncidenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesDeAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesDeDocentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Docentes;
        private System.Windows.Forms.TabPage AlumnosAsistencia;
        private System.Windows.Forms.TabPage AlumnosIncidencia;
        private System.Windows.Forms.TabPage Reportes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDocentes;
        private System.Windows.Forms.TabPage Bienvenida;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.Button btnAlumnos;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel displayAsistencia;
    }
}