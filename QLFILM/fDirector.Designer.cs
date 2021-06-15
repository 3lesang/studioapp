namespace QLFILM
{
    partial class fDirector
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.exitDirector = new System.Windows.Forms.Button();
            this.editDirector = new System.Windows.Forms.Button();
            this.delDirector = new System.Windows.Forms.Button();
            this.addDirector = new System.Windows.Forms.Button();
            this.dgDirector = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDirectorName = new System.Windows.Forms.TextBox();
            this.txtDirectorID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDirector)).BeginInit();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.exitDirector);
            this.panel4.Controls.Add(this.editDirector);
            this.panel4.Controls.Add(this.delDirector);
            this.panel4.Controls.Add(this.addDirector);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 638);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1178, 50);
            this.panel4.TabIndex = 26;
            // 
            // exitDirector
            // 
            this.exitDirector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.exitDirector.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitDirector.FlatAppearance.BorderSize = 0;
            this.exitDirector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitDirector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.exitDirector.Location = new System.Drawing.Point(1028, 0);
            this.exitDirector.Name = "exitDirector";
            this.exitDirector.Size = new System.Drawing.Size(150, 50);
            this.exitDirector.TabIndex = 3;
            this.exitDirector.Text = "CLOSE";
            this.exitDirector.UseVisualStyleBackColor = false;
            this.exitDirector.Click += new System.EventHandler(this.exitDirector_Click);
            // 
            // editDirector
            // 
            this.editDirector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(147)))), ((int)(((byte)(249)))));
            this.editDirector.Dock = System.Windows.Forms.DockStyle.Left;
            this.editDirector.FlatAppearance.BorderSize = 0;
            this.editDirector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editDirector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.editDirector.Location = new System.Drawing.Point(300, 0);
            this.editDirector.Name = "editDirector";
            this.editDirector.Size = new System.Drawing.Size(150, 50);
            this.editDirector.TabIndex = 2;
            this.editDirector.Text = "EDIT";
            this.editDirector.UseVisualStyleBackColor = false;
            // 
            // delDirector
            // 
            this.delDirector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.delDirector.Dock = System.Windows.Forms.DockStyle.Left;
            this.delDirector.FlatAppearance.BorderSize = 0;
            this.delDirector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delDirector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.delDirector.Location = new System.Drawing.Point(150, 0);
            this.delDirector.Name = "delDirector";
            this.delDirector.Size = new System.Drawing.Size(150, 50);
            this.delDirector.TabIndex = 1;
            this.delDirector.Text = "DELETE";
            this.delDirector.UseVisualStyleBackColor = false;
            this.delDirector.Click += new System.EventHandler(this.delDirector_Click);
            // 
            // addDirector
            // 
            this.addDirector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(250)))), ((int)(((byte)(123)))));
            this.addDirector.Dock = System.Windows.Forms.DockStyle.Left;
            this.addDirector.FlatAppearance.BorderSize = 0;
            this.addDirector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDirector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.addDirector.Location = new System.Drawing.Point(0, 0);
            this.addDirector.Name = "addDirector";
            this.addDirector.Size = new System.Drawing.Size(150, 50);
            this.addDirector.TabIndex = 0;
            this.addDirector.Text = "ADD";
            this.addDirector.UseVisualStyleBackColor = false;
            this.addDirector.Click += new System.EventHandler(this.addDirector_Click);
            // 
            // dgDirector
            // 
            this.dgDirector.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDirector.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.dgDirector.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDirector.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgDirector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDirector.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDirector.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgDirector.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgDirector.Location = new System.Drawing.Point(0, 0);
            this.dgDirector.MinimumSize = new System.Drawing.Size(1178, 480);
            this.dgDirector.Name = "dgDirector";
            this.dgDirector.RowTemplate.Height = 28;
            this.dgDirector.Size = new System.Drawing.Size(1178, 480);
            this.dgDirector.TabIndex = 3;
            this.dgDirector.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDirector_CellClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtDirectorName);
            this.panel2.Controls.Add(this.txtDirectorID);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 480);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1178, 158);
            this.panel2.TabIndex = 25;
            // 
            // txtDirectorName
            // 
            this.txtDirectorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDirectorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirectorName.Location = new System.Drawing.Point(647, 61);
            this.txtDirectorName.Name = "txtDirectorName";
            this.txtDirectorName.Size = new System.Drawing.Size(169, 30);
            this.txtDirectorName.TabIndex = 25;
            // 
            // txtDirectorID
            // 
            this.txtDirectorID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDirectorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirectorID.Location = new System.Drawing.Point(289, 60);
            this.txtDirectorID.Name = "txtDirectorID";
            this.txtDirectorID.Size = new System.Drawing.Size(169, 30);
            this.txtDirectorID.TabIndex = 0;
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
            this.label11.TabIndex = 24;
            this.label11.Text = "INFOR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(227, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(555, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "NAME";
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
            // fDirector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1178, 688);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dgDirector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "fDirector";
            this.Text = "Director";
            this.Load += new System.EventHandler(this.fDirector_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDirector)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgDirector;
        private System.Windows.Forms.Button exitDirector;
        private System.Windows.Forms.Button editDirector;
        private System.Windows.Forms.Button delDirector;
        private System.Windows.Forms.Button addDirector;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtDirectorID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDirectorName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}