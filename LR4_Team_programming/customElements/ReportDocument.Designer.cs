
namespace LR4_Team_programming.customElements
{
    partial class ReportDocument
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportDocument));
            this.reportPanel = new System.Windows.Forms.Panel();
            this.printButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.saveChangeButton = new System.Windows.Forms.Button();
            this.Head = new System.Windows.Forms.GroupBox();
            this.anotherReportLabel = new System.Windows.Forms.Label();
            this.docNumber = new System.Windows.Forms.TextBox();
            this.reportLabel = new System.Windows.Forms.Label();
            this.productsGrid = new System.Windows.Forms.DataGridView();
            this.productName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.okpCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiverDepColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.deleteRowColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.reportInfo1 = new System.Windows.Forms.GroupBox();
            this.senderComboBox = new System.Windows.Forms.ComboBox();
            this.creationDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.reportPanel.SuspendLayout();
            this.Head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsGrid)).BeginInit();
            this.reportInfo1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportPanel
            // 
            this.reportPanel.Controls.Add(this.printButton);
            this.reportPanel.Controls.Add(this.progressBar1);
            this.reportPanel.Controls.Add(this.saveChangeButton);
            this.reportPanel.Controls.Add(this.Head);
            this.reportPanel.Controls.Add(this.productsGrid);
            this.reportPanel.Controls.Add(this.reportInfo1);
            this.reportPanel.Location = new System.Drawing.Point(0, 0);
            this.reportPanel.Name = "reportPanel";
            this.reportPanel.Size = new System.Drawing.Size(835, 690);
            this.reportPanel.TabIndex = 13;
            // 
            // printButton
            // 
            this.printButton.Image = ((System.Drawing.Image)(resources.GetObject("printButton.Image")));
            this.printButton.Location = new System.Drawing.Point(774, 26);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(50, 49);
            this.printButton.TabIndex = 13;
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(20, 202);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(797, 29);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 12;
            this.progressBar1.Visible = false;
            // 
            // saveChangeButton
            // 
            this.saveChangeButton.Location = new System.Drawing.Point(288, 643);
            this.saveChangeButton.Name = "saveChangeButton";
            this.saveChangeButton.Size = new System.Drawing.Size(298, 36);
            this.saveChangeButton.TabIndex = 11;
            this.saveChangeButton.Text = "Сохранить";
            this.saveChangeButton.UseVisualStyleBackColor = true;
            this.saveChangeButton.Click += new System.EventHandler(this.saveChangeButton_Click);
            // 
            // Head
            // 
            this.Head.Controls.Add(this.anotherReportLabel);
            this.Head.Controls.Add(this.docNumber);
            this.Head.Controls.Add(this.reportLabel);
            this.Head.Location = new System.Drawing.Point(20, 10);
            this.Head.Name = "Head";
            this.Head.Size = new System.Drawing.Size(746, 69);
            this.Head.TabIndex = 10;
            this.Head.TabStop = false;
            // 
            // anotherReportLabel
            // 
            this.anotherReportLabel.AutoSize = true;
            this.anotherReportLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.anotherReportLabel.Location = new System.Drawing.Point(361, 23);
            this.anotherReportLabel.Name = "anotherReportLabel";
            this.anotherReportLabel.Size = new System.Drawing.Size(360, 31);
            this.anotherReportLabel.TabIndex = 2;
            this.anotherReportLabel.Text = "СДАЧИ ПРОДУКЦИИ ЦЕХАМИ";
            // 
            // docNumber
            // 
            this.docNumber.Location = new System.Drawing.Point(217, 27);
            this.docNumber.Name = "docNumber";
            this.docNumber.PlaceholderText = "№ документа";
            this.docNumber.Size = new System.Drawing.Size(138, 27);
            this.docNumber.TabIndex = 9;
            // 
            // reportLabel
            // 
            this.reportLabel.AutoSize = true;
            this.reportLabel.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.reportLabel.Location = new System.Drawing.Point(65, 22);
            this.reportLabel.Name = "reportLabel";
            this.reportLabel.Size = new System.Drawing.Size(146, 32);
            this.reportLabel.TabIndex = 0;
            this.reportLabel.Text = "РАПОРТ №";
            // 
            // productsGrid
            // 
            this.productsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.productsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productName,
            this.okpCode,
            this.dataGridViewTextBoxColumn1,
            this.receiverDepColumn,
            this.deleteRowColumn});
            this.productsGrid.Location = new System.Drawing.Point(20, 234);
            this.productsGrid.Name = "productsGrid";
            this.productsGrid.RowHeadersWidth = 51;
            this.productsGrid.Size = new System.Drawing.Size(797, 403);
            this.productsGrid.TabIndex = 1;
            this.productsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsGrid_CellContentClick);
            this.productsGrid.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.productsGrid_CellPainting);
            this.productsGrid.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.productsGrid_CellValidating);
            this.productsGrid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.productsGrid_RowsAdded);
            this.productsGrid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.productsGrid_RowsRemoved);
            // 
            // productName
            // 
            this.productName.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.productName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productName.HeaderText = "Наименование продукта";
            this.productName.MinimumWidth = 6;
            this.productName.Name = "productName";
            this.productName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.productName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // okpCode
            // 
            this.okpCode.HeaderText = "Код ОКП";
            this.okpCode.MinimumWidth = 6;
            this.okpCode.Name = "okpCode";
            this.okpCode.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // receiverDepColumn
            // 
            this.receiverDepColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.receiverDepColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receiverDepColumn.HeaderText = "Цех-получатель";
            this.receiverDepColumn.MinimumWidth = 6;
            this.receiverDepColumn.Name = "receiverDepColumn";
            this.receiverDepColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.receiverDepColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // deleteRowColumn
            // 
            this.deleteRowColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.deleteRowColumn.HeaderText = "";
            this.deleteRowColumn.MinimumWidth = 6;
            this.deleteRowColumn.Name = "deleteRowColumn";
            this.deleteRowColumn.Width = 40;
            // 
            // reportInfo1
            // 
            this.reportInfo1.Controls.Add(this.senderComboBox);
            this.reportInfo1.Controls.Add(this.creationDate);
            this.reportInfo1.Controls.Add(this.label9);
            this.reportInfo1.Controls.Add(this.label10);
            this.reportInfo1.Location = new System.Drawing.Point(20, 68);
            this.reportInfo1.Name = "reportInfo1";
            this.reportInfo1.Size = new System.Drawing.Size(380, 132);
            this.reportInfo1.TabIndex = 8;
            this.reportInfo1.TabStop = false;
            // 
            // senderComboBox
            // 
            this.senderComboBox.FormattingEnabled = true;
            this.senderComboBox.Location = new System.Drawing.Point(145, 77);
            this.senderComboBox.Name = "senderComboBox";
            this.senderComboBox.Size = new System.Drawing.Size(180, 28);
            this.senderComboBox.TabIndex = 8;
            // 
            // creationDate
            // 
            this.creationDate.CustomFormat = "dd MMMM yyyy";
            this.creationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.creationDate.Location = new System.Drawing.Point(145, 34);
            this.creationDate.Name = "creationDate";
            this.creationDate.Size = new System.Drawing.Size(180, 27);
            this.creationDate.TabIndex = 4;
            this.creationDate.Value = new System.DateTime(2021, 3, 25, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "цех-отправитель";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "от";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "778aac5a69fd790400b9bbfb72a3e7ce.png");
            // 
            // ReportDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportPanel);
            this.Name = "ReportDocument";
            this.Size = new System.Drawing.Size(837, 692);
            this.reportPanel.ResumeLayout(false);
            this.Head.ResumeLayout(false);
            this.Head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsGrid)).EndInit();
            this.reportInfo1.ResumeLayout(false);
            this.reportInfo1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel reportPanel;
        private System.Windows.Forms.GroupBox Head;
        private System.Windows.Forms.Label anotherReportLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label reportLabel;
        private System.Windows.Forms.DataGridView productsGrid;
        private System.Windows.Forms.GroupBox reportInfo1;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button saveChangeButton;
        private System.Windows.Forms.DateTimePicker creationDate;
        private System.Windows.Forms.TextBox docNumber;
        private System.Windows.Forms.ComboBox senderComboBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.DataGridViewComboBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn okpCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn receiverDepColumn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteRowColumn;
        private System.Windows.Forms.ImageList imageList1;
    }
}
