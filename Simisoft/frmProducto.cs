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
    public partial class frmProducto : DevExpress.XtraEditors.XtraForm
    {
        public frmProducto()
        {
            InitializeComponent();
            
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            productosBindingSource.DataSource = new Productos().GetAll();
            gvProducto.BestFitColumns();
        }
    }
}