﻿namespace LibFormularios
{
    partial class frmAsistencia
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsistencia));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl_Docente = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvListadoAlumnos = new System.Windows.Forms.DataGridView();
            this.colunmNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnpresente = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnTarde = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnFalta = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnOBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboGrado = new System.Windows.Forms.ComboBox();
            this.tbDocente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.tabControl_Docente.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoAlumnos)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl_Docente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1326, 729);
            this.panel1.TabIndex = 0;
            // 
            // tabControl_Docente
            // 
            this.tabControl_Docente.Controls.Add(this.tabPage1);
            this.tabControl_Docente.Controls.Add(this.tabPage2);
            this.tabControl_Docente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Docente.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Docente.Name = "tabControl_Docente";
            this.tabControl_Docente.SelectedIndex = 0;
            this.tabControl_Docente.Size = new System.Drawing.Size(1326, 729);
            this.tabControl_Docente.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1318, 696);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Asistencia";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvListadoAlumnos);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 174);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1312, 454);
            this.panel4.TabIndex = 6;
            // 
            // dgvListadoAlumnos
            // 
            this.dgvListadoAlumnos.AllowUserToAddRows = false;
            this.dgvListadoAlumnos.AllowUserToDeleteRows = false;
            this.dgvListadoAlumnos.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgvListadoAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunmNro,
            this.ColumnCod,
            this.ColumnNombres,
            this.Columnpresente,
            this.ColumnTarde,
            this.ColumnFalta,
            this.ColumnOBS});
            this.dgvListadoAlumnos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListadoAlumnos.GridColor = System.Drawing.SystemColors.GrayText;
            this.dgvListadoAlumnos.Location = new System.Drawing.Point(0, 0);
            this.dgvListadoAlumnos.Name = "dgvListadoAlumnos";
            this.dgvListadoAlumnos.Size = new System.Drawing.Size(1312, 454);
            this.dgvListadoAlumnos.TabIndex = 3;
            this.dgvListadoAlumnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoAlumnos_CellClick);
            // 
            // colunmNro
            // 
            this.colunmNro.HeaderText = "Nro";
            this.colunmNro.Name = "colunmNro";
            this.colunmNro.Width = 70;
            // 
            // ColumnCod
            // 
            this.ColumnCod.HeaderText = "Cod";
            this.ColumnCod.Name = "ColumnCod";
            // 
            // ColumnNombres
            // 
            this.ColumnNombres.HeaderText = "Apellidos y nombres";
            this.ColumnNombres.Name = "ColumnNombres";
            this.ColumnNombres.Width = 500;
            // 
            // Columnpresente
            // 
            this.Columnpresente.HeaderText = "Presente";
            this.Columnpresente.Name = "Columnpresente";
            // 
            // ColumnTarde
            // 
            this.ColumnTarde.HeaderText = "Tarde";
            this.ColumnTarde.Name = "ColumnTarde";
            // 
            // ColumnFalta
            // 
            this.ColumnFalta.HeaderText = "Falta";
            this.ColumnFalta.Name = "ColumnFalta";
            // 
            // ColumnOBS
            // 
            this.ColumnOBS.HeaderText = "Observaciones";
            this.ColumnOBS.Name = "ColumnOBS";
            this.ColumnOBS.Width = 250;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(3, 628);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1312, 65);
            this.panel2.TabIndex = 4;
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Firebrick;
            this.btnSalir.Location = new System.Drawing.Point(1197, 11);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(95, 34);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuardar.Location = new System.Drawing.Point(20, 11);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(95, 34);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel3.Controls.Add(this.lblTiempo);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cboGrado);
            this.panel3.Controls.Add(this.tbDocente);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblTitulo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1312, 171);
            this.panel3.TabIndex = 5;
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.Location = new System.Drawing.Point(890, 50);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(284, 73);
            this.lblTiempo.TabIndex = 63;
            this.lblTiempo.Text = "00:00:00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(20, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 111);
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(371, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 24);
            this.label3.TabIndex = 61;
            this.label3.Text = "LISTADO DE ALUMNOS";
            // 
            // cboGrado
            // 
            this.cboGrado.CausesValidation = false;
            this.cboGrado.FormattingEnabled = true;
            this.cboGrado.Location = new System.Drawing.Point(248, 90);
            this.cboGrado.Name = "cboGrado";
            this.cboGrado.Size = new System.Drawing.Size(538, 28);
            this.cboGrado.Sorted = true;
            this.cboGrado.TabIndex = 59;
            this.cboGrado.Text = "Seleccione";
            this.cboGrado.SelectedIndexChanged += new System.EventHandler(this.cboGrado_SelectedIndexChanged);
            // 
            // tbDocente
            // 
            this.tbDocente.Enabled = false;
            this.tbDocente.Location = new System.Drawing.Point(248, 47);
            this.tbDocente.Name = "tbDocente";
            this.tbDocente.Size = new System.Drawing.Size(538, 26);
            this.tbDocente.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(178, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 57;
            this.label2.Text = "Grado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 56;
            this.label1.Text = "Docente:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(345, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(318, 24);
            this.lblTitulo.TabIndex = 55;
            this.lblTitulo.Text = "REGISTRAR ASISTENCIA ALUMNO";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1318, 696);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reportes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 729);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmAsistencia";
            this.RightToLeftLayout = true;
            this.Text = "frmAsistencia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAsistencia_FormClosing);
            this.Load += new System.EventHandler(this.frmAsistencia_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl_Docente.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoAlumnos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl_Docente;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvListadoAlumnos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboGrado;
        private System.Windows.Forms.TextBox tbDocente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunmNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombres;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Columnpresente;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnTarde;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnFalta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOBS;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTiempo;

    }
}