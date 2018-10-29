namespace WindowsFormsApp2
{
    partial class CadetWatch
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
            this.closeBtn = new System.Windows.Forms.Button();
            this.testTab = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.CadetView = new System.Windows.Forms.DataGridView();
            this.tabView = new System.Windows.Forms.TabControl();
            this.testInsert = new System.Windows.Forms.Button();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CadetView)).BeginInit();
            this.tabView.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(876, 581);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 5;
            this.closeBtn.Text = "Close Tab";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // testTab
            // 
            this.testTab.Location = new System.Drawing.Point(4, 22);
            this.testTab.Name = "testTab";
            this.testTab.Padding = new System.Windows.Forms.Padding(3);
            this.testTab.Size = new System.Drawing.Size(986, 539);
            this.testTab.TabIndex = 1;
            this.testTab.Text = "tabPage2";
            this.testTab.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.testInsert);
            this.tabPage1.Controls.Add(this.CadetView);
            this.tabPage1.Controls.Add(this.refreshBtn);
            this.tabPage1.Controls.Add(this.searchBox);
            this.tabPage1.Controls.Add(this.searchBtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(986, 539);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadet Table";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(3, 6);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(84, 8);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(280, 20);
            this.searchBox.TabIndex = 1;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(555, 8);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshBtn.TabIndex = 3;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // CadetView
            // 
            this.CadetView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CadetView.Location = new System.Drawing.Point(6, 37);
            this.CadetView.Name = "CadetView";
            this.CadetView.Size = new System.Drawing.Size(977, 506);
            this.CadetView.TabIndex = 0;
            this.CadetView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CadetView_CellDoubleClick);
            // 
            // tabView
            // 
            this.tabView.Controls.Add(this.tabPage1);
            this.tabView.Controls.Add(this.testTab);
            this.tabView.Location = new System.Drawing.Point(12, 12);
            this.tabView.Name = "tabView";
            this.tabView.SelectedIndex = 0;
            this.tabView.Size = new System.Drawing.Size(994, 565);
            this.tabView.TabIndex = 4;
            // 
            // testInsert
            // 
            this.testInsert.Location = new System.Drawing.Point(442, 8);
            this.testInsert.Name = "testInsert";
            this.testInsert.Size = new System.Drawing.Size(75, 23);
            this.testInsert.TabIndex = 4;
            this.testInsert.Text = "Test Insert";
            this.testInsert.UseVisualStyleBackColor = true;
            this.testInsert.Click += new System.EventHandler(this.testInsert_Click);
            // 
            // CadetWatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 616);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.tabView);
            this.Name = "CadetWatch";
            this.Text = "CadetWatch";
            this.Load += new System.EventHandler(this.CadetWatch_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CadetView)).EndInit();
            this.tabView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.TabPage testTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView CadetView;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TabControl tabView;
        private System.Windows.Forms.Button testInsert;
    }
}

