using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Accord.IO;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using Accord.Statistics.Kernels;
using Data = System.Data;
using Accord.Math;
using Accord;
using Accord.MachineLearning.VectorMachines.Learning;
using Accord.MachineLearning.VectorMachines;

namespace NetUI
{
    class AI
    {
        double[] output1;

        SupportVectorMachine<IKernel> svm;

        public double[,] load_excel(int arr_count)
        {
            double[,] arr_d = new double[arr_count, 2];

            try
            {
                Excel.Application app = new Excel.Application();
                
                Excel.Workbook book1 = app.Workbooks.Open(System.Windows.Forms.Application.StartupPath + @"\" + "Book");
                Excel.Worksheet sheet = (Excel.Worksheet)book1.Worksheets[1];

                Excel.Range range = sheet.get_Range("A1:B" + arr_count.ToString());

                int totalRows = range.Rows.Count;
                int totalColumns = range.Columns.Count;
                for (int rowCounter = 1; rowCounter <= totalRows; rowCounter++)
                {
                    var cellVal_x = sheet.Cells[rowCounter, 1];
                    var val_x = cellVal_x.Text;
                    arr_d[rowCounter - 1, 0] = Convert.ToDouble(val_x);


                    var cellVal_y = sheet.Cells[rowCounter, 2];
                    var val_y = cellVal_y.Text;
                    arr_d[rowCounter - 1, 1] = Convert.ToDouble(val_y);
                }

                app.Quit();


                
            }
            catch { MessageBox.Show("Excel read error.");}
            return (arr_d);
        }

        private IKernel createKernel(double[,] arr)
        {
            decimal numSigma = 0;

            //Data.DataTable source = arr as Data.DataTable;
           
            // Get only the input vector values (in the first two columns)
            double[][] inputs = arr.GetColumns(0, 1).ToJagged();

            DoubleRange range; // valid range will be returned as an out parameter
            Gaussian gaussian = Gaussian.Estimate(inputs, inputs.Length, out range);

            numSigma = (decimal)gaussian.Sigma;

            return new Accord.Statistics.Kernels.Gaussian((double)numSigma);
        }

        public void create_regression(double[,] arr)
        {
            try
            {
                // Creates a matrix from the entire source data table
                double[][] table = arr.ToJagged();

                // Get only the input vector values (first column)
                double[][] inputs = table.GetColumns(0);

                // Get only the outputs (last column)
                double[] outputs = table.GetColumn(1);


                // Create the specified Kernel
                IKernel kernel = createKernel(arr);

                // Creates a new SMO for regression learning algorithm
                var teacher = new SequentialMinimalOptimizationRegression()
                {
                    // Set learning parameters
                    Complexity = 1.0000000,
                    Tolerance = 0.0010000,
                    Epsilon = 0.0010000,
                    Kernel = kernel
                };

                svm = teacher.Learn(inputs, outputs);

                // Show the support vector labels on the scatter plot
                var supportVectorLabels = new double[svm.SupportVectors.Length];
                for (int i = 0; i < supportVectorLabels.Length; i++)
                {
                    int j = inputs.Find(sv => sv == svm.SupportVectors[i])[0];
                    supportVectorLabels[i] = outputs[j];
                }

                testing(arr);
            }
            catch { MessageBox.Show("Kernel create error."); }
        }

        private void testing(double[,] arr)
        {

            // Extract the first columns (X)
            double[][] inputs = arr.GetColumns(0).ToJagged();

            // Extract the expected output values
            double[] expected = arr.GetColumn(1);

            // Compute the actual machine outputs
            double[] output = svm.Score(inputs);

            if (output.Length == 4)
            {
                output1 = new double[output.Length];
                for (int i = 0; i < output.Length; i++)
                    output1[i] = output[i];
            }
            else if (output.Length % 4 == 0)
            {
                for (int i = output.Length; i > (output.Length - output1.Length); i--)
                {
                    if(output[i-1] > (output1[i - (output.Length - output1.Length)-1] + 20))
                    {
                        MessageBox.Show("Network load is not matching predicted values. It could be network attack.");
                        return;
                    }
                }
            }
        }
    }
}
