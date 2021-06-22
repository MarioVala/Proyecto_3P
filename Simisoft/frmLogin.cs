using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Simisoft
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("server=DESKTOP-21KVI4D; database=simisoftdb; integrated security=True");
            cn.Open();
            SqlCommand cm=new SqlCommand("select Nombre,Clave from Login where Nombre='" + txtUsuario.Text + "'and Clave='" + txtContraseña.Text + "'", cn);

            SqlDataReader dr = cm.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Login Exitoso", "Sistema");
                frmMain abrir = new frmMain();
                abrir.ShowDialog();
            }
            else {
                MessageBox.Show("El nombre o la contraseña no existen");
            }
        }
    }
}