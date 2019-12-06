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
    
    public partial class frmStockReceipt : DevExpress.XtraEditors.XtraForm
    {
        
        public frmStockReceipt()
        {
            InitializeComponent();

        }

        private void resourcesComboBoxControl1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }


        private void frmStockReceipt_Load(object sender, EventArgs e)
        {
            LoadComboBox();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    cbo_idProduct.Properties.Items.Add(item);
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
                txtName.Text=list[0].tensanpham;
                txtDongia.Text = list[0].dongia.ToString();
                //txtThanhtien.Text = list[0].idsanpham;
                foreach (var item in list)
                {
                    cboProvider.Properties.Items.Add(item.nhacungcap);
                }
            }
        }

        #endregion

        private void cbo_idProduct_SizeChanged(object sender, EventArgs e)
        {

        }

        private void cbo_idProduct_SelectedValueChanged(object sender, EventArgs e)
        {
            loadAllData(cbo_idProduct.SelectedItem.ToString());
        }

        private void txtThanhtien_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}