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
    public partial class frmIngresoDatos : Form
    {
        cDocente aDocente = new cDocente();
        cAlumno aAlumnoo = new cAlumno();
        public frmIngresoDatos()
        {
            InitializeComponent();
        }

        private void presionarteclatexto(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void ControlarTexto(object sender, CancelEventArgs e)
        {
            TextBox tb = (sender as TextBox);
            if (tb.Text.Length == 0)
            {
                tb.Focus();
                this.errorProvider1.SetError(tb, "Este campo debe ser llenado");
            }
            else if (tb.Name == "tbDNIal" | tb.Name == "tbDNIdoc")
            {
                if (tb.Text.Length < 8)
                {
                    tb.Focus();
                    this.errorProvider1.SetError(tb, "Complete el DNI");
                }

            }

        }

        private void ValidarDNI(object sender, KeyPressEventArgs e)
        {
            int tecla = e.KeyChar;
            if (tecla != 8)
            {
                if (tecla < 48 | tecla > 57)
                    e.Handled = true;
                if ((sender as TextBox).Text.Length >= 8)
                {
                    e.Handled = true;
                    if (Char.IsControl(e.KeyChar))
                        e.Handled = false;
                }
            }
        }

        private void ValidarTelefono(object sender, KeyPressEventArgs e)
        {
            int tecla = e.KeyChar;
            if (tecla != 8)
            {
                if (tecla < 48 | tecla > 57)
                    e.Handled = true;
                if ((sender as TextBox).Text.Length >= 9)
                {
                    e.Handled = true;
                    if (Char.IsControl(e.KeyChar))
                        e.Handled = false;
                }
            }
        }
        private void linklblSalir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void frmIngresoDatos_Load(object sender, EventArgs e)
        {
            CargarListaAlumnos();
            CargarListaDocentes();
        }

        private void CargarListaAlumnos()
        {
            //DataTable Docentes = aDocente.ListarDocentes();
            //dgvAlumnos.Rows.Clear();
            //DataTable tabla = aAlumnoo.ListarAlumnos();
            //foreach (DataRow linea in tabla.Rows)
            //{
            //    dgvAlumnos.Rows.Add(linea[0].ToString(), linea[1].ToString(), linea[2].ToString(), linea[3].ToString(), linea[4].ToString());
            //}
        }

        private void CargarListaDocentes()
        {
            //dgvDocentes.Rows.Clear();
            //DataTable tabla = aDocente.ListarDocentes();

            //foreach (DataRow linea in tabla.Rows)
            //{
            //    dgvDocentes.Rows.Add(linea[0].ToString(), linea[2].ToString(), linea[3].ToString(), linea[4].ToString(), linea[5].ToString());
            //}
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            //int cod = int.Parse(aAlumnoo.ultimo().Rows[0][0].ToString().Substring(1,4))+1;
            //string Nombres = txtNombreal.Text + " " + txtAPal.Text + " " + tbAMal.Text;
            
            //aAlumnoo.Insertar(new string[] {"A00"+cod.ToString(),tbDNIal.Text,Nombres,tbDireccional.Text,tbTelefonoal.Text });
            //MessageBox.Show("Alumno Registrado Exitosamente");
            //CargarListaAlumnos();
            //limpiarAlumno();
        }

        private void limpiarAlumno()
        {
            tbDNIal.Clear();
            txtNombreal.Clear();
            txtAPal.Clear();
            tbAMal.Clear();
            tbDireccional.Clear();
            tbTelefonoal.Clear();
            tbDNIal.Focus();
        }

        private void limpiarDocente()
        {
            tbDNIdoc.Clear();
            tbNmbresdoc.Clear();
            tbAPdoc.Clear();
            tbAMdoc.Clear();
            tbDirecciondoc.Clear();
            tbtelefonodoc.Clear();
            cbTipoDoc.Text = "Seleccionar";
            tbDNIdoc.Focus();
        }

        private void btnGrabarDocente_Click(object sender, EventArgs e)
        {
            //int cod = int.Parse(aDocente.ultimo().Rows[0][0].ToString().Substring(2, 3 )) + 1;
            //string Nombres = tbNmbresdoc.Text + " " + tbAPdoc.Text + " " + tbAMdoc.Text;
            //string tipo="";
            //if(cbTipoDoc.Text=="Docente Primaria")
            //    tipo="DP";
            //if(cbTipoDoc.Text=="Docente Secundaria")
            //    tipo="DS";
            //aDocente.Insertar(new string[] { tipo+ "00" + cod.ToString(),"0000", tbDNIdoc.Text, Nombres, tbDirecciondoc.Text, tbtelefonodoc.Text });
            //MessageBox.Show("Docente Registrado Exitosamente");
            //CargarListaDocentes();
            //limpiarDocente();
        }
    }
}
