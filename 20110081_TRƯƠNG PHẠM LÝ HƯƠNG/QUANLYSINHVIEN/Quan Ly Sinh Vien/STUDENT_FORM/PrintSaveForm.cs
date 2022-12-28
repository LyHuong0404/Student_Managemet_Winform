using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;


namespace Quan_Ly_Sinh_Vien
{
    public partial class PrintSaveForm : Form
    {
        public PrintSaveForm()
        {
            InitializeComponent();
            AddTypeToSave();
            comboBoxFileType.DataSource = loai;
            comboBoxFileType.DisplayMember = "SaveTo";
        }

        public void LoadData(string query)
        {
            string strCon = @"Data Source=(local);Initial Catalog=QUANLYSINHVIEN;Integrated Security=True";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = strCon;
            dataGridView_information.RowTemplate.Height = 80;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet("std");
                adapter.Fill(ds, "std");
                System.Data.DataTable table = ds.Tables["std"];
                dataGridView_information.DataSource = table;

                dataGridView_information.Columns[0].HeaderText = "Student ID";
                dataGridView_information.Columns[1].HeaderText = "First Name";
                dataGridView_information.Columns[2].HeaderText = "Last Name";
                dataGridView_information.Columns[3].HeaderText = "BirthDate";
                dataGridView_information.Columns[4].HeaderText = "Gender";
                dataGridView_information.Columns[5].HeaderText = "Phone";
                dataGridView_information.Columns[6].HeaderText = "Address";
                dataGridView_information.Columns[7].HeaderText = "Picture";

                picCol = (DataGridViewImageColumn)dataGridView_information.Columns[7];
                picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                dataGridView_information.AllowUserToAddRows = false;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }
            finally
            {
                conn.Dispose();
            }
        }
        private void PrintSaveForm_Load(object sender, EventArgs e)
        {
            radioButton_all.Checked = true;
            radioButton_No.Checked = true;

            if (radioButton_No.Checked)
            {
                dateTimePicker_Start.Enabled = false;
                dateTimePicker_End.Enabled = false;
            }
            string query = "SELECT * FROM std";
            LoadData(query);
        }

        private void radioButton_Yes_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker_Start.Enabled = true;
            dateTimePicker_End.Enabled = true;
        }

        private void radioButton_No_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker_Start.Enabled = false;
            dateTimePicker_End.Enabled = false;
        }

        private void button_Check_Click(object sender, EventArgs e)
        {
            string strSQL = "SELECT * FROM std";

            if (radioButton_Yes.Checked == true)
            {
                string start = dateTimePicker_Start.Value.ToString("yyyy-MM-dd");
                string end = dateTimePicker_End.Value.ToString("yyyy-MM-dd");

                if (radioButton_all.Checked == true)
                    strSQL += " WHERE bdate BETWEEN '" + start + " 'AND' " + end + "'";

                else if (radioButton_Male.Checked == true)
                    strSQL += " WHERE gender = 'Male' AND bdate BETWEEN '" + start + " 'AND' " + end + "'";

                else
                    strSQL += " WHERE gender = 'Female' AND bdate BETWEEN '" + start + " 'AND' " + end + "'";

                LoadData(strSQL);
            }
            else
            {
                if (radioButton_Male.Checked == true)
                {
                    strSQL += " WHERE gender = 'Male'";
                }
                else if (radioButton_Female.Checked)
                {
                    strSQL += " WHERE gender = 'Female'";
                }
                LoadData(strSQL);
            }
        }

        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            try
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
                    oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
                    oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

                    //add header row manually
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                    }

                    //table style 
                    oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 5");
                    oDoc.Application.Selection.Tables[1].Rows[1].Select();
                    oDoc.Application.Selection.Cells.VerticalAlignment =
                        Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                    //oDoc.Tables[1].Cell(1, 4).Range.Shading.BackgroundPatternColor = Word.WdColor.wdColorDarkRed;
                    oDoc.Tables[1].Range.Shading.BackgroundPatternColor = Word.WdColor.wdColorWhite;
                    //oDoc.Application.Selection.Tables[1].Rows[1].Range.Shading.BackgroundPatternColor = Word.WdColor.wdColorBrightGreen;
                    oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Color = Word.WdColor.wdColorBlack;
                    //header text
                    foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
                    {
                        Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                        headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                        headerRange.Text = "BỘ GIÁO DỤC VÀ ĐÀO TẠO                                         CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM         ĐẠI HỌC SPKT                                                                         Độc lập - Tự do - Hạnh phúc\n\n" + "DANH SÁCH SINH VIÊN";
                        headerRange.Font.Bold = 4;
                        headerRange.Font.Color = Word.WdColor.wdColorBlack;
                        headerRange.Font.Size = 14;
                        headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    }

                    int n = DGV.Rows.Count;
                    for (int i = 0; i < n; i++)
                    {
                        byte[] imgbyte = (byte[])DGV.Rows[i].Cells[7].Value;
                        Object oMissing = System.Reflection.Missing.Value;
                        MemoryStream ms = new MemoryStream(imgbyte);
                        System.Drawing.Image sparePicture = System.Drawing.Image.FromStream(ms);
                        System.Drawing.Image finalPic = (System.Drawing.Image)(new Bitmap(sparePicture, new
                            Size(90, 90)));
                        Clipboard.SetDataObject(finalPic);
                        var oPara2 = oDoc.Content.Paragraphs.Add(ref oMissing);
                        oDoc.Tables[1].Cell(2 + i, 8).Range.Paste();
                    }
                    //save the file
                    oDoc.SaveAs2(filename);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
        private void button_Print_Click(object sender, EventArgs e)
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

        public List<TypeToSave> loai = new List<TypeToSave>();
        public class TypeToSave
        {
            public string SaveTo { get; set; }
        }

        public void AddTypeToSave()
        {
            loai.Add(new TypeToSave() { SaveTo = "Text" });
            loai.Add(new TypeToSave() { SaveTo = "PDF" });
            loai.Add(new TypeToSave() { SaveTo = "Excel" });
            loai.Add(new TypeToSave() { SaveTo = "Doc.x" });
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            if (comboBoxFileType.Text == "Doc.x")
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
            else if (comboBoxFileType.Text == "PDF")
            {
                if (dataGridView_information.Rows.Count > 0)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "PDF (*.pdf)|*.pdf";
                    sfd.FileName = "Output.pdf";
                    bool fileError = false;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        if (File.Exists(sfd.FileName))
                        {
                            try
                            {
                                File.Delete(sfd.FileName);
                            }
                            catch (IOException ex)
                            {
                                fileError = true;
                                MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                            }
                        }
                        if (!fileError)
                        {
                            try
                            {
                                PdfPTable pdfTable = new PdfPTable(dataGridView_information.Columns.Count);
                                pdfTable.DefaultCell.Padding = 3;
                                pdfTable.WidthPercentage = 100;
                                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                                foreach (DataGridViewColumn column in dataGridView_information.Columns)
                                {
                                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                    pdfTable.AddCell(cell);

                                }
                                foreach (DataGridViewRow row in dataGridView_information.Rows)
                                {
                                    string id = row.Cells[0].Value.ToString();
                                    pdfTable.AddCell(id);
                                    string Fname = row.Cells[1].Value.ToString();
                                    pdfTable.AddCell(Fname);
                                    string Lname = row.Cells[2].Value.ToString();
                                    pdfTable.AddCell(Lname);
                                    string Bdate = row.Cells[3].Value.ToString();
                                    pdfTable.AddCell(Bdate);
                                    string gender = row.Cells[4].Value.ToString();
                                    pdfTable.AddCell(gender);
                                    string phone = row.Cells[5].Value.ToString();
                                    pdfTable.AddCell(phone);
                                    string address = row.Cells[6].Value.ToString();
                                    pdfTable.AddCell(address);
                                    byte[] imageByte = (byte[])row.Cells[7].Value;
                                    iTextSharp.text.Image Image = iTextSharp.text.Image.GetInstance(imageByte);
                                    pdfTable.AddCell(Image);
                                }
                                using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                                {
                                    Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                    PdfWriter.GetInstance(pdfDoc, stream);
                                    pdfDoc.Open();
                                    pdfDoc.Add(pdfTable);
                                    pdfDoc.Close();
                                    stream.Close();
                                }

                                MessageBox.Show("Data Exported Successfully !!!", "Info");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error :" + ex.Message);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No Record To Export !!!", "Info");
                }
            }
            else if (comboBoxFileType.Text == "Excel")
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
                //TextWriter wrt = new StreamWriter(path);
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\studentlist.txt";
                using (var wrt = new StreamWriter(path))
                {
                    if (!File.Exists(path))
                    {
                        File.Create(path);
                    }

                    DateTime bdate;
                    for (int i = 0; i < dataGridView_information.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView_information.Columns.Count; j++)
                        {
                            if (j == 3)
                            {
                                bdate = Convert.ToDateTime(dataGridView_information.Rows[i].Cells[j].Value.ToString());
                                wrt.Write("\t" + bdate.ToString("yyyy-MM-dd") + "\t|");
                            }

                            else if (j == dataGridView_information.Columns.Count - 2)
                            {
                                wrt.Write("\t" + dataGridView_information.Rows[i].Cells[j].Value.ToString());
                            }
                            else
                            {
                                wrt.Write("\t" + dataGridView_information.Rows[i].Cells[j].Value.ToString() + "\t|");
                            }
                            //wrt.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                        }
                        wrt.WriteLine("");
                        wrt.WriteLine("========================================================================================================================");
                    }
                    wrt.Close();
                    MessageBox.Show("Data Exported Successfully!", "Info");
                }
            }
        }
    }
}
