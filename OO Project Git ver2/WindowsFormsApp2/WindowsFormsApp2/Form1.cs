using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;
using Microsoft;
//TO-DO:
//Insertion
//Deletion
//Alteration
//Color problem with ordering
//Fields problem with ordering
namespace WindowsFormsApp2
{
    public partial class CadetWatch : Form
    {
        public CadetWatch()
        {
            InitializeComponent();
        }
        DataSet result = new DataSet();

        private void CadetWatch_Load(object sender, EventArgs e)
        {
            Boolean t = true;
            Boolean f = false;
            CadetView.ReadOnly = t;   //Sets the datagrid to be non-editable
            CadetView.AllowUserToAddRows = f;
            String path = @"E:\OO Project\Project\Cadets.xlsx";   //String path of the excel sheet
            FileStream fs = File.OpenRead(path);   //a file stream that opens the file
            IExcelDataReader reader = ExcelReaderFactory.CreateOpenXmlReader(fs);
            result = reader.AsDataSet(new ExcelDataSetConfiguration()
            {
                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                {
                    UseHeaderRow = true
                }
            });// This whole thing is setting the first table in dataset 'result' to be the excel table, it also sets the headers to be the values of the first row
            CadetView.DataSource = result.Tables[0];
            CadetView.Columns["Photo"].Visible = f; //Sets photo column to non-visible, it will be a file path and therefore ugly
            searchBox.KeyDown += new KeyEventHandler(searchEnter);
            //NEXT TO DO, CHANGE SUBPAR GRADES TO RED
            for (int i = 0; i < CadetView.RowCount; i++)
            {
                DataGridViewRow r = CadetView.Rows[i];
                if ((Double)result.Tables[0].Rows[i]["Term GPA"] < 2.0)
                {
                    r.DefaultCellStyle.BackColor = Color.Red;
                }
            }
            tabView.TabPages.Remove(testTab);
        }
        

        private void CadetView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //This is a method to populate form 2 with information based on the cell you double-click on
        
        private void CadetView_CellDoubleClick(Object sender, DataGridViewCellEventArgs e)
        {
            DataRow[] rows = result.Tables[0].Select();
            //Form2 form2 = new Form2(rows, e.RowIndex);
            newTab(rows, e.RowIndex);
        }
        //This method is to search the table based on what is in searchBox
        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(searchBox.Text)) {
                for (int i = 0; i < CadetView.RowCount; i++)
                {
                    CurrencyManager m1 = (CurrencyManager)BindingContext[CadetView.DataSource];
                    m1.SuspendBinding();
                    String ser = result.Tables[0].Rows[i][0].ToString();
                    String[] find = ser.Split(' ');
                    if (!ser.Contains(searchBox.Text))// && find[0] != searchBox.Text && find[1] != searchBox.Text)
                    {
                        CadetView.Rows[i].Visible = false;   
                    }
                    if(ser.Contains(searchBox.Text))//||find[0] == searchBox.Text||find[1] == searchBox.Text)
                    {
                        
                        CadetView.Rows[i].Visible = true;
                    }
                    m1.ResumeBinding();
                }
            }
        }
        //This method is for the refresh button, it refreshes the table
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            searchBox.Text = "";
            for (int i = 0; i < CadetView.RowCount; i++)
            {
                CadetView.Rows[i].Visible = true;
            }
        }
        
        private void searchBox_TextChanged(object sender, EventArgs e)
        {

        }
        //This is the same method as searchBtn_Click, except it is called when you hit the 'Enter' key while in searchBox
        private void searchEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                if (!String.IsNullOrEmpty(searchBox.Text))
                {
                    for (int i = 0; i < CadetView.RowCount; i++)
                    {
                        CurrencyManager m1 = (CurrencyManager)BindingContext[CadetView.DataSource];
                        m1.SuspendBinding();
                        String ser = result.Tables[0].Rows[i][0].ToString();
                        String[] find = ser.Split(' ');
                        if (!ser.Contains(searchBox.Text))// && find[0] != searchBox.Text && find[1] != searchBox.Text)
                        {
                            CadetView.Rows[i].Visible = false;
                        }
                        if (ser.Contains(searchBox.Text))// || find[0] == searchBox.Text || find[1] == searchBox.Text)
                        {

                            CadetView.Rows[i].Visible = true;
                        }
                        m1.ResumeBinding();
                    }
                }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        public void newTab(DataRow[] rows, int i)
        {
            CadetTab newCadet = new CadetTab(rows, i);
            TabPage uTab = new TabPage();
            uTab.Controls.Add(newCadet);
            uTab.Text = rows[i]["Name"].ToString();
            tabView.TabPages.Add(uTab);
            tabView.SelectedTab = uTab;


        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            if (tabView.SelectedTab.Text != "Cadet Table")
            {
                tabView.TabPages.Remove(tabView.SelectedTab);
            }
        }
    }
    
}
