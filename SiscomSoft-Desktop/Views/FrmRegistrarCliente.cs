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
using System.Drawing.Imaging;

namespace SiscomSoft_Desktop.Views
{
    public partial class FrmRegistrarCliente : Form
    {
        public String ImagenString { get; set; }
        public Bitmap ImagenBitmap { get; set; }


        public FrmRegistrarCliente()
        {
            InitializeComponent();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmBuscarCliente Buscar = new FrmBuscarCliente();
            Buscar.ShowDialog();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
           if (this.txtRFC.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtRFC, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtRFC, "Campo necesario");
                this.txtRFC.Focus();
            }
            else if (this.txtRazonSocial.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtRazonSocial, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtRazonSocial, "Campo necesario");
                this.txtRazonSocial.Focus();
            }
            else if (this.txtPersona.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtPersona, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtPersona, "Campo necesario");
                this.txtPersona.Focus();
            }
            else if (this.txtCurp.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtCurp, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtCurp, "Campo necesario");
                this.txtCurp.Focus();
            }
            else if (this.txtNombre.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtNombre, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtNombre, "Campo necesario");
                this.txtNombre.Focus();
            }
            else if (this.txtPais.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtPais, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtPais, "Campo necesario");
                this.txtPais.Focus();
            }
            else if (this.txtCodigoPostal.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtCodigoPostal, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtCodigoPostal, "Campo necesario");
                this.txtCodigoPostal.Focus();
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
            else if (this.txtLocalidad.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtLocalidad, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtLocalidad, "Campo necesario");
                this.txtLocalidad.Focus();
            }
            else if (this.txtColonia.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtColonia, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtColonia, "Campo necesario");
                this.txtColonia.Focus();
            }
            else if (this.txtCalle.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtCalle, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtCalle, "Campo necesario");
                this.txtCalle.Focus();
            }
            else if (this.txtNumExte.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtNumExte, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtNumExte, "Campo necesario");
                this.txtNumExte.Focus();
            }
            else if (this.txtNuminte.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtNuminte, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtNuminte, "Campo necesario");
                this.txtNuminte.Focus();
            }
            else if (this.txtTelFijo.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtTelFijo, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtTelFijo, "Campo necesario");
                this.txtTelFijo.Focus();
            }
            else if (this.txtTelMvil.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtTelMvil, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtTelMvil, "Campo necesario");
                this.txtTelMvil.Focus();
            }
            else if (this.txtCorreo.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtCorreo, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtCorreo, "Campo necesario");
                this.txtCorreo.Focus();
            }
            else if (this.txtEstadoCliente.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtEstadoCliente, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtEstadoCliente, "Campo necesario");
                this.txtEstadoCliente.Focus();
            }
            else if (this.txtReferencia.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtReferencia, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtReferencia, "Campo necesario");
                this.txtReferencia.Focus();
            }
            else if (this.cbxMetodoPago.Text == "Seleccione Una Opcion")
            {
                this.ErrorProvider.SetIconAlignment(this.cbxMetodoPago, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.cbxMetodoPago, "Favor de Seleccionar una opcion");
                this.cbxMetodoPago.Focus();
            }
            else if (this.txtNumCuenta.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtNumCuenta, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtNumCuenta, "Campo necesario");
                this.txtNumCuenta.Focus();
            }
            else if (this.txtCondicionesPago.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtCondicionesPago, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtCondicionesPago, "Campo necesario");
                this.txtCondicionesPago.Focus();
            }
            else if (this.cbxTipoCliente.Text == "Seleccione Una Opcion")
            {
                this.ErrorProvider.SetIconAlignment(this.cbxTipoCliente, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.cbxTipoCliente, "Favor de Seleccionar Una Opcion");
                this.txtCorreo.Focus();
            }


            else
            {
                Cliente nCliente = new Cliente();

                nCliente.sRfc = txtRFC.Text;
                nCliente.sRazonSocial = txtRazonSocial.Text;
                
                nCliente.iPersona = Convert.ToInt32(txtPersona.Text);
                nCliente.sCurp = txtCurp.Text;
                nCliente.sNombre = txtNombre.Text;
                nCliente.sPais = txtPais.Text;
                nCliente.iCodPostal = Convert.ToInt32(txtCodigoPostal.Text);
                nCliente.sEstado = txtEstado.Text;
                nCliente.sMunicipio = txtMunicipio.Text;
                nCliente.sLocalidad = txtLocalidad.Text;
                nCliente.sColonia = txtColonia.Text;
                nCliente.sCalle = txtCalle.Text;
                nCliente.iNumExterior = Convert.ToInt32(txtNumExte.Text);
                nCliente.iNumInterior = Convert.ToInt32(txtNuminte.Text);
                nCliente.sTelFijo = txtTelFijo.Text;
                nCliente.sTelMovil = txtTelMvil.Text;
                nCliente.sCorreo = txtCorreo.Text;
                nCliente.sEstCliente = txtEstadoCliente.Text;
                nCliente.sReferencia = txtReferencia.Text;
                nCliente.sTipoPAgo = cbxMetodoPago.Text;
                nCliente.iNumCuenta = Convert.ToInt32(txtNumCuenta.Text);
                nCliente.sCondPAgo = txtCondicionesPago.Text;
                nCliente.sTipoCliente = cbxTipoCliente.Text;
                nCliente.sLogo = ImagenString;





                ManejoCliente.RegistrarNuevoCliente(nCliente);

                MessageBox.Show("¡Cliente Registrado!");
                txtRFC.Clear();
                txtRazonSocial.Clear();
                txtPersona.Clear();
                txtCurp.Clear();
                txtNombre.Clear();
                txtPais.Clear();
                txtCodigoPostal.Clear();
                txtEstado.Clear();
                txtMunicipio.Clear();
                txtLocalidad.Clear();
                txtColonia.Clear();
                txtCalle.Clear();
                txtNuminte.Clear();
                txtNumExte.Clear();
                txtTelFijo.Clear();
                txtTelMvil.Clear();
                txtCorreo.Clear();
                txtEstadoCliente.Clear();
                txtReferencia.Clear();
                txtNumCuenta.Clear();
                txtCondicionesPago.Clear();
                
              
                pcbLogo.Image = null;
            }
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog BuscarImagen = new OpenFileDialog();
                BuscarImagen.Filter = "Archivos de Imagen|*.jpg;*.png;*gif;*.bmp";
                //Aquí incluiremos los filtros que queramos.
                BuscarImagen.FileName = "";
                BuscarImagen.Title = "Seleccione una imagen";
                if (BuscarImagen.ShowDialog() == DialogResult.OK)
                {
                    string logo = BuscarImagen.FileName;
                    this.pcbLogo.ImageLocation = logo;
                    ImagenBitmap = new System.Drawing.Bitmap(logo);
                    ImagenString = ToolImagen.ToBase64String(ImagenBitmap, ImageFormat.Jpeg);
                    pcbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido" + ex.Message);
            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void cbxMetodoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void txtReferencia_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void txtEstadoCliente_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtTelMvil_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txtTelFijo_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void txtNuminte_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtNumExte_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txtCalle_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtColonia_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtLocalidad_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtMunicipio_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigoPostal_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtPais_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtCurp_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPersona_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtRazonSocial_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtRFC_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pcbLogo_Click(object sender, EventArgs e)
        {

        }

        private void FrmRegistrarCliente_Load(object sender, EventArgs e)
        {
          
        }

        private void cbxTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }
    }
}