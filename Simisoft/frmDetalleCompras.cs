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
    public partial class frmDetalleCompras : DevExpress.XtraEditors.XtraForm
    {
        public frmDetalleCompras()
        {
            InitializeComponent();
        }

        private void frmDetalleCompras_Load(object sender, EventArgs e)
        {
            detalleCompraBindingSource.DataSource = new detalleCompra().GetAll();
            gvDetalleCompras.BestFitColumns();
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            detalleCompraBindingSource.DataSource = new detalleCompra().GetAll();
            gvDetalleCompras.BestFitColumns();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNDetalleCompras { Text = "Nuevo Detalle de Compra" }.ShowDialog();
            detalleCompraBindingSource.DataSource = new detalleCompra().GetAll();
            gvDetalleCompras.BestFitColumns();
        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNDetalleCompras((int)gvDetalleCompras.GetFocusedRowCellValue("idDetalleCompra")) { Text = "Modificar detalle de compra" }.ShowDialog();
            detalleCompraBindingSource.DataSource = new detalleCompra().GetAll();
            gvDetalleCompras.BestFitColumns();
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int indice = gvDetalleCompras.FocusedRowHandle;
            string indiceconvertido = Convert.ToString(gvDetalleCompras.GetRowCellValue(indice, "idDetalleCompra")); 
            detalleCompraBindingSource.DataSource = new detalleCompra().Delete(indiceconvertido);
            detalleCompraBindingSource.DataSource = new detalleCompra().GetAll();
            gvDetalleCompras.BestFitColumns();            
        }
    }
}