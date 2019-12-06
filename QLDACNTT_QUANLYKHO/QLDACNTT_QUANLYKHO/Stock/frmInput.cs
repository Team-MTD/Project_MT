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

namespace QLDACNTT_QUANLYKHO.Stock
{
    public partial class frmInput : DevExpress.XtraEditors.XtraForm
    {
        public frmInput()
        {
            InitializeComponent();
        }

        private void frmInput_Load(object sender, EventArgs e)
        {
            loadcombo();
            loadDataToGridView();

        }

        private void loadcombo()
        {
            var linq = from item in ConnectString.data.SANPHAMs
                      select item.tensanpham;
            var list = linq.ToList();
            if (list.Count > 0)
            {
                foreach (var item in list)
                {
                    comboname.Properties.Items.Add(item);
                }
            }
        }
        private void loadAllDataToTextBox(string value)
        {
            var linq = from item in ConnectString.data.SANPHAMs
                       where item.tensanpham == value
                       select item;
            var list = linq.ToList();
            if (list.Count > 0)
            {
                txtidproduct.Text = list[0].idsanpham;
                
            }
        }
        private void loadDataToGridView()
        {
            
            var linq = from kiemke in ConnectString.data.KIEMKEs
                       join sanpham in ConnectString.data.SANPHAMs
                      on kiemke.idsanpham equals sanpham.idsanpham into g
                       from d in g.DefaultIfEmpty()
                       orderby d.idsanpham
                       select new
                       {
                           id = kiemke.idsanpham,
                           name = d.tensanpham,
                           soluong=kiemke.soluongtonkho
                       };
            var x = linq.ToList();
            gcdatasodu.DataSource = x;
            
        }

        private void comboname_SelectedValueChanged(object sender, EventArgs e)
        {
            loadAllDataToTextBox(comboname.SelectedItem.ToString());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            add();
        }
        private bool add()
        {

            KIEMKE kiemke = new KIEMKE
            {
                idphieukiemke = Guid.NewGuid().ToString(),
                idsanpham = txtidproduct.Text,
                ngaykiemke = DateTime.Today,
                soluongtonkho = Convert.ToInt32(txtvalue.Text),
            };
            ConnectString.data.KIEMKEs.InsertOnSubmit(kiemke);
            try
            {
                ConnectString.data.SubmitChanges();
                MessageBox.Show("Cap nhat hang ton thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                gcdatasodu.DataSource = null;
                loadDataToGridView();
                return true;
            }
            catch
            {
                
            }

            return false;
        }

        private void gcdatasodu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
