
namespace LR4_Team_programming.customElements
{
    partial class InventarizationDocumentEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventarizationDocumentEdit));
            this.editAndLookVedomost = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.headerLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.inventarizationTable = new System.Windows.Forms.DataGridView();
            this.searchFilterBar1 = new LR4_Team_programming.screens.searchFilterBar();
            this.documentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreateDocument = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifyColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.editAndLookVedomost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventarizationTable)).BeginInit();
            this.SuspendLayout();
            // 
            // editAndLookVedomost
            // 
            this.editAndLookVedomost.Controls.Add(this.progressBar);
            this.editAndLookVedomost.Controls.Add(this.headerLabel);
            this.editAndLookVedomost.Controls.Add(this.searchButton);
            this.editAndLookVedomost.Controls.Add(this.inventarizationTable);
            this.editAndLookVedomost.Controls.Add(this.searchFilterBar1);
            this.editAndLookVedomost.Location = new System.Drawing.Point(0, 0);
            this.editAndLookVedomost.Name = "editAndLookVedomost";
            this.editAndLookVedomost.Size = new System.Drawing.Size(835, 690);
            this.editAndLookVedomost.TabIndex = 17;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(20, 234);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(801, 29);
            this.progressBar.Step = 300;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 20;
            this.progressBar.Visible = false;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.headerLabel.Location = new System.Drawing.Point(213, 10);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(411, 32);
            this.headerLabel.TabIndex = 19;
            this.headerLabel.Text = "ВЕДОМОСТИ ИНВЕНТАРИЗАЦИИ";
            // 
            // searchButton
            // 
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.Location = new System.Drawing.Point(402, 126);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(35, 35);
            this.searchButton.TabIndex = 18;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // inventarizationTable
            // 
            this.inventarizationTable.AllowUserToAddRows = false;
            this.inventarizationTable.AllowUserToDeleteRows = false;
            this.inventarizationTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inventarizationTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventarizationTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.documentNumber,
            this.dateCreateDocument,
            this.modifyColumn});
            this.inventarizationTable.Location = new System.Drawing.Point(20, 269);
            this.inventarizationTable.Name = "inventarizationTable";
            this.inventarizationTable.ReadOnly = true;
            this.inventarizationTable.RowHeadersVisible = false;
            this.inventarizationTable.RowHeadersWidth = 51;
            this.inventarizationTable.RowTemplate.Height = 29;
            this.inventarizationTable.Size = new System.Drawing.Size(801, 410);
            this.inventarizationTable.TabIndex = 3;
            // 
            // searchFilterBar1
            // 
            this.searchFilterBar1.Location = new System.Drawing.Point(20, 54);
            this.searchFilterBar1.Name = "searchFilterBar1";
            this.searchFilterBar1.Size = new System.Drawing.Size(815, 191);
            this.searchFilterBar1.TabIndex = 4;
            // 
            // documentNumber
            // 
            this.documentNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.documentNumber.FillWeight = 109.893F;
            this.documentNumber.HeaderText = "Номер документа";
            this.documentNumber.MinimumWidth = 6;
            this.documentNumber.Name = "documentNumber";
            this.documentNumber.ReadOnly = true;
            // 
            // dateCreateDocument
            // 
            this.dateCreateDocument.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dateCreateDocument.FillWeight = 109.893F;
            this.dateCreateDocument.HeaderText = "Дата создания документа";
            this.dateCreateDocument.MinimumWidth = 6;
            this.dateCreateDocument.Name = "dateCreateDocument";
            this.dateCreateDocument.ReadOnly = true;
            this.dateCreateDocument.Width = 350;
            // 
            // modifyColumn
            // 
            this.modifyColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.modifyColumn.FillWeight = 80.21391F;
            this.modifyColumn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.modifyColumn.HeaderText = "";
            this.modifyColumn.MinimumWidth = 6;
            this.modifyColumn.Name = "modifyColumn";
            this.modifyColumn.ReadOnly = true;
            this.modifyColumn.Width = 50;
            // 
            // InventarizationDocumentEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.editAndLookVedomost);
            this.Name = "InventarizationDocumentEdit";
            this.Size = new System.Drawing.Size(835, 690);
            this.editAndLookVedomost.ResumeLayout(false);
            this.editAndLookVedomost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventarizationTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel editAndLookVedomost;
        private System.Windows.Forms.DataGridView inventarizationTable;
        private screens.searchFilterBar searchFilterBar1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreateDocument;
        private System.Windows.Forms.DataGridViewButtonColumn modifyColumn;
    }
}
