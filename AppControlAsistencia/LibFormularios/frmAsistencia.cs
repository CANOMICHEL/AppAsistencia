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
namespace LibFormularios
{
    public partial class frmAsistencia : Form
    {
        cDocente aDocente = new cDocente();
        cAlumno aAlumno = new cAlumno();
        private string aCodDocente = "";
        //Este atributo tiene la funcion de verificar que el docente haya guardado la lista de asistencia
        private bool aGuardado = false;
        private string aEstado;

        public frmAsistencia()
        {
            InitializeComponent();
        }

        #region eventos

        private void frmAsistencia_Load(object sender, EventArgs e)
        {

            tbDocente.Text = aDocente.NombreDocente(Int32.Parse(aCodDocente));
            tbNombreDocente.Text = aDocente.NombreDocente(Int32.Parse(aCodDocente));
            ListarSalonesDeDocente();
        }

       
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Guardar()
        {
            cAsistenciaAlumno a = new cAsistenciaAlumno();
            string[] datos = new string[5];
            string auxiliar = "";
            for (int i = 0; i < dgvListadoAlumnos.RowCount - 1; i++)
            {
                
             
                //auxiliar = Estado(dgvListadoAlumnos,i);
                auxiliar = "P";
                Console.WriteLine("ESTADO: " + auxiliar);
                if (auxiliar != "NA")
                {
                    datos[0] = /*"20/02/2019";*/ DateTime.Now.ToShortDateString();// Year.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Day.ToString();
                    datos[1] = dgvListadoAlumnos.Rows[i].Cells[1].Value.ToString();
                    datos[2] = /*"2019";*/DateTime.Now.Year.ToString();
                    datos[3] = auxiliar;
                    datos[4] = dgvListadoAlumnos.Rows[i].Cells[6].Value.ToString();

                    a.Insertar(datos);            

                }
                else
                {
                    MessageBox.Show("No se ingresó todos los estados de los alumnos");
                    break;

                }              
            }
            MessageBox.Show("Se guardó el registro");
        }

        private string Estado(DataGridView dgv,int fila)
        {
            if ((dgv.Rows[fila].Cells[3] as DataGridViewCheckBoxCell).Selected == true)
                return "P";
            else if ((dgv.Rows[fila].Cells[4] as DataGridViewCheckBoxCell).Selected == true)
                return "T";
            else if ((dgv.Rows[fila].Cells[5] as DataGridViewCheckBoxCell).Selected == true)
                return "F";
            else
                return "NA";
        }
        private string Posicion(int n)
        {
            if(n == 3){
                return "P";
            }else if(n == 4){
                return "T";
            }else {
                return "F";
            }
        }

        private void cboGrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        #endregion eventos



        #region metodos

        private void ListarSalonesDeDocente()
        {
            cboGrado.DataSource = aDocente.GradoDocente(Int32.Parse(aCodDocente));
            cboSeccion.DataSource = aDocente.SeccionDocente(Int32.Parse(aCodDocente));
            cboGrado.DisplayMember = "Grado";
            cboGrado.ValueMember = "Grado";
            cboSeccion.DisplayMember = "Seccion";
            cboSeccion.ValueMember = "Seccion";
            cboGradoR.DataSource= aDocente.GradoDocente(Int32.Parse(aCodDocente));
            cboSeccionR.DataSource = aDocente.SeccionDocente(Int32.Parse(aCodDocente));
            cboGradoR.DisplayMember = "Grado";
            cboGradoR.ValueMember = "Grado";
            cboSeccionR.DisplayMember = "Seccion";
            cboSeccionR.ValueMember = "Seccion";
        }


        public void CargarListaAlumnos()
        {
            
            dgvListadoAlumnos.Rows.Clear();
            DataTable tabla = ListaAlumnos();
           
            bool check = false;
            int n = 0;
            foreach(DataRow linea in tabla.Rows){
                n++;
                dgvListadoAlumnos.Rows.Add(n.ToString(),linea[0].ToString(),linea[1],check,check,check,"");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvReporte.Rows.Clear();
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
            }
        }

        private DataTable ListaAlumnos()
        {
            return aAlumno.ListarAlumnosGrado(cboGrado.SelectedValue.ToString(), cboSeccion.SelectedValue.ToString(), aDocente.Nivel(Int32.Parse(aCodDocente)));
        }
        //propiedades
        public TextBox TBDocente
        {
            get { return this.tbDocente; }
            set { this.tbDocente = value; }
        }

        public ComboBox CBOGrado
        {
            get { return this.cboGrado;}
            set { this.cboGrado=value;}
        }

        public string CodDocente
        {
            get { return aCodDocente;}
            set { aCodDocente=value;}
        }

        #endregion metodos

        private void timer1_Tick(object sender, EventArgs e)
        {
            string clock = DateTime.Now.ToString("HH:mm:ss");
            lblTiempo.Text = clock;
        }

        private void dgvListadoAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            var fila = dgvListadoAlumnos.CurrentRow;
            //(sender as DataGridViewCheckBoxCell).TrueValue = true;
            if (dgvListadoAlumnos.CurrentCell.ColumnIndex == 3)
            {
                (fila.Cells[3] as DataGridViewCheckBoxCell).Value = true;
                aEstado = "P";
                (fila.Cells[4] as DataGridViewCheckBoxCell).Value = false;
                (fila.Cells[5] as DataGridViewCheckBoxCell).Value = false;
            }
            if (dgvListadoAlumnos.CurrentCell.ColumnIndex == 4)
            {
                (fila.Cells[3] as DataGridViewCheckBoxCell).Value = false;
                (fila.Cells[4] as DataGridViewCheckBoxCell).Value = true;
                aEstado = "T";
                (fila.Cells[5] as DataGridViewCheckBoxCell).Value = false;
            }
            if (dgvListadoAlumnos.CurrentCell.ColumnIndex == 5)
            {
                (fila.Cells[3] as DataGridViewCheckBoxCell).Value = false;
                (fila.Cells[4] as DataGridViewCheckBoxCell).Value = false;
                (fila.Cells[5] as DataGridViewCheckBoxCell).Value = true;
                aEstado = "F";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CargarListaAlumnos();
        }
    }
}
