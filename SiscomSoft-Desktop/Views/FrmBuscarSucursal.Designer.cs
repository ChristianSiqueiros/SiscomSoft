﻿namespace SiscomSoft_Desktop.Views
{
    partial class FrmBuscarSucursal
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.ckbStatus = new System.Windows.Forms.CheckBox();
            this.dgvDatosSucursal = new System.Windows.Forms.DataGridView();
            this.pkSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNomComercial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEstSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNumCertificado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMunicipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sColonia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iCodPostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscarSucursal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosSucursal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(242, 396);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(109, 31);
            this.btnSalir.TabIndex = 32;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Enabled = false;
            this.btnActualizar.Location = new System.Drawing.Point(127, 396);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(109, 31);
            this.btnActualizar.TabIndex = 31;
            this.btnActualizar.Tag = "2";
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Enabled = false;
            this.btnBorrar.Location = new System.Drawing.Point(12, 396);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(109, 31);
            this.btnBorrar.TabIndex = 30;
            this.btnBorrar.Tag = "1";
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // lblRegistros
            // 
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.Location = new System.Drawing.Point(780, 365);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(68, 18);
            this.lblRegistros.TabIndex = 29;
            this.lblRegistros.Text = "Registro:";
            // 
            // ckbStatus
            // 
            this.ckbStatus.AutoSize = true;
            this.ckbStatus.Checked = true;
            this.ckbStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbStatus.Location = new System.Drawing.Point(15, 368);
            this.ckbStatus.Name = "ckbStatus";
            this.ckbStatus.Size = new System.Drawing.Size(69, 22);
            this.ckbStatus.TabIndex = 28;
            this.ckbStatus.Text = "Status";
            this.ckbStatus.UseVisualStyleBackColor = true;
            // 
            // dgvDatosSucursal
            // 
            this.dgvDatosSucursal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosSucursal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkSucursal,
            this.sNomComercial,
            this.sEstSucursal,
            this.iNumCertificado,
            this.sEstado,
            this.sMunicipio,
            this.sColonia,
            this.sCalle,
            this.iCodPostal});
            this.dgvDatosSucursal.Location = new System.Drawing.Point(12, 38);
            this.dgvDatosSucursal.Name = "dgvDatosSucursal";
            this.dgvDatosSucursal.RowHeadersVisible = false;
            this.dgvDatosSucursal.Size = new System.Drawing.Size(894, 324);
            this.dgvDatosSucursal.TabIndex = 27;
            // 
            // pkSucursal
            // 
            this.pkSucursal.DataPropertyName = "pkSucursal";
            this.pkSucursal.HeaderText = "Sucursal";
            this.pkSucursal.Name = "pkSucursal";
            // 
            // sNomComercial
            // 
            this.sNomComercial.DataPropertyName = "sNomComercial";
            this.sNomComercial.HeaderText = "Nombre";
            this.sNomComercial.Name = "sNomComercial";
            // 
            // sEstSucursal
            // 
            this.sEstSucursal.DataPropertyName = "sEstSucursal";
            this.sEstSucursal.HeaderText = "Estado de Sucursal";
            this.sEstSucursal.Name = "sEstSucursal";
            // 
            // iNumCertificado
            // 
            this.iNumCertificado.DataPropertyName = "iNumCertificado";
            this.iNumCertificado.HeaderText = "Numero de Certificado";
            this.iNumCertificado.Name = "iNumCertificado";
            // 
            // sEstado
            // 
            this.sEstado.DataPropertyName = "sEstado";
            this.sEstado.HeaderText = "Estado";
            this.sEstado.Name = "sEstado";
            this.sEstado.Width = 90;
            // 
            // sMunicipio
            // 
            this.sMunicipio.DataPropertyName = "sMunicipio";
            this.sMunicipio.HeaderText = "Municipio";
            this.sMunicipio.Name = "sMunicipio";
            // 
            // sColonia
            // 
            this.sColonia.DataPropertyName = "sColonia";
            this.sColonia.HeaderText = "Colonia";
            this.sColonia.Name = "sColonia";
            // 
            // sCalle
            // 
            this.sCalle.DataPropertyName = "sCalle";
            this.sCalle.HeaderText = "Calle";
            this.sCalle.Name = "sCalle";
            // 
            // iCodPostal
            // 
            this.iCodPostal.DataPropertyName = "iCodPostal";
            this.iCodPostal.HeaderText = "Codigo Postal";
            this.iCodPostal.Name = "iCodPostal";
            // 
            // txtBuscarSucursal
            // 
            this.txtBuscarSucursal.Location = new System.Drawing.Point(229, 8);
            this.txtBuscarSucursal.Name = "txtBuscarSucursal";
            this.txtBuscarSucursal.Size = new System.Drawing.Size(676, 24);
            this.txtBuscarSucursal.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Buscar Sucursal Por Nombre";
            // 
            // FrmBuscarSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 455);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.ckbStatus);
            this.Controls.Add(this.dgvDatosSucursal);
            this.Controls.Add(this.txtBuscarSucursal);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmBuscarSucursal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Sucursal";
            this.Load += new System.EventHandler(this.FrmBuscarSucursal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosSucursal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.CheckBox ckbStatus;
        private System.Windows.Forms.DataGridView dgvDatosSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNomComercial;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEstSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNumCertificado;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMunicipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn sColonia;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn iCodPostal;
        private System.Windows.Forms.TextBox txtBuscarSucursal;
        private System.Windows.Forms.Label label1;
    }
}