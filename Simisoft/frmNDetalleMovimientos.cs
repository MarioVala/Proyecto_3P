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
    public partial class frmNDetalleMovimientos : DevExpress.XtraEditors.XtraForm
    {
        private int idDetalleMovimiento = 0;

        public frmNDetalleMovimientos()
        {
            InitializeComponent();
        }

        public frmNDetalleMovimientos(int idDetalleMovimiento)
        {
            InitializeComponent();
            this.idDetalleMovimiento = idDetalleMovimiento;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(new detalleMovimientos
            {
                idProducto = Convert.ToInt32(txtIDProducto.Text),
                cantidad = Convert.ToInt32(txtCantidad.Text)
            }.Add() >0)
            {
                XtraMessageBox.Show("Detalle de movimiento almacenado correctamente", Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void frmNDetalleMovimientos_Load(object sender, EventArgs e)
        {
            if (idDetalleMovimiento > 0)
            {
                txtIDProducto.EditValue = new detalleMovimientos { idDetalleMovimiento = this.idDetalleMovimiento }.GetById().idProducto;
                txtIDProducto.SelectAll();
                txtIDProducto.Focus();

                txtCantidad.EditValue = new detalleMovimientos { idDetalleMovimiento = this.idDetalleMovimiento }.GetById().cantidad;
                txtCantidad.SelectAll();
                txtCantidad.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}