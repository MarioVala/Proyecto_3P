using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
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
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
                if (form.GetType() == typeof(frmDetalleCompras))
                {
                    form.Activate();
                    return;
                }

            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Cargando Detalles de Compras...");

            new frmDetalleCompras { MdiParent = this }.Show();

            SplashScreenManager.CloseForm();
        }

        private void btnEstados_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
                if (form.GetType() == typeof(frmEstados))
                {
                    form.Activate();
                    return;
                }

            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Cargando Estados...");
            
            new frmEstados { MdiParent = this }.Show();

            SplashScreenManager.CloseForm();
        }

        private void btnDetalleVentas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
                if (form.GetType() == typeof(frmDetalleVentas))
                {
                    form.Activate();
                    return;
                }

            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Cargando Detalles de Ventas...");

            new frmDetalleVentas { MdiParent = this }.Show();

            SplashScreenManager.CloseForm();
        }

        private void btnDetalleMovimientos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
                if (form.GetType() == typeof(frmDetalleMovimientos))
                {
                    form.Activate();
                    return;
                }

            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Cargando Detalles de Movimientos...");

            new frmDetalleMovimientos { MdiParent = this }.Show();

            SplashScreenManager.CloseForm();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
                if (form.GetType() == typeof(frmSucursales))
                {
                    form.Activate();
                    return;
                }

            SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Cargando Sucursales...");

            new frmSucursales { MdiParent = this }.Show();

            SplashScreenManager.CloseForm();
        }
    }
}