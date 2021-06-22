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
    public partial class frmDetalleVentas : DevExpress.XtraEditors.XtraForm
    {
        public frmDetalleVentas()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void frmDetalleVentas_Load(object sender, EventArgs e)
        {
            detalleVentasBindingSource.DataSource = new detalleVentas().GetAll();
            gvDetalleVentas.BestFitColumns();
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            detalleVentasBindingSource.DataSource = new detalleVentas().GetAll();
            gvDetalleVentas.BestFitColumns();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNDetalleVentas { Text = "Nuevo Detalle de Venta" }.ShowDialog();
            detalleVentasBindingSource.DataSource = new detalleVentas().GetAll();
            gvDetalleVentas.BestFitColumns();
        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNDetalleVentas((int)gvDetalleVentas.GetFocusedRowCellValue("idDetalleVenta")) { Text = "Modificar detalle de venta" }.ShowDialog();
            detalleVentasBindingSource.DataSource = new detalleVentas().GetAll();
            gvDetalleVentas.BestFitColumns();
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int indice = gvDetalleVentas.FocusedRowHandle;
            string indiceconvertido = Convert.ToString(gvDetalleVentas.GetRowCellValue(indice, "idDetalleVenta"));
            detalleVentasBindingSource.DataSource = new detalleVentas().Delete(indiceconvertido);
            detalleVentasBindingSource.DataSource = new detalleVentas().GetAll();
            gvDetalleVentas.BestFitColumns();
        }
    }
}