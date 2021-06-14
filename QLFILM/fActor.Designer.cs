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
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtActorName = new System.Windows.Forms.TextBox();
            this.txtActorID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exitActor = new System.Windows.Forms.Button();
            this.editActor = new System.Windows.Forms.Button();
            this.delActor = new System.Windows.Forms.Button();
            this.addActor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgActor)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgActor
            // 
            this.dgActor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.dgActor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgActor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgActor.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgActor.Location = new System.Drawing.Point(395, 0);
            this.dgActor.Name = "dgActor";
            this.dgActor.RowTemplate.Height = 28;
            this.dgActor.Size = new System.Drawing.Size(583, 644);
            this.dgActor.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtActorName);
            this.panel1.Controls.Add(this.txtActorID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 329);
            this.panel1.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 25);
            this.label11.TabIndex = 25;
            this.label11.Text = "INFOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.label2.Location = new System.Drawing.Point(30, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.label1.Location = new System.Drawing.Point(48, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // txtActorName
            // 
            this.txtActorName.Location = new System.Drawing.Point(109, 170);
            this.txtActorName.Name = "txtActorName";
            this.txtActorName.Size = new System.Drawing.Size(244, 26);
            this.txtActorName.TabIndex = 1;
            // 
            // txtActorID
            // 
            this.txtActorID.Location = new System.Drawing.Point(109, 83);
            this.txtActorID.Name = "txtActorID";
            this.txtActorID.Size = new System.Drawing.Size(244, 26);
            this.txtActorID.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.exitActor);
            this.panel2.Controls.Add(this.editActor);
            this.panel2.Controls.Add(this.delActor);
            this.panel2.Controls.Add(this.addActor);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 329);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 315);
            this.panel2.TabIndex = 2;
            // 
            // exitActor
            // 
            this.exitActor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.exitActor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exitActor.FlatAppearance.BorderSize = 0;
            this.exitActor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitActor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitActor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.exitActor.Location = new System.Drawing.Point(0, 265);
            this.exitActor.Name = "exitActor";
            this.exitActor.Size = new System.Drawing.Size(395, 50);
            this.exitActor.TabIndex = 3;
            this.exitActor.Text = "CLOSE";
            this.exitActor.UseVisualStyleBackColor = false;
            this.exitActor.Click += new System.EventHandler(this.button4_Click);
            // 
            // editActor
            // 
            this.editActor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(147)))), ((int)(((byte)(249)))));
            this.editActor.Dock = System.Windows.Forms.DockStyle.Top;
            this.editActor.FlatAppearance.BorderSize = 0;
            this.editActor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editActor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editActor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.editActor.Location = new System.Drawing.Point(0, 100);
            this.editActor.Name = "editActor";
            this.editActor.Size = new System.Drawing.Size(395, 50);
            this.editActor.TabIndex = 2;
            this.editActor.Text = "EDIT";
            this.editActor.UseVisualStyleBackColor = false;
            // 
            // delActor
            // 
            this.delActor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.delActor.Dock = System.Windows.Forms.DockStyle.Top;
            this.delActor.FlatAppearance.BorderSize = 0;
            this.delActor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delActor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delActor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.delActor.Location = new System.Drawing.Point(0, 50);
            this.delActor.Name = "delActor";
            this.delActor.Size = new System.Drawing.Size(395, 50);
            this.delActor.TabIndex = 1;
            this.delActor.Text = "DELETE";
            this.delActor.UseVisualStyleBackColor = false;
            // 
            // addActor
            // 
            this.addActor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(250)))), ((int)(((byte)(123)))));
            this.addActor.Dock = System.Windows.Forms.DockStyle.Top;
            this.addActor.FlatAppearance.BorderSize = 0;
            this.addActor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addActor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addActor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.addActor.Location = new System.Drawing.Point(0, 0);
            this.addActor.Name = "addActor";
            this.addActor.Size = new System.Drawing.Size(395, 50);
            this.addActor.TabIndex = 0;
            this.addActor.Text = "ADD";
            this.addActor.UseVisualStyleBackColor = false;
            this.addActor.Click += new System.EventHandler(this.addActor_Click);
            // 
            // fActor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgActor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fActor";
            this.Text = "Actor";
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
        private System.Windows.Forms.Label label11;
    }
}