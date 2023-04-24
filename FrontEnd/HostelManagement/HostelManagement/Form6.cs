﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelManagement
{
    public partial class Mess : Form
    {
        public Mess()
        {
            InitializeComponent();
        }

        private void profileicon_Click(object sender, EventArgs e)
        {
            Profile frm = new Profile();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void roombookicon_Click(object sender, EventArgs e)
        {
            Booking frm = new Booking();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void Mess_Load(object sender, EventArgs e)
        {

        }

        private void roomchangeicon_Click(object sender, EventArgs e)
        {
            Change frm = new Change();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void issuesicon_Click(object sender, EventArgs e)
        {
            Issues frm = new Issues();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}
