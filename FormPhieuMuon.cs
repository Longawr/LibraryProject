﻿using LibraryProject.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject
{
    public partial class FormPhieuMuon : Form
    {
        public FormPhieuMuon()
        {
            InitializeComponent();
        }

        private void FormPhieuMuon_Load(object sender, EventArgs e)
        {

            PhieuMuonBUS.Instance.XemPhieuMuon(dgvPhieuMuon);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
    }
}
