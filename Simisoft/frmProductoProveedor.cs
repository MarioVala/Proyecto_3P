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
    public partial class frmProductoProveedor : DevExpress.XtraEditors.XtraForm
    {
        public frmProductoProveedor()
        {
            InitializeComponent();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void frmProductoProveedor_Load(object sender, EventArgs e)
        {
            productoProveedoresBindingSource = new productoProveedores().GetAll();
            gvProductoProveedor.BestFitColumns();
        }
    }
}