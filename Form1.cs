using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private string[] SelectedFiles;
        private void btn_select_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Excel Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "xls",
                Filter = "Excel Files|*.xls;*.xlsx;",

                //FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true,
                Multiselect = true

            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileNameInd = "";
                txt_selectedfiles.Clear();
                foreach (string name in openFileDialog1.FileNames)
                {
                    txt_selectedfiles.Text += name + Environment.NewLine;
                    fileNameInd = Path.GetFileNameWithoutExtension(name);
                    txt_destloc.Text += @"C:\ExcelConvertor\Target\" + fileNameInd + ".csv" + Environment.NewLine;
                }
                SelectedFiles = openFileDialog1.FileNames;
            }
            else
            {
                txt_destloc.Text = "";
                txt_selectedfiles.Text = "";
            }
        }

        private void btn_Process_Click(object sender, EventArgs e)
        {
            IExcelDataReader excelDataReader;
            FileStream fileStream;
            DataSet result;
            foreach (string singleFile in SelectedFiles)
            {
                FileInfo fi = new FileInfo(singleFile);
                if (fi.Extension == ".xls") //xls 97-2003
                {
                    fileStream = File.Open(singleFile, FileMode.Open, FileAccess.Read);
                    excelDataReader = ExcelReaderFactory.CreateBinaryReader(fileStream);
                    result = excelDataReader.AsDataSet();
                    PlaceFile(result,Path.GetFileNameWithoutExtension(fi.Name));
                }
                else  //xlsx //XML
                {
                    fileStream = File.Open(singleFile, FileMode.Open, FileAccess.Read);
                    excelDataReader = ExcelReaderFactory.CreateOpenXmlReader(fileStream);
                    result = excelDataReader.AsDataSet();
                    PlaceFile(result, Path.GetFileNameWithoutExtension(fi.Name));
                }
                fileStream.Close();
                excelDataReader.Close();
            }
            Process.Start(@"C:\ExcelConvertor\Target");
        }
        private void PlaceFile(DataSet result,string filename)
        {
            string csvData = "";
            int row_no = 0;

            while (row_no < result.Tables[0].Rows.Count) // ind is the index of table
                                                           // (sheet name) which you want to convert to csv
            {
                for (int i = 0; i < result.Tables[0].Columns.Count; i++)
                {
                    csvData += result.Tables[0].Rows[row_no][i].ToString() + ", ";
                }
                row_no++;
                csvData += "\n";
            }
            string root = @"C:\ExcelConvertor\Target\";
            if (!Directory.Exists(root)) //Create Dir if not Exists
            {
                Directory.CreateDirectory(root);
            }
            string output = root + filename + ".csv"; // define your own filepath & filename
            StreamWriter csv = new StreamWriter(@output, false);
            csv.Write(csvData);
            csv.Close();
        }
    }
}
