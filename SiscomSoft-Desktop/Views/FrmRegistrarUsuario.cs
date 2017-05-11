﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SiscomSoft.Models;
using SiscomSoft_Desktop.Controller;
using SiscomSoft_Desktop.Comun;

namespace SiscomSoft_Desktop.Views
{
    public partial class FrmRegistrarUsuario : Form
    {
        public FrmRegistrarUsuario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmBuscarUsuario Usuario = new FrmBuscarUsuario();
            Usuario.ShowDialog();
        }

        private void FrmRegistrarUsuario_Load(object sender, EventArgs e)
        {
            this.cargarRoles();
        }
        public void cargarRoles()
        {
            int indexrol = 0;
            //llenar combo
            cbxRol.DataSource = ManejoRol.getAll(true);
            cbxRol.DisplayMember = "sNombre";
            cbxRol.ValueMember = "pkRol";

            cbxRol.SelectedIndex = indexrol;
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
                if (this.txtRFC.Text == "")
                {
                    this.ErrorProvider.SetIconAlignment(this.txtRFC, ErrorIconAlignment.MiddleRight);
                    this.ErrorProvider.SetError(this.txtRFC, "Campo necesario");
                    this.txtRFC.Focus();
                }
                else if (this.txtUsuario.Text == "")
                {
                    this.ErrorProvider.SetIconAlignment(this.txtUsuario, ErrorIconAlignment.MiddleRight);
                    this.ErrorProvider.SetError(this.txtUsuario, "Campo necesario");
                    this.txtUsuario.Focus();
                }
                else if (this.txtNombre.Text == "")
                {
                    this.ErrorProvider.SetIconAlignment(this.txtNombre, ErrorIconAlignment.MiddleRight);
                    this.ErrorProvider.SetError(this.txtNombre, "Campo necesario");
                    this.txtNombre.Focus();
                }
                else if (this.txtPerfil.Text == "")
                {
                    this.ErrorProvider.SetIconAlignment(this.txtPerfil, ErrorIconAlignment.MiddleRight);
                    this.ErrorProvider.SetError(this.txtPerfil, "Campo necesario");
                    this.txtPerfil.Focus();
                }
                else if (this.txtContraseña.Text == "")
                {
                    this.ErrorProvider.SetIconAlignment(this.txtContraseña, ErrorIconAlignment.MiddleRight);
                    this.ErrorProvider.SetError(this.txtContraseña, "Campo necesario");
                    this.txtContraseña.Focus();
                }
                else if (this.txtTelefono.Text == "")
                {
                    this.ErrorProvider.SetIconAlignment(this.txtTelefono, ErrorIconAlignment.MiddleRight);
                    this.ErrorProvider.SetError(this.txtTelefono, "Campo necesario");
                    this.txtTelefono.Focus();
                }
                else if (this.txtNombre.Text == "")
                {
                    this.ErrorProvider.SetIconAlignment(this.txtNombre, ErrorIconAlignment.MiddleRight);
                    this.ErrorProvider.SetError(this.txtNombre, "Campo necesario");
                    this.txtNombre.Focus();
                }
                else if (this.txtCorreo.Text == "")
                {
                    this.ErrorProvider.SetIconAlignment(this.txtCorreo, ErrorIconAlignment.MiddleRight);
                    this.ErrorProvider.SetError(this.txtCorreo, "Campo necesario");
                    this.txtCorreo.Focus();
                }
                else if (this.txtComentario.Text == "")
                {
                    this.ErrorProvider.SetIconAlignment(this.txtComentario, ErrorIconAlignment.MiddleRight);
                    this.ErrorProvider.SetError(this.txtComentario, "Campo necesario");
                    this.txtComentario.Focus();
                }
                else if (this.cbxRol.Text == "")
                {
                    this.ErrorProvider.SetIconAlignment(this.cbxRol, ErrorIconAlignment.MiddleRight);
                    this.ErrorProvider.SetError(this.cbxRol, "Seleccione una opcion");
                    this.cbxRol.Focus();
                }
                else
                {
                    Usuario nUsuario = new Usuario();

                    nUsuario.sRfc = txtRFC.Text;
                    nUsuario.sUsuario = txtUsuario.Text;
                    nUsuario.sNombre = txtNombre.Text;
                    nUsuario.sPerfil = txtPerfil.Text;
                   
                    nUsuario.sContrasena = LoginTool.GetMD5(txtContraseña.Text);
                    nUsuario.sNumero = txtTelefono.Text;
                    nUsuario.sCorreo = txtCorreo.Text;
                    nUsuario.sComentario = txtComentario.Text;
                    int fkRol = Convert.ToInt32(cbxRol.SelectedValue.ToString());



                    ManejoUsuario.RegistrarNuevoUsuario(nUsuario, fkRol);

                    MessageBox.Show("¡Usuario Registrado!");
                    txtRFC.Clear();
                    txtUsuario.Clear();
                    txtNombre.Clear();
                    txtPerfil.Clear();
                    txtContraseña.Clear();
                    txtTelefono.Clear();
                    txtCorreo.Clear();
                    txtComentario.Clear();
                   
                   


                
            
            }
        }

        private void txtRFC_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtPerfil_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtContraseña_TextAlignChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtComentario_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }
    }
}