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
using System.Windows;
using ExcelDataReader;
using Microsoft;
using XL = Microsoft.Office.Interop.Excel;
//TO-DO:
//Insertion: Houston: Pretty Much Complete
//Deletion: Prince
//Alteration: Austin
//Color problem with ordering: Complete
//Fields problem with ordering: Complete
//Multiple GPAs in the CadetTab: Houston
//Alter table according to Jungs specs
namespace WindowsFormsApp2
{
    public partial class CadetWatch : Form
    {
        public CadetWatch()
        {
            InitializeComponent();
        }
        DataSet result = new DataSet();
        String path = @"E:\OO Project\Project\eCadets.xlsx";//String path of the excel sheet
        private void CadetWatch_Load(object sender, EventArgs e)
        {
            Boolean t = true;
            Boolean f = false;
            CadetView.ReadOnly = t;   //Sets the datagrid to be non-editable
            CadetView.AllowUserToAddRows = f;
             //String path of the excel sheet
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
            for (int i = 0; i < CadetView.ColumnCount; i++)
            {
                CadetView.Columns[i].Visible = f;
            }
            CadetView.Columns["First Name"].Visible = t;
            CadetView.Columns["Last Name"].Visible = t;
            CadetView.Columns["MS Level"].Visible = t;
            CadetView.Columns["Major"].Visible = t;
            CadetView.Columns["Eagle ID"].Visible = t;

            //Sets photo column to non-visible, it will be a file path and therefore ugly

            searchBox.KeyDown += new KeyEventHandler(searchEnter);//Adds a key event handler for enter to the searchBox
            CadetView.CellFormatting += new DataGridViewCellFormattingEventHandler(CadetViewRed);//Adds an event handler for cell formatting to keep BackColor through sorting
            tabView.TabPages.Remove(testTab);
            fs.Close();
        }

        //This is a method to populate form 2 with information based on the cell you double-click on
        
        private void CadetView_CellDoubleClick(Object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0)
            {
                return;
            }
            DataGridViewRow rows = CadetView.Rows[e.RowIndex];
            newTab(rows);
            //The following line is obsolete
            //Form2 form2 = new Form2(rows, e.RowIndex);
        }
        //This method is to search the table based on what is in searchBox
        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(searchBox.Text)) {
                for (int i = 0; i < CadetView.RowCount; i++)
                {
                    CurrencyManager m1 = (CurrencyManager)BindingContext[CadetView.DataSource];
                    m1.SuspendBinding();
                    String fSer = CadetView.Rows[i].Cells["First Name"].Value.ToString();
                    String lSer = CadetView.Rows[i].Cells["Last Name"].Value.ToString();
                    String[] find = {fSer, lSer };
                    String ser = fSer + lSer;
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
            refresh();
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
                        String fSer = CadetView.Rows[i].Cells["First Name"].Value.ToString();
                        String lSer = CadetView.Rows[i].Cells["Last Name"].Value.ToString();
                        String[] find = { fSer, lSer };
                        String ser = fSer + lSer;
                        if (!ser.Contains(searchBox.Text))// && find[0] != searchBox.Text && find[1] != searchBox.Text)
                        {
                            CadetView.Rows[i].Visible = false;
                        }
                        if (ser.Contains(searchBox.Text))//||find[0] == searchBox.Text||find[1] == searchBox.Text)
                        {

                            CadetView.Rows[i].Visible = true;
                        }
                        m1.ResumeBinding();
                    }
                }
            }
        }
        //This method is called by the new cadet button to open and add cadet page
        public void newTab()
        {
            addCadet newCadet = new addCadet();
            newCadet.addPerson += (s, e) => AddCadet(newCadet);
            TabPage uTab = new TabPage();
            uTab.Controls.Add(newCadet);//This adds the newCadet controls to the uTab
            uTab.Text = "New Cadet";
            tabView.TabPages.Add(uTab);
            tabView.SelectedTab = uTab;
        }
        //This method is an overloaded method that creates a tab based on the row clicked and the userControl CadetTab
        public void newTab(DataGridViewRow rows)
        {
            CadetTab newCadet = new CadetTab(rows);
            TabPage uTab = new TabPage();
            uTab.Controls.Add(newCadet);//This adds the newCadet controls to the uTab
            uTab.Text = rows.Cells["First Name"].Value.ToString() + rows.Cells["Last Name"].Value.ToString();
            tabView.TabPages.Add(uTab);
            tabView.SelectedTab = uTab;
        }
        //Closes the current tab, excluding the table tab
        private void closeBtn_Click(object sender, EventArgs e)
        {
            int i = tabView.SelectedIndex;
            if (tabView.SelectedTab.Text != "Cadet Table")
            {
                tabView.TabPages.Remove(tabView.SelectedTab);
                tabView.SelectedIndex = i - 1;
            }
        }
        //Method to ensure that rows with lower than 2.0 GPA remain red after sorting, called by the load
        private void CadetViewRed(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (CadetView.Rows[e.RowIndex].Cells["Term GPA"].Value.ToString() != "") {
                if ((double)CadetView.Rows[e.RowIndex].Cells["Term GPA"].Value < 2.0)
                {
                    DataGridViewRow row = CadetView.Rows[e.RowIndex];
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }
        //A test method to see if writing to an excel sheet is possible, contains basis for sheet alteration.
        private void testInsert_Click(object sender, EventArgs e)
        {
           
            XL.Application excel = new XL.Application();
            excel.DisplayAlerts = false;
            XL.Workbooks wbs = excel.Workbooks;
            XL.Workbook wb = wbs.Open(path, ReadOnly: false, Editable: true);
            XL.Sheets wSheets = wb.Worksheets;
            XL.Worksheet ws = wSheets.Item[1] as XL.Worksheet;
            if(ws == null)
            {
                return;
            }
            int i = CadetView.Rows.Count;
            XL.Range row1 = ws.Rows.Cells[i + 2, 1];

            row1.Value = "Test100";
            Cleanup();
            excel.Application.ActiveWorkbook.SaveAs(path);
            excel.Application.Quit();
            excel.DisplayAlerts = true;
            excel.Quit();
            System.Threading.Thread.Sleep(15);
            refresh();
            
        }
        //Garbage collection of the variables in the testInsert_Click method
        private void Cleanup()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void newCadet_Click(object sender, EventArgs e)
        {
            newTab();
        }
        public void AddCadet(addCadet n)
        {
            XL.Application excel = new XL.Application();
            excel.DisplayAlerts = false;
            XL.Workbooks wbs = excel.Workbooks;
            XL.Workbook wb = wbs.Open(path, ReadOnly: false, Editable: true);
            XL.Sheets wSheets = wb.Worksheets;
            XL.Worksheet ws = wSheets.Item[1] as XL.Worksheet;
            if (ws == null)
            {
                return;
            }
            int i =CadetView.Rows.Count;
            XL.Range firstName = ws.Rows.Cells[i + 2, 1];
            XL.Range lastName = ws.Rows.Cells[i + 2, 2];
            XL.Range EagleID = ws.Rows.Cells[i + 2, 4];
            XL.Range msLevel = ws.Rows.Cells[i + 2, 5];
            XL.Range major = ws.Rows.Cells[i + 2, 15];

            firstName.Value = n.fNameText();
            lastName.Value = n.lNameText();
            EagleID.Value = n.idText();
            msLevel.Value = n.msText();
            major.Value = n.majorText();
            Cleanup();
            excel.Application.ActiveWorkbook.SaveAs(path);
            excel.Application.Quit();
            excel.DisplayAlerts = true;
            excel.Quit();
            System.Threading.Thread.Sleep(15);
            refresh();
        }
        public void refresh()
        {
            Boolean t = true;
            Boolean f = false;
            CadetView.ReadOnly = t;   //Sets the datagrid to be non-editable
            CadetView.AllowUserToAddRows = f;
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
            CadetView.CellFormatting += new DataGridViewCellFormattingEventHandler(CadetViewRed);//Adds an event handler for cell formatting to keep BackColor through sorting
            tabView.TabPages.Remove(testTab);
            fs.Close();
            searchBox.Text = "";
        }
    }
    
}
