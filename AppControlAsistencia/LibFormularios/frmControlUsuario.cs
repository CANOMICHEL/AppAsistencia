﻿using System;
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
    public partial class frmControlUsuario : Form
    {
        //Atributos
        cDocente aDocente = new cDocente();
        cUsuario aUsuario = new cUsuario();
        public frmControlUsuario()
        {
            InitializeComponent();
        }

        private void enter_event(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb.Text == "Usuario")
            {
                tb.Clear();
                tb.ForeColor = Color.Black;

            }
            if (tb.Text == "Contraseña")
            {
                tb.Clear();
                tb.ForeColor = Color.Black;
                tb.UseSystemPasswordChar = true;
            }
        }

        private void leave_event(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb.Text == "" & txtPassword.Text == "Contraseña")
            {
                txtUsername.Text = "Usuario";
                tb.ForeColor = Color.White;
            }
            if (tb.Text == "" & txtUsername.Text == "Usuario")
            {
                tb.UseSystemPasswordChar = false;
                txtPassword.Text = "Contraseña";
                tb.ForeColor = Color.White;
            }
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (aUsuario.RespuestaLogin(txtUsername.Text, txtPassword.Text))
            {
                //Console.WriteLine(txtUsername.Text[0].ToString() + txtUsername.Text[1]);
                if (aUsuario.RolLogin(txtUsername.Text) == "DOCENTE")
                {
                    frmAsistencia L = new frmAsistencia();
                    L.CodDocente = aDocente.IdDocente(txtUsername.Text);
                    L.ShowDialog();
                }
                if (aUsuario.RolLogin(txtUsername.Text) == "DIRECTOR")
                {
                    //Abrir formulario de director
                    frmDirector L = new frmDirector();
                    //L.CodDirector = this.txtUsername.Text;
                    L.CodDirector = aDocente.IdDocente(txtUsername.Text);
                    L.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acceso Denegado");
                }
            }
        }

    }
}
