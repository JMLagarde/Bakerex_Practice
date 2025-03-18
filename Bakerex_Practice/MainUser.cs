﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakerex_Practice
{
    public partial class MainUser : Form
    {
        public MainUser()
        {
            InitializeComponent();
            lblHome.MouseEnter += lblHome_MouseEnter;
            lblHome.MouseLeave += lblHome_MouseLeave;
            lblSubmitTicket.MouseEnter += lblSubmitTicket_MouseEnter;
            lblSubmitTicket.MouseLeave += lblSubmitTicket_MouseLeave;
            lblTrackTicket.MouseEnter += lblTrackTicket_MouseEnter;
            lblTrackTicket.MouseLeave += lblTrackTicket_MouseLeave;
        }

        private void MainUser_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            MainUser mainUser = new MainUser();
            mainUser.Show();

            this.Hide();
        }

        private void lblHome_MouseEnter(object sender, EventArgs e)
        {
            lblHome.ForeColor = Color.Indigo;
        }

        private void lblHome_MouseLeave(object sender, EventArgs e)
        {
            lblHome.ForeColor = Color.Black;
        }

        private void lblSubmitTicket_MouseEnter(object sender, EventArgs e)
        {
            lblSubmitTicket.ForeColor = Color.Indigo;
        }

        private void lblSubmitTicket_MouseLeave(object sender, EventArgs e)
        {
            lblSubmitTicket.ForeColor = Color.Black;
        }

        private void lblTrackTicket_MouseEnter(object sender, EventArgs e)
        {
            lblTrackTicket.ForeColor = Color.Indigo;
        }

        private void lblTrackTicket_MouseLeave(object sender, EventArgs e)
        {
            lblTrackTicket.ForeColor = Color.Black;
        }

    }
}
