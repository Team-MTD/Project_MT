using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace QLDACNTT_QUANLYKHO
{
    public partial class frmStockIssue : DevExpress.XtraEditors.XtraForm
    {
        public frmStockIssue()
        {
            InitializeComponent();
        }
       
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmStockIssue_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLKHODataSet.SANPHAM' table. You can move, or remove it, as needed.
           
            
        }
    }
}