using DevExpress.XtraEditors;
using SimiSoft.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simisoft
{
    public partial class frmNProveedor : DevExpress.XtraEditors.XtraForm
    {

        public static string datosServer = "Server=DESKTOP-2R4CM0U;Database=simisoftdb;Trusted_Connection=True";
        SqlConnection Conexion = new SqlConnection(datosServer);

        private DataAccess dataAccess = DataAccess.Instance();

        public frmNProveedor()
        {
            InitializeComponent();
            llenarCombo();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void cbContactos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void llenarCombo()
        {


            Conexion.Open();

            SqlCommand cmd = new SqlCommand("SELECT idContacto, tipoC FROM dbo.Contactos", Conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            Conexion.Close();

            DataRow fila = dt.NewRow();
            fila["tipoC"] = "Por favor selecciona un Contacto";
            dt.Rows.InsertAt(fila, 0);

            cbContactos.ValueMember = "tipoC";
            cbContactos.DisplayMember = "tipoC";
            cbContactos.DataSource = dt;

        }

        private void frmNProveedor_Load(object sender, EventArgs e)
        {

        }
    }
}