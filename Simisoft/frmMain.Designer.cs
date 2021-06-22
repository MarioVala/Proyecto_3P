
namespace Simisoft
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.mnArchivo = new DevExpress.XtraBars.BarSubItem();
            this.btnSalir = new DevExpress.XtraBars.BarButtonItem();
            this.mnCategorias = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.btnEstados = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.btnDetalleCompras = new DevExpress.XtraBars.BarButtonItem();
            this.btnDetalleVentas = new DevExpress.XtraBars.BarButtonItem();
            this.btnDetalleMovimientos = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.btnMunicipio = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
            this.btnContacto = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.tabMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabMdiManager)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.mnCategorias,
            this.mnArchivo,
            this.btnSalir,
            this.btnEstados,
            this.btnDetalleCompras,
            this.btnDetalleVentas,
            this.btnDetalleMovimientos,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barButtonItem8,
            this.barButtonItem9,
            this.barButtonItem10,
            this.barButtonItem11,
            this.barButtonItem12,
            this.barButtonItem13,
            this.btnContacto,
            this.btnMunicipio});
            this.barManager1.MaxItemId = 22;
            // 
            // bar1
            // 
            this.bar1.BarName = "Herramientas";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.mnArchivo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.mnCategorias, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.Text = "Herramientas";
            // 
            // mnArchivo
            // 
            this.mnArchivo.Caption = "Archivo";
            this.mnArchivo.Id = 2;
            this.mnArchivo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnArchivo.ImageOptions.Image")));
            this.mnArchivo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("mnArchivo.ImageOptions.LargeImage")));
            this.mnArchivo.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSalir)});
            this.mnArchivo.Name = "mnArchivo";
            // 
            // btnSalir
            // 
            this.btnSalir.Caption = "Salir";
            this.btnSalir.Id = 3;
            this.btnSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.Image")));
            this.btnSalir.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.LargeImage")));
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // mnCategorias
            // 
            this.mnCategorias.Caption = "Catálogos";
            this.mnCategorias.Id = 1;
            this.mnCategorias.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnCategorias.ImageOptions.Image")));
            this.mnCategorias.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("mnCategorias.ImageOptions.LargeImage")));
            this.mnCategorias.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem5),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEstados),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem6),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDetalleCompras),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDetalleVentas),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDetalleMovimientos),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem7),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnMunicipio),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem8),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem9),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem11),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem12),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem13),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnContacto),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem10)});
            this.mnCategorias.Name = "mnCategorias";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Categoria";
            this.barButtonItem2.Id = 8;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Cliente";
            this.barButtonItem3.Id = 9;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Compra";
            this.barButtonItem4.Id = 10;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Localidad";
            this.barButtonItem5.Id = 11;
            this.barButtonItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // btnEstados
            // 
            this.btnEstados.Caption = "Estados";
            this.btnEstados.Id = 4;
            this.btnEstados.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEstados.ImageOptions.Image")));
            this.btnEstados.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEstados.ImageOptions.LargeImage")));
            this.btnEstados.Name = "btnEstados";
            this.btnEstados.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEstados_ItemClick);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Inventario";
            this.barButtonItem6.Id = 12;
            this.barButtonItem6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.Image")));
            this.barButtonItem6.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.LargeImage")));
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // btnDetalleCompras
            // 
            this.btnDetalleCompras.Caption = "Detalles de Compras";
            this.btnDetalleCompras.Id = 5;
            this.btnDetalleCompras.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDetalleCompras.ImageOptions.Image")));
            this.btnDetalleCompras.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDetalleCompras.ImageOptions.LargeImage")));
            this.btnDetalleCompras.Name = "btnDetalleCompras";
            this.btnDetalleCompras.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // btnDetalleVentas
            // 
            this.btnDetalleVentas.Caption = "Detalles de Ventas";
            this.btnDetalleVentas.Id = 6;
            this.btnDetalleVentas.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDetalleVentas.ImageOptions.Image")));
            this.btnDetalleVentas.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDetalleVentas.ImageOptions.LargeImage")));
            this.btnDetalleVentas.Name = "btnDetalleVentas";
            this.btnDetalleVentas.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDetalleVentas_ItemClick);
            // 
            // btnDetalleMovimientos
            // 
            this.btnDetalleMovimientos.Caption = "Detalles de Movimientos";
            this.btnDetalleMovimientos.Id = 7;
            this.btnDetalleMovimientos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDetalleMovimientos.ImageOptions.Image")));
            this.btnDetalleMovimientos.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDetalleMovimientos.ImageOptions.LargeImage")));
            this.btnDetalleMovimientos.Name = "btnDetalleMovimientos";
            this.btnDetalleMovimientos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDetalleMovimientos_ItemClick);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Movimiento";
            this.barButtonItem7.Id = 13;
            this.barButtonItem7.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.Image")));
            this.barButtonItem7.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.LargeImage")));
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // btnMunicipio
            // 
            this.btnMunicipio.Caption = "Municipio";
            this.btnMunicipio.Id = 21;
            this.btnMunicipio.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem15.ImageOptions.Image")));
            this.btnMunicipio.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem15.ImageOptions.LargeImage")));
            this.btnMunicipio.Name = "btnMunicipio";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Sucursal";
            this.barButtonItem8.Id = 14;
            this.barButtonItem8.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.Image")));
            this.barButtonItem8.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.LargeImage")));
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem8_ItemClick);
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Usuario";
            this.barButtonItem9.Id = 15;
            this.barButtonItem9.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.ImageOptions.Image")));
            this.barButtonItem9.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.ImageOptions.LargeImage")));
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "Producto";
            this.barButtonItem11.Id = 17;
            this.barButtonItem11.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem11.ImageOptions.Image")));
            this.barButtonItem11.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem11.ImageOptions.LargeImage")));
            this.barButtonItem11.Name = "barButtonItem11";
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Caption = "Producto-Proveedor";
            this.barButtonItem12.Id = 18;
            this.barButtonItem12.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem12.ImageOptions.Image")));
            this.barButtonItem12.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem12.ImageOptions.LargeImage")));
            this.barButtonItem12.Name = "barButtonItem12";
            // 
            // barButtonItem13
            // 
            this.barButtonItem13.Caption = "Proveedor";
            this.barButtonItem13.Id = 19;
            this.barButtonItem13.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem13.ImageOptions.Image")));
            this.barButtonItem13.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem13.ImageOptions.LargeImage")));
            this.barButtonItem13.Name = "barButtonItem13";
            // 
            // btnContacto
            // 
            this.btnContacto.Caption = "Contacto";
            this.btnContacto.Id = 20;
            this.btnContacto.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem14.ImageOptions.Image")));
            this.btnContacto.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem14.ImageOptions.LargeImage")));
            this.btnContacto.Name = "btnContacto";
            this.btnContacto.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem14_ItemClick);
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "Venta";
            this.barButtonItem10.Id = 16;
            this.barButtonItem10.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem10.ImageOptions.Image")));
            this.barButtonItem10.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem10.ImageOptions.LargeImage")));
            this.barButtonItem10.Name = "barButtonItem10";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(532, 25);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 378);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(532, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 25);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 353);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(532, 25);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 353);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Salir";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // tabMdiManager
            // 
            this.tabMdiManager.MdiParent = this;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 378);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FarmSoft - 2021";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabMdiManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarSubItem mnArchivo;
        private DevExpress.XtraBars.BarButtonItem btnSalir;
        private DevExpress.XtraBars.BarSubItem mnCategorias;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnEstados;
        private DevExpress.XtraBars.BarButtonItem btnDetalleCompras;
        private DevExpress.XtraBars.BarButtonItem btnDetalleVentas;
        private DevExpress.XtraBars.BarButtonItem btnDetalleMovimientos;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager tabMdiManager;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraBars.BarButtonItem barButtonItem13;
        private DevExpress.XtraBars.BarButtonItem btnContacto;
        private DevExpress.XtraBars.BarButtonItem btnMunicipio;
    }
}