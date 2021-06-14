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
    public partial class frmNDetalleVentas : DevExpress.XtraEditors.XtraForm
    {
        private int idDetalleVenta = 0;
        public frmNDetalleVentas()
        {
            InitializeComponent();
        }

        public frmNDetalleVentas(int idDetalleVenta)
        {
            InitializeComponent();
            this.idDetalleVenta = idDetalleVenta;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(new detalleVentas
            {
                idVenta = Convert.ToInt32(txtIDVenta.Text),
                idProducto = Convert.ToInt32(txtIDProducto.Text),
                cantidad = Convert.ToInt32(txtCantidad.Text),
                precio = Convert.ToDouble(txtPrecio.Text),
                descuento = Convert.ToDouble(txtDescuento.Text),
                importeTotal = Convert.ToDouble(txtImporteTotal.Text),
                importeNeto = Convert.ToDouble(txtImporteNeto.Text),
            }.Add() >0)
            {
                XtraMessageBox.Show("Detalle de ventas almacenada correctamente", Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void frmNDetalleVentas_Load(object sender, EventArgs e)
        {
            if (idDetalleVenta > 0)
            {
                txtIDVenta.EditValue = new detalleVentas { idDetalleVenta = this.idDetalleVenta }.GetById().idVenta;
                txtIDVenta.SelectAll();
                txtIDVenta.Focus();

                txtIDProducto.EditValue = new detalleVentas { idDetalleVenta = this.idDetalleVenta }.GetById().idProducto;
                txtIDProducto.SelectAll();
                txtIDProducto.Focus();

                txtCantidad.EditValue = new detalleVentas { idDetalleVenta = this.idDetalleVenta }.GetById().cantidad;
                txtCantidad.SelectAll();
                txtCantidad.Focus();

                txtPrecio.EditValue = new detalleVentas { idDetalleVenta = this.idDetalleVenta }.GetById().precio;
                txtPrecio.SelectAll();
                txtPrecio.Focus();

                txtDescuento.EditValue = new detalleVentas { idDetalleVenta = this.idDetalleVenta }.GetById().descuento;
                txtDescuento.SelectAll();
                txtDescuento.Focus();

                txtImporteTotal.EditValue = new detalleVentas { idDetalleVenta = this.idDetalleVenta }.GetById().importeTotal;
                txtImporteTotal.SelectAll();
                txtImporteTotal.Focus();

                txtImporteNeto.EditValue = new detalleVentas { idDetalleVenta = this.idDetalleVenta }.GetById().importeNeto;
                txtImporteNeto.SelectAll();
                txtImporteNeto.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtDescuento_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}