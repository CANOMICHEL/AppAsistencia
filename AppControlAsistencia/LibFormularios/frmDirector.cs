using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LibClases;
using LibFormularios;

namespace LibFormularios
{
    public partial class frmDirector : Form
    {
        private string aCodDirector = "";
        cDocente aDocente = new cDocente();
        cAlumno aAlumno = new cAlumno();

        public string CodDirector
        {
            get { return aCodDirector; }
            set { aCodDirector = value; }
        }
        public frmDirector()
        {
            InitializeComponent();
            tabControl1.SelectedTab = tabControl1.TabPages["Bienvenida"];
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            frmIngresoDatos L = new frmIngresoDatos();
        }

        private void btnDocentes_Click(object sender, EventArgs e)
        {

        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void CargarListaDocentes()
        {
            dgvDocentes.Rows.Clear();
            DataTable tabla = ListaDocentes();

            int n = 0;
            foreach (DataRow linea in tabla.Rows)
            {
                n++;
                dgvDocentes.Rows.Add(linea[0].ToString(), linea[1].ToString(), linea[2].ToString(), linea[3].ToString(), linea[4].ToString());
            }
        }

        private DataTable ListaDocentes()
        {
            //String Cod = cboGrado.SelectedValue.ToString();
            return aDocente.ListarDocentes();
        }


        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["Docentes"];
            CargarListaDocentes();

            //tabControl1.SelectedIndex = 0;
        }

        private void registrarAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["AlumnosAsistencia"];
            /*frmAsistencia L = new frmAsistencia();
            L.CodDocente = this.CodDirector;
            L.TopLevel = false;
            L.AutoScroll = true;
            this.displayAsistencia.Controls.Add(L);
            L.Show();*/
            //tabControl1.SelectedIndex = 1;
        }


        /*******  Asistencia *********/
        public void CargarListaAlumnosD()
        {
            dgvDocentes.Rows.Clear();
            DataTable tabla = ListaAlumnosD();

            bool check = false;
            int n = 0;
            foreach (DataRow linea in tabla.Rows)
            {
                n++;
                dgvListadoAlumnos.Rows.Add(n.ToString(), linea[0].ToString(), linea[1], check, check, check, "");
            }
        }

        private DataTable ListaAlumnosD()
        {
            //String Cod = cboGrado.SelectedValue.ToString();
            return aAlumno.ListarAlumnosGrado(cboGrado.Text, cboSeccion.Text, cboNivel.Text);
        }

        private void registrarIncidenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["AlumnosIncidencia"];
            //tabControl1.SelectedIndex = 2;
        }

        private void reportesDeAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["Reportes"];
            //tabControl1.SelectedIndex = 3;
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            /*dgvReporte.Rows.Clear();
            string Nivel = aDocente.Nivel(Int32.Parse(aCodDocente));
            DataTable tabla = aDocente.ReporteAlumnos(cboGradoR.SelectedValue.ToString(), cboSeccionR.SelectedValue.ToString(), Nivel, cboMes.Text);
            int n = 0;
            foreach (DataRow linea in tabla.Rows)
            {
                n++;
                dgvReporte.Rows.Add(n.ToString(), linea[0], linea[1], linea[2], linea[3], linea[4], linea[5]
                    , linea[6], linea[7], linea[8], linea[9], linea[10], linea[11], linea[12], linea[13], linea[14]
                    , linea[15], linea[16], linea[17], linea[18], linea[19], linea[20], linea[21], linea[22]
                    , linea[23], linea[24], linea[25], linea[26], linea[27], linea[28], linea[29], linea[30], linea[31]);
            }*/
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            CargarListaAlumnosD();
        }
    }
}
