﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace BaoCao_PTTKHT.GUI
{
    public partial class FmQuanLySinhVien : DevComponents.DotNetBar.Metro.MetroForm
    {
        /*
         * YÊU CẦU: tìm sv      -> group sinh viên không được bỏ trống
         *          tìm lớp học -> group lớp học k được bỏ trống
         * LƯU Ý: Khi ở tap sv: mở 2 group
         *        Khi ở tap lớp đóng tap sv
         */
        public FmQuanLySinhVien()
        {
            InitializeComponent();
        }

        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FmQuanLySinhVien_Load(object sender, EventArgs e)
        {

        }

        private void cbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            String temp = cbNam.Text.Substring(2, 2);
            temp += tbMSSV.Text.Substring(2, tbMSSV.Text.Length - 2);
            tbMSSV.Text = temp;
        }
    }
}