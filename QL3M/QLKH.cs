﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Entity;

namespace QL3M
{
    public partial class QLKH : DevExpress.XtraEditors.XtraUserControl
    {
        public QLKH()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            QL3M.QL3MEntities dbContext = new QL3M.QL3MEntities();
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.Customers.Load();
            // This line of code is generated by Data Source Configuration Wizard
            grvMain.DataSource = dbContext.Customers.Local.ToBindingList();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            AddNewCus addCus = new AddNewCus(-1);
            addCus.ShowDialog();
        }
    }
}
