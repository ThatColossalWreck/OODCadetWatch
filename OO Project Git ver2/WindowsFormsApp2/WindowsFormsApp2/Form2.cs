using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //A constructor that fills in a limited amount of fields in the form, for now
        public Form2(DataRow[] rows, int i)
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
            }catch(System.IO.FileNotFoundException)
            {
                studentImage.Image = Image.FromFile(@"E:\OO Project\Project\Pictures\errorImageResize.png");
            }
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
