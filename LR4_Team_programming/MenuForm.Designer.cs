
namespace LR4_Team_programming
{
    partial class MenuForm
    {
        /// <summary>
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Создание");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Просмотр и редактирование");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Ведомость инвентаризации", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Создать");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Просмотр и редактирование");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Рапорта о выполнении", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.menuTree = new System.Windows.Forms.TreeView();
            this.imagesForMenuTree = new System.Windows.Forms.ImageList(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.AccountingBalancesPanel = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.reciverDep = new System.Windows.Forms.TextBox();
            this.reciverLabel = new System.Windows.Forms.Label();
            this.reportDate = new System.Windows.Forms.DateTimePicker();
            this.senderLabel = new System.Windows.Forms.Label();
            this.senderDep = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.RaportPanel = new System.Windows.Forms.Panel();
            this.Head = new System.Windows.Forms.GroupBox();
            this.anotherReportLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.reportLabel = new System.Windows.Forms.Label();
            this.productsGrid = new System.Windows.Forms.DataGridView();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.okpCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportInfo1 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.VedomostPanel = new System.Windows.Forms.Panel();
            this.AccountingBalancesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.RaportPanel.SuspendLayout();
            this.Head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsGrid)).BeginInit();
            this.reportInfo1.SuspendLayout();
            this.VedomostPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTree
            // 
            this.menuTree.ImageIndex = 0;
            this.menuTree.ImageList = this.imagesForMenuTree;
            this.menuTree.Location = new System.Drawing.Point(12, 12);
            this.menuTree.Name = "menuTree";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "";
            treeNode1.Text = "Создание";
            treeNode2.ImageIndex = 2;
            treeNode2.Name = "";
            treeNode2.Text = "Просмотр и редактирование";
            treeNode3.ImageIndex = 0;
            treeNode3.Name = "Node0";
            treeNode3.Text = "Ведомость инвентаризации";
            treeNode4.ImageIndex = 1;
            treeNode4.Name = "createRaport";
            treeNode4.Text = "Создать";
            treeNode5.ImageIndex = 2;
            treeNode5.Name = "editAndLookRaport";
            treeNode5.Text = "Просмотр и редактирование";
            treeNode6.ImageIndex = 3;
            treeNode6.Name = "raports";
            treeNode6.Text = "Рапорта о выполнении";
            this.menuTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6});
            this.menuTree.SelectedImageIndex = 4;
            this.menuTree.Size = new System.Drawing.Size(353, 690);
            this.menuTree.TabIndex = 4;
            this.menuTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.menuTree_AfterSelect);
            // 
            // imagesForMenuTree
            // 
            this.imagesForMenuTree.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imagesForMenuTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagesForMenuTree.ImageStream")));
            this.imagesForMenuTree.TransparentColor = System.Drawing.Color.Transparent;
            this.imagesForMenuTree.Images.SetKeyName(0, "i.jpg");
            this.imagesForMenuTree.Images.SetKeyName(1, "create-an-icon-from-a-png-3.png");
            this.imagesForMenuTree.Images.SetKeyName(2, "img_179080.png");
            this.imagesForMenuTree.Images.SetKeyName(3, "127-1279288_report-clipart-hd-png-download.png");
            this.imagesForMenuTree.Images.SetKeyName(4, "9e3fc0aa10f16d013eb8cf20e6f2d845.png");
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(14, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(231, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Цех";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(526, 18);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(292, 27);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // AccountingBalancesPanel
            // 
            this.AccountingBalancesPanel.Controls.Add(this.dataGridView2);
            this.AccountingBalancesPanel.Controls.Add(this.comboBox1);
            this.AccountingBalancesPanel.Controls.Add(this.dateTimePicker1);
            this.AccountingBalancesPanel.Location = new System.Drawing.Point(1110, 212);
            this.AccountingBalancesPanel.Name = "AccountingBalancesPanel";
            this.AccountingBalancesPanel.Size = new System.Drawing.Size(835, 690);
            this.AccountingBalancesPanel.TabIndex = 5;
            this.AccountingBalancesPanel.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(14, 63);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(804, 576);
            this.dataGridView2.TabIndex = 0;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeight = 29;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewComboBoxColumn1,
            this.dataGridViewComboBoxColumn2,
            this.Column4});
            this.dataGridView3.Location = new System.Drawing.Point(5, 228);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.Size = new System.Drawing.Size(823, 410);
            this.dataGridView3.TabIndex = 0;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.dateTimePicker2);
            this.groupBox3.Location = new System.Drawing.Point(29, 82);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(774, 125);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Информация о документе";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Цех";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(316, 78);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(203, 28);
            this.comboBox2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Дата составления документа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "№ документа";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Номер документа";
            this.textBox1.Size = new System.Drawing.Size(194, 27);
            this.textBox1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd MMMM yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(564, 35);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(194, 27);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(260, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ВЕДОМОСТЬ ИНВЕНТАРИЗАЦИИ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // reciverDep
            // 
            this.reciverDep.Location = new System.Drawing.Point(0, 0);
            this.reciverDep.Name = "reciverDep";
            this.reciverDep.Size = new System.Drawing.Size(100, 27);
            this.reciverDep.TabIndex = 0;
            // 
            // reciverLabel
            // 
            this.reciverLabel.Location = new System.Drawing.Point(0, 0);
            this.reciverLabel.Name = "reciverLabel";
            this.reciverLabel.Size = new System.Drawing.Size(100, 23);
            this.reciverLabel.TabIndex = 0;
            // 
            // reportDate
            // 
            this.reportDate.Location = new System.Drawing.Point(0, 0);
            this.reportDate.Name = "reportDate";
            this.reportDate.Size = new System.Drawing.Size(200, 27);
            this.reportDate.TabIndex = 0;
            // 
            // senderLabel
            // 
            this.senderLabel.Location = new System.Drawing.Point(0, 0);
            this.senderLabel.Name = "senderLabel";
            this.senderLabel.Size = new System.Drawing.Size(100, 23);
            this.senderLabel.TabIndex = 0;
            // 
            // senderDep
            // 
            this.senderDep.Location = new System.Drawing.Point(0, 0);
            this.senderDep.Name = "senderDep";
            this.senderDep.Size = new System.Drawing.Size(100, 27);
            this.senderDep.TabIndex = 0;
            // 
            // dateLabel
            // 
            this.dateLabel.Location = new System.Drawing.Point(0, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(100, 23);
            this.dateLabel.TabIndex = 0;
            // 
            // RaportPanel
            // 
            this.RaportPanel.Controls.Add(this.Head);
            this.RaportPanel.Controls.Add(this.productsGrid);
            this.RaportPanel.Controls.Add(this.reportInfo1);
            this.RaportPanel.Location = new System.Drawing.Point(1001, 322);
            this.RaportPanel.Name = "RaportPanel";
            this.RaportPanel.Size = new System.Drawing.Size(835, 690);
            this.RaportPanel.TabIndex = 12;
            // 
            // Head
            // 
            this.Head.Controls.Add(this.anotherReportLabel);
            this.Head.Controls.Add(this.textBox2);
            this.Head.Controls.Add(this.reportLabel);
            this.Head.Location = new System.Drawing.Point(20, 10);
            this.Head.Name = "Head";
            this.Head.Size = new System.Drawing.Size(797, 69);
            this.Head.TabIndex = 10;
            this.Head.TabStop = false;
            // 
            // anotherReportLabel
            // 
            this.anotherReportLabel.AutoSize = true;
            this.anotherReportLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.anotherReportLabel.Location = new System.Drawing.Point(388, 23);
            this.anotherReportLabel.Name = "anotherReportLabel";
            this.anotherReportLabel.Size = new System.Drawing.Size(360, 31);
            this.anotherReportLabel.TabIndex = 2;
            this.anotherReportLabel.Text = "СДАЧИ ПРОДУКЦИИ ЦЕХАМИ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(244, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(138, 27);
            this.textBox2.TabIndex = 9;
            // 
            // reportLabel
            // 
            this.reportLabel.AutoSize = true;
            this.reportLabel.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.reportLabel.Location = new System.Drawing.Point(92, 22);
            this.reportLabel.Name = "reportLabel";
            this.reportLabel.Size = new System.Drawing.Size(146, 32);
            this.reportLabel.TabIndex = 0;
            this.reportLabel.Text = "РАПОРТ №";
            // 
            // productsGrid
            // 
            this.productsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productName,
            this.okpCode,
            this.dataGridViewTextBoxColumn1});
            this.productsGrid.Location = new System.Drawing.Point(20, 309);
            this.productsGrid.Name = "productsGrid";
            this.productsGrid.RowHeadersWidth = 51;
            this.productsGrid.Size = new System.Drawing.Size(797, 354);
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // reportInfo1
            // 
            this.reportInfo1.Controls.Add(this.textBox5);
            this.reportInfo1.Controls.Add(this.label8);
            this.reportInfo1.Controls.Add(this.dateTimePicker4);
            this.reportInfo1.Controls.Add(this.label9);
            this.reportInfo1.Controls.Add(this.textBox6);
            this.reportInfo1.Controls.Add(this.label10);
            this.reportInfo1.Location = new System.Drawing.Point(20, 107);
            this.reportInfo1.Name = "reportInfo1";
            this.reportInfo1.Size = new System.Drawing.Size(380, 172);
            this.reportInfo1.TabIndex = 8;
            this.reportInfo1.TabStop = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(145, 115);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(180, 27);
            this.textBox5.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "цех-получатель";
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.CustomFormat = "dd MMMM yyyy";
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker4.Location = new System.Drawing.Point(145, 34);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(180, 27);
            this.dateTimePicker4.TabIndex = 4;
            this.dateTimePicker4.Value = new System.DateTime(2021, 3, 25, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "цех-отправитель";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(145, 74);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(180, 27);
            this.textBox6.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "от";
            // 
            // VedomostPanel
            // 
            this.VedomostPanel.Controls.Add(this.groupBox3);
            this.VedomostPanel.Controls.Add(this.label1);
            this.VedomostPanel.Controls.Add(this.dataGridView3);
            this.VedomostPanel.Location = new System.Drawing.Point(922, 429);
            this.VedomostPanel.Name = "VedomostPanel";
            this.VedomostPanel.Size = new System.Drawing.Size(835, 690);
            this.VedomostPanel.TabIndex = 13;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1494, 714);
            this.Controls.Add(this.AccountingBalancesPanel);
            this.Controls.Add(this.RaportPanel);
            this.Controls.Add(this.menuTree);
            this.Controls.Add(this.VedomostPanel);
            this.Name = "MenuForm";
            this.Text = "m";
            this.AccountingBalancesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.RaportPanel.ResumeLayout(false);
            this.Head.ResumeLayout(false);
            this.Head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsGrid)).EndInit();
            this.reportInfo1.ResumeLayout(false);
            this.reportInfo1.PerformLayout();
            this.VedomostPanel.ResumeLayout(false);
            this.VedomostPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView menuTree;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel AccountingBalancesPanel;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox fg;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewComboBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;


        private System.Windows.Forms.TextBox reciverDep;
        private System.Windows.Forms.Label reciverLabel;
        private System.Windows.Forms.DateTimePicker reportDate;
        private System.Windows.Forms.Label senderLabel;
        private System.Windows.Forms.TextBox senderDep;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox textBox3;
        //private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel RaportPanel;
        private System.Windows.Forms.GroupBox Head;
        private System.Windows.Forms.Label anotherReportLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label reportLabel;
        private System.Windows.Forms.DataGridView productsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn okpCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.GroupBox reportInfo1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel VedomostPanel;
        private System.Windows.Forms.ImageList imagesForMenuTree;
    }
}