
namespace LR4_Team_programming.screens
{
    partial class searchFilterBar
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.departmentSearch = new System.Windows.Forms.GroupBox();
            this.senderDep = new System.Windows.Forms.ComboBox();
            this.senderDepSelector = new System.Windows.Forms.CheckBox();
            this.senderDepLabel = new System.Windows.Forms.Label();
            this.numberSearch = new System.Windows.Forms.GroupBox();
            this.documentNumberSelector = new System.Windows.Forms.CheckBox();
            this.reportNumberLabel = new System.Windows.Forms.Label();
            this.reportNumber = new System.Windows.Forms.TextBox();
            this.reportDateFilter = new System.Windows.Forms.GroupBox();
            this.reportDatePeriodSelector = new System.Windows.Forms.RadioButton();
            this.reportDateSelector = new System.Windows.Forms.RadioButton();
            this.reportHighestDate = new System.Windows.Forms.DateTimePicker();
            this.reportLowestDate = new System.Windows.Forms.DateTimePicker();
            this.reportHighestDateLabel = new System.Windows.Forms.Label();
            this.reportDate = new System.Windows.Forms.DateTimePicker();
            this.reportLowestDateLabel = new System.Windows.Forms.Label();
            this.reportDateLabel = new System.Windows.Forms.Label();
            this.departmentSearch.SuspendLayout();
            this.numberSearch.SuspendLayout();
            this.reportDateFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // departmentSearch
            // 
            this.departmentSearch.Controls.Add(this.senderDep);
            this.departmentSearch.Controls.Add(this.senderDepSelector);
            this.departmentSearch.Controls.Add(this.senderDepLabel);
            this.departmentSearch.Location = new System.Drawing.Point(420, 96);
            this.departmentSearch.Name = "departmentSearch";
            this.departmentSearch.Size = new System.Drawing.Size(380, 76);
            this.departmentSearch.TabIndex = 14;
            this.departmentSearch.TabStop = false;
            this.departmentSearch.Text = "поиск по цеху";
            // 
            // senderDep
            // 
            this.senderDep.FormattingEnabled = true;
            this.senderDep.Location = new System.Drawing.Point(145, 34);
            this.senderDep.Name = "senderDep";
            this.senderDep.Size = new System.Drawing.Size(180, 28);
            this.senderDep.TabIndex = 15;
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
            // senderDepLabel
            // 
            this.senderDepLabel.AutoSize = true;
            this.senderDepLabel.Location = new System.Drawing.Point(12, 37);
            this.senderDepLabel.Name = "senderDepLabel";
            this.senderDepLabel.Size = new System.Drawing.Size(33, 20);
            this.senderDepLabel.TabIndex = 7;
            this.senderDepLabel.Text = "цех";
            // 
            // numberSearch
            // 
            this.numberSearch.Controls.Add(this.documentNumberSelector);
            this.numberSearch.Controls.Add(this.reportNumberLabel);
            this.numberSearch.Controls.Add(this.reportNumber);
            this.numberSearch.Location = new System.Drawing.Point(420, 0);
            this.numberSearch.Name = "numberSearch";
            this.numberSearch.Size = new System.Drawing.Size(380, 76);
            this.numberSearch.TabIndex = 13;
            this.numberSearch.TabStop = false;
            this.numberSearch.Text = "поиск по номеру документа";
            // 
            // documentNumberSelector
            // 
            this.documentNumberSelector.AutoSize = true;
            this.documentNumberSelector.Location = new System.Drawing.Point(343, 36);
            this.documentNumberSelector.Name = "documentNumberSelector";
            this.documentNumberSelector.Size = new System.Drawing.Size(18, 17);
            this.documentNumberSelector.TabIndex = 14;
            this.documentNumberSelector.UseVisualStyleBackColor = true;
            this.documentNumberSelector.CheckedChanged += new System.EventHandler(this.documentNumberSelector_CheckedChanged);
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
            this.reportNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.reportNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.reportNumber.Location = new System.Drawing.Point(145, 34);
            this.reportNumber.Name = "reportNumber";
            this.reportNumber.Size = new System.Drawing.Size(180, 27);
            this.reportNumber.TabIndex = 5;
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
            this.reportDateFilter.Location = new System.Drawing.Point(0, 0);
            this.reportDateFilter.Name = "reportDateFilter";
            this.reportDateFilter.Size = new System.Drawing.Size(380, 172);
            this.reportDateFilter.TabIndex = 12;
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
            this.reportDatePeriodSelector.MouseUp += new System.Windows.Forms.MouseEventHandler(this.reportDatePeriodSelector_MouseUp);
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
            this.reportDateSelector.MouseUp += new System.Windows.Forms.MouseEventHandler(this.reportDateSelector_MouseUp);
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
            // reportLowestDateLabel
            // 
            this.reportLowestDateLabel.AutoSize = true;
            this.reportLowestDateLabel.Location = new System.Drawing.Point(12, 92);
            this.reportLowestDateLabel.Name = "reportLowestDateLabel";
            this.reportLowestDateLabel.Size = new System.Drawing.Size(97, 20);
            this.reportLowestDateLabel.TabIndex = 7;
            this.reportLowestDateLabel.Text = "нижняя дата";
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
            // searchFilterBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.departmentSearch);
            this.Controls.Add(this.numberSearch);
            this.Controls.Add(this.reportDateFilter);
            this.Name = "searchFilterBar";
            this.Size = new System.Drawing.Size(807, 176);
            this.departmentSearch.ResumeLayout(false);
            this.departmentSearch.PerformLayout();
            this.numberSearch.ResumeLayout(false);
            this.numberSearch.PerformLayout();
            this.reportDateFilter.ResumeLayout(false);
            this.reportDateFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox departmentSearch;
        private System.Windows.Forms.CheckBox senderDepSelector;
        private System.Windows.Forms.Label senderDepLabel;
        private System.Windows.Forms.GroupBox numberSearch;
        private System.Windows.Forms.CheckBox documentNumberSelector;
        private System.Windows.Forms.Label reportNumberLabel;
        private System.Windows.Forms.TextBox reportNumber;
        private System.Windows.Forms.GroupBox reportDateFilter;
        private System.Windows.Forms.RadioButton reportDatePeriodSelector;
        private System.Windows.Forms.RadioButton reportDateSelector;
        private System.Windows.Forms.DateTimePicker reportHighestDate;
        private System.Windows.Forms.DateTimePicker reportLowestDate;
        private System.Windows.Forms.Label reportHighestDateLabel;
        private System.Windows.Forms.DateTimePicker reportDate;
        private System.Windows.Forms.Label reportLowestDateLabel;
        private System.Windows.Forms.Label reportDateLabel;
        private System.Windows.Forms.ComboBox senderDep;
    }
}
