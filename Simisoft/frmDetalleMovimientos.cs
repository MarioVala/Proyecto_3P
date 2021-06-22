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
    public partial class frmDetalleMovimientos : DevExpress.XtraEditors.XtraForm
    {
        public frmDetalleMovimientos()
        {
            InitializeComponent();
        }

        private void gcDetalleMovimientos_Click(object sender, EventArgs e)
        {

        }

        private void frmDetalleMovimientos_Load(object sender, EventArgs e)
        {
            detalleMovimientosBindingSource.DataSource = new detalleMovimientos().GetAll();
            gvDetalleMovimientos.BestFitColumns();
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            detalleMovimientosBindingSource.DataSource = new detalleMovimientos().GetAll();
            gvDetalleMovimientos.BestFitColumns();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNDetalleMovimientos { Text = "Nuevo Detalle de Movimiento" }.ShowDialog();
            detalleMovimientosBindingSource.DataSource = new detalleMovimientos().GetAll();
            gvDetalleMovimientos.BestFitColumns();
        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNDetalleMovimientos((int)gvDetalleMovimientos.GetFocusedRowCellValue("idDetalleMovimiento")) { Text = "Modificar detalle de movimiento" }.ShowDialog();
            detalleMovimientosBindingSource.DataSource = new detalleMovimientos().GetAll();
            gvDetalleMovimientos.BestFitColumns();
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int indice = gvDetalleMovimientos.FocusedRowHandle;
            string indiceconvertido = Convert.ToString(gvDetalleMovimientos.GetRowCellValue(indice, "idDetalleMovimiento"));
            detalleMovimientosBindingSource.DataSource = new detalleMovimientos().Delete(indiceconvertido);
            detalleMovimientosBindingSource.DataSource = new detalleMovimientos().GetAll();
            gvDetalleMovimientos.BestFitColumns();
        }
    }
}