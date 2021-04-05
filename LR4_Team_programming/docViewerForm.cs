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
using System.Threading;

namespace LR4_Team_programming
{
    public partial class docViewerForm : Form
    {
        Word.Application wordApp;
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
            if (docType == mainForm.docTypes.report || docType == mainForm.docTypes.vedomost || docType == mainForm.docTypes.analysis)
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

        private void printFileDialog()
        {
            wordApp = new Word.Application();
            wordApp.Visible = false;
            PrintDialog pDialog = new PrintDialog();
            if (pDialog.ShowDialog() == DialogResult.OK)
            {
                Word.Document doc = wordApp.Documents.Add(createdFileName);
                wordApp.ActivePrinter = pDialog.PrinterSettings.PrinterName;
                //Thread.Sleep(10000);
                try
                {
                    wordApp.ActiveDocument.PrintOut();
                    doc.Close(SaveChanges: false);
                    doc = null;
                }
                catch { MessageBox.Show("Проблемы с принтером"); };

            }

        }


        private void printButton_Click(object sender, EventArgs e)
        {
            //mainForm.printMethod(createdFileName);
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            PrintFileDialogs invoker = new PrintFileDialogs(printFileDialog);
            mainForm.activ.Invoke(invoker);
        }
        private delegate void PrintFileDialogs();



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
            ((Word._Application)wordApp).Quit(SaveChanges: false);
            wordApp = null;
        }
    }
}
