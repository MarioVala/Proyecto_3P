using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Simisoft
{
    public partial class frmNMunicipio : DevExpress.XtraEditors.XtraForm
    {
        int idMunicipio = 0;
        public frmNMunicipio(int idMunicipio)
        {
            InitializeComponent();
            this.idMunicipio = idMunicipio;
        }

        public frmNMunicipio()
        {
            InitializeComponent();
        }
    }
}