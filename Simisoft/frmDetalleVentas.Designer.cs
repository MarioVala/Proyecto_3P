
namespace Simisoft
{
    partial class frmDetalleVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetalleVentas));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnActualizar = new DevExpress.XtraBars.BarButtonItem();
            this.btnNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.btnModificar = new DevExpress.XtraBars.BarButtonItem();
            this.btnEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gcDetalleVentas = new DevExpress.XtraGrid.GridControl();
            this.detalleVentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvDetalleVentas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidDetalleVenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidVenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimporteTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimporteNeto = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDetalleVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalleVentas)).BeginInit();
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
            this.btnActualizar,
            this.btnNuevo,
            this.btnModificar,
            this.btnEliminar});
            this.barManager1.MaxItemId = 4;
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
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(798, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 560);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(798, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 530);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(798, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 530);
            // 
            // gcDetalleVentas
            // 
            this.gcDetalleVentas.DataSource = this.detalleVentasBindingSource;
            this.gcDetalleVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDetalleVentas.Location = new System.Drawing.Point(0, 30);
            this.gcDetalleVentas.MainView = this.gvDetalleVentas;
            this.gcDetalleVentas.MenuManager = this.barManager1;
            this.gcDetalleVentas.Name = "gcDetalleVentas";
            this.gcDetalleVentas.Size = new System.Drawing.Size(798, 530);
            this.gcDetalleVentas.TabIndex = 4;
            this.gcDetalleVentas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDetalleVentas});
            // 
            // detalleVentasBindingSource
            // 
            this.detalleVentasBindingSource.DataSource = typeof(SimiSoft.BML.detalleVentas);
            // 
            // gvDetalleVentas
            // 
            this.gvDetalleVentas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidDetalleVenta,
            this.colidVenta,
            this.colidProducto,
            this.colcantidad,
            this.colprecio,
            this.coldescuento,
            this.colimporteTotal,
            this.colimporteNeto});
            this.gvDetalleVentas.GridControl = this.gcDetalleVentas;
            this.gvDetalleVentas.Name = "gvDetalleVentas";
            this.gvDetalleVentas.OptionsBehavior.Editable = false;
            this.gvDetalleVentas.OptionsView.ColumnAutoWidth = false;
            this.gvDetalleVentas.OptionsView.EnableAppearanceEvenRow = true;
            this.gvDetalleVentas.OptionsView.ShowAutoFilterRow = true;
            this.gvDetalleVentas.OptionsView.ShowGroupPanel = false;
            // 
            // colidDetalleVenta
            // 
            this.colidDetalleVenta.Caption = "IDDetalleVenta";
            this.colidDetalleVenta.FieldName = "idDetalleVenta";
            this.colidDetalleVenta.MinWidth = 25;
            this.colidDetalleVenta.Name = "colidDetalleVenta";
            this.colidDetalleVenta.Visible = true;
            this.colidDetalleVenta.VisibleIndex = 0;
            this.colidDetalleVenta.Width = 94;
            // 
            // colidVenta
            // 
            this.colidVenta.Caption = "ID Venta";
            this.colidVenta.FieldName = "idVenta";
            this.colidVenta.MinWidth = 25;
            this.colidVenta.Name = "colidVenta";
            this.colidVenta.Visible = true;
            this.colidVenta.VisibleIndex = 1;
            this.colidVenta.Width = 94;
            // 
            // colidProducto
            // 
            this.colidProducto.Caption = "ID Producto";
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
            // colprecio
            // 
            this.colprecio.Caption = "Precio";
            this.colprecio.FieldName = "precio";
            this.colprecio.MinWidth = 25;
            this.colprecio.Name = "colprecio";
            this.colprecio.Visible = true;
            this.colprecio.VisibleIndex = 4;
            this.colprecio.Width = 94;
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
            this.colimporteNeto.Caption = "Importe Neto";
            this.colimporteNeto.FieldName = "importeNeto";
            this.colimporteNeto.MinWidth = 25;
            this.colimporteNeto.Name = "colimporteNeto";
            this.colimporteNeto.Visible = true;
            this.colimporteNeto.VisibleIndex = 7;
            this.colimporteNeto.Width = 94;
            // 
            // frmDetalleVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 560);
            this.Controls.Add(this.gcDetalleVentas);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmDetalleVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles de ventas";
            this.Load += new System.EventHandler(this.frmDetalleVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDetalleVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalleVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnActualizar;
        private DevExpress.XtraBars.BarButtonItem btnNuevo;
        private DevExpress.XtraBars.BarButtonItem btnModificar;
        private DevExpress.XtraBars.BarButtonItem btnEliminar;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gcDetalleVentas;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDetalleVentas;
        private System.Windows.Forms.BindingSource detalleVentasBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colidDetalleVenta;
        private DevExpress.XtraGrid.Columns.GridColumn colidVenta;
        private DevExpress.XtraGrid.Columns.GridColumn colidProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colprecio;
        private DevExpress.XtraGrid.Columns.GridColumn coldescuento;
        private DevExpress.XtraGrid.Columns.GridColumn colimporteTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colimporteNeto;
    }
}