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
using SiscomSoft_Desktop.Comun;
using SiscomSoft_Desktop.Controller;

namespace SiscomSoft_Desktop.Views
{
    public partial class FrmRegistrarEntrada : Form
    {
        public FrmRegistrarEntrada()
        {
            InitializeComponent();
        }

        private void FrmRegistrarEntrada_Load(object sender, EventArgs e)
        {
            this.cargarClientes();
        }
        public void cargarClientes()
        {
            int indexrol = 0;
            //llenar combo
            cbxProveedor.DataSource = ManejoCliente.getAll(true);
            cbxProveedor.DisplayMember = "sNombre";
            cbxProveedor.ValueMember = "pkCliente";

            cbxProveedor.SelectedIndex = indexrol;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmBuscarEntrada Entrada = new FrmBuscarEntrada();
            Entrada.ShowDialog();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (this.txtNombreProducto.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtNombreProducto, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtNombreProducto, "Campo necesario");
                this.txtNombreProducto.Focus();
            }
            else if (this.txtMoneda.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtMoneda, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtMoneda, "Campo necesario");
                this.txtMoneda.Focus();
            }
            else if (this.txtNoFactura.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtNoFactura, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtNoFactura, "Campo necesario");
                this.txtNoFactura.Focus();
            }

            else if (this.cbxMetodoPago.Text == "Seleccione una opcion")
            {
                this.ErrorProvider.SetIconAlignment(this.cbxMetodoPago, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.cbxMetodoPago, "Requiere Seleccionar una opcion");
                this.cbxMetodoPago.Focus();
            }
            else if (this.txtCantidad.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtCantidad, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtCantidad, "Campo necesario");
                this.txtCantidad.Focus();
            }
            else if (this.txtPrecio.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtPrecio, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtPrecio, "Campo necesario");
                this.txtPrecio.Focus();
            }
            else if (this.txtDescuento.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtDescuento, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtDescuento, "Campo necesario");
                this.txtDescuento.Focus();
            }
            else if (this.txtLote.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtLote, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtLote, "Campo necesario");
                this.txtLote.Focus();
            }
            else if (this.cbxProveedor.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.cbxProveedor, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.cbxProveedor, "Debe Ingresar un Cliente Primero");
                this.cbxProveedor.Focus();
            }
            else if (this.cbxMetodoPago.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.cbxMetodoPago, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.cbxMetodoPago, "Seleccione un metodo de pago");
                this.cbxMetodoPago.Focus();
            }

            else
            {
                InventarioEntrada nEntrada = new InventarioEntrada();

                nEntrada.dtFecha = dtpFechaEntrada.Value.Date;
                nEntrada.sTipoPago = cbxMetodoPago.Text;
                nEntrada.sMoneda = txtMoneda.Text;
                nEntrada.iNoFactura = Convert.ToInt32(txtNoFactura.Text);
                nEntrada.dCantidad = Convert.ToDouble(txtCantidad.Text);
                nEntrada.sNomProducto = txtNombreProducto.Text;
                nEntrada.dPrecio = Convert.ToDouble(txtPrecio.Text);
                nEntrada.iDescuento = Convert.ToInt32(txtDescuento.Text);
                nEntrada.iLote = Convert.ToInt32(txtLote.Text);
                nEntrada.dtCaducidad = dtpFechaCaducidad.Value.Date;


                int fkCliente = Convert.ToInt32(cbxProveedor.SelectedValue.ToString());



                ManejoEntrada.RegistrarNuevaEntrada(nEntrada, fkCliente);

                MessageBox.Show("¡Entrada Registrada!");
                txtMoneda.Clear();
                txtNoFactura.Clear();
                txtCantidad.Clear();
                txtNombreProducto.Clear();
                txtPrecio.Clear();
                txtDescuento.Clear();
                txtLote.Clear();
              






            }
        }

        private void txtNombreProducto_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtLote_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtMoneda_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtNoFactura_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void cbxMetodoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtLote_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNoFactura_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtMoneda_KeyDown(object sender, KeyEventArgs e)
        {
         
        }

        private void txtMoneda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)
          && e.KeyChar != 8) e.Handled = true;
        }

        private void FrmRegistrarEntrada_ResizeEnd(object sender, EventArgs e)
        {
            if (this.Width < 442) this.Width = 442;
            if (this.Height < 131) this.Height = 131;
            if (this.Width > 442) this.Width = 442;
            if (this.Height > 131) this.Height = 131;
        }
    }
}
