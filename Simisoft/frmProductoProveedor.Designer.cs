
namespace Simisoft
{
    partial class frmProductoProveedor
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnActualizar = new DevExpress.XtraBars.BarButtonItem();
            this.btnNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.btnModificar = new DevExpress.XtraBars.BarButtonItem();
            this.btnEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.gcProductoProveedor = new DevExpress.XtraGrid.GridControl();
            this.gvProductoProveedor = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.productoProveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colidproductoProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProductoProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductoProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoProveedoresBindingSource)).BeginInit();
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
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(640, 25);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 521);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(640, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 25);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 496);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(640, 25);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 496);
            // 
            // bar1
            // 
            this.bar1.BarName = "Herramientas";
            this.bar1.DockCol = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnActualizar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNuevo),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnModificar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEliminar)});
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.Text = "Herramientas";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Caption = "Actualizar";
            this.btnActualizar.Id = 0;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnActualizar_ItemClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Caption = "Nuevo";
            this.btnNuevo.Id = 1;
            this.btnNuevo.Name = "btnNuevo";
            // 
            // btnModificar
            // 
            this.btnModificar.Caption = "Modificar";
            this.btnModificar.Id = 2;
            this.btnModificar.Name = "btnModificar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Caption = "Eliminar";
            this.btnEliminar.Id = 3;
            this.btnEliminar.Name = "btnEliminar";
            // 
            // gcProductoProveedor
            // 
            this.gcProductoProveedor.DataSource = this.productoProveedoresBindingSource;
            this.gcProductoProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcProductoProveedor.Location = new System.Drawing.Point(0, 25);
            this.gcProductoProveedor.MainView = this.gvProductoProveedor;
            this.gcProductoProveedor.MenuManager = this.barManager1;
            this.gcProductoProveedor.Name = "gcProductoProveedor";
            this.gcProductoProveedor.Size = new System.Drawing.Size(640, 496);
            this.gcProductoProveedor.TabIndex = 4;
            this.gcProductoProveedor.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProductoProveedor});
            this.gcProductoProveedor.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gvProductoProveedor
            // 
            this.gvProductoProveedor.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidproductoProveedor,
            this.colidProveedor,
            this.colidProducto});
            this.gvProductoProveedor.GridControl = this.gcProductoProveedor;
            this.gvProductoProveedor.Name = "gvProductoProveedor";
            // 
            // productoProveedoresBindingSource
            // 
            this.productoProveedoresBindingSource.DataSource = typeof(SimiSoft.BML.productoProveedores);
            // 
            // colidproductoProveedor
            // 
            this.colidproductoProveedor.FieldName = "IDPP";
            this.colidproductoProveedor.MinWidth = 25;
            this.colidproductoProveedor.Name = "colidproductoProveedor";
            this.colidproductoProveedor.Visible = true;
            this.colidproductoProveedor.VisibleIndex = 0;
            this.colidproductoProveedor.Width = 94;
            // 
            // colidProveedor
            // 
            this.colidProveedor.FieldName = "Proveedor";
            this.colidProveedor.MinWidth = 25;
            this.colidProveedor.Name = "colidProveedor";
            this.colidProveedor.Visible = true;
            this.colidProveedor.VisibleIndex = 1;
            this.colidProveedor.Width = 94;
            // 
            // colidProducto
            // 
            this.colidProducto.FieldName = "Producto";
            this.colidProducto.MinWidth = 25;
            this.colidProducto.Name = "colidProducto";
            this.colidProducto.Visible = true;
            this.colidProducto.VisibleIndex = 2;
            this.colidProducto.Width = 94;
            // 
            // frmProductoProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 521);
            this.Controls.Add(this.gcProductoProveedor);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmProductoProveedor";
            this.Text = "frmProductoProveedor";
            this.Load += new System.EventHandler(this.frmProductoProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProductoProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductoProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoProveedoresBindingSource)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gcProductoProveedor;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProductoProveedor;
        private System.Windows.Forms.BindingSource productoProveedoresBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colidproductoProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colidProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colidProducto;
    }
}