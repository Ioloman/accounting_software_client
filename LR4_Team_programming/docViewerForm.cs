using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Printing;
using System.Drawing;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
using Xceed.Words.NET;
using Xceed.Document.NET;

namespace LR4_Team_programming
{
    public partial class docViewerForm : Form
    {
        int counter = 0; // сквозной номер строки в массиве строк, которые выводятся
        int curPage; // текущая страница

        private string createdFileName = String.Empty;
        private docViewerForm()
        {
            InitializeComponent();
        }

        public docViewerForm(string numberDoc, 
                             string dep, 
                             string createDate, 
                             List<List<String>> data, 
                             mainForm.docTypes docType, 
                             string pathToTemplate) // для всего, кроме сводного учета
        {
            InitializeComponent();
            string fileName = makeDocument(docType, numberDoc, dep, createDate, data, pathToTemplate);
            createdFileName = fileName;
            showDocument(fileName);
        }
        public docViewerForm(string dep, 
                             string startDate, 
                             string endDate, 
                             List<List<String>> data, 
                             string pathToTemplate)// для сводного учета
        {
            InitializeComponent();
            string fileName = makeDocument(mainForm.docTypes.analysis, dep, startDate, endDate, data, pathToTemplate);
            createdFileName = fileName;
            showDocument(fileName);
        }

        private string makeDocument(mainForm.docTypes docType, 
                                    string numberDoc, 
                                    string dep, 
                                    string createDate, 
                                    List<List<string>> data, 
                                    string pathToTemplate, 
                                    string docName = null)
        {
            // Если docName = null, то к шаблону добавляется текущая дата - это название рапорта.
            // возвращает путь, по которому сохранен документ
            DocX document = DocX.Load(pathToTemplate);
            if (docType == mainForm.docTypes.report  || docType == mainForm.docTypes.vedomost || docType == mainForm.docTypes.analysis)
            {
                document.Paragraphs[2].Append(numberDoc).FontSize(14).
                    Font("Times New Roman").UnderlineStyle(UnderlineStyle.singleLine).Bold(true);  
                document.Paragraphs[3].Append(dep).FontSize(14).
                    Font("Times New Roman").UnderlineStyle(UnderlineStyle.singleLine).Bold(true); 
                document.Paragraphs[4].Append(createDate).FontSize(14).
                    Font("Times New Roman").UnderlineStyle(UnderlineStyle.singleLine).Bold(true);                
            }
            if (docType == mainForm.docTypes.balances)
            {
                document.Paragraphs[2].Append(dep).FontSize(14).
                    Font("Times New Roman").UnderlineStyle(UnderlineStyle.singleLine).Bold(true); 
                document.Paragraphs[3].Append(createDate).FontSize(14).
                    Font("Times New Roman").UnderlineStyle(UnderlineStyle.singleLine).Bold(true);  
            }

            Table tableinDoc = document.Tables[0];
            for (int i = 0; i < data.Count; i++)
            {
                tableinDoc.InsertRow();
                for (int j = 0; j < data[i].Count; j++)
                    tableinDoc.Rows[i + 1].Cells[j].Paragraphs[0].Append(data[i][j]).FontSize(14).
                        Font("Times New Roman");
            }
            if (docName == null)
            {
                string path = pathToTemplate.Substring(0, pathToTemplate.Length - 5) + DateTime.Now.ToString().Replace(":", "-") + ".docx";
                document.SaveAs(path);
                document.Dispose();             
                return path;
            }
            else
            {
                document.SaveAs(docName);
                document.Dispose();
                return docName;
            }
        }

        private void showDocument(string filename)
        {
            docViewer.ReadOnly = false;
            docViewer.Text = "";
            Word.Application wordObject = new Word.Application();
            object File = filename;
            object nullobject = Missing.Value;
            Word._Document docs = wordObject.Documents.Open(
                ref File, ref nullobject, ref nullobject, ref nullobject, 
                ref nullobject, ref nullobject, ref nullobject, ref nullobject,
                ref nullobject, ref nullobject, ref nullobject, ref nullobject, 
                ref nullobject, ref nullobject, ref nullobject, ref nullobject);
            docs.ActiveWindow.Selection.WholeStory();
            docs.ActiveWindow.Selection.Copy();
            docViewer.Paste();
            docs.Close(ref nullobject, ref nullobject, ref nullobject);  
            docViewer.ReadOnly = true;
            wordObject.Quit(ref nullobject, ref nullobject, ref nullobject);
        }

        private void printButton_Click(object sender, EventArgs e)
        {
                
        }

        private delegate DialogResult ShowSaveFileDialogInvoker();
        private void editButton_Click(object sender, EventArgs e)
        {        
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            ShowSaveFileDialogInvoker invoker = new ShowSaveFileDialogInvoker(saveFileDialogMethod);
            mainForm.activ.Invoke(invoker);
        }      
        private DialogResult saveFileDialogMethod()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = "docx";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return DialogResult.Cancel;
            string filename = saveFileDialog.FileName;
            File.Copy(createdFileName, filename);
            MessageBox.Show("Файл сохранен", "Cохранение файла", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return DialogResult.OK;
        }

        private void docViewerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            File.Delete(createdFileName);
        }

        private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
        {
            counter = 0;
            curPage = 1;
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            System.Drawing.Font myFont = new System.Drawing.Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Pixel);

            string curLine; // текущая выводимая строка

            // Отступы внутри страницы
            float leftMargin = e.MarginBounds.Left; // отступы слева в документе
            float topMargin = e.MarginBounds.Top; // отступы сверху в документе
            float yPos = 0; // текущая позиция Y для вывода строки

            int nPages; // количество страниц
            int nLines; // максимально-возможное количество строк на странице
            int i; // номер текущей строки для вывода на странице

            // Вычислить максимально возможное количество строк на странице
            nLines = (int)(e.MarginBounds.Height / myFont.GetHeight(e.Graphics));

            // Вычислить количество страниц для печати
            nPages = (docViewer.Lines.Length - 1) / nLines + 1;

            // Цикл печати/вывода одной страницы
            i = 0;
            while ((i < nLines) && (counter < docViewer.Lines.Length))
            {
                // Взять строку для вывода из richTextBox1
                curLine = docViewer.Lines[counter];

                // Вычислить текущую позицию по оси Y
                yPos = topMargin + i * myFont.GetHeight(e.Graphics);

                // Вывести строку в документ
                e.Graphics.DrawString(curLine, myFont, Brushes.Blue,
                  leftMargin, yPos, new StringFormat());

                counter++;
                i++;
            }
            // Если весь текст не помещается на 1 страницу, то
            // нужно добавить дополнительную страницу для печати
            e.HasMorePages = false;

            if (curPage < nPages)
            {
                curPage++;
                e.HasMorePages = true;
            }
        }

    }
}
