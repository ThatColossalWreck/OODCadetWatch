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
    public partial class addCadet : UserControl
    {
        public delegate void ButtonClickedEventHandler(object sender, EventArgs e);
        public event ButtonClickedEventHandler addPerson;
        public addCadet()
        {
            InitializeComponent();
            addCadetBtn.Click += new EventHandler(ButtonClick);
            nurseBox.Items.Add("No");
            nurseBox.Items.Add("Yes");
            nurseBox.SelectedIndex = 0;
        }

        private void addCadet_Load(object sender, EventArgs e)
        {

        }
        private void ButtonClick(object sender, EventArgs e)
        {
            if(addPerson != null)
            {
                addPerson(this, e);
            }
        }
        public String fNameText()
        {
            return firstBox.Text;
        }
        public String lNameText()
        {
            return lastBox.Text;
        }
        public String idText()
        {
            return IDBox.Text;
        }
        public String msText()
        {
            return msBox.Text;
        }
        public String majorText()
        {
            return majorBox.Text;
        }
        public String msDateRet()
        {
            return msDate.Text;
        }
    }
}
