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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDirectorName = new System.Windows.Forms.TextBox();
            this.txtDirectorID = new System.Windows.Forms.TextBox();
            this.dgDirector = new System.Windows.Forms.DataGridView();
            this.exitDirector = new System.Windows.Forms.Button();
            this.editDirector = new System.Windows.Forms.Button();
            this.delDirector = new System.Windows.Forms.Button();
            this.addDirector = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDirector)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtDirectorName);
            this.panel1.Controls.Add(this.txtDirectorID);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 300);
            this.panel1.TabIndex = 4;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // txtDirectorName
            // 
            this.txtDirectorName.Location = new System.Drawing.Point(109, 170);
            this.txtDirectorName.Name = "txtDirectorName";
            this.txtDirectorName.Size = new System.Drawing.Size(244, 26);
            this.txtDirectorName.TabIndex = 1;
            // 
            // txtDirectorID
            // 
            this.txtDirectorID.Location = new System.Drawing.Point(109, 83);
            this.txtDirectorID.Name = "txtDirectorID";
            this.txtDirectorID.Size = new System.Drawing.Size(244, 26);
            this.txtDirectorID.TabIndex = 0;
            // 
            // dgDirector
            // 
            this.dgDirector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDirector.Location = new System.Drawing.Point(397, 12);
            this.dgDirector.Name = "dgDirector";
            this.dgDirector.RowTemplate.Height = 28;
            this.dgDirector.Size = new System.Drawing.Size(569, 620);
            this.dgDirector.TabIndex = 3;
            // 
            // exitDirector
            // 
            this.exitDirector.Location = new System.Drawing.Point(14, 218);
            this.exitDirector.Name = "exitDirector";
            this.exitDirector.Size = new System.Drawing.Size(350, 50);
            this.exitDirector.TabIndex = 3;
            this.exitDirector.Text = "EXIT";
            this.exitDirector.UseVisualStyleBackColor = true;
            // 
            // editDirector
            // 
            this.editDirector.Location = new System.Drawing.Point(14, 148);
            this.editDirector.Name = "editDirector";
            this.editDirector.Size = new System.Drawing.Size(350, 50);
            this.editDirector.TabIndex = 2;
            this.editDirector.Text = "EDIT";
            this.editDirector.UseVisualStyleBackColor = true;
            // 
            // delDirector
            // 
            this.delDirector.Location = new System.Drawing.Point(14, 75);
            this.delDirector.Name = "delDirector";
            this.delDirector.Size = new System.Drawing.Size(350, 50);
            this.delDirector.TabIndex = 1;
            this.delDirector.Text = "DELETE";
            this.delDirector.UseVisualStyleBackColor = true;
            // 
            // addDirector
            // 
            this.addDirector.Location = new System.Drawing.Point(14, 3);
            this.addDirector.Name = "addDirector";
            this.addDirector.Size = new System.Drawing.Size(350, 50);
            this.addDirector.TabIndex = 0;
            this.addDirector.Text = "ADD";
            this.addDirector.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.exitDirector);
            this.panel2.Controls.Add(this.editDirector);
            this.panel2.Controls.Add(this.delDirector);
            this.panel2.Controls.Add(this.addDirector);
            this.panel2.Location = new System.Drawing.Point(12, 340);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 292);
            this.panel2.TabIndex = 5;
            // 
            // fDirector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgDirector);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "fDirector";
            this.Text = "fDirector";
            this.Load += new System.EventHandler(this.fDirector_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDirector)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDirectorName;
        private System.Windows.Forms.TextBox txtDirectorID;
        private System.Windows.Forms.DataGridView dgDirector;
        private System.Windows.Forms.Button exitDirector;
        private System.Windows.Forms.Button editDirector;
        private System.Windows.Forms.Button delDirector;
        private System.Windows.Forms.Button addDirector;
        private System.Windows.Forms.Panel panel2;
    }
}