
namespace LR4_Team_programming.customElements
{
    partial class InventarizationDocument
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteRecordButton = new System.Windows.Forms.Button();
            this.saveChangeButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.informationAboutDocPanel = new System.Windows.Forms.GroupBox();
            this.depLabel = new System.Windows.Forms.Label();
            this.depTextBox = new System.Windows.Forms.ComboBox();
            this.docCreateDateLabel = new System.Windows.Forms.Label();
            this.docNumberLabel = new System.Windows.Forms.Label();
            this.docNumberTextBox = new System.Windows.Forms.TextBox();
            this.docCreateDate = new System.Windows.Forms.DateTimePicker();
            this.headerLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.informationAboutDocPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.headerLabel);
            this.groupBox1.Controls.Add(this.deleteRecordButton);
            this.groupBox1.Controls.Add(this.saveChangeButton);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.informationAboutDocPanel);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(835, 687);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // deleteRecordButton
            // 
            this.deleteRecordButton.Location = new System.Drawing.Point(531, 645);
            this.deleteRecordButton.Name = "deleteRecordButton";
            this.deleteRecordButton.Size = new System.Drawing.Size(298, 36);
            this.deleteRecordButton.TabIndex = 7;
            this.deleteRecordButton.Text = "Удалить запись";
            this.deleteRecordButton.UseVisualStyleBackColor = true;
            // 
            // saveChangeButton
            // 
            this.saveChangeButton.Location = new System.Drawing.Point(6, 645);
            this.saveChangeButton.Name = "saveChangeButton";
            this.saveChangeButton.Size = new System.Drawing.Size(298, 36);
            this.saveChangeButton.TabIndex = 6;
            this.saveChangeButton.Text = "Сохранить изменения";
            this.saveChangeButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewComboBoxColumn1,
            this.dataGridViewComboBoxColumn2,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(6, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(823, 428);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.HeaderText = "Название детали";
            this.dataGridViewComboBoxColumn1.MinimumWidth = 6;
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            // 
            // dataGridViewComboBoxColumn2
            // 
            this.dataGridViewComboBoxColumn2.HeaderText = "Код по ОКП";
            this.dataGridViewComboBoxColumn2.MinimumWidth = 6;
            this.dataGridViewComboBoxColumn2.Name = "dataGridViewComboBoxColumn2";
            this.dataGridViewComboBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Количество, шт";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // informationAboutDocPanel
            // 
            this.informationAboutDocPanel.Controls.Add(this.depLabel);
            this.informationAboutDocPanel.Controls.Add(this.depTextBox);
            this.informationAboutDocPanel.Controls.Add(this.docCreateDateLabel);
            this.informationAboutDocPanel.Controls.Add(this.docNumberLabel);
            this.informationAboutDocPanel.Controls.Add(this.docNumberTextBox);
            this.informationAboutDocPanel.Controls.Add(this.docCreateDate);
            this.informationAboutDocPanel.Location = new System.Drawing.Point(30, 69);
            this.informationAboutDocPanel.Name = "informationAboutDocPanel";
            this.informationAboutDocPanel.Size = new System.Drawing.Size(774, 125);
            this.informationAboutDocPanel.TabIndex = 5;
            this.informationAboutDocPanel.TabStop = false;
            this.informationAboutDocPanel.Text = "Информация о документе";
            // 
            // depLabel
            // 
            this.depLabel.AutoSize = true;
            this.depLabel.Location = new System.Drawing.Point(74, 76);
            this.depLabel.Name = "depLabel";
            this.depLabel.Size = new System.Drawing.Size(35, 20);
            this.depLabel.TabIndex = 8;
            this.depLabel.Text = "Цех";
            // 
            // depTextBox
            // 
            this.depTextBox.FormattingEnabled = true;
            this.depTextBox.Location = new System.Drawing.Point(122, 73);
            this.depTextBox.Name = "depTextBox";
            this.depTextBox.Size = new System.Drawing.Size(206, 28);
            this.depTextBox.TabIndex = 7;
            // 
            // docCreateDateLabel
            // 
            this.docCreateDateLabel.AutoSize = true;
            this.docCreateDateLabel.Location = new System.Drawing.Point(349, 36);
            this.docCreateDateLabel.Name = "docCreateDateLabel";
            this.docCreateDateLabel.Size = new System.Drawing.Size(209, 20);
            this.docCreateDateLabel.TabIndex = 6;
            this.docCreateDateLabel.Text = "Дата составления документа";
            // 
            // docNumberLabel
            // 
            this.docNumberLabel.AutoSize = true;
            this.docNumberLabel.Location = new System.Drawing.Point(6, 36);
            this.docNumberLabel.Name = "docNumberLabel";
            this.docNumberLabel.Size = new System.Drawing.Size(103, 20);
            this.docNumberLabel.TabIndex = 6;
            this.docNumberLabel.Text = "№ документа";
            // 
            // docNumberTextBox
            // 
            this.docNumberTextBox.Location = new System.Drawing.Point(122, 35);
            this.docNumberTextBox.Name = "docNumberTextBox";
            this.docNumberTextBox.PlaceholderText = "Номер документа";
            this.docNumberTextBox.Size = new System.Drawing.Size(206, 27);
            this.docNumberTextBox.TabIndex = 6;
            // 
            // docCreateDate
            // 
            this.docCreateDate.CustomFormat = "dd MMMM yyyy";
            this.docCreateDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.docCreateDate.Location = new System.Drawing.Point(564, 35);
            this.docCreateDate.Name = "docCreateDate";
            this.docCreateDate.Size = new System.Drawing.Size(194, 27);
            this.docCreateDate.TabIndex = 2;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.headerLabel.Location = new System.Drawing.Point(208, 23);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(407, 32);
            this.headerLabel.TabIndex = 8;
            this.headerLabel.Text = "ВЕДОМОСТЬ ИНВЕНТАРИЗАЦИИ";
            // 
            // InventarizationDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "InventarizationDocument";
            this.Size = new System.Drawing.Size(835, 690);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.informationAboutDocPanel.ResumeLayout(false);
            this.informationAboutDocPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveChangeButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewComboBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox informationAboutDocPanel;
        private System.Windows.Forms.Label depLabel;
        private System.Windows.Forms.ComboBox depTextBox;
        private System.Windows.Forms.Label docCreateDateLabel;
        private System.Windows.Forms.Label docNumberLabel;
        private System.Windows.Forms.TextBox docNumberTextBox;
        private System.Windows.Forms.DateTimePicker docCreateDate;
        private System.Windows.Forms.Button deleteRecordButton;
        private System.Windows.Forms.Label headerLabel;
    }
}
