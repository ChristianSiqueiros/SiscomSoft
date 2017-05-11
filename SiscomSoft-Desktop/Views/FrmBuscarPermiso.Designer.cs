﻿namespace SiscomSoft_Desktop.Views
{
    partial class FrmBuscarPermiso
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
            this.lblRegistros = new System.Windows.Forms.Label();
            this.ckbStatus = new System.Windows.Forms.CheckBox();
            this.dgvDatosPermiso = new System.Windows.Forms.DataGridView();
            this.pkPermiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sModulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sComentario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscarPermiso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosPermiso)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(171, 384);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(78, 31);
            this.btnSalir.TabIndex = 48;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblRegistros
            // 
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.Location = new System.Drawing.Point(247, 344);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(68, 18);
            this.lblRegistros.TabIndex = 45;
            this.lblRegistros.Text = "Registro:";
            // 
            // ckbStatus
            // 
            this.ckbStatus.AutoSize = true;
            this.ckbStatus.Checked = true;
            this.ckbStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbStatus.Location = new System.Drawing.Point(12, 340);
            this.ckbStatus.Name = "ckbStatus";
            this.ckbStatus.Size = new System.Drawing.Size(69, 22);
            this.ckbStatus.TabIndex = 44;
            this.ckbStatus.Text = "Status";
            this.ckbStatus.UseVisualStyleBackColor = true;
            this.ckbStatus.CheckedChanged += new System.EventHandler(this.ckbStatus_CheckedChanged);
            // 
            // dgvDatosPermiso
            // 
            this.dgvDatosPermiso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosPermiso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkPermiso,
            this.sModulo,
            this.sComentario});
            this.dgvDatosPermiso.Location = new System.Drawing.Point(12, 39);
            this.dgvDatosPermiso.Name = "dgvDatosPermiso";
            this.dgvDatosPermiso.RowHeadersVisible = false;
            this.dgvDatosPermiso.Size = new System.Drawing.Size(303, 286);
            this.dgvDatosPermiso.TabIndex = 43;
            // 
            // pkPermiso
            // 
            this.pkPermiso.DataPropertyName = "pkPermiso";
            this.pkPermiso.HeaderText = "Permiso";
            this.pkPermiso.Name = "pkPermiso";
            // 
            // sModulo
            // 
            this.sModulo.DataPropertyName = "sModulo";
            this.sModulo.HeaderText = "Modulo";
            this.sModulo.Name = "sModulo";
            // 
            // sComentario
            // 
            this.sComentario.DataPropertyName = "sComentario";
            this.sComentario.HeaderText = "Comentario";
            this.sComentario.Name = "sComentario";
            // 
            // txtBuscarPermiso
            // 
            this.txtBuscarPermiso.Location = new System.Drawing.Point(133, 12);
            this.txtBuscarPermiso.Name = "txtBuscarPermiso";
            this.txtBuscarPermiso.Size = new System.Drawing.Size(182, 24);
            this.txtBuscarPermiso.TabIndex = 42;
            this.txtBuscarPermiso.TextChanged += new System.EventHandler(this.txtBuscarPermiso_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 41;
            this.label1.Text = "Buscar Permiso";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(3, 384);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(78, 31);
            this.btnBorrar.TabIndex = 49;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(87, 384);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(78, 31);
            this.btnActualizar.TabIndex = 50;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // FrmBuscarPermiso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 433);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.ckbStatus);
            this.Controls.Add(this.dgvDatosPermiso);
            this.Controls.Add(this.txtBuscarPermiso);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmBuscarPermiso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Permiso";
            this.Load += new System.EventHandler(this.FrmBuscarPermiso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosPermiso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.CheckBox ckbStatus;
        private System.Windows.Forms.DataGridView dgvDatosPermiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkPermiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn sModulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn sComentario;
        private System.Windows.Forms.TextBox txtBuscarPermiso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnActualizar;
    }
}