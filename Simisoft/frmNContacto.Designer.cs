
namespace Simisoft
{
    partial class frmNContacto
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.txtTelefono = new DevExpress.XtraEditors.TextEdit();
            this.txtcodigoPostal = new DevExpress.XtraEditors.TextEdit();
            this.txtCalle = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtComuna = new DevExpress.XtraEditors.TextEdit();
            this.txtEntidad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcodigoPostal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCalle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComuna.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEntidad.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.btnCancelar);
            this.groupControl1.Controls.Add(this.btnGuardar);
            this.groupControl1.Controls.Add(this.txtTelefono);
            this.groupControl1.Controls.Add(this.txtcodigoPostal);
            this.groupControl1.Controls.Add(this.txtCalle);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtComuna);
            this.groupControl1.Controls.Add(this.txtEntidad);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(251, 251);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(164, 208);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(25, 208);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(91, 159);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(132, 20);
            this.txtTelefono.TabIndex = 11;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtcodigoPostal
            // 
            this.txtcodigoPostal.Location = new System.Drawing.Point(91, 123);
            this.txtcodigoPostal.Name = "txtcodigoPostal";
            this.txtcodigoPostal.Size = new System.Drawing.Size(132, 20);
            this.txtcodigoPostal.TabIndex = 10;
            this.txtcodigoPostal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigoPostal_KeyPress);
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(63, 83);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(160, 20);
            this.txtCalle.TabIndex = 9;
            this.txtCalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCalle_KeyPress);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(5, 162);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(46, 13);
            this.labelControl6.TabIndex = 8;
            this.labelControl6.Text = "Teléfono:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(5, 126);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(69, 13);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "Codigo Postal:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(5, 90);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(27, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Calle:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(5, 55);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(43, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Comuna:";
            // 
            // txtComuna
            // 
            this.txtComuna.Location = new System.Drawing.Point(63, 52);
            this.txtComuna.Name = "txtComuna";
            this.txtComuna.Size = new System.Drawing.Size(160, 20);
            this.txtComuna.TabIndex = 4;
            this.txtComuna.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtComuna_KeyPress);
            // 
            // txtEntidad
            // 
            this.txtEntidad.Location = new System.Drawing.Point(63, 5);
            this.txtEntidad.Name = "txtEntidad";
            this.txtEntidad.Size = new System.Drawing.Size(160, 20);
            this.txtEntidad.TabIndex = 3;
            this.txtEntidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEntidad_KeyPress);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 8);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Entidad:";
            // 
            // frmNContacto
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(275, 275);
            this.Controls.Add(this.groupControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNContacto";
            this.Text = "frmNContacto";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcodigoPostal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCalle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComuna.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEntidad.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.TextEdit txtTelefono;
        private DevExpress.XtraEditors.TextEdit txtcodigoPostal;
        private DevExpress.XtraEditors.TextEdit txtCalle;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtComuna;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtEntidad;
    }
}