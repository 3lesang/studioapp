namespace QLFILM
{
    partial class fCategory
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
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.dgCategory = new System.Windows.Forms.DataGridView();
            this.exitCategory = new System.Windows.Forms.Button();
            this.editCategory = new System.Windows.Forms.Button();
            this.delCategory = new System.Windows.Forms.Button();
            this.addCategory = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategory)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCategoryName);
            this.panel1.Controls.Add(this.txtCategoryID);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 300);
            this.panel1.TabIndex = 7;
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
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(109, 170);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(244, 26);
            this.txtCategoryName.TabIndex = 1;
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Location = new System.Drawing.Point(109, 83);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.Size = new System.Drawing.Size(244, 26);
            this.txtCategoryID.TabIndex = 0;
            // 
            // dgCategory
            // 
            this.dgCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCategory.Location = new System.Drawing.Point(397, 12);
            this.dgCategory.Name = "dgCategory";
            this.dgCategory.RowTemplate.Height = 28;
            this.dgCategory.Size = new System.Drawing.Size(569, 620);
            this.dgCategory.TabIndex = 6;
            // 
            // exitCategory
            // 
            this.exitCategory.Location = new System.Drawing.Point(14, 218);
            this.exitCategory.Name = "exitCategory";
            this.exitCategory.Size = new System.Drawing.Size(350, 50);
            this.exitCategory.TabIndex = 3;
            this.exitCategory.Text = "EXIT";
            this.exitCategory.UseVisualStyleBackColor = true;
            // 
            // editCategory
            // 
            this.editCategory.Location = new System.Drawing.Point(14, 148);
            this.editCategory.Name = "editCategory";
            this.editCategory.Size = new System.Drawing.Size(350, 50);
            this.editCategory.TabIndex = 2;
            this.editCategory.Text = "EDIT";
            this.editCategory.UseVisualStyleBackColor = true;
            // 
            // delCategory
            // 
            this.delCategory.Location = new System.Drawing.Point(14, 75);
            this.delCategory.Name = "delCategory";
            this.delCategory.Size = new System.Drawing.Size(350, 50);
            this.delCategory.TabIndex = 1;
            this.delCategory.Text = "DELETE";
            this.delCategory.UseVisualStyleBackColor = true;
            // 
            // addCategory
            // 
            this.addCategory.Location = new System.Drawing.Point(14, 3);
            this.addCategory.Name = "addCategory";
            this.addCategory.Size = new System.Drawing.Size(350, 50);
            this.addCategory.TabIndex = 0;
            this.addCategory.Text = "ADD";
            this.addCategory.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.exitCategory);
            this.panel2.Controls.Add(this.editCategory);
            this.panel2.Controls.Add(this.delCategory);
            this.panel2.Controls.Add(this.addCategory);
            this.panel2.Location = new System.Drawing.Point(12, 340);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 292);
            this.panel2.TabIndex = 8;
            // 
            // fCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgCategory);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "fCategory";
            this.Text = "fCategory";
            this.Load += new System.EventHandler(this.fCategory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategory)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.DataGridView dgCategory;
        private System.Windows.Forms.Button exitCategory;
        private System.Windows.Forms.Button editCategory;
        private System.Windows.Forms.Button delCategory;
        private System.Windows.Forms.Button addCategory;
        private System.Windows.Forms.Panel panel2;
    }
}