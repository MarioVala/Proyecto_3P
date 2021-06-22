
namespace Simisoft
{
    partial class frmMunicipio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMunicipio));
            this.gcMunicipio = new DevExpress.XtraGrid.GridControl();
            this.municipiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvMunicipio = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidMunicipio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombreMunicipio = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.gcMunicipio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipiosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMunicipio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcMunicipio
            // 
            this.gcMunicipio.DataSource = this.municipiosBindingSource;
            this.gcMunicipio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcMunicipio.Location = new System.Drawing.Point(0, 24);
            this.gcMunicipio.MainView = this.gvMunicipio;
            this.gcMunicipio.Name = "gcMunicipio";
            this.gcMunicipio.Size = new System.Drawing.Size(696, 337);
            this.gcMunicipio.TabIndex = 0;
            this.gcMunicipio.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMunicipio});
            this.gcMunicipio.Click += new System.EventHandler(this.gcMunicipio_Click);
            // 
            // municipiosBindingSource
            // 
            this.municipiosBindingSource.DataSource = typeof(SimiSoft.BML.Municipios);
            // 
            // gvMunicipio
            // 
            this.gvMunicipio.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidMunicipio,
            this.colidEstado,
            this.colnombreMunicipio});
            this.gvMunicipio.GridControl = this.gcMunicipio;
            this.gvMunicipio.Name = "gvMunicipio";
            // 
            // colidMunicipio
            // 
            this.colidMunicipio.Caption = "colidMunicipio";
            this.colidMunicipio.FieldName = "ID:";
            this.colidMunicipio.Name = "colidMunicipio";
            this.colidMunicipio.Visible = true;
            this.colidMunicipio.VisibleIndex = 0;
            // 
            // colidEstado
            // 
            this.colidEstado.FieldName = "Estado ID:";
            this.colidEstado.Name = "colidEstado";
            this.colidEstado.Visible = true;
            this.colidEstado.VisibleIndex = 1;
            // 
            // colnombreMunicipio
            // 
            this.colnombreMunicipio.FieldName = "Nombre del Municipio";
            this.colnombreMunicipio.Name = "colnombreMunicipio";
            this.colnombreMunicipio.Visible = true;
            this.colnombreMunicipio.VisibleIndex = 2;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnActualizar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNuevo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnModificar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEliminar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Offset = 9;
            this.bar1.Text = "Herramientas";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Caption = "Actualizar";
            this.btnActualizar.Id = 0;
            this.btnActualizar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.ImageOptions.Image")));
            this.btnActualizar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnActualizar.ImageOptions.LargeImage")));
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnActualizar_ItemClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Caption = "Nuevo";
            this.btnNuevo.Id = 1;
            this.btnNuevo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.ImageOptions.Image")));
            this.btnNuevo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.ImageOptions.LargeImage")));
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNuevo_ItemClick);
            // 
            // btnModificar
            // 
            this.btnModificar.Caption = "Modificar";
            this.btnModificar.Id = 2;
            this.btnModificar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.ImageOptions.Image")));
            this.btnModificar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnModificar.ImageOptions.LargeImage")));
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnModificar_ItemClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Caption = "Eliminar";
            this.btnEliminar.Id = 3;
            this.btnEliminar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.ImageOptions.Image")));
            this.btnEliminar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.ImageOptions.LargeImage")));
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEliminar_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(696, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 361);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(696, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 337);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(696, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 337);
            // 
            // frmMunicipio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 361);
            this.Controls.Add(this.gcMunicipio);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmMunicipio";
            this.Text = "frmMunicipio";
            ((System.ComponentModel.ISupportInitialize)(this.gcMunicipio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipiosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMunicipio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcMunicipio;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMunicipio;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnActualizar;
        private DevExpress.XtraBars.BarButtonItem btnNuevo;
        private DevExpress.XtraBars.BarButtonItem btnModificar;
        private DevExpress.XtraBars.BarButtonItem btnEliminar;
        private System.Windows.Forms.BindingSource municipiosBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colidMunicipio;
        private DevExpress.XtraGrid.Columns.GridColumn colidEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colnombreMunicipio;
    }
}