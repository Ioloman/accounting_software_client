
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
            this.reportPanel = new System.Windows.Forms.Panel();
            this.Head = new System.Windows.Forms.GroupBox();
            this.anotherReportLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.reportLabel = new System.Windows.Forms.Label();
            this.productsGrid = new System.Windows.Forms.DataGridView();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.okpCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiverDepColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportInfo1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.deleteRecordButton = new System.Windows.Forms.Button();
            this.saveChangeButton = new System.Windows.Forms.Button();
            this.reportPanel.SuspendLayout();
            this.Head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsGrid)).BeginInit();
            this.reportInfo1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportPanel
            // 
            this.reportPanel.Controls.Add(this.deleteRecordButton);
            this.reportPanel.Controls.Add(this.saveChangeButton);
            this.reportPanel.Controls.Add(this.Head);
            this.reportPanel.Controls.Add(this.productsGrid);
            this.reportPanel.Controls.Add(this.reportInfo1);
            this.reportPanel.Location = new System.Drawing.Point(0, 0);
            this.reportPanel.Name = "reportPanel";
            this.reportPanel.Size = new System.Drawing.Size(835, 690);
            this.reportPanel.TabIndex = 13;
            // 
            // Head
            // 
            this.Head.Controls.Add(this.anotherReportLabel);
            this.Head.Controls.Add(this.textBox2);
            this.Head.Controls.Add(this.reportLabel);
            this.Head.Location = new System.Drawing.Point(20, 10);
            this.Head.Name = "Head";
            this.Head.Size = new System.Drawing.Size(797, 69);
            this.Head.TabIndex = 10;
            this.Head.TabStop = false;
            // 
            // anotherReportLabel
            // 
            this.anotherReportLabel.AutoSize = true;
            this.anotherReportLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.anotherReportLabel.Location = new System.Drawing.Point(388, 23);
            this.anotherReportLabel.Name = "anotherReportLabel";
            this.anotherReportLabel.Size = new System.Drawing.Size(360, 31);
            this.anotherReportLabel.TabIndex = 2;
            this.anotherReportLabel.Text = "СДАЧИ ПРОДУКЦИИ ЦЕХАМИ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(244, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(138, 27);
            this.textBox2.TabIndex = 9;
            // 
            // reportLabel
            // 
            this.reportLabel.AutoSize = true;
            this.reportLabel.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.reportLabel.Location = new System.Drawing.Point(92, 22);
            this.reportLabel.Name = "reportLabel";
            this.reportLabel.Size = new System.Drawing.Size(146, 32);
            this.reportLabel.TabIndex = 0;
            this.reportLabel.Text = "РАПОРТ №";
            // 
            // productsGrid
            // 
            this.productsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productName,
            this.okpCode,
            this.dataGridViewTextBoxColumn1,
            this.receiverDepColumn});
            this.productsGrid.Location = new System.Drawing.Point(20, 223);
            this.productsGrid.Name = "productsGrid";
            this.productsGrid.RowHeadersWidth = 51;
            this.productsGrid.Size = new System.Drawing.Size(797, 414);
            this.productsGrid.TabIndex = 1;
            // 
            // productName
            // 
            this.productName.HeaderText = "Наименование продукта";
            this.productName.MinimumWidth = 6;
            this.productName.Name = "productName";
            // 
            // okpCode
            // 
            this.okpCode.HeaderText = "Код ОКП";
            this.okpCode.MinimumWidth = 6;
            this.okpCode.Name = "okpCode";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // receiverDepColumn
            // 
            this.receiverDepColumn.HeaderText = "Цех-получатель";
            this.receiverDepColumn.MinimumWidth = 6;
            this.receiverDepColumn.Name = "receiverDepColumn";
            // 
            // reportInfo1
            // 
            this.reportInfo1.Controls.Add(this.dateTimePicker4);
            this.reportInfo1.Controls.Add(this.label9);
            this.reportInfo1.Controls.Add(this.textBox6);
            this.reportInfo1.Controls.Add(this.label10);
            this.reportInfo1.Location = new System.Drawing.Point(20, 85);
            this.reportInfo1.Name = "reportInfo1";
            this.reportInfo1.Size = new System.Drawing.Size(380, 132);
            this.reportInfo1.TabIndex = 8;
            this.reportInfo1.TabStop = false;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.CustomFormat = "dd MMMM yyyy";
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker4.Location = new System.Drawing.Point(145, 34);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(180, 27);
            this.dateTimePicker4.TabIndex = 4;
            this.dateTimePicker4.Value = new System.DateTime(2021, 3, 25, 0, 0, 0, 0);
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
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(145, 74);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(180, 27);
            this.textBox6.TabIndex = 5;
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
            // deleteRecordButton
            // 
            this.deleteRecordButton.Location = new System.Drawing.Point(519, 643);
            this.deleteRecordButton.Name = "deleteRecordButton";
            this.deleteRecordButton.Size = new System.Drawing.Size(298, 36);
            this.deleteRecordButton.TabIndex = 12;
            this.deleteRecordButton.Text = "Удалить запись";
            this.deleteRecordButton.UseVisualStyleBackColor = true;
            // 
            // saveChangeButton
            // 
            this.saveChangeButton.Location = new System.Drawing.Point(20, 643);
            this.saveChangeButton.Name = "saveChangeButton";
            this.saveChangeButton.Size = new System.Drawing.Size(298, 36);
            this.saveChangeButton.TabIndex = 11;
            this.saveChangeButton.Text = "Сохранить изменения";
            this.saveChangeButton.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn okpCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiverDepColumn;
        private System.Windows.Forms.GroupBox reportInfo1;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button deleteRecordButton;
        private System.Windows.Forms.Button saveChangeButton;
    }
}
