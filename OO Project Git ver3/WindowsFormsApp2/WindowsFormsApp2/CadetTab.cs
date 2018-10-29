using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class CadetTab : UserControl
    {
        public CadetTab()
        {
            InitializeComponent();
        }
        public CadetTab(DataRow[] rows, int i)
        {
            InitializeComponent();
            nameBox.Text = rows[i]["Name"].ToString();
            IDBox.Text = rows[i]["Eagle ID"].ToString();
            DoBBox.Text = rows[i]["Date of Birth"].ToString();
            missionBox.Text = rows[i]["Mission Set Projection"].ToString();
            msBox.Text = rows[i]["MS Level"].ToString();
            String path = rows[i]["Photo"].ToString();
            try
            {
                studentImage.Image = Image.FromFile(@path);
            }
            catch (System.IO.FileNotFoundException)
            {
                studentImage.Image = Image.FromFile(@"E:\OO Project\Project\Pictures\errorImageResize.png");
            }
        }
        public CadetTab(DataGridViewRow rows)
        {
            InitializeComponent();
            nameBox.Text = rows.Cells[0].Value.ToString();
            IDBox.Text = rows.Cells["Eagle ID"].Value.ToString();
            DoBBox.Text = rows.Cells["Date of Birth"].Value.ToString();
            missionBox.Text = rows.Cells["Mission Set Projection"].Value.ToString();
            msBox.Text = rows.Cells["MS Level"].Value.ToString();
            String path = rows.Cells["Photo"].Value.ToString();
            try
            {
                studentImage.Image = Image.FromFile(@path);
            }
            catch (System.IO.FileNotFoundException)
            {
                studentImage.Image = Image.FromFile(@"E:\OO Project\Project\Pictures\errorImageResize.png");
            }

        }
        private void CadetTab_Load(object sender, EventArgs e)
        {

        }
    }
}
