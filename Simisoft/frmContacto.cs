using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SimiSoft.BML;

namespace Simisoft
{
    public partial class frmContacto : DevExpress.XtraEditors.XtraForm
    {
        public frmContacto()
        {
            InitializeComponent();
        }

        private void frmContacto_Load(object sender, EventArgs e)
        {
            contactoBindingSource.DataSource = new Contacto().GetAll();
            gvContacto.BestFitColumns();
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int indice = gvContacto.FocusedRowHandle;
            string indiceconvertido = Convert.ToString(gvContacto.GetRowCellValue(indice, "idContacto"));
            contactoBindingSource.DataSource = new Contacto().Delete(indiceconvertido);
            contactoBindingSource.DataSource = new Contacto().GetAll();
            gvContacto.BestFitColumns();
        }
        
        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNContacto((int)gvContacto.GetFocusedRowCellValue("idContacto")) { Text = "Modificar contacto" }.ShowDialog();
            contactoBindingSource.DataSource = new Contacto().GetAll();
            gvContacto.BestFitColumns();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNContacto { Text = "Nuevo contacto" }.ShowDialog();
            contactoBindingSource.DataSource = new Contacto().GetAll();
            gvContacto.BestFitColumns();
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            contactoBindingSource.DataSource = new Contacto().GetAll();
            gvContacto.BestFitColumns();
        }
        
    }
}