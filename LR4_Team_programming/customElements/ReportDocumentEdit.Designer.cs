
namespace LR4_Team_programming.customElements
{
    partial class ReportDocumentEdit
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
            this.reportEditPanel = new System.Windows.Forms.Panel();
            this.reportsGrid = new System.Windows.Forms.DataGridView();
            this.documentNumberColoumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportDateColoumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderDepColoumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchFilterBar1 = new LR4_Team_programming.screens.searchFilterBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.reportEditPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportsGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportEditPanel
            // 
            this.reportEditPanel.Controls.Add(this.reportsGrid);
            this.reportEditPanel.Controls.Add(this.searchFilterBar1);
            this.reportEditPanel.Controls.Add(this.groupBox1);
            this.reportEditPanel.Location = new System.Drawing.Point(0, 0);
            this.reportEditPanel.Name = "reportEditPanel";
            this.reportEditPanel.Size = new System.Drawing.Size(835, 690);
            this.reportEditPanel.TabIndex = 18;
            // 
            // reportsGrid
            // 
            this.reportsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reportsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.documentNumberColoumn,
            this.reportDateColoumn,
            this.senderDepColoumn});
            this.reportsGrid.Location = new System.Drawing.Point(20, 280);
            this.reportsGrid.Name = "reportsGrid";
            this.reportsGrid.RowHeadersWidth = 51;
            this.reportsGrid.Size = new System.Drawing.Size(800, 398);
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
            // searchFilterBar1
            // 
            this.searchFilterBar1.Location = new System.Drawing.Point(20, 85);
            this.searchFilterBar1.Name = "searchFilterBar1";
            this.searchFilterBar1.Size = new System.Drawing.Size(808, 220);
            this.searchFilterBar1.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(20, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(808, 69);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(204, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(384, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "РАПОРТА СДАЧИ ПРОДУКЦИИ";
            // 
            // ReportDocumentEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportEditPanel);
            this.Name = "ReportDocumentEdit";
            this.Size = new System.Drawing.Size(835, 690);
            this.reportEditPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reportsGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel reportEditPanel;
        private System.Windows.Forms.DataGridView reportsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentNumberColoumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportDateColoumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderDepColoumn;
        private screens.searchFilterBar searchFilterBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
    }
}
