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
using BUS_KHOHANG;


namespace QLDACNTT_QUANLYKHO.Report
{
    public partial class Reportfrm : DevExpress.XtraEditors.XtraForm
    {
        bus bus = new bus();
        public Reportfrm()
        {
            InitializeComponent();
            Load_Data();
        }
        #region // Methods of Form
        public void Load_Data()
        {
            gcData_Export.DataSource = bus.Get_KiemKe();
        }
        #endregion


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string Filename = @"C:\Users\phamh\Desktop\test.xlsx";
                gcData_Export.ExportToXlsx(Filename);
                this.Hide();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}