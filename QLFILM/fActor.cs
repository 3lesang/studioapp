﻿using QLFILM.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLFILM
{
    public partial class fActor : Form
    {
        BUSActor busActor;
        public fActor()
        {
            InitializeComponent();
            busActor = new BUSActor();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fActor_Load(object sender, EventArgs e)
        {
            busActor.ShowActor(dgActor);
        }
    }
}
