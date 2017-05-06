﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using static EStore.EntityFrameworkTransactionsControl;

namespace EStore
{
    public partial class ManufacturersControl : UserControl
    {
        
        EStore.MainModel dbContext = new EStore.MainModel();
        public ManufacturersControl()
        {
            InitializeComponent();
            
            // Instantiate a new DBContext
            EStore.MainModel dbContext = new EStore.MainModel();
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.Manufacturers.Load();
            // This line of code is generated by Data Source Configuration Wizard
            gridControl1.DataSource = dbContext.Manufacturers.Local.ToBindingList();
            gridView1.Columns[0].Visible = false;
            gridView1.Columns[1].OptionsColumn.AllowFocus = false;
            gridView1.Columns[1].Caption = "Manufacturer name";
            gridView1.Columns[1].AppearanceHeader.Font = new Font("Tahoma", 9, FontStyle.Bold);

        }

        private void btnAddManufacturer_Click(object sender, EventArgs e)
        {
            string manufacturerName = Microsoft.VisualBasic.Interaction.
             InputBox("Please, enter the name of the manufacturer.", "Add new manufacturer");
            if (manufacturerName.Length < 3)
            {
                MessageBox.Show("Invalid manufacturer name. Manufacturer's name should be longer than 3 symbols.",
                     "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Manufacturers cat = dbContext.Manufacturers.FirstOrDefault(m => m.name == manufacturerName);

            if (cat == null)
                dbContext.Manufacturers.Add(new Manufacturers(manufacturerName));
            else
            {
                MessageBox.Show("The manufacturer already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Commit(dbContext);
            dbContext.Manufacturers.Load();
            gridControl1.DataSource = dbContext.Manufacturers.ToList();
        }

    }
}
