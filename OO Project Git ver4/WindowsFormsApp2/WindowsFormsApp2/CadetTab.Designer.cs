namespace WindowsFormsApp2
{
    partial class CadetTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.studentImage = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.msBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.missionBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DoBBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.majorBox = new System.Windows.Forms.TextBox();
            this.majorLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentImage)).BeginInit();
            this.SuspendLayout();
            // 
            // studentImage
            // 
            this.studentImage.Location = new System.Drawing.Point(623, 30);
            this.studentImage.Name = "studentImage";
            this.studentImage.Size = new System.Drawing.Size(220, 236);
            this.studentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.studentImage.TabIndex = 32;
            this.studentImage.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "MS Level:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // msBox
            // 
            this.msBox.Location = new System.Drawing.Point(52, 177);
            this.msBox.Name = "msBox";
            this.msBox.Size = new System.Drawing.Size(111, 20);
            this.msBox.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Mission Set Projection:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // missionBox
            // 
            this.missionBox.Location = new System.Drawing.Point(52, 140);
            this.missionBox.Name = "missionBox";
            this.missionBox.Size = new System.Drawing.Size(111, 20);
            this.missionBox.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Date Of Birth:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DoBBox
            // 
            this.DoBBox.Location = new System.Drawing.Point(52, 103);
            this.DoBBox.Name = "DoBBox";
            this.DoBBox.Size = new System.Drawing.Size(111, 20);
            this.DoBBox.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "EagleID:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(52, 66);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(111, 20);
            this.IDBox.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(52, 30);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(111, 20);
            this.nameBox.TabIndex = 22;
            // 
            // majorBox
            // 
            this.majorBox.Location = new System.Drawing.Point(52, 219);
            this.majorBox.Name = "majorBox";
            this.majorBox.Size = new System.Drawing.Size(111, 20);
            this.majorBox.TabIndex = 33;
            // 
            // majorLbl
            // 
            this.majorLbl.AutoSize = true;
            this.majorLbl.Location = new System.Drawing.Point(49, 203);
            this.majorLbl.Name = "majorLbl";
            this.majorLbl.Size = new System.Drawing.Size(36, 13);
            this.majorLbl.TabIndex = 34;
            this.majorLbl.Text = "Major:";
            this.majorLbl.Click += new System.EventHandler(this.label6_Click);
            // 
            // CadetTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.majorLbl);
            this.Controls.Add(this.majorBox);
            this.Controls.Add(this.studentImage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.msBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.missionBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DoBBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameBox);
            this.Name = "CadetTab";
            this.Size = new System.Drawing.Size(916, 481);
            ((System.ComponentModel.ISupportInitialize)(this.studentImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox studentImage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox msBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox missionBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DoBBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox majorBox;
        private System.Windows.Forms.Label majorLbl;
    }
}
