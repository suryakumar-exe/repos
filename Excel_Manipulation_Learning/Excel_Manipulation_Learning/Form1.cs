using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using ClosedXML.Excel;
using ExcelDataReader;


using System.Reflection;
using Spire.Xls;
using Spire.Xls.Collections;
using Application = Microsoft.Office.Interop.Excel.Application;
using System.IO;
using ExcelDataReader;

using Aspose.Words.Tables;


namespace Excel_Manipulation_Learning
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTableCollection tableCollection;
        string Fatigue_excel = "";
        string QuickView_excel = "";
        string pitch_excel = "";

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {

                Excel.Application xlApp1 = new Excel.Application();
                Excel.Workbooks xlWbks1 = xlApp1.Workbooks;
                Excel.Workbook xlWbk1 = xlWbks1.Open(@"D:\LOADS PROJECT\QuickView_Design_Loads_Delta4000 (004).xlsx");
                Excel.Worksheet xlWorkSheet1 = xlWbk1.Sheets["Pitch N155_4.X"];
                xlWorkSheet1.Activate();
                xlApp1.Visible = true;
                /*  string m_del_value = "DEL m=" + v;
                  string m_meqn_value = "MEQn m=" + v;*/
                Excel.Range xlUsedRange1 = xlWorkSheet1.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing);
                //object[] myCriteria = new object[] { "MREQn m=3", "MEQn m=5"};
                xlUsedRange1.AutoFilter(2, "DEL m=5", Excel.XlAutoFilterOperator.xlAnd, Type.Missing, Type.Missing);
                //xlUsedRange1.AutoFilter(2, "MREQn m=3", Excel.XlAutoFilterOperator.xlOr,,Type.Missing);

                Excel.Range filteredRange1 = xlUsedRange1.SpecialCells(Excel.XlCellType.xlCellTypeVisible);

                MessageBox.Show("Clear All Filter?");
                xlUsedRange1.Worksheet.AutoFilterMode = false;
            }
            catch (Exception theException)
            {
                String errorMessage;
                errorMessage = "Error: ";
                errorMessage = String.Concat(errorMessage, theException.Message);
                errorMessage = String.Concat(errorMessage, " Line: ");
                errorMessage = String.Concat(errorMessage, theException.Source);

                MessageBox.Show(errorMessage, "Error");
            }







        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                Excel.Application xlApp = new Excel.Application();
                Excel.Workbooks xlWbks = xlApp.Workbooks;
                //Excel.Workbook xlWbk = xlWbks.Open(@"D:\LOADS PROJECT\fatigue_comparison_ed4_SSLXXX (003).xlsx");
                Excel.Workbook xlWbk = xlWbks.Open(Fatigue_excel);
                Excel.Sheets xlSheets = xlWbk.Sheets;
                Excel.Worksheet xlWorkSheet = xlSheets.get_Item(1);
                

                

                List<KeyValuePair<string, string>> d = new List<KeyValuePair<string, string>>();


                d.Add(new KeyValuePair<string, string>("Pitch - Lau Lagun/TMB reinforced", "3"));
                d.Add(new KeyValuePair<string, string>("Pitch - Lau Lagun/TMB reinforced", "5"));
                d.Add(new KeyValuePair<string, string>("Pitch - Lau Lagun/TMB reinforced", "9"));

                int f = 0;
                foreach (var q in d)
                {
                    if ((q.Key == "Pitch - Lau Lagun/TMB reinforced") && (q.Value == "10"))
                    {
                        f += 1;
                    }
                }
                if (f == 0)
                {
                    d.Add(new KeyValuePair<string, string>("Pitch - Lau Lagun/TMB reinforced", "10"));
                }
                Excel.Range xlUsedRange = xlWorkSheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing);


                //pitch
                foreach (var q in d)
                {
                    xlUsedRange.AutoFilter(3,q.Key, Excel.XlAutoFilterOperator.xlAnd, Type.Missing, Type.Missing);
                    xlUsedRange.AutoFilter(10, q.Value, Excel.XlAutoFilterOperator.xlAnd, Type.Missing, Type.Missing);
                    xlApp.Visible = true;
                    perform(q.Key, q.Value);
                
                    
                
                }
                      
                        
     
               void perform(string ki,string val)
                {
                    Excel.Range filteredRange = xlUsedRange.SpecialCells(Excel.XlCellType.xlCellTypeVisible);
                    var sensorName1 = new List<string>();

                    foreach (Excel.Range area in filteredRange.Areas)
                    {
                        foreach (Excel.Range row in area.Rows)
                        {
                            if (((Excel.Range)row.Cells[1, 6]).Text == "Common Sensor Name")
                            {
                                continue;
                            }
                            else if (((Excel.Range)row.Cells[1, 6]).Text != "")
                            {
                                //MessageBox.Show(((Excel.Range)row.Cells[1, 6]).Text);
                                sensorName1.Add(((Excel.Range)row.Cells[1, 6]).Text);

                            }
                            else
                            {
                                break;
                            }

                        }
                    }
                

                    Excel.Application xlApp1 = new Excel.Application();
                    Excel.Workbooks xlWbks1 = xlApp1.Workbooks;
                    Excel.Workbook xlWbk1 = xlWbks1.Open(QuickView_excel);

                    string temp_sheet = "";
                    if (ki.Substring(0,5).ToLower()=="pitch")
                    {
                        temp_sheet = pitch_excel;
                    }
                    else if (ki.Substring(0, 5).ToLower() == "Tower")
                    {
                        // temp_sheet = tower_excel;
                    }
                    else if (ki.Substring(0, 5).ToLower() == "blade")
                    {
                       // temp_sheet = blade_excel;
                    }
                    else if (ki.Substring(0, 5).ToLower() == "hub")
                    {
                        // temp_sheet = hub_excel;
                    }
                    else
                    {

                    }
                    Excel.Worksheet xlWorkSheet1 = xlWbk1.Sheets[temp_sheet];
                    xlWorkSheet1.Activate();
                    // xlApp1.Visible = true;
                    string m_del_value = "DEL m=" + val;
                    string m_meqn_value = "MEQn m=" + val ;
                    Excel.Range xlUsedRange1 = xlWorkSheet1.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing);
                    //object[] myCriteria = new object[] { "MREQn m=3", "MEQn m=5"};
                    if (val.Equals("3"))
                    {
                        xlUsedRange1.AutoFilter(2, "MREQn m=3", Excel.XlAutoFilterOperator.xlAnd,Type.Missing,Type.Missing);
                    }
                    else
                    {
                        xlUsedRange1.AutoFilter(2, m_del_value, Excel.XlAutoFilterOperator.xlOr, m_meqn_value, true);
                    }
                  
                    //xlUsedRange1.AutoFilter(2, "MREQn m=3", Excel.XlAutoFilterOperator.xlOr,,Type.Missing);

                    Excel.Range filteredRange1 = xlUsedRange1.SpecialCells(Excel.XlCellType.xlCellTypeVisible);

                    var Dicval = new Dictionary<string, string>();  

                    foreach (Excel.Range area1 in filteredRange1.Areas)
                    {
                        foreach (Excel.Range row in area1.Rows)
                        {
                   

                            if (((Excel.Range)row.Cells[1, 1]).Text == "Design Loads Delta4000 > Pitch N155/4.X")
                            {
                                continue;
                            }
                            else if (((Excel.Range)row.Cells[1, 1]).Text != "" && ((Excel.Range)row.Cells[1, 2]).Text == m_del_value)
                            {
                         
                                Dicval.Add(((Excel.Range)row.Cells[1, 1]).Text, ((Excel.Range)row.Cells[1, 3]).Text);
                             
                            }
                            else if (((Excel.Range)row.Cells[1, 1]).Text != "" && ((Excel.Range)row.Cells[1, 2]).Text ==m_meqn_value)
                            {
                           
                                String s = ((Excel.Range)row.Cells[1, 1]).Text + "_MEqn";
                                Dicval.Add(s, ((Excel.Range)row.Cells[1, 3]).Text);
                          

                            }
                            else if (((Excel.Range)row.Cells[1, 1]).Text != "" && ((Excel.Range)row.Cells[1, 2]).Text == "MREQn m=3")
                            {
                                String s = ((Excel.Range)row.Cells[1, 1]).Text + "_MREqn";
                                Dicval.Add(s, ((Excel.Range)row.Cells[1, 3]).Text);
                            }
                            else
                            {
                                break;
                            }

                        }
                    }
                    var orgSen = new List<string>();

                    for (int i = 0; i < sensorName1.Count; i++)
                    {
                        foreach (var k in Dicval)
                        {
                            if (sensorName1[i] == k.Key)
                            {
                                //MessageBox.Show(k.Value);
                                orgSen.Add(k.Value);
                            }
                        }
                    }
                    int cnt = orgSen.Count;
                    int j = 0;
                    //filteredRange.get_Range("D4","D20").Value2 =orgSen;
                    foreach (Excel.Range area in filteredRange.Areas)
                    {
                        foreach (Excel.Range row in area.Rows)
                        {
                            if (((Excel.Range)row.Cells[1, 11]).Text == "D.L.E")
                            {
                                continue;
                            }
                            else if (((Excel.Range)row.Cells[1, 11]).Text == "")
                            {
                                if (j != (cnt))
                                {
                                    row.Cells[1, 11].value2 = orgSen[j]; //no not 2 its [1,11]
                                    j += 1;
                                }
                                else
                                {
                                    break;
                                }
                                //MessageBox.Show(((Excel.Range)row.Cells[1, 6]).Text);
                            }
                            else
                            {
                                break;
                            }

                        }
                    }
                    sensorName1.Clear();
                    orgSen.Clear();
                    Dicval.Clear();
                }
                

            }
            catch (Exception theException)
            {
                String errorMessage;
                errorMessage = "Error: ";
                errorMessage = String.Concat(errorMessage, theException.Message);
                errorMessage = String.Concat(errorMessage, " Line: ");
                errorMessage = String.Concat(errorMessage, theException.Source);

                MessageBox.Show(errorMessage, "Error");
            }


        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx|Excel 97-2003 Workbookj|*.xls" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Fatigue.Text = openFileDialog.FileName;
                    //MessageBox.Show(openFileDialog.FileName);
                    Fatigue_excel = openFileDialog.FileName;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx|Excel 97-2003 Workbookj|*.xls" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    QuickView.Text = openFileDialog.FileName;
                    //MessageBox.Show(openFileDialog.FileName);
                    QuickView_excel = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tableCollection = result.Tables;
                            quickview_cb.Items.Clear();
                            foreach (System.Data.DataTable table in tableCollection)
                            {
                               quickview_cb.Items.Add(table.TableName);
                           

                            }

                        }
                    }
                }
            }

        }

        private void quickview_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Data.DataTable new_one_sheet = tableCollection[quickview_cb.SelectedItem.ToString()];
            //dataGridView1.DataSource = new_one_sheet.DefaultView;
            pitch_excel = quickview_cb.SelectedItem.ToString();
            MessageBox.Show(pitch_excel);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
