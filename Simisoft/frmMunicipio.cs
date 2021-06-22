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
    public partial class frmMunicipio : DevExpress.XtraEditors.XtraForm
    {
        public frmMunicipio()
        {
            InitializeComponent();
        }
        private void frmMunicipio_Load(object sender, EventArgs e)
        {
            municipiosBindingSource.DataSource = new Municipios().GetAll();
            gvMunicipio.BestFitColumns();
        }
       

        private void gcContacto_Click(object sender, EventArgs e)
        {

        }

        private void gcMunicipio_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMunicipio((int)gvMunicipio.GetFocusedRowCellValue("idMunicipio")) { Text = "Modificar municipio" }.ShowDialog();
            municipiosBindingSource.DataSource = new Municipios().GetAll();
            gvMunicipio.BestFitColumns();
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int indice = gvMunicipio.FocusedRowHandle;
            string indiceconvertido = Convert.ToString(gvMunicipio.GetRowCellValue(indice, "idContacto"));
            municipiosBindingSource.DataSource = new Municipios().Delete(indiceconvertido);
            municipiosBindingSource.DataSource = new Municipios().GetAll();
            gvMunicipio.BestFitColumns();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMunicipio { Text = "Nuevo municipio" }.ShowDialog();
            municipiosBindingSource.DataSource = new Municipios().GetAll();
            gvMunicipio.BestFitColumns();
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            municipiosBindingSource.DataSource = new Municipios().GetAll();
            gvMunicipio.BestFitColumns();
        }
    }
}