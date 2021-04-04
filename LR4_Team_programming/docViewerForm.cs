using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
using System.Diagnostics;

namespace LR4_Team_programming
{
    public partial class docViewerForm : Form
    {


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
            Microsoft.Office.Interop.Word.Application wordobject = new Microsoft.Office.Interop.Word.Application();
            wordobject.DisplayAlerts = Microsoft.Office.Interop.Word.WdAlertLevel.wdAlertsNone;
            Microsoft.Office.Interop.Word._Document docs = wordObject.Documents.Open(
                ref File, ref nullobject, ref nullobject, ref nullobject, 
                ref nullobject, ref nullobject, ref nullobject, ref nullobject,
                ref nullobject, ref nullobject, ref nullobject, ref nullobject, 
                ref nullobject, ref nullobject, ref nullobject, ref nullobject);
            docs.ActiveWindow.Selection.WholeStory();
            docs.ActiveWindow.Selection.Copy();
            docViewer.Paste();
            docs.Close(ref nullobject, ref nullobject, ref nullobject);      
            docViewer.ReadOnly = true;
            // дичайший костыль
            try
            {
                foreach (var process in Process.GetProcessesByName("WINWORD"))
                {
                    process.Kill();
                }
            }
            catch { };
        }



        private void printButton_Click(object sender, EventArgs e)
        {
            // Это потом удалится. Это - тест 
            List<List<string>> data = new List<List<string>>();
            for (int i = 0; i < 10; i++)
            {
                data.Add(new List<string>());
                for (int j = 0; j < 4; j++)
                {
                    data[i].Add((i + j).ToString());
                }
            }
            //makeDocument("1488", "Цех твоего очка", "20.10.2021", data,
            //    "C:\\Users\\aleks\\Desktop\\Шаблон  Ведомости.docx", "C:\\Users\\aleks\\Desktop\\Шаблон  Ведомости1.docx");
            //showDocument("C:\\Users\\aleks\\Desktop\\Шаблон  Ведомости1.docx");



        }
        private delegate DialogResult ShowSaveFileDialogInvoker();


        private void editButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            ShowSaveFileDialogInvoker invoker = new ShowSaveFileDialogInvoker(saveFileDialog.ShowDialog);

            this.Invoke(invoker);

            //saveFileDialog.DefaultExt = "docx";
            //if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
            //    return;
            //string filename = saveFileDialog.FileName;
           // File.Copy(createdFileName, filename);
           // MessageBox.Show("Файл сохранен");

        }      



        private void docViewerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            File.Delete(createdFileName);
        }
    }
}
