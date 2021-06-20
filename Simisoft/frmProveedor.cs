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
    public partial class frmProveedor : DevExpress.XtraEditors.XtraForm
    {
        public frmProveedor()
        {
            InitializeComponent();
        }

        private void frmProveedor_Load(object sender, EventArgs e)
        {
            proveedoresBindingSource.DataSource = new Proveedores().GetAll();
            gvProveedor.BestFitColumns();
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNProveedor { Text = "Nuevo Proveedor" }.ShowDialog();
            proveedoresBindingSource.DataSource = new Proveedores().GetAll();
            gvProveedor.BestFitColumns();
        }

        
    }
}