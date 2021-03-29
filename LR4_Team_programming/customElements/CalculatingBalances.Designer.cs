
namespace LR4_Team_programming.customElements
{
    partial class CalculatingBalances
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatingBalances));
            this.headerLabel = new System.Windows.Forms.Label();
            this.searchPanel = new System.Windows.Forms.GroupBox();
            this.depNameComboBox = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.dateLabel = new System.Windows.Forms.Label();
            this.depLabel = new System.Windows.Forms.Label();
            this.table = new System.Windows.Forms.DataGridView();
            this.detailNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeOKPColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.headerLabel.Location = new System.Drawing.Point(86, 10);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(670, 32);
            this.headerLabel.TabIndex = 2;
            this.headerLabel.Text = "РАСЧЕТ ОСТАТКОВ НЕЗАВЕРШЕННОГО ПРОИЗВОДСТВА";
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.searchButton);
            this.searchPanel.Controls.Add(this.depNameComboBox);
            this.searchPanel.Controls.Add(this.date);
            this.searchPanel.Controls.Add(this.dateLabel);
            this.searchPanel.Controls.Add(this.depLabel);
            this.searchPanel.Location = new System.Drawing.Point(9, 61);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(399, 141);
            this.searchPanel.TabIndex = 3;
            this.searchPanel.TabStop = false;
            this.searchPanel.Text = "поиск";
            // 
            // depNameComboBox
            // 
            this.depNameComboBox.FormattingEnabled = true;
            this.depNameComboBox.Location = new System.Drawing.Point(65, 37);
            this.depNameComboBox.Name = "depNameComboBox";
            this.depNameComboBox.Size = new System.Drawing.Size(241, 28);
            this.depNameComboBox.TabIndex = 14;
            // 
            // date
            // 
            this.date.CustomFormat = "dd MMMM yyyy";
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(65, 86);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(241, 27);
            this.date.TabIndex = 13;
            this.date.Value = new System.DateTime(2021, 3, 25, 0, 0, 0, 0);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(6, 91);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(41, 20);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "Дата";
            // 
            // depLabel
            // 
            this.depLabel.AutoSize = true;
            this.depLabel.Location = new System.Drawing.Point(6, 37);
            this.depLabel.Name = "depLabel";
            this.depLabel.Size = new System.Drawing.Size(35, 20);
            this.depLabel.TabIndex = 0;
            this.depLabel.Text = "Цех";
            // 
            // table
            // 
            this.table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detailNameColumn,
            this.codeOKPColumn,
            this.amount});
            this.table.Location = new System.Drawing.Point(9, 217);
            this.table.Name = "table";
            this.table.RowHeadersWidth = 51;
            this.table.RowTemplate.Height = 29;
            this.table.Size = new System.Drawing.Size(814, 461);
            this.table.TabIndex = 4;
            // 
            // detailNameColumn
            // 
            this.detailNameColumn.HeaderText = "Название детали";
            this.detailNameColumn.MinimumWidth = 6;
            this.detailNameColumn.Name = "detailNameColumn";
            // 
            // codeOKPColumn
            // 
            this.codeOKPColumn.HeaderText = "Код по ОКП";
            this.codeOKPColumn.MinimumWidth = 6;
            this.codeOKPColumn.Name = "codeOKPColumn";
            // 
            // amount
            // 
            this.amount.HeaderText = "Количество, шт";
            this.amount.MinimumWidth = 6;
            this.amount.Name = "amount";
            // 
            // searchButton
            // 
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.Location = new System.Drawing.Point(358, 100);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(35, 35);
            this.searchButton.TabIndex = 18;
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // CalculatingBalances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.table);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.headerLabel);
            this.Name = "CalculatingBalances";
            this.Size = new System.Drawing.Size(835, 690);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.GroupBox searchPanel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label depLabel;
        private System.Windows.Forms.ComboBox depNameComboBox;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeOKPColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.Button searchButton;
    }
}
