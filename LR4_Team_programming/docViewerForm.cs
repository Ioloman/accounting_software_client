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

namespace LR4_Team_programming
{
    public partial class docViewerForm : Form
    {
        public docViewerForm()
        {
            InitializeComponent();
        }

        private void makeDocument(string numberDoc, string dep, string createDate, List<List<String>> data, string pathToTemplate, string reportName = null)
        {
            // Если reportName = null, то к шаблону добавляется текущая дата - это название рапорта
            // data должна содержать 6 элементов по ширине, нулевой - это порядковый номер (для рапорта, а для ведомости - 4)

            DocX document = DocX.Load(pathToTemplate);

            document.Paragraphs[2].Append(numberDoc).FontSize(14).
                Font("Times New Roman").UnderlineStyle(UnderlineStyle.singleLine).Bold(true);  // добавить номер документа
            document.Paragraphs[3].Append(dep).FontSize(14).
                Font("Times New Roman").UnderlineStyle(UnderlineStyle.singleLine).Bold(true);  // добавить цех-получатель
            document.Paragraphs[4].Append(createDate).FontSize(14).
                Font("Times New Roman").UnderlineStyle(UnderlineStyle.singleLine).Bold(true);  // добавить дату создания

            Table tableinDoc = document.Tables[0];

            for (int i = 0; i < data.Count; i++)
            {
                tableinDoc.InsertRow();
                for (int j = 0; j < data[i].Count; j++)
                    tableinDoc.Rows[i + 1].Cells[j].Paragraphs[0].Append(data[i][j]).FontSize(14).
                        Font("Times New Roman");
            }

            if (reportName == null)
                document.SaveAs(pathToTemplate.Substring(0, pathToTemplate.Length - 5) + DateTime.Now.ToString().Replace(":", "-") + ".docx");
            else
                document.SaveAs(reportName);

            document.Dispose();
        }

        private void showDocument(string filename)
        {
            Word.Application wordObject = new Word.Application();
            object File = filename;
            object nullobject = Missing.Value;
            Microsoft.Office.Interop.Word.Application wordobject = new Microsoft.Office.Interop.Word.Application();
            wordobject.DisplayAlerts = Microsoft.Office.Interop.Word.WdAlertLevel.wdAlertsNone;
            Microsoft.Office.Interop.Word._Document docs = wordObject.Documents.Open(ref File, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject);
            docs.ActiveWindow.Selection.WholeStory();
            docs.ActiveWindow.Selection.Copy();
            docViewer.Paste();
            docs.Close(ref nullobject, ref nullobject, ref nullobject);
        }



        private void printButton_Click(object sender, EventArgs e)
        {
            // Это потом удалится. Это - тест 
            docViewer.ReadOnly = false;
            docViewer.Text = "";
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

            docViewer.ReadOnly = true;


        }

        private void editButton_Click(object sender, EventArgs e)
        {
            // Это потом удалится. Это - тест 
            docViewer.ReadOnly = false;
            docViewer.Text = "";
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

            docViewer.ReadOnly = true;
        }
    }
}
