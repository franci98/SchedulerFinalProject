﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace Scheduler
{
    public partial class ScheduleView : Form
    {
        public ScheduleView(string schedule_id)
        {
            InitializeComponent();
            string sid = schedule_id;
            //string query = "";
        }

        OleDbConnection con = new System.Data.OleDb.OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = schedulerDB.accdb");
        //Ustvarjanje dataseta / making of a data set
        DataSet ds1 = new DataSet();
        //Adapter / Posrednik med datasetom in povezavo
        OleDbDataAdapter da;

        private void ScheduleView_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadGrid(string qry)
        {
            da = new OleDbDataAdapter(qry, con);
            da.Fill(ds1);
            ScheduleGridView.DataSource = ds1.Tables[0];
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            ScheduleGridView.Columns.Add(btn);
            btn.Text = "Pojdi na urnik";
        }
    }
}