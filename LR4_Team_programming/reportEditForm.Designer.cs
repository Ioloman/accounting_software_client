
namespace LR4_Team_programming
{
    partial class reportEditForm
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
            this.reportsGrid = new System.Windows.Forms.DataGridView();
            this.documentNumberColoumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportDateColoumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderDepColoumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportDate = new System.Windows.Forms.DateTimePicker();
            this.reportDateLabel = new System.Windows.Forms.Label();
            this.reportDateFilter = new System.Windows.Forms.GroupBox();
            this.reportDatePeriodSelector = new System.Windows.Forms.RadioButton();
            this.reportDateSelector = new System.Windows.Forms.RadioButton();
            this.reportHighestDate = new System.Windows.Forms.DateTimePicker();
            this.reportLowestDate = new System.Windows.Forms.DateTimePicker();
            this.reportHighestDateLabel = new System.Windows.Forms.Label();
            this.reportLowestDateLabel = new System.Windows.Forms.Label();
            this.reportPanel = new System.Windows.Forms.Panel();
            this.departmentSearch = new System.Windows.Forms.GroupBox();
            this.senderDepLabel = new System.Windows.Forms.Label();
            this.senderDep = new System.Windows.Forms.TextBox();
            this.numberSearch = new System.Windows.Forms.GroupBox();
            this.reportNumberLabel = new System.Windows.Forms.Label();
            this.reportNumber = new System.Windows.Forms.TextBox();
            this.Head = new System.Windows.Forms.GroupBox();
            this.reportLabel = new System.Windows.Forms.Label();
            this.documentNumberSelector = new System.Windows.Forms.CheckBox();
            this.senderDepSelector = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.reportsGrid)).BeginInit();
            this.reportDateFilter.SuspendLayout();
            this.reportPanel.SuspendLayout();
            this.departmentSearch.SuspendLayout();
            this.numberSearch.SuspendLayout();
            this.Head.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportsGrid
            // 
            this.reportsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reportsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.documentNumberColoumn,
            this.reportDateColoumn,
            this.senderDepColoumn});
            this.reportsGrid.Location = new System.Drawing.Point(20, 309);
            this.reportsGrid.Name = "reportsGrid";
            this.reportsGrid.RowHeadersWidth = 51;
            this.reportsGrid.Size = new System.Drawing.Size(1031, 293);
            this.reportsGrid.TabIndex = 1;
            // 
            // documentNumberColoumn
            // 
            this.documentNumberColoumn.HeaderText = "Номер рапорта";
            this.documentNumberColoumn.MinimumWidth = 6;
            this.documentNumberColoumn.Name = "documentNumberColoumn";
            // 
            // reportDateColoumn
            // 
            this.reportDateColoumn.HeaderText = "Дата составления";
            this.reportDateColoumn.MinimumWidth = 6;
            this.reportDateColoumn.Name = "reportDateColoumn";
            // 
            // senderDepColoumn
            // 
            this.senderDepColoumn.HeaderText = "Цех-отправитель";
            this.senderDepColoumn.MinimumWidth = 6;
            this.senderDepColoumn.Name = "senderDepColoumn";
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
            // reportDateLabel
            // 
            this.reportDateLabel.AutoSize = true;
            this.reportDateLabel.Location = new System.Drawing.Point(12, 39);
            this.reportDateLabel.Name = "reportDateLabel";
            this.reportDateLabel.Size = new System.Drawing.Size(91, 20);
            this.reportDateLabel.TabIndex = 6;
            this.reportDateLabel.Text = "точная дата";
            // 
            // reportDateFilter
            // 
            this.reportDateFilter.Controls.Add(this.reportDatePeriodSelector);
            this.reportDateFilter.Controls.Add(this.reportDateSelector);
            this.reportDateFilter.Controls.Add(this.reportHighestDate);
            this.reportDateFilter.Controls.Add(this.reportLowestDate);
            this.reportDateFilter.Controls.Add(this.reportHighestDateLabel);
            this.reportDateFilter.Controls.Add(this.reportDate);
            this.reportDateFilter.Controls.Add(this.reportLowestDateLabel);
            this.reportDateFilter.Controls.Add(this.reportDateLabel);
            this.reportDateFilter.Location = new System.Drawing.Point(20, 107);
            this.reportDateFilter.Name = "reportDateFilter";
            this.reportDateFilter.Size = new System.Drawing.Size(380, 172);
            this.reportDateFilter.TabIndex = 8;
            this.reportDateFilter.TabStop = false;
            this.reportDateFilter.Text = "поиск по дате";
            // 
            // reportDatePeriodSelector
            // 
            this.reportDatePeriodSelector.AutoSize = true;
            this.reportDatePeriodSelector.Location = new System.Drawing.Point(345, 115);
            this.reportDatePeriodSelector.Name = "reportDatePeriodSelector";
            this.reportDatePeriodSelector.Size = new System.Drawing.Size(17, 16);
            this.reportDatePeriodSelector.TabIndex = 13;
            this.reportDatePeriodSelector.TabStop = true;
            this.reportDatePeriodSelector.UseVisualStyleBackColor = true;
            // 
            // reportDateSelector
            // 
            this.reportDateSelector.AutoSize = true;
            this.reportDateSelector.Location = new System.Drawing.Point(345, 41);
            this.reportDateSelector.Name = "reportDateSelector";
            this.reportDateSelector.Size = new System.Drawing.Size(17, 16);
            this.reportDateSelector.TabIndex = 12;
            this.reportDateSelector.TabStop = true;
            this.reportDateSelector.UseVisualStyleBackColor = true;
            // 
            // reportHighestDate
            // 
            this.reportHighestDate.CustomFormat = "dd MMMM yyyy";
            this.reportHighestDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.reportHighestDate.Location = new System.Drawing.Point(145, 128);
            this.reportHighestDate.Name = "reportHighestDate";
            this.reportHighestDate.Size = new System.Drawing.Size(180, 27);
            this.reportHighestDate.TabIndex = 11;
            this.reportHighestDate.Value = new System.DateTime(2021, 3, 25, 0, 0, 0, 0);
            // 
            // reportLowestDate
            // 
            this.reportLowestDate.CustomFormat = "dd MMMM yyyy";
            this.reportLowestDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.reportLowestDate.Location = new System.Drawing.Point(145, 87);
            this.reportLowestDate.Name = "reportLowestDate";
            this.reportLowestDate.Size = new System.Drawing.Size(180, 27);
            this.reportLowestDate.TabIndex = 10;
            this.reportLowestDate.Value = new System.DateTime(2021, 3, 25, 0, 0, 0, 0);
            // 
            // reportHighestDateLabel
            // 
            this.reportHighestDateLabel.AutoSize = true;
            this.reportHighestDateLabel.Location = new System.Drawing.Point(12, 133);
            this.reportHighestDateLabel.Name = "reportHighestDateLabel";
            this.reportHighestDateLabel.Size = new System.Drawing.Size(100, 20);
            this.reportHighestDateLabel.TabIndex = 8;
            this.reportHighestDateLabel.Text = "верхняя дата";
            // 
            // reportLowestDateLabel
            // 
            this.reportLowestDateLabel.AutoSize = true;
            this.reportLowestDateLabel.Location = new System.Drawing.Point(12, 92);
            this.reportLowestDateLabel.Name = "reportLowestDateLabel";
            this.reportLowestDateLabel.Size = new System.Drawing.Size(97, 20);
            this.reportLowestDateLabel.TabIndex = 7;
            this.reportLowestDateLabel.Text = "нижняя дата";
            // 
            // reportPanel
            // 
            this.reportPanel.Controls.Add(this.departmentSearch);
            this.reportPanel.Controls.Add(this.numberSearch);
            this.reportPanel.Controls.Add(this.Head);
            this.reportPanel.Controls.Add(this.reportsGrid);
            this.reportPanel.Controls.Add(this.reportDateFilter);
            this.reportPanel.Location = new System.Drawing.Point(17, 12);
            this.reportPanel.Name = "reportPanel";
            this.reportPanel.Size = new System.Drawing.Size(1070, 654);
            this.reportPanel.TabIndex = 11;
            // 
            // departmentSearch
            // 
            this.departmentSearch.Controls.Add(this.senderDepSelector);
            this.departmentSearch.Controls.Add(this.senderDepLabel);
            this.departmentSearch.Controls.Add(this.senderDep);
            this.departmentSearch.Location = new System.Drawing.Point(467, 203);
            this.departmentSearch.Name = "departmentSearch";
            this.departmentSearch.Size = new System.Drawing.Size(380, 76);
            this.departmentSearch.TabIndex = 11;
            this.departmentSearch.TabStop = false;
            this.departmentSearch.Text = "поиск по цеху";
            // 
            // senderDepLabel
            // 
            this.senderDepLabel.AutoSize = true;
            this.senderDepLabel.Location = new System.Drawing.Point(12, 37);
            this.senderDepLabel.Name = "senderDepLabel";
            this.senderDepLabel.Size = new System.Drawing.Size(127, 20);
            this.senderDepLabel.TabIndex = 7;
            this.senderDepLabel.Text = "цех-отправитель";
            // 
            // senderDep
            // 
            this.senderDep.Location = new System.Drawing.Point(145, 34);
            this.senderDep.Name = "senderDep";
            this.senderDep.Size = new System.Drawing.Size(180, 27);
            this.senderDep.TabIndex = 5;
            // 
            // numberSearch
            // 
            this.numberSearch.Controls.Add(this.documentNumberSelector);
            this.numberSearch.Controls.Add(this.reportNumberLabel);
            this.numberSearch.Controls.Add(this.reportNumber);
            this.numberSearch.Location = new System.Drawing.Point(467, 107);
            this.numberSearch.Name = "numberSearch";
            this.numberSearch.Size = new System.Drawing.Size(380, 76);
            this.numberSearch.TabIndex = 10;
            this.numberSearch.TabStop = false;
            this.numberSearch.Text = "поиск по номеру документа";
            // 
            // reportNumberLabel
            // 
            this.reportNumberLabel.AutoSize = true;
            this.reportNumberLabel.Location = new System.Drawing.Point(12, 37);
            this.reportNumberLabel.Name = "reportNumberLabel";
            this.reportNumberLabel.Size = new System.Drawing.Size(132, 20);
            this.reportNumberLabel.TabIndex = 7;
            this.reportNumberLabel.Text = "номер документа";
            // 
            // reportNumber
            // 
            this.reportNumber.Location = new System.Drawing.Point(145, 34);
            this.reportNumber.Name = "reportNumber";
            this.reportNumber.Size = new System.Drawing.Size(180, 27);
            this.reportNumber.TabIndex = 5;
            // 
            // Head
            // 
            this.Head.Controls.Add(this.reportLabel);
            this.Head.Location = new System.Drawing.Point(20, 10);
            this.Head.Name = "Head";
            this.Head.Size = new System.Drawing.Size(1031, 69);
            this.Head.TabIndex = 10;
            this.Head.TabStop = false;
            // 
            // reportLabel
            // 
            this.reportLabel.AutoSize = true;
            this.reportLabel.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.reportLabel.Location = new System.Drawing.Point(329, 23);
            this.reportLabel.Name = "reportLabel";
            this.reportLabel.Size = new System.Drawing.Size(384, 32);
            this.reportLabel.TabIndex = 0;
            this.reportLabel.Text = "РАПОРТА СДАЧИ ПРОДУКЦИИ";
            this.reportLabel.Click += new System.EventHandler(this.reportLabel_Click);
            // 
            // documentNumberSelector
            // 
            this.documentNumberSelector.AutoSize = true;
            this.documentNumberSelector.Location = new System.Drawing.Point(343, 36);
            this.documentNumberSelector.Name = "documentNumberSelector";
            this.documentNumberSelector.Size = new System.Drawing.Size(18, 17);
            this.documentNumberSelector.TabIndex = 14;
            this.documentNumberSelector.UseVisualStyleBackColor = true;
            // 
            // senderDepSelector
            // 
            this.senderDepSelector.AutoSize = true;
            this.senderDepSelector.Location = new System.Drawing.Point(343, 42);
            this.senderDepSelector.Name = "senderDepSelector";
            this.senderDepSelector.Size = new System.Drawing.Size(18, 17);
            this.senderDepSelector.TabIndex = 15;
            this.senderDepSelector.UseVisualStyleBackColor = true;
            // 
            // reportEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 678);
            this.Controls.Add(this.reportPanel);
            this.Name = "reportEditForm";
            this.Text = "report";
            this.Load += new System.EventHandler(this.report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportsGrid)).EndInit();
            this.reportDateFilter.ResumeLayout(false);
            this.reportDateFilter.PerformLayout();
            this.reportPanel.ResumeLayout(false);
            this.departmentSearch.ResumeLayout(false);
            this.departmentSearch.PerformLayout();
            this.numberSearch.ResumeLayout(false);
            this.numberSearch.PerformLayout();
            this.Head.ResumeLayout(false);
            this.Head.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView reportsGrid;
        private System.Windows.Forms.DateTimePicker reportDate;
        private System.Windows.Forms.Label reportDateLabel;
        private System.Windows.Forms.GroupBox reportDateFilter;
        private System.Windows.Forms.Label reportHighestDateLabel;
        private System.Windows.Forms.Panel reportPanel;
        private System.Windows.Forms.GroupBox Head;
        private System.Windows.Forms.Label reportLabel;
        private System.Windows.Forms.DateTimePicker reportLowestDate;
        private System.Windows.Forms.Label reportLowestDateLabel;
        private System.Windows.Forms.GroupBox numberSearch;
        private System.Windows.Forms.Label reportNumberLabel;
        private System.Windows.Forms.TextBox reportNumber;
        private System.Windows.Forms.DateTimePicker reportHighestDate;
        private System.Windows.Forms.RadioButton reportDatePeriodSelector;
        private System.Windows.Forms.RadioButton reportDateSelector;
        private System.Windows.Forms.GroupBox departmentSearch;
        private System.Windows.Forms.Label senderDepLabel;
        private System.Windows.Forms.TextBox senderDep;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentNumberColoumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportDateColoumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderDepColoumn;
        private System.Windows.Forms.CheckBox senderDepSelector;
        private System.Windows.Forms.CheckBox documentNumberSelector;
    }
}