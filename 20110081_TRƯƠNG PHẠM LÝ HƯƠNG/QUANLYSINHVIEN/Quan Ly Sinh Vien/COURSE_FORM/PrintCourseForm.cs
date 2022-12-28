using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Excel;
using System.IO;

namespace Quan_Ly_Sinh_Vien
{
    public partial class PrintCourseForm : Form
    {
        public PrintCourseForm()
        {
            InitializeComponent();
            AddTypeToSave();
            comboBox1.DataSource = loai;
            comboBox1.DisplayMember = "SaveTo";
        }


        private void buttonPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;
            if (printDlg.ShowDialog() == DialogResult.OK)
                printDoc.Print();
        }

        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;
                Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                //add rows
                int r = 0;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                    } //end row loop
                } //end column loop

                Word.Document oDoc = new Word.Document();
                oDoc.Application.Visible = true;

                //page orintation
                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;


                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for (r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + DataArray[r, c] + "\t";

                    }
                }

                //table format
                oRange.Text = oTemp;

                object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                      Type.Missing, Type.Missing, ref ApplyBorders,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

                oRange.Select();

                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();

                //header row style
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Times New Roman";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

                //add header row manually
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                }

                //table style 
                oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 5");
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                //header text
                foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
                {
                    Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                    headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }
                //save the file
                oDoc.SaveAs2(filename);
            }
        }
            private void ToExcel(DataGridView DGV, string fileName)
        {
            //khai báo thư viện hỗ trợ Microsoft.Office.Interop.Excel
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                //Tạo đối tượng COM.
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                //tạo mới một Workbooks bằng phương thức add()
                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                //đặt tên cho sheet
                worksheet.Name = "QUANLYSINHVIEN";

                // export header trong DataGridView
                for (int i = 0; i < DGV.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = DGV.Columns[i].HeaderText;
                }
                // export nội dung trong DataGridView
                for (int i = 0; i < DGV.RowCount; i++)
                {
                    for (int j = 0; j < DGV.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = DGV.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // sử dụng phương thức SaveAs() để lưu workbook với filename
                workbook.SaveAs(fileName);
                //đóng workbook
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Data exported successfully!", "Info");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }
        /*
         void exportexcel(DataGridView dgwObservaciones)
            {
                Excel.Application oXL; //Se va usar Excel e interactuar con la aplicación
                Excel._Workbook oWB; //Crea el libro
                Excel._Worksheet oSheet;

                try
                {
                    //Inicia Excel
                    oXL = new Excel.Application();
                    oXL.Visible = true;
                    //Obtiene el libro y la hoja con la que se va a trabajar
                    oWB = (Excel._Workbook)(oXL.Workbooks.Add(Missing.Value));
                    oSheet = (Excel._Worksheet)oWB.ActiveSheet;

                    //Ancho de columnas
                    oSheet.get_Range("A1").ColumnWidth = 30;
                    oSheet.get_Range("B1", "D1").ColumnWidth = 50;
                    //Empieza llenado
                    oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oWB.Worksheets.get_Item(1);

                    //Recorremos el DataGridView rellenando la hoja de trabajo
                    for (int i = 0; i < dgwObservaciones.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgwObservaciones.Columns.Count; j++)
                        {
                            DataGridViewCell cell = dgwObservaciones[j, i];
                            if (cell.Value.GetType() == typeof(byte[]))
                            {
                                string image = Convert.ToString(dgwObservaciones.CurrentRow.Cells[i].Value);
                                Excel.Range oRange = (Excel.Range)oSheet.Cells[i + 1, j + 1];
                                float Left = (float)((double)oRange.Left);
                                float Top = (float)((double)oRange.Top);
                                const float ImageSize = 32;
                                oSheet.Shapes.AddPicture(oSheet.Cells[i + 1, j + 1], Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, Left, Top, ImageSize, ImageSize);
                                oRange.RowHeight = ImageSize + 2;
                            }
                            else
                            {
                                oSheet.Cells[i + 1, j + 1] = cell.Value;
                            }
                        }
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
        */

        public List<TypeToSave> loai = new List<TypeToSave>();
        public class TypeToSave
        {
            public string SaveTo { get; set; }
        }

        public void AddTypeToSave()
        {
            loai.Add(new TypeToSave() { SaveTo = "Excel" });
            loai.Add(new TypeToSave() { SaveTo = "Doc.x" });
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Doc.x")
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Word Documents (.docx)|.docx";
                sfd.FileName = "Export.docx";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Export_Data_To_Word(dataGridView_information, sfd.FileName);
                    MessageBox.Show("Data Exported Successfully !!!", "Info");
                }
            }
            else if (comboBox1.Text == "Excel")
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel (*.xls)|*.xls";
                sfd.FileName = "Export.xls";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    //gọi hàm ToExcel()
                    ToExcel(dataGridView_information, sfd.FileName);
                }
            }
            else
            {
                try
                {
                    //TextWriter wrt = new StreamWriter(path);
                    string path = @"E:\Export.txt";
                    using (var wrt = new StreamWriter(path))
                    {
                        if (!File.Exists(path))
                        {
                            File.Create(path);
                        }


                        DateTime bdate;
                        for (int i = 0; i < dataGridView_information.Rows.Count; i++)
                        {
                            for (int j = 0; j < dataGridView_information.Rows.Count - 1; j++)
                            {
                                if (j == 3)
                                {
                                    bdate = Convert.ToDateTime(dataGridView_information.Rows[i].Cells[j].Value.ToString());
                                    wrt.Write("\t" + bdate.ToString("yyyy-MM-dd") + "\t");
                                }
                                /*
                                else if (j == dataGridView_information.Columns.Count - 2)
                                {
                                    wrt.Write("\t" + dataGridView_information.Rows[i].Cells[j].Value.ToString());
                                }*/
                                else
                                {
                                    wrt.Write("\t" + dataGridView_information.Rows[i].Cells[j].Value.ToString() + "\t");
                                }
                                //wrt.Write("\t" + dataGridView_information.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                            }
                            wrt.WriteLine("");
                            wrt.WriteLine("==================================================================================");
                        }
                        wrt.Close();
                        MessageBox.Show("Data Exported Successfully!", "Info");
                    }
                }
                catch (FileLoadException fe)
                {
                    fe.Message.ToString();
                }
            }
        }

        private void PrintCourseForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLYSINHVIENDataSet5.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter2.Fill(this.qUANLYSINHVIENDataSet5.Course);

        }
    }
}
