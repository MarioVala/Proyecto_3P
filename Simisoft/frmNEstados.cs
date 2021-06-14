using DevExpress.XtraEditors;
using SimiSoft.BML;
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
    public partial class frmNEstados : DevExpress.XtraEditors.XtraForm
    {
        private int idEstado = 0;

        public frmNEstados()
        {
            InitializeComponent();
        }

        public frmNEstados(int IdEstado)
        {
            InitializeComponent();
            this.idEstado = idEstado;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(new Estado
            {
                nombreEstado = txtNombre.Text
            }.Add() > 0)
            {
                XtraMessageBox.Show("Estado almacenado correctamente", Application.ProductName, 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void frmNEstados_Load(object sender, EventArgs e)
        {
            if (idEstado > 0)
            {
                txtNombre.EditValue = new Estado { idEstado = this.idEstado }.GetById().nombreEstado;
                txtNombre.SelectAll();
                txtNombre.Focus();
            }
            
        }
    }
}