using DevExpress.XtraEditors;
using SimiSoft.BML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simisoft
{
    public partial class frmNMSucursal : DevExpress.XtraEditors.XtraForm
    {
        private int idSucursal = 0;
        public frmNMSucursal()
        {
            InitializeComponent();
        }

        public frmNMSucursal(int idSucursal) {
            InitializeComponent();
            this.idSucursal = idSucursal;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (idSucursal > 0)
            {
                if (new Sucursales
                { 
                    idSucursal = this.idSucursal,
                        nombreSucursal=txtNombre.Text,
                        idContacto= int.Parse(txtIdContacto.Text)
                }.Update()>0)
                    {
                    XtraMessageBox.Show("Sucursal actualizada correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            else 
            {
                if (new Sucursales
                {
                    nombreSucursal = txtNombre.Text,
                    idContacto = int.Parse(txtIdContacto.Text)
                    
                    
                }.Add() > 0)
                {
                    XtraMessageBox.Show("Sucursal almacenada correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
        }

        private void frmNMSucursal_Load(object sender, EventArgs e)
        {
            if (idSucursal > 0)
            {
                txtNombre.EditValue = new Sucursales { idSucursal = this.idSucursal }.GetById().nombreSucursal;
                txtNombre.SelectAll();
                txtNombre.Focus();

                txtIdContacto.EditValue = new Sucursales { idSucursal = this.idSucursal }.GetById().idContacto;
                txtIdContacto.SelectAll();
                txtIdContacto.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}