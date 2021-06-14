namespace QLFILM
{
    partial class fFilm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.exitFilm = new System.Windows.Forms.Button();
            this.editFilm = new System.Windows.Forms.Button();
            this.delFilm = new System.Windows.Forms.Button();
            this.addFilm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbDrector = new System.Windows.Forms.ComboBox();
            this.cbActor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGross = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGating = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtVietnameseTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEnglishTitle = new System.Windows.Forms.TextBox();
            this.txtFilmID = new System.Windows.Forms.TextBox();
            this.dgFilm = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFilm)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.exitFilm);
            this.panel2.Controls.Add(this.editFilm);
            this.panel2.Controls.Add(this.delFilm);
            this.panel2.Controls.Add(this.addFilm);
            this.panel2.Location = new System.Drawing.Point(12, 404);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 238);
            this.panel2.TabIndex = 5;
            // 
            // exitFilm
            // 
            this.exitFilm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.exitFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitFilm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.exitFilm.Location = new System.Drawing.Point(143, 181);
            this.exitFilm.Name = "exitFilm";
            this.exitFilm.Size = new System.Drawing.Size(250, 50);
            this.exitFilm.TabIndex = 3;
            this.exitFilm.Text = "CLOSE";
            this.exitFilm.UseVisualStyleBackColor = false;
            this.exitFilm.Click += new System.EventHandler(this.exitFilm_Click);
            // 
            // editFilm
            // 
            this.editFilm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(147)))), ((int)(((byte)(249)))));
            this.editFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editFilm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.editFilm.Location = new System.Drawing.Point(143, 120);
            this.editFilm.Name = "editFilm";
            this.editFilm.Size = new System.Drawing.Size(250, 50);
            this.editFilm.TabIndex = 2;
            this.editFilm.Text = "EDIT";
            this.editFilm.UseVisualStyleBackColor = false;
            // 
            // delFilm
            // 
            this.delFilm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.delFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delFilm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.delFilm.Location = new System.Drawing.Point(143, 62);
            this.delFilm.Name = "delFilm";
            this.delFilm.Size = new System.Drawing.Size(250, 50);
            this.delFilm.TabIndex = 1;
            this.delFilm.Text = "DELETE";
            this.delFilm.UseVisualStyleBackColor = false;
            // 
            // addFilm
            // 
            this.addFilm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(250)))), ((int)(((byte)(123)))));
            this.addFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFilm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.addFilm.Location = new System.Drawing.Point(143, 3);
            this.addFilm.Name = "addFilm";
            this.addFilm.Size = new System.Drawing.Size(250, 50);
            this.addFilm.TabIndex = 0;
            this.addFilm.Text = "ADD";
            this.addFilm.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.cbCategory);
            this.panel1.Controls.Add(this.cbDrector);
            this.panel1.Controls.Add(this.cbActor);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtGross);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtGating);
            this.panel1.Controls.Add(this.txtLength);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtYear);
            this.panel1.Controls.Add(this.txtVietnameseTitle);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtEnglishTitle);
            this.panel1.Controls.Add(this.txtFilmID);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.panel1.Location = new System.Drawing.Point(12, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 409);
            this.panel1.TabIndex = 4;
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(436, 149);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(121, 33);
            this.cbCategory.TabIndex = 22;
            // 
            // cbDrector
            // 
            this.cbDrector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDrector.FormattingEnabled = true;
            this.cbDrector.Location = new System.Drawing.Point(436, 96);
            this.cbDrector.Name = "cbDrector";
            this.cbDrector.Size = new System.Drawing.Size(121, 33);
            this.cbDrector.TabIndex = 21;
            // 
            // cbActor
            // 
            this.cbActor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbActor.FormattingEnabled = true;
            this.cbActor.Location = new System.Drawing.Point(436, 54);
            this.cbActor.Name = "cbActor";
            this.cbActor.Size = new System.Drawing.Size(121, 33);
            this.cbActor.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.label8.Location = new System.Drawing.Point(322, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "Category";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.label9.Location = new System.Drawing.Point(322, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Director";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.label10.Location = new System.Drawing.Point(322, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = "Actor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.label7.Location = new System.Drawing.Point(3, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Gross";
            // 
            // txtGross
            // 
            this.txtGross.Location = new System.Drawing.Point(162, 345);
            this.txtGross.Name = "txtGross";
            this.txtGross.Size = new System.Drawing.Size(158, 30);
            this.txtGross.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.label5.Location = new System.Drawing.Point(3, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Gating";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.label6.Location = new System.Drawing.Point(3, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Length";
            // 
            // txtGating
            // 
            this.txtGating.Location = new System.Drawing.Point(162, 300);
            this.txtGating.Name = "txtGating";
            this.txtGating.Size = new System.Drawing.Size(158, 30);
            this.txtGating.TabIndex = 9;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(162, 253);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(158, 30);
            this.txtLength.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.label3.Location = new System.Drawing.Point(3, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.label4.Location = new System.Drawing.Point(-1, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "VietnameseTitle";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(162, 202);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(158, 30);
            this.txtYear.TabIndex = 5;
            // 
            // txtVietnameseTitle
            // 
            this.txtVietnameseTitle.Location = new System.Drawing.Point(162, 155);
            this.txtVietnameseTitle.Name = "txtVietnameseTitle";
            this.txtVietnameseTitle.Size = new System.Drawing.Size(158, 30);
            this.txtVietnameseTitle.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.label2.Location = new System.Drawing.Point(3, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "EnglishTitle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.label1.Location = new System.Drawing.Point(5, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // txtEnglishTitle
            // 
            this.txtEnglishTitle.Location = new System.Drawing.Point(162, 96);
            this.txtEnglishTitle.Name = "txtEnglishTitle";
            this.txtEnglishTitle.Size = new System.Drawing.Size(158, 30);
            this.txtEnglishTitle.TabIndex = 1;
            // 
            // txtFilmID
            // 
            this.txtFilmID.Location = new System.Drawing.Point(162, 49);
            this.txtFilmID.Name = "txtFilmID";
            this.txtFilmID.Size = new System.Drawing.Size(158, 30);
            this.txtFilmID.TabIndex = 0;
            // 
            // dgFilm
            // 
            this.dgFilm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.dgFilm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFilm.Location = new System.Drawing.Point(578, -1);
            this.dgFilm.Name = "dgFilm";
            this.dgFilm.RowTemplate.Height = 28;
            this.dgFilm.Size = new System.Drawing.Size(702, 652);
            this.dgFilm.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.label11.Location = new System.Drawing.Point(5, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 25);
            this.label11.TabIndex = 25;
            this.label11.Text = "INFOR";
            // 
            // fFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1278, 644);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgFilm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "fFilm";
            this.Text = "Film";
            this.Load += new System.EventHandler(this.fFilm_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFilm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button exitFilm;
        private System.Windows.Forms.Button editFilm;
        private System.Windows.Forms.Button delFilm;
        private System.Windows.Forms.Button addFilm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEnglishTitle;
        private System.Windows.Forms.TextBox txtFilmID;
        private System.Windows.Forms.DataGridView dgFilm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGross;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGating;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtVietnameseTitle;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbDrector;
        private System.Windows.Forms.ComboBox cbActor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}