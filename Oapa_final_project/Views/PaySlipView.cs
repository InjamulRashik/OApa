﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oapa_final_project.Views
{
    public partial class PaySlipView : Form
    {
        public PaySlipView()
        {
            InitializeComponent();
        }

        private void richTextBoxPaymentSlip_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelDate_Click(object sender, EventArgs e)
        {

        }

        private void PaySlipView_Load(object sender, EventArgs e)
        {
            labelMin.Text = QRView.passValueMin;
            labelSec.Text = QRView.passValueSec;
        }
    }
}
