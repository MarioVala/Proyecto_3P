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
    public partial class frmNDetalleCompras : DevExpress.XtraEditors.XtraForm
    {
        private int idDetalleCompra = 0;

        public frmNDetalleCompras()
        {
            InitializeComponent();
        }

        public frmNDetalleCompras(int idDetalleCompras)
        {
            InitializeComponent();
            this.idDetalleCompra = idDetalleCompra;
        }
        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (new detalleCompra
            {
                idCompra = Convert.ToInt32(txtIDCompra.Text),
                idProducto = Convert.ToInt32(txtIDProducto.Text),
                cantidad = Convert.ToInt32(txtCantidad.Text),
                costo = Convert.ToDecimal(txtCosto.Text),
                descuento = Convert.ToDecimal(txtDescuento.Text),
                importeTotal = Convert.ToDecimal(txtImporteTotal.Text),
                importeNeto = Convert.ToDecimal(txtImporteNeto.Text)
            }.Add() > 0)
            {
                XtraMessageBox.Show("Detalle de compra almacenada correctamente", Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void frmNDetalleCompras_Load(object sender, EventArgs e)
        {
            if (idDetalleCompra > 0)
            {
                txtIDCompra.EditValue = new detalleCompra { idDetalleCompra = this.idDetalleCompra }.GetById().idCompra;
                txtIDCompra.SelectAll();
                txtIDCompra.Focus();

                txtIDProducto.EditValue = new detalleCompra { idDetalleCompra = this.idDetalleCompra }.GetById().idProducto;
                txtIDProducto.SelectAll();
                txtIDProducto.Focus();

                txtCantidad.EditValue = new detalleCompra { idDetalleCompra = this.idDetalleCompra }.GetById().cantidad;
                txtCantidad.SelectAll();
                txtCantidad.Focus();

                txtCosto.EditValue = new detalleCompra { idDetalleCompra = this.idDetalleCompra }.GetById().costo;
                txtCosto.SelectAll();
                txtCosto.Focus();

                txtDescuento.EditValue = new detalleCompra { idDetalleCompra = this.idDetalleCompra }.GetById().descuento;
                txtDescuento.SelectAll();
                txtDescuento.Focus();

                txtImporteTotal.EditValue = new detalleCompra { idDetalleCompra = this.idDetalleCompra }.GetById().importeTotal;
                txtImporteTotal.SelectAll();
                txtImporteTotal.Focus();

                txtImporteNeto.EditValue = new detalleCompra { idDetalleCompra = this.idDetalleCompra }.GetById().importeNeto;
                txtImporteNeto.SelectAll();
                txtImporteNeto.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}