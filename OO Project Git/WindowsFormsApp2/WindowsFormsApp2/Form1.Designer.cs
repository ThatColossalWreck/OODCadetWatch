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
            this.CadetView = new System.Windows.Forms.DataGridView();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CadetView)).BeginInit();
            this.SuspendLayout();
            // 
            // CadetView
            // 
            this.CadetView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CadetView.Location = new System.Drawing.Point(12, 90);
            this.CadetView.Name = "CadetView";
            this.CadetView.Size = new System.Drawing.Size(994, 514);
            this.CadetView.TabIndex = 0;
            this.CadetView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CadetView_CellContentClick);
            this.CadetView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CadetView_CellDoubleClick);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(93, 46);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(280, 20);
            this.searchBox.TabIndex = 1;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(12, 44);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(607, 43);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshBtn.TabIndex = 3;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // CadetWatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 616);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.CadetView);
            this.Name = "CadetWatch";
            this.Text = "CadetWatch";
            this.Load += new System.EventHandler(this.CadetWatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CadetView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CadetView;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button refreshBtn;
    }
}

