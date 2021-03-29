
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
            this.searchButton = new System.Windows.Forms.Button();
            this.inventarizationTable = new System.Windows.Forms.DataGridView();
            this.documentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreateDocument = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchFilterBar1 = new LR4_Team_programming.screens.searchFilterBar();
            this.headerLabel = new System.Windows.Forms.Label();
            this.editAndLookVedomost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventarizationTable)).BeginInit();
            this.SuspendLayout();
            // 
            // editAndLookVedomost
            // 
            this.editAndLookVedomost.Controls.Add(this.headerLabel);
            this.editAndLookVedomost.Controls.Add(this.searchButton);
            this.editAndLookVedomost.Controls.Add(this.inventarizationTable);
            this.editAndLookVedomost.Controls.Add(this.searchFilterBar1);
            this.editAndLookVedomost.Location = new System.Drawing.Point(0, 0);
            this.editAndLookVedomost.Name = "editAndLookVedomost";
            this.editAndLookVedomost.Size = new System.Drawing.Size(835, 690);
            this.editAndLookVedomost.TabIndex = 17;
            // 
            // searchButton
            // 
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.Location = new System.Drawing.Point(402, 126);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(35, 35);
            this.searchButton.TabIndex = 18;
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // inventarizationTable
            // 
            this.inventarizationTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inventarizationTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventarizationTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.documentNumber,
            this.dateCreateDocument});
            this.inventarizationTable.Location = new System.Drawing.Point(20, 251);
            this.inventarizationTable.Name = "inventarizationTable";
            this.inventarizationTable.RowHeadersWidth = 51;
            this.inventarizationTable.RowTemplate.Height = 29;
            this.inventarizationTable.Size = new System.Drawing.Size(801, 428);
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
            // searchFilterBar1
            // 
            this.searchFilterBar1.Location = new System.Drawing.Point(20, 54);
            this.searchFilterBar1.Name = "searchFilterBar1";
            this.searchFilterBar1.Size = new System.Drawing.Size(814, 191);
            this.searchFilterBar1.TabIndex = 4;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn documentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreateDocument;
        private screens.searchFilterBar searchFilterBar1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label headerLabel;
    }
}
