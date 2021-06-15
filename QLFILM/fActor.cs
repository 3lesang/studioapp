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

        private void dgActor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ID = this.dgActor.CurrentRow.Cells[0].Value.ToString();
            Actor ac = busActor.GetActorByID(ID);
            this.txtActorID.Text = ac.AID;
            this.txtActorName.Text = ac.ActorName;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ID = this.dgActor.CurrentRow.Cells[0].Value.ToString();
            Actor ac = busActor.GetActorByID(ID);
            busActor.DeleteActor(ac);
            Reload();
        }

        private void delActor_Click(object sender, EventArgs e)
        {
            string ID = this.dgActor.CurrentRow.Cells[0].Value.ToString();
            Actor ac = busActor.GetActorByID(ID);
            busActor.DeleteActor(ac);
            Reload();
        }
    }
}
