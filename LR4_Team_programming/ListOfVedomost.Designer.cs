
namespace LR4_Team_programming
{
    partial class ListOfVedomost
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.editAndListVedomost = new System.Windows.Forms.Panel();
            this.inventarizationTable = new System.Windows.Forms.DataGridView();
            this.documentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreateDocument = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventarizationSearchPanel = new System.Windows.Forms.GroupBox();
            this.finishDateSearch = new System.Windows.Forms.DateTimePicker();
            this.finishDateSearchLabel = new System.Windows.Forms.Label();
            this.startDateSearch = new System.Windows.Forms.DateTimePicker();
            this.startDateSearchLabel = new System.Windows.Forms.Label();
            this.inventarizationHeader = new System.Windows.Forms.Label();
            this.editAndListVedomost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventarizationTable)).BeginInit();
            this.inventarizationSearchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // editAndListVedomost
            // 
            this.editAndListVedomost.Controls.Add(this.inventarizationTable);
            this.editAndListVedomost.Controls.Add(this.inventarizationSearchPanel);
            this.editAndListVedomost.Controls.Add(this.inventarizationHeader);
            this.editAndListVedomost.Location = new System.Drawing.Point(24, 22);
            this.editAndListVedomost.Name = "editAndListVedomost";
            this.editAndListVedomost.Size = new System.Drawing.Size(835, 690);
            this.editAndListVedomost.TabIndex = 15;
            // 
            // inventarizationTable
            // 
            this.inventarizationTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inventarizationTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventarizationTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.documentNumber,
            this.dateCreateDocument});
            this.inventarizationTable.Location = new System.Drawing.Point(29, 168);
            this.inventarizationTable.Name = "inventarizationTable";
            this.inventarizationTable.RowHeadersWidth = 51;
            this.inventarizationTable.RowTemplate.Height = 29;
            this.inventarizationTable.Size = new System.Drawing.Size(782, 447);
            this.inventarizationTable.TabIndex = 3;
            // 
            // documentNumber
            // 
            this.documentNumber.HeaderText = "Номер документа";
            this.documentNumber.MinimumWidth = 6;
            this.documentNumber.Name = "documentNumber";
            // 
            // dateCreateDocument
            // 
            this.dateCreateDocument.HeaderText = "Дата создания документа";
            this.dateCreateDocument.MinimumWidth = 6;
            this.dateCreateDocument.Name = "dateCreateDocument";
            // 
            // inventarizationSearchPanel
            // 
            this.inventarizationSearchPanel.Controls.Add(this.finishDateSearch);
            this.inventarizationSearchPanel.Controls.Add(this.finishDateSearchLabel);
            this.inventarizationSearchPanel.Controls.Add(this.startDateSearch);
            this.inventarizationSearchPanel.Controls.Add(this.startDateSearchLabel);
            this.inventarizationSearchPanel.Location = new System.Drawing.Point(29, 54);
            this.inventarizationSearchPanel.Name = "inventarizationSearchPanel";
            this.inventarizationSearchPanel.Size = new System.Drawing.Size(782, 87);
            this.inventarizationSearchPanel.TabIndex = 2;
            this.inventarizationSearchPanel.TabStop = false;
            this.inventarizationSearchPanel.Text = "Поиск";
            // 
            // finishDateSearch
            // 
            this.finishDateSearch.CustomFormat = "dd MMMM yyyy";
            this.finishDateSearch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.finishDateSearch.Location = new System.Drawing.Point(516, 37);
            this.finishDateSearch.Name = "finishDateSearch";
            this.finishDateSearch.Size = new System.Drawing.Size(180, 27);
            this.finishDateSearch.TabIndex = 7;
            this.finishDateSearch.Value = new System.DateTime(2021, 3, 25, 0, 0, 0, 0);
            // 
            // finishDateSearchLabel
            // 
            this.finishDateSearchLabel.AutoSize = true;
            this.finishDateSearchLabel.Location = new System.Drawing.Point(465, 44);
            this.finishDateSearchLabel.Name = "finishDateSearchLabel";
            this.finishDateSearchLabel.Size = new System.Drawing.Size(27, 20);
            this.finishDateSearchLabel.TabIndex = 6;
            this.finishDateSearchLabel.Text = "по";
            // 
            // startDateSearch
            // 
            this.startDateSearch.CustomFormat = "dd MMMM yyyy";
            this.startDateSearch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDateSearch.Location = new System.Drawing.Point(256, 37);
            this.startDateSearch.Name = "startDateSearch";
            this.startDateSearch.Size = new System.Drawing.Size(180, 27);
            this.startDateSearch.TabIndex = 5;
            this.startDateSearch.Value = new System.DateTime(2021, 3, 25, 0, 0, 0, 0);
            // 
            // startDateSearchLabel
            // 
            this.startDateSearchLabel.AutoSize = true;
            this.startDateSearchLabel.Location = new System.Drawing.Point(87, 42);
            this.startDateSearchLabel.Name = "startDateSearchLabel";
            this.startDateSearchLabel.Size = new System.Drawing.Size(146, 20);
            this.startDateSearchLabel.TabIndex = 1;
            this.startDateSearchLabel.Text = "Найти ведомости с ";
            // 
            // inventarizationHeader
            // 
            this.inventarizationHeader.AutoSize = true;
            this.inventarizationHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.inventarizationHeader.Location = new System.Drawing.Point(272, 14);
            this.inventarizationHeader.Name = "inventarizationHeader";
            this.inventarizationHeader.Size = new System.Drawing.Size(301, 25);
            this.inventarizationHeader.TabIndex = 1;
            this.inventarizationHeader.Text = "ВЕДОМОСТИ ИНВЕНТАРИЗАЦИИ";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 639);
            this.Controls.Add(this.editAndListVedomost);
            this.Name = "login";
            this.Text = "LR4";
            this.editAndListVedomost.ResumeLayout(false);
            this.editAndListVedomost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventarizationTable)).EndInit();
            this.inventarizationSearchPanel.ResumeLayout(false);
            this.inventarizationSearchPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel editAndListVedomost;
        private System.Windows.Forms.DataGridView inventarizationTable;
        private System.Windows.Forms.GroupBox inventarizationSearchPanel;
        private System.Windows.Forms.Label startDateSearchLabel;
        private System.Windows.Forms.Label inventarizationHeader;
        private System.Windows.Forms.DateTimePicker finishDateSearch;
        private System.Windows.Forms.Label finishDateSearchLabel;
        private System.Windows.Forms.DateTimePicker startDateSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreateDocument;
    }
}

