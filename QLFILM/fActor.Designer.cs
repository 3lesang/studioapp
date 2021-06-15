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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgActor = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtActorName = new System.Windows.Forms.TextBox();
            this.txtActorID = new System.Windows.Forms.TextBox();
            this.editActor = new System.Windows.Forms.Button();
            this.delActor = new System.Windows.Forms.Button();
            this.addActor = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.exitActor = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgActor)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgActor
            // 
            this.dgActor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgActor.BackgroundColor = System.Drawing.Color.White;
            this.dgActor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgActor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgActor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgActor.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgActor.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgActor.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgActor.Location = new System.Drawing.Point(0, 0);
            this.dgActor.Name = "dgActor";
            this.dgActor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgActor.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgActor.RowTemplate.Height = 28;
            this.dgActor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgActor.Size = new System.Drawing.Size(1178, 480);
            this.dgActor.TabIndex = 0;
            this.dgActor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgActor_CellClick);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtActorName);
            this.panel4.Controls.Add(this.txtActorID);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 480);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1178, 208);
            this.panel4.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
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
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(442, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(155, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // txtActorName
            // 
            this.txtActorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtActorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActorName.Location = new System.Drawing.Point(521, 67);
            this.txtActorName.Name = "txtActorName";
            this.txtActorName.Size = new System.Drawing.Size(193, 30);
            this.txtActorName.TabIndex = 1;
            // 
            // txtActorID
            // 
            this.txtActorID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtActorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActorID.Location = new System.Drawing.Point(216, 66);
            this.txtActorID.Name = "txtActorID";
            this.txtActorID.Size = new System.Drawing.Size(193, 30);
            this.txtActorID.TabIndex = 0;
            // 
            // editActor
            // 
            this.editActor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(147)))), ((int)(((byte)(249)))));
            this.editActor.Dock = System.Windows.Forms.DockStyle.Left;
            this.editActor.FlatAppearance.BorderSize = 0;
            this.editActor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editActor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editActor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.editActor.Location = new System.Drawing.Point(200, 0);
            this.editActor.Name = "editActor";
            this.editActor.Size = new System.Drawing.Size(100, 50);
            this.editActor.TabIndex = 2;
            this.editActor.Text = "EDIT";
            this.editActor.UseVisualStyleBackColor = false;
            // 
            // delActor
            // 
            this.delActor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.delActor.Dock = System.Windows.Forms.DockStyle.Left;
            this.delActor.FlatAppearance.BorderSize = 0;
            this.delActor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delActor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delActor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.delActor.Location = new System.Drawing.Point(0, 0);
            this.delActor.Name = "delActor";
            this.delActor.Size = new System.Drawing.Size(100, 50);
            this.delActor.TabIndex = 1;
            this.delActor.Text = "DELETE";
            this.delActor.UseVisualStyleBackColor = false;
            this.delActor.Click += new System.EventHandler(this.delActor_Click);
            // 
            // addActor
            // 
            this.addActor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(250)))), ((int)(((byte)(123)))));
            this.addActor.Dock = System.Windows.Forms.DockStyle.Left;
            this.addActor.FlatAppearance.BorderSize = 0;
            this.addActor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addActor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addActor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.addActor.Location = new System.Drawing.Point(100, 0);
            this.addActor.Name = "addActor";
            this.addActor.Size = new System.Drawing.Size(100, 50);
            this.addActor.TabIndex = 0;
            this.addActor.Text = "ADD";
            this.addActor.UseVisualStyleBackColor = false;
            this.addActor.Click += new System.EventHandler(this.addActor_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.exitActor);
            this.panel3.Controls.Add(this.editActor);
            this.panel3.Controls.Add(this.addActor);
            this.panel3.Controls.Add(this.delActor);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 638);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1178, 50);
            this.panel3.TabIndex = 3;
            // 
            // exitActor
            // 
            this.exitActor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.exitActor.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitActor.FlatAppearance.BorderSize = 0;
            this.exitActor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitActor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitActor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.exitActor.Location = new System.Drawing.Point(1078, 0);
            this.exitActor.Name = "exitActor";
            this.exitActor.Size = new System.Drawing.Size(100, 50);
            this.exitActor.TabIndex = 3;
            this.exitActor.Text = "CLOSE";
            this.exitActor.UseVisualStyleBackColor = false;
            this.exitActor.Click += new System.EventHandler(this.button4_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(135, 34);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(240, 30);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // fActor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1178, 688);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dgActor);
            this.Name = "fActor";
            this.Text = "Actor";
            this.Load += new System.EventHandler(this.fActor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgActor)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgActor;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button editActor;
        private System.Windows.Forms.Button delActor;
        private System.Windows.Forms.Button addActor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtActorName;
        private System.Windows.Forms.TextBox txtActorID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button exitActor;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}