
namespace Simisoft
{
    partial class frmDetalleCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetalleCompras));
            this.bManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnActualizar = new DevExpress.XtraBars.BarButtonItem();
            this.btnNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.btnModificar = new DevExpress.XtraBars.BarButtonItem();
            this.btnEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gcDetalleCompras = new DevExpress.XtraGrid.GridControl();
            this.detalleCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvDetalleCompras = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidDetalleCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimporteTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimporteNeto = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDetalleCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleCompraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalleCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // bManager
            // 
            this.bManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.bManager.DockControls.Add(this.barDockControlTop);
            this.bManager.DockControls.Add(this.barDockControlBottom);
            this.bManager.DockControls.Add(this.barDockControlLeft);
            this.bManager.DockControls.Add(this.barDockControlRight);
            this.bManager.Form = this;
            this.bManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnActualizar,
            this.btnNuevo,
            this.btnModificar,
            this.btnEliminar});
            this.bManager.MaxItemId = 4;
            // 
            // bar1
            // 
            this.bar1.BarName = "Herramientas";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnActualizar),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNuevo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnModificar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEliminar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.Text = "Herramientas";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Caption = "Actualizar";
            this.btnActualizar.Id = 0;
            this.btnActualizar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnActualizar.ImageOptions.SvgImage")));
            this.btnActualizar.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnActualizar_ItemClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Caption = "Nuevo";
            this.btnNuevo.Id = 1;
            this.btnNuevo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNuevo.ImageOptions.SvgImage")));
            this.btnNuevo.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNuevo_ItemClick);
            // 
            // btnModificar
            // 
            this.btnModificar.Caption = "Modificar";
            this.btnModificar.Id = 2;
            this.btnModificar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnModificar.ImageOptions.SvgImage")));
            this.btnModificar.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnModificar_ItemClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Caption = "Eliminar";
            this.btnEliminar.Id = 3;
            this.btnEliminar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEliminar.ImageOptions.SvgImage")));
            this.btnEliminar.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.btnEliminar.Name = "btnEliminar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.bManager;
            this.barDockControlTop.Size = new System.Drawing.Size(798, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 560);
            this.barDockControlBottom.Manager = this.bManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(798, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.bManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 530);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(798, 30);
            this.barDockControlRight.Manager = this.bManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 530);
            // 
            // gcDetalleCompras
            // 
            this.gcDetalleCompras.DataSource = this.detalleCompraBindingSource;
            this.gcDetalleCompras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDetalleCompras.Location = new System.Drawing.Point(0, 30);
            this.gcDetalleCompras.MainView = this.gvDetalleCompras;
            this.gcDetalleCompras.MenuManager = this.bManager;
            this.gcDetalleCompras.Name = "gcDetalleCompras";
            this.gcDetalleCompras.Size = new System.Drawing.Size(798, 530);
            this.gcDetalleCompras.TabIndex = 4;
            this.gcDetalleCompras.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDetalleCompras});
            // 
            // detalleCompraBindingSource
            // 
            this.detalleCompraBindingSource.DataSource = typeof(SimiSoft.BML.detalleCompra);
            // 
            // gvDetalleCompras
            // 
            this.gvDetalleCompras.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidDetalleCompra,
            this.colidCompra,
            this.colidProducto,
            this.colcantidad,
            this.colcosto,
            this.coldescuento,
            this.colimporteTotal,
            this.colimporteNeto});
            this.gvDetalleCompras.GridControl = this.gcDetalleCompras;
            this.gvDetalleCompras.Name = "gvDetalleCompras";
            this.gvDetalleCompras.OptionsBehavior.Editable = false;
            this.gvDetalleCompras.OptionsView.ColumnAutoWidth = false;
            this.gvDetalleCompras.OptionsView.EnableAppearanceEvenRow = true;
            this.gvDetalleCompras.OptionsView.ShowAutoFilterRow = true;
            this.gvDetalleCompras.OptionsView.ShowGroupPanel = false;
            // 
            // colidDetalleCompra
            // 
            this.colidDetalleCompra.Caption = "IDDetalleCompra";
            this.colidDetalleCompra.FieldName = "idDetalleCompra";
            this.colidDetalleCompra.MinWidth = 25;
            this.colidDetalleCompra.Name = "colidDetalleCompra";
            this.colidDetalleCompra.Visible = true;
            this.colidDetalleCompra.VisibleIndex = 0;
            this.colidDetalleCompra.Width = 94;
            // 
            // colidCompra
            // 
            this.colidCompra.Caption = "IDCompra";
            this.colidCompra.FieldName = "idCompra";
            this.colidCompra.MinWidth = 25;
            this.colidCompra.Name = "colidCompra";
            this.colidCompra.Visible = true;
            this.colidCompra.VisibleIndex = 1;
            this.colidCompra.Width = 94;
            // 
            // colidProducto
            // 
            this.colidProducto.Caption = "IDProducto";
            this.colidProducto.FieldName = "idProducto";
            this.colidProducto.MinWidth = 25;
            this.colidProducto.Name = "colidProducto";
            this.colidProducto.Visible = true;
            this.colidProducto.VisibleIndex = 2;
            this.colidProducto.Width = 94;
            // 
            // colcantidad
            // 
            this.colcantidad.Caption = "Cantidad";
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.MinWidth = 25;
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 3;
            this.colcantidad.Width = 94;
            // 
            // colcosto
            // 
            this.colcosto.Caption = "Costo";
            this.colcosto.FieldName = "costo";
            this.colcosto.MinWidth = 25;
            this.colcosto.Name = "colcosto";
            this.colcosto.Visible = true;
            this.colcosto.VisibleIndex = 4;
            this.colcosto.Width = 94;
            // 
            // coldescuento
            // 
            this.coldescuento.Caption = "Descuento";
            this.coldescuento.FieldName = "descuento";
            this.coldescuento.MinWidth = 25;
            this.coldescuento.Name = "coldescuento";
            this.coldescuento.Visible = true;
            this.coldescuento.VisibleIndex = 5;
            this.coldescuento.Width = 94;
            // 
            // colimporteTotal
            // 
            this.colimporteTotal.Caption = "ImporteTotal";
            this.colimporteTotal.FieldName = "importeTotal";
            this.colimporteTotal.MinWidth = 25;
            this.colimporteTotal.Name = "colimporteTotal";
            this.colimporteTotal.Visible = true;
            this.colimporteTotal.VisibleIndex = 6;
            this.colimporteTotal.Width = 94;
            // 
            // colimporteNeto
            // 
            this.colimporteNeto.Caption = "ImporteNeto";
            this.colimporteNeto.FieldName = "importeNeto";
            this.colimporteNeto.MinWidth = 25;
            this.colimporteNeto.Name = "colimporteNeto";
            this.colimporteNeto.Visible = true;
            this.colimporteNeto.VisibleIndex = 7;
            this.colimporteNeto.Width = 94;
            // 
            // frmDetalleCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 560);
            this.Controls.Add(this.gcDetalleCompras);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmDetalleCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Detalles de Compras";
            this.Load += new System.EventHandler(this.frmDetalleCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDetalleCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleCompraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalleCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager bManager;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnActualizar;
        private DevExpress.XtraBars.BarButtonItem btnNuevo;
        private DevExpress.XtraBars.BarButtonItem btnModificar;
        private DevExpress.XtraBars.BarButtonItem btnEliminar;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gcDetalleCompras;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDetalleCompras;
        private System.Windows.Forms.BindingSource detalleCompraBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colidDetalleCompra;
        private DevExpress.XtraGrid.Columns.GridColumn colidCompra;
        private DevExpress.XtraGrid.Columns.GridColumn colidProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colcosto;
        private DevExpress.XtraGrid.Columns.GridColumn coldescuento;
        private DevExpress.XtraGrid.Columns.GridColumn colimporteTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colimporteNeto;
    }
}