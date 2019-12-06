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
            LoadComboBox();
        }
        private void LoadComboBox()
        {
            var linq = from item in ConnectString.data.SANPHAMs
                       select item.idsanpham;
            var list = linq.ToList();
            if (list.Count > 0)
            {
                foreach (var item in list)
                {
                    cboidProduct.Properties.Items.Add(item);
                }
            }

        }
        #region Load Data vao toan bo textbox khi chon combobox
        private void loadAllData(string value)
        {
            var linq = from item in ConnectString.data.SANPHAMs
                       where item.idsanpham == value
                       select item;

            var list = linq.ToList();
            if (list.Count > 0)
            {
                txtTenSP.Text = list[0].tensanpham;
            }
        }
        #endregion
        private void cboidProduct_SelectedValueChanged(object sender, EventArgs e)
        {
            loadAllData(cboidProduct.SelectedItem.ToString());
        }
    }
}