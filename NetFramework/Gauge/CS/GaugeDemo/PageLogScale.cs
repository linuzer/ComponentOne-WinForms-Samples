﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Gauge;

namespace GaugeDemo
{
    public partial class PageLogScale : BaseGaugePage
    {
        public PageLogScale()
        {
            InitializeComponent();
        }

        private void c1RadialGauge1_ItemMouseMove(object sender, ItemMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                C1GaugePointer p = e.Gauge.Pointer;
                p.Value = p.GetValueAt(e.X, e.Y);
            }
        }
    }
}
