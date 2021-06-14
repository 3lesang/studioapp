using QLFILM.BUS;
using QLFILM.Model;
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
        public void Reload()
        {
            dgActor.DataSource = null;
            busActor.ShowActor(dgActor);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fActor_Load(object sender, EventArgs e)
        {
            busActor.ShowActor(dgActor);
        }

        private void addActor_Click(object sender, EventArgs e)
        {
            Actor ac = new Actor();
            ac.AID = txtActorID.Text;
            ac.ActorName = txtActorName.Text;
            busActor.AddActor(ac);
            Reload();
        }
    }
}
