namespace QLFILM
{
    partial class fActor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgActor = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addActor = new System.Windows.Forms.Button();
            this.delActor = new System.Windows.Forms.Button();
            this.editActor = new System.Windows.Forms.Button();
            this.exitActor = new System.Windows.Forms.Button();
            this.txtActorID = new System.Windows.Forms.TextBox();
            this.txtActorName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgActor)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgActor
            // 
            this.dgActor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgActor.Location = new System.Drawing.Point(397, 12);
            this.dgActor.Name = "dgActor";
            this.dgActor.RowTemplate.Height = 28;
            this.dgActor.Size = new System.Drawing.Size(569, 620);
            this.dgActor.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtActorName);
            this.panel1.Controls.Add(this.txtActorID);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 300);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.exitActor);
            this.panel2.Controls.Add(this.editActor);
            this.panel2.Controls.Add(this.delActor);
            this.panel2.Controls.Add(this.addActor);
            this.panel2.Location = new System.Drawing.Point(12, 340);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 292);
            this.panel2.TabIndex = 2;
            // 
            // addActor
            // 
            this.addActor.Location = new System.Drawing.Point(14, 3);
            this.addActor.Name = "addActor";
            this.addActor.Size = new System.Drawing.Size(350, 50);
            this.addActor.TabIndex = 0;
            this.addActor.Text = "ADD";
            this.addActor.UseVisualStyleBackColor = true;
            // 
            // delActor
            // 
            this.delActor.Location = new System.Drawing.Point(14, 75);
            this.delActor.Name = "delActor";
            this.delActor.Size = new System.Drawing.Size(350, 50);
            this.delActor.TabIndex = 1;
            this.delActor.Text = "DELETE";
            this.delActor.UseVisualStyleBackColor = true;
            // 
            // editActor
            // 
            this.editActor.Location = new System.Drawing.Point(14, 148);
            this.editActor.Name = "editActor";
            this.editActor.Size = new System.Drawing.Size(350, 50);
            this.editActor.TabIndex = 2;
            this.editActor.Text = "EDIT";
            this.editActor.UseVisualStyleBackColor = true;
            // 
            // exitActor
            // 
            this.exitActor.Location = new System.Drawing.Point(14, 218);
            this.exitActor.Name = "exitActor";
            this.exitActor.Size = new System.Drawing.Size(350, 50);
            this.exitActor.TabIndex = 3;
            this.exitActor.Text = "EXIT";
            this.exitActor.UseVisualStyleBackColor = true;
            this.exitActor.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtActorID
            // 
            this.txtActorID.Location = new System.Drawing.Point(109, 83);
            this.txtActorID.Name = "txtActorID";
            this.txtActorID.Size = new System.Drawing.Size(244, 26);
            this.txtActorID.TabIndex = 0;
            // 
            // txtActorName
            // 
            this.txtActorName.Location = new System.Drawing.Point(109, 170);
            this.txtActorName.Name = "txtActorName";
            this.txtActorName.Size = new System.Drawing.Size(244, 26);
            this.txtActorName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "NAME";
            // 
            // fActor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgActor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fActor";
            this.Text = "fActor";
            this.Load += new System.EventHandler(this.fActor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgActor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgActor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button exitActor;
        private System.Windows.Forms.Button editActor;
        private System.Windows.Forms.Button delActor;
        private System.Windows.Forms.Button addActor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtActorName;
        private System.Windows.Forms.TextBox txtActorID;
    }
}