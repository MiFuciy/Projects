using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Collections;
using Microsoft.Office.Interop.Excel;

using Excel = Microsoft.Office.Interop.Excel;

namespace NetUI
{
    class AdFunctions
    {
        int excel_exist = 0;
        AI ai_call = new AI();
        //Form_Graph graph_call = new Form_Graph();

        List<int> y = new List<int>() { 0 };
        List<string> x = new List<string>() { "0" };


        public void Ip_List(string firstIp, string secondIp)
        {
            //MessageBox.Show(" First " + firstIp + " Second " + secondIp);

            //Variables to control file status
            int fileEmpty = 0;
            int firstIPExist = 0;
            int secondIPExist = 0;

            //New File stream too create file if it's not exists
            FileStream FileCheck = new FileStream("TraceIP.txt", FileMode.OpenOrCreate);
            FileCheck.Close();

            //check is file is empty
            string[] strok = File.ReadAllLines("TraceIP.txt");
            if (strok.Length == 0)
            {
                fileEmpty = 1;
            }

            FileStream srFile = new FileStream("TraceIP.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(srFile);
            string line;

            //cheking file for existing Ip
            if (fileEmpty == 0)
            {
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();

                    if (line == firstIp)
                    {
                        firstIPExist = 1;
                    }

                    if (line == secondIp)
                    {
                        secondIPExist = 1;
                    }
                }
                sr.Close();

                //adding new Ip
                if (firstIPExist == 0)
                {
                    FileStream aFile = new FileStream("TraceIP.txt", FileMode.OpenOrCreate);
                    StreamWriter sw = new StreamWriter(aFile);
                    aFile.Seek(0, SeekOrigin.End);
                    sw.WriteLine(firstIp);
                    sw.Close();
                    //MessageBox.Show("New unknown IP added to IP List \nPlease go to 'IP Options' menu to view it.");
                    firstIPExist = 0;
                }

                if (secondIPExist == 0)
                {
                    FileStream aFile = new FileStream("TraceIP.txt", FileMode.OpenOrCreate);
                    StreamWriter sw = new StreamWriter(aFile);
                    aFile.Seek(0, SeekOrigin.End);
                    sw.WriteLine(secondIp);
                    sw.Close();
                    //MessageBox.Show("New unknown IP added to IP List \nPlease go to 'IP Options' menu to view it.");
                    secondIPExist = 0;
                }
            }
            else
            {
                StreamWriter sw = new StreamWriter(srFile);
                srFile.Seek(0, SeekOrigin.End);
                sw.WriteLine(firstIp);
                sw.WriteLine(secondIp);
                sw.Close();
                //MessageBox.Show("New unknown IP added to IP List \nPlease go to 'IP Options' menu to view it.");
                return;
            }
        }

        public void excel_push(string[] x_arr, int[] y_arr)
        {
            try
            {
                if (File.Exists(System.Windows.Forms.Application.StartupPath + @"\" + "Book.xlsx") == false)
                {

                    Excel.Application excel_app = new Excel.Application();
                    Workbook workbook = excel_app.Workbooks.Add();
                    Worksheet sheet = workbook.Sheets.Add();

                    for (int i = 0; i < x_arr.Length; i++)
                    {
                        sheet.Cells[i + 1, 1] = i + 1;
                        sheet.Cells[i + 1, 2] = y_arr[i];
                    }

                    
                    
                    workbook.SaveAs(System.Windows.Forms.Application.StartupPath + @"\" + "Book");
                    workbook.Close();
                    excel_app.Quit();
                }
                else
                {
                    Excel.Application app = new Excel.Application();

                    Workbook book1 = app.Workbooks.Open(System.Windows.Forms.Application.StartupPath + @"\" + "Book");
                    Worksheet sheet = (Excel.Worksheet)book1.Worksheets[1];

                    for (int i = 0; i < x_arr.Length; i++)
                    {
                        sheet.Cells[i + 1, 1] = i + 1;
                        sheet.Cells[i + 1, 2] = y_arr[i];
                    }
                    app.DisplayAlerts = false;

                    /*book1.SaveAs(System.Windows.Forms.Application.StartupPath + @"\" + "Book", Type.Missing,
                    Type.Missing, Type.Missing, false, false,
                    XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing);*/

                    book1.SaveAs(System.Windows.Forms.Application.StartupPath + @"\" + "Book");
                    book1.Close();
                    app.Quit();
                }
            }
            catch { MessageBox.Show("Excel write error."); }
        }

        public void susp_node(int lenght, TreeNode node)
        {
            Form_Main run = new Form_Main();

            //check if UDP lenght is too big
            if (lenght >= 300)
            {
                //MessageBox.Show("This UPD pakcet is suspicious due to it's big length.");
                node.BackColor = System.Drawing.Color.Red;
            }
        }


        //Функция для создания массивов
        public void networkload(int pack_count, string current_time, out string[] x_arr, out int[] y_arr)
        {

            x.Add(current_time);
            y.Add(pack_count);

            x_arr = x.ToArray();
            y_arr = y.ToArray();


            
            if (x_arr.Length%4 == 0)
            {
                

                excel_push(x_arr, y_arr);

                double[,] arr_d = ai_call.load_excel(x_arr.Length);
                ai_call.create_regression(arr_d);
                

            }

            
        }

    }
}