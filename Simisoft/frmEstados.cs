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
    public partial class frmEstados : DevExpress.XtraEditors.XtraForm
    {
       
        public frmEstados()
        {
            InitializeComponent();
        }

        private void frmEstados_Load(object sender, EventArgs e)
        {
            estadoBindingSource.DataSource = new Estado().GetAll();
            gvEstados.BestFitColumns();
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            estadoBindingSource.DataSource = new Estado().GetAll();
            gvEstados.BestFitColumns();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNEstados { Text = "Nuevo Estado" }.ShowDialog();
            estadoBindingSource.DataSource = new Estado().GetAll();
            gvEstados.BestFitColumns();
        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNEstados((int)gvEstados.GetFocusedRowCellValue("idEstado")) { Text = "Modificar Estado" }.ShowDialog();
            estadoBindingSource.DataSource = new Estado().GetAll();
            gvEstados.BestFitColumns();
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}