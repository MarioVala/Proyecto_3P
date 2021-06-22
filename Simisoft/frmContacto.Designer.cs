
namespace Simisoft
{
    partial class frmContacto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContacto));
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
            this.gcContacto = new DevExpress.XtraGrid.GridControl();
            this.contactoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvContacto = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidContacto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colentidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcomuna = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigoPostal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcContacto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvContacto)).BeginInit();
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnActualizar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNuevo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnModificar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEliminar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Offset = 1;
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
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
            // gcContacto
            // 
            this.gcContacto.DataSource = this.contactoBindingSource;
            this.gcContacto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcContacto.Location = new System.Drawing.Point(0, 24);
            this.gcContacto.MainView = this.gvContacto;
            this.gcContacto.MenuManager = this.barManager1;
            this.gcContacto.Name = "gcContacto";
            this.gcContacto.Size = new System.Drawing.Size(696, 337);
            this.gcContacto.TabIndex = 4;
            this.gcContacto.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvContacto});
            // 
            // contactoBindingSource
            // 
            this.contactoBindingSource.DataSource = typeof(SimiSoft.BML.Contacto);
            // 
            // gvContacto
            // 
            this.gvContacto.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidContacto,
            this.colentidad,
            this.colcomuna,
            this.colcalle,
            this.colcodigoPostal,
            this.coltelefono});
            this.gvContacto.GridControl = this.gcContacto;
            this.gvContacto.Name = "gvContacto";
            // 
            // colidContacto
            // 
            this.colidContacto.Caption = "colidContacto";
            this.colidContacto.FieldName = "ID";
            this.colidContacto.Name = "colidContacto";
            this.colidContacto.Visible = true;
            this.colidContacto.VisibleIndex = 0;
            // 
            // colentidad
            // 
            this.colentidad.FieldName = "Entidad";
            this.colentidad.Name = "colentidad";
            this.colentidad.Visible = true;
            this.colentidad.VisibleIndex = 1;
            // 
            // colcomuna
            // 
            this.colcomuna.FieldName = "Comuna";
            this.colcomuna.Name = "colcomuna";
            this.colcomuna.Visible = true;
            this.colcomuna.VisibleIndex = 2;
            // 
            // colcalle
            // 
            this.colcalle.FieldName = "Calle";
            this.colcalle.Name = "colcalle";
            this.colcalle.Visible = true;
            this.colcalle.VisibleIndex = 3;
            // 
            // colcodigoPostal
            // 
            this.colcodigoPostal.FieldName = "Codigo Postal";
            this.colcodigoPostal.Name = "colcodigoPostal";
            this.colcodigoPostal.Visible = true;
            this.colcodigoPostal.VisibleIndex = 4;
            // 
            // coltelefono
            // 
            this.coltelefono.FieldName = "Teléfono";
            this.coltelefono.Name = "coltelefono";
            this.coltelefono.Visible = true;
            this.coltelefono.VisibleIndex = 5;
            // 
            // frmContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 361);
            this.Controls.Add(this.gcContacto);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmContacto";
            this.Text = "frmContacto";
            this.Load += new System.EventHandler(this.frmContacto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcContacto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvContacto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private DevExpress.XtraGrid.GridControl gcContacto;
        private System.Windows.Forms.BindingSource contactoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvContacto;
        private DevExpress.XtraGrid.Columns.GridColumn colidContacto;
        private DevExpress.XtraGrid.Columns.GridColumn colentidad;
        private DevExpress.XtraGrid.Columns.GridColumn colcomuna;
        private DevExpress.XtraGrid.Columns.GridColumn colcalle;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigoPostal;
        private DevExpress.XtraGrid.Columns.GridColumn coltelefono;
    }
}