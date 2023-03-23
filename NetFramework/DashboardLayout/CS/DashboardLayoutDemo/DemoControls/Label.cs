﻿using C1.Win.C1Input;

namespace DashboardLayoutDemo.Controls
{
    public class DemoLabel : C1Label, IDemo
    {
        public void Init()
        {
            DataSource = SampleHelper.Instance.GetSourceTable("Total Sales", Properties.Resources.TotalSales);
            DataField = "Sales";
        }
    }
}
