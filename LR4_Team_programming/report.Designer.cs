
namespace LR4_Team_programming
{
    partial class report
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reportLabel = new System.Windows.Forms.Label();
            this.productsGrid = new System.Windows.Forms.DataGridView();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.okpCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anotherReportLabel = new System.Windows.Forms.Label();
            this.reportDate = new System.Windows.Forms.DateTimePicker();
            this.senderDep = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.senderLabel = new System.Windows.Forms.Label();
            this.reportInfo1 = new System.Windows.Forms.GroupBox();
            this.reciverDep = new System.Windows.Forms.TextBox();
            this.reciverLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Head = new System.Windows.Forms.GroupBox();
            this.reportPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.productsGrid)).BeginInit();
            this.reportInfo1.SuspendLayout();
            this.Head.SuspendLayout();
            this.reportPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportLabel
            // 
            this.reportLabel.AutoSize = true;
            this.reportLabel.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.reportLabel.Location = new System.Drawing.Point(234, 23);
            this.reportLabel.Name = "reportLabel";
            this.reportLabel.Size = new System.Drawing.Size(146, 32);
            this.reportLabel.TabIndex = 0;
            this.reportLabel.Text = "РАПОРТ №";
            this.reportLabel.Click += new System.EventHandler(this.reportLabel_Click);
            // 
            // productsGrid
            // 
            this.productsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productName,
            this.okpCode,
            this.amount});
            this.productsGrid.Location = new System.Drawing.Point(20, 309);
            this.productsGrid.Name = "productsGrid";
            this.productsGrid.RowHeadersWidth = 51;
            this.productsGrid.Size = new System.Drawing.Size(1031, 293);
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
            // amount
            // 
            this.amount.HeaderText = "Количество";
            this.amount.MinimumWidth = 6;
            this.amount.Name = "amount";
            // 
            // anotherReportLabel
            // 
            this.anotherReportLabel.AutoSize = true;
            this.anotherReportLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.anotherReportLabel.Location = new System.Drawing.Point(530, 24);
            this.anotherReportLabel.Name = "anotherReportLabel";
            this.anotherReportLabel.Size = new System.Drawing.Size(360, 31);
            this.anotherReportLabel.TabIndex = 2;
            this.anotherReportLabel.Text = "СДАЧИ ПРОДУКЦИИ ЦЕХАМИ";
            // 
            // reportDate
            // 
            this.reportDate.CustomFormat = "dd MMMM yyyy";
            this.reportDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.reportDate.Location = new System.Drawing.Point(145, 34);
            this.reportDate.Name = "reportDate";
            this.reportDate.Size = new System.Drawing.Size(180, 27);
            this.reportDate.TabIndex = 4;
            this.reportDate.Value = new System.DateTime(2021, 3, 25, 0, 0, 0, 0);
            // 
            // senderDep
            // 
            this.senderDep.Location = new System.Drawing.Point(145, 74);
            this.senderDep.Name = "senderDep";
            this.senderDep.Size = new System.Drawing.Size(180, 27);
            this.senderDep.TabIndex = 5;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(12, 39);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(24, 20);
            this.dateLabel.TabIndex = 6;
            this.dateLabel.Text = "от";
            // 
            // senderLabel
            // 
            this.senderLabel.AutoSize = true;
            this.senderLabel.Location = new System.Drawing.Point(12, 77);
            this.senderLabel.Name = "senderLabel";
            this.senderLabel.Size = new System.Drawing.Size(127, 20);
            this.senderLabel.TabIndex = 7;
            this.senderLabel.Text = "цех-отправитель";
            // 
            // reportInfo1
            // 
            this.reportInfo1.Controls.Add(this.reciverDep);
            this.reportInfo1.Controls.Add(this.reciverLabel);
            this.reportInfo1.Controls.Add(this.reportDate);
            this.reportInfo1.Controls.Add(this.senderLabel);
            this.reportInfo1.Controls.Add(this.senderDep);
            this.reportInfo1.Controls.Add(this.dateLabel);
            this.reportInfo1.Location = new System.Drawing.Point(20, 107);
            this.reportInfo1.Name = "reportInfo1";
            this.reportInfo1.Size = new System.Drawing.Size(380, 172);
            this.reportInfo1.TabIndex = 8;
            this.reportInfo1.TabStop = false;
            // 
            // reciverDep
            // 
            this.reciverDep.Location = new System.Drawing.Point(145, 115);
            this.reciverDep.Name = "reciverDep";
            this.reciverDep.Size = new System.Drawing.Size(180, 27);
            this.reciverDep.TabIndex = 9;
            // 
            // reciverLabel
            // 
            this.reciverLabel.AutoSize = true;
            this.reciverLabel.Location = new System.Drawing.Point(12, 118);
            this.reciverLabel.Name = "reciverLabel";
            this.reciverLabel.Size = new System.Drawing.Size(118, 20);
            this.reciverLabel.TabIndex = 8;
            this.reciverLabel.Text = "цех-получатель";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(386, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(138, 27);
            this.textBox2.TabIndex = 9;
            // 
            // Head
            // 
            this.Head.Controls.Add(this.anotherReportLabel);
            this.Head.Controls.Add(this.textBox2);
            this.Head.Controls.Add(this.reportLabel);
            this.Head.Location = new System.Drawing.Point(20, 10);
            this.Head.Name = "Head";
            this.Head.Size = new System.Drawing.Size(1031, 69);
            this.Head.TabIndex = 10;
            this.Head.TabStop = false;
            // 
            // reportPanel
            // 
            this.reportPanel.Controls.Add(this.Head);
            this.reportPanel.Controls.Add(this.productsGrid);
            this.reportPanel.Controls.Add(this.reportInfo1);
            this.reportPanel.Location = new System.Drawing.Point(17, 39);
            this.reportPanel.Name = "reportPanel";
            this.reportPanel.Size = new System.Drawing.Size(1070, 654);
            this.reportPanel.TabIndex = 11;
            // 
            // report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 678);
            this.Controls.Add(this.reportPanel);
            this.Name = "report";
            this.Text = "report";
            this.Load += new System.EventHandler(this.report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsGrid)).EndInit();
            this.reportInfo1.ResumeLayout(false);
            this.reportInfo1.PerformLayout();
            this.Head.ResumeLayout(false);
            this.Head.PerformLayout();
            this.reportPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label reportLabel;
        private System.Windows.Forms.DataGridView productsGrid;
        private System.Windows.Forms.Label anotherReportLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn okpCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DateTimePicker reportDate;
        private System.Windows.Forms.TextBox senderDep;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label senderLabel;
        private System.Windows.Forms.GroupBox reportInfo1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox reciverDep;
        private System.Windows.Forms.Label reciverLabel;
        private System.Windows.Forms.GroupBox Head;
        private System.Windows.Forms.Panel reportPanel;
    }
}