
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportDocumentEdit));
            this.reportEditPanel = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.searchButton = new System.Windows.Forms.Button();
            this.reportsGrid = new System.Windows.Forms.DataGridView();
            this.documentNumberColoumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportDateColoumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderDepColoumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.searchFilterBar1 = new LR4_Team_programming.screens.searchFilterBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.reportEditPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportsGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportEditPanel
            // 
            this.reportEditPanel.Controls.Add(this.progressBar);
            this.reportEditPanel.Controls.Add(this.searchButton);
            this.reportEditPanel.Controls.Add(this.reportsGrid);
            this.reportEditPanel.Controls.Add(this.searchFilterBar1);
            this.reportEditPanel.Controls.Add(this.groupBox1);
            this.reportEditPanel.Location = new System.Drawing.Point(0, 0);
            this.reportEditPanel.Name = "reportEditPanel";
            this.reportEditPanel.Size = new System.Drawing.Size(835, 690);
            this.reportEditPanel.TabIndex = 18;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(19, 259);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(801, 29);
            this.progressBar.Step = 300;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 21;
            this.progressBar.Visible = false;
            // 
            // searchButton
            // 
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.Location = new System.Drawing.Point(404, 157);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(35, 35);
            this.searchButton.TabIndex = 18;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // reportsGrid
            // 
            this.reportsGrid.AllowUserToAddRows = false;
            this.reportsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reportsGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.reportsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.documentNumberColoumn,
            this.reportDateColoumn,
            this.senderDepColoumn,
            this.editColumn,
            this.deleteColumn});
            this.reportsGrid.Location = new System.Drawing.Point(20, 294);
            this.reportsGrid.Name = "reportsGrid";
            this.reportsGrid.ReadOnly = true;
            this.reportsGrid.RowHeadersWidth = 51;
            this.reportsGrid.Size = new System.Drawing.Size(800, 396);
            this.reportsGrid.TabIndex = 1;
            this.reportsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reportsGrid_CellContentClick);
            this.reportsGrid.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.reportsGrid_CellPainting);
            this.reportsGrid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.reportsGrid_RowsAdded);
            // 
            // documentNumberColoumn
            // 
            this.documentNumberColoumn.FillWeight = 97.05215F;
            this.documentNumberColoumn.HeaderText = "Номер рапорта";
            this.documentNumberColoumn.MinimumWidth = 6;
            this.documentNumberColoumn.Name = "documentNumberColoumn";
            this.documentNumberColoumn.ReadOnly = true;
            // 
            // reportDateColoumn
            // 
            this.reportDateColoumn.FillWeight = 97.05215F;
            this.reportDateColoumn.HeaderText = "Дата составления";
            this.reportDateColoumn.MinimumWidth = 6;
            this.reportDateColoumn.Name = "reportDateColoumn";
            this.reportDateColoumn.ReadOnly = true;
            // 
            // senderDepColoumn
            // 
            this.senderDepColoumn.FillWeight = 97.05215F;
            this.senderDepColoumn.HeaderText = "Цех-отправитель";
            this.senderDepColoumn.MinimumWidth = 6;
            this.senderDepColoumn.Name = "senderDepColoumn";
            this.senderDepColoumn.ReadOnly = true;
            // 
            // editColumn
            // 
            this.editColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.editColumn.HeaderText = "";
            this.editColumn.MinimumWidth = 6;
            this.editColumn.Name = "editColumn";
            this.editColumn.ReadOnly = true;
            this.editColumn.Width = 40;
            // 
            // deleteColumn
            // 
            this.deleteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.deleteColumn.FillWeight = 108.8435F;
            this.deleteColumn.HeaderText = "";
            this.deleteColumn.MinimumWidth = 6;
            this.deleteColumn.Name = "deleteColumn";
            this.deleteColumn.ReadOnly = true;
            this.deleteColumn.Width = 40;
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
            this.groupBox1.Size = new System.Drawing.Size(800, 69);
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
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Image1");
            this.imageList1.Images.SetKeyName(1, "Image2");
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
        private screens.searchFilterBar searchFilterBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentNumberColoumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportDateColoumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderDepColoumn;
        private System.Windows.Forms.DataGridViewButtonColumn editColumn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteColumn;
    }
}
