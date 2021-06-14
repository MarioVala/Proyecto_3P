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
    public partial class frmSucursales : DevExpress.XtraEditors.XtraForm
    {
        public frmSucursales()
        {
            InitializeComponent();
        }

        private void frmSucursales_Load(object sender, EventArgs e)
        {
            sucursalesBindingSource.DataSource = new Sucursales().GetAll();
            gvSucursales.BestFitColumns();
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            sucursalesBindingSource.DataSource = new Sucursales().GetAll();
            gvSucursales.BestFitColumns();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMSucursal { Text = "Nueva Susursal" }.ShowDialog();
            sucursalesBindingSource.DataSource = new Sucursales().GetAll();
            gvSucursales.BestFitColumns();
        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMSucursal((int)gvSucursales.GetFocusedRowCellValue("idSucursal")) { Text = "Modificar Sucursal" }.ShowDialog();
            sucursalesBindingSource.DataSource = new Sucursales().GetAll();
            gvSucursales.BestFitColumns();
        }
    }
}