﻿using QLDACNTT_QUANLYKHO.Employee;
using QLDACNTT_QUANLYKHO.Stock;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS_KHOHANG;
using QLDACNTT_QUANLYKHO.Report;


namespace QLDACNTT_QUANLYKHO
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public bus func = new bus();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLYKHO_DataSet.SANPHAM' table. You can move, or remove it, as needed.
            loadData();
        }

        #region Methods for form
        public void loadData()
        {
            this.gcData_Main.DataSource = func.Get_SanPham();
        }

        #endregion


        #region //Open Forms
        private void barbtnProductManager_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmProduct product = new frmProduct();
            product.Show();
        }

        private void barbtnProviderManager_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmProvider provider = new frmProvider();
            provider.Show();
        }

        private void barbtnExitApplication_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void barbtnEmployee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmEmployee employee = new frmEmployee();
            employee.ShowDialog();
        }

        private void barbtnStock_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmStock stock = new frmStock();
            stock.ShowDialog();
        }

        private void barbtnQLNhapkho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmStockReceipt stockReceipt = new frmStockReceipt();
            stockReceipt.ShowDialog();
        }

        private void barbtnQLXuatkho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmStockIssue stockIssue = new frmStockIssue();
            stockIssue.ShowDialog();
        }

        private void barbtnKiemkekho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmStockChecking stockChecking = new frmStockChecking();
            stockChecking.ShowDialog();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmInput input = new frmInput();
            input.ShowDialog();
        }
        #endregion

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Reportfrm reportfrm = new Reportfrm();
            reportfrm.ShowDialog();
            
        }
    }
}
