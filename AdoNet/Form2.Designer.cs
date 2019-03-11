namespace AdoNet
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.lvCategories = new System.Windows.Forms.ListView();
            this.clmCategoryId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCategoryName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "GetCategory";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lvCategories
            // 
            this.lvCategories.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmCategoryId,
            this.clmCategoryName,
            this.clmDescription});
            this.lvCategories.Location = new System.Drawing.Point(67, 120);
            this.lvCategories.Name = "lvCategories";
            this.lvCategories.Size = new System.Drawing.Size(686, 284);
            this.lvCategories.TabIndex = 1;
            this.lvCategories.UseCompatibleStateImageBehavior = false;
            this.lvCategories.View = System.Windows.Forms.View.Details;
            // 
            // clmCategoryId
            // 
            this.clmCategoryId.Text = "CategoryId";
            this.clmCategoryId.Width = 121;
            // 
            // clmCategoryName
            // 
            this.clmCategoryName.Text = "CategoryName";
            this.clmCategoryName.Width = 134;
            // 
            // clmDescription
            // 
            this.clmDescription.Text = "Description";
            this.clmDescription.Width = 332;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvCategories);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "ADO.Net ExecuteReader()";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lvCategories;
        private System.Windows.Forms.ColumnHeader clmCategoryId;
        private System.Windows.Forms.ColumnHeader clmCategoryName;
        private System.Windows.Forms.ColumnHeader clmDescription;
    }
}