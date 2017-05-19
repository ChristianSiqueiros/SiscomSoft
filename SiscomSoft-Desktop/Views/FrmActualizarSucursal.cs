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
    public partial class FrmActualizarSucursal : Form
    {
        FrmBuscarSucursal vMain;
        public FrmActualizarSucursal(FrmBuscarSucursal vmain)
        {
            InitializeComponent();
            vMain = vmain;
            vMain.cargarSucursales();
        }
        public void cargarPreferencias()
        {
            int indexrol = 0;
            //llenar combo
            cbxPreferencia.DataSource = ManejoPreferencia.getAll(true);
            cbxPreferencia.DisplayMember = "sNumSerie";
            cbxPreferencia.ValueMember = "pkPreferencia";

            cbxPreferencia.SelectedIndex = indexrol;
        }

        private void FrmActualizarSucursal_Load(object sender, EventArgs e)
        {
            this.cargarPreferencias();
            Sucursal nSucursal = ManejoSucursal.getById(FrmBuscarSucursal.PKSUCURSAL);

            txtNombreSucursal.Text = nSucursal.sNombre;
            txtEstadoSucursal.Text = nSucursal.sEstSucursal;
            txtNumCertificado.Text = Convert.ToInt32(nSucursal.iNumCertificado).ToString();
            txtPais.Text = nSucursal.sPais;
            txtEstado.Text = nSucursal.sEstado;
            txtMunicipio.Text = nSucursal.sMunicipio;
            txtColonia.Text = nSucursal.sColonia;
            txtLocalidad.Text = nSucursal.sLocalidad;
            txtCalle.Text = nSucursal.sCalle;
            txtNumExterior.Text = Convert.ToInt32(nSucursal.iNumExterior).ToString();
           txtNumInterior.Text = Convert.ToInt32(nSucursal.iNumInterior).ToString();
            txtCodigoPostal.Text = Convert.ToInt32(nSucursal.iCodPostal).ToString();


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (this.txtNombreSucursal.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtNombreSucursal, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtNombreSucursal, "Campo necesario");
                this.txtNombreSucursal.Focus();
            }
            else if (this.txtEstadoSucursal.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtEstadoSucursal, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtEstadoSucursal, "Campo necesario");
                this.txtEstadoSucursal.Focus();
            }
            else if (this.txtNumCertificado.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtNumCertificado, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtNumCertificado, "Campo necesario");
                this.txtNumCertificado.Focus();
            }

            else if (this.txtPais.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtPais, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtPais, "Campo necesario");
                this.txtPais.Focus();
            }
            else if (this.txtEstado.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtEstado, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtEstado, "Campo necesario");
                this.txtEstado.Focus();
            }
            else if (this.txtMunicipio.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtMunicipio, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtMunicipio, "Campo necesario");
                this.txtMunicipio.Focus();
            }
            else if (this.txtColonia.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtColonia, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtColonia, "Campo necesario");
                this.txtColonia.Focus();
            }
            else if (this.txtLocalidad.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtLocalidad, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtLocalidad, "Campo necesario");
                this.txtLocalidad.Focus();
            }
            else if (this.txtCalle.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtCalle, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtCalle, "Seleccione una opcion");
                this.txtCalle.Focus();
            }
            else if (this.txtNumExterior.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtNumExterior, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtNumExterior, "Seleccione una opcion");
                this.txtNumExterior.Focus();
            }
            else if (this.txtNumInterior.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtNumInterior, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtNumInterior, "Seleccione una opcion");
                this.txtNumInterior.Focus();
            }
            else if (this.txtCodigoPostal.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtCodigoPostal, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtCodigoPostal, "Seleccione una opcion");
                this.txtCodigoPostal.Focus();
            }
            else
            {
                Sucursal nSucursal = new Sucursal();
                nSucursal.pkSucursal = FrmBuscarSucursal.PKSUCURSAL;
              
                nSucursal.sNombre = txtNombreSucursal.Text;
                nSucursal.sEstSucursal = txtEstadoSucursal.Text;
                nSucursal.sEstSucursal = txtEstadoSucursal.Text;
                nSucursal.iNumCertificado = Convert.ToInt32(txtNumCertificado.Text);
                nSucursal.sPais = txtPais.Text;
                nSucursal.sEstado = txtEstado.Text;
                nSucursal.sMunicipio = txtMunicipio.Text;
                nSucursal.sColonia = txtColonia.Text;
                nSucursal.sLocalidad = txtLocalidad.Text;
                nSucursal.sCalle = txtCalle.Text;
                nSucursal.iNumExterior = Convert.ToInt32(txtNumExterior.Text);
                nSucursal.iNumInterior = Convert.ToInt32(txtNumInterior.Text);
                nSucursal.iCodPostal = Convert.ToInt32(txtCodigoPostal.Text);







                int fkPreferencia = Convert.ToInt32(cbxPreferencia.SelectedValue.ToString());


                ManejoSucursal.Modificar(nSucursal);

                vMain.cargarSucursales();

                this.Close();
            }
        }

        private void txtPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)
             && e.KeyChar != 8) e.Handled = true;
        }

        private void txtEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)
             && e.KeyChar != 8) e.Handled = true;
        }

        private void txtMunicipio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)
             && e.KeyChar != 8) e.Handled = true;
        }

        private void txtNumInterior_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNumExterior_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtCodigoPostal_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtCodigoPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNumCertificado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNombreSucursal_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtEstadoSucursal_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtNumCertificado_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtPais_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtMunicipio_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtColonia_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtLocalidad_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtCalle_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtNumInterior_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtNumExterior_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void FrmActualizarSucursal_ResizeEnd(object sender, EventArgs e)
        {
            if (this.Width < 442) this.Width = 442;
            if (this.Height < 131) this.Height = 131;
            if (this.Width > 442) this.Width = 442;
            if (this.Height > 131) this.Height = 131;
        }
    }
}
