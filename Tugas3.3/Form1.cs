﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas3._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var nama = txtNama.Text;
            var pendidikan = cmbPendidikan.Text;
            var pekerjaan = lstPekerjaan.Text;

            txtPesan1.Text = string.Format("Halo {0}",nama);
            txtPesan2.Text = string.Format("Pendidikan Anda {0} ya?", pendidikan);
            txtPesan3.Text = string.Format("Anda Seorang {0}, hebat!!!", pekerjaan);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
