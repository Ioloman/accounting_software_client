
namespace LR4_Team_programming
{
    partial class mainForm
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
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Создание");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Просмотр и редактирование");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Ведомость инвентаризации", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Создание");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Просмотр и редактирование");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Рапорта о выполнении", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.menuTree = new System.Windows.Forms.TreeView();
            this.imagesForMenuTree = new System.Windows.Forms.ImageList(this.components);
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
            this.reportPanel = new System.Windows.Forms.Panel();
            this.Head = new System.Windows.Forms.GroupBox();
            this.anotherReportLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.reportLabel = new System.Windows.Forms.Label();
            this.productsGrid = new System.Windows.Forms.DataGridView();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.okpCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiverDepColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportInfo1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.inventarizationPanel = new System.Windows.Forms.Panel();
            this.editAndLookVedomost = new System.Windows.Forms.Panel();
            this.searchDepPanel = new System.Windows.Forms.GroupBox();
            this.searchDepCheckBox = new System.Windows.Forms.CheckBox();
            this.searchDepLabel = new System.Windows.Forms.Label();
            this.searchDep = new System.Windows.Forms.TextBox();
            this.searchDocNumberPanel = new System.Windows.Forms.GroupBox();
            this.searchDocNumberCheckBox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.searchDocNumber = new System.Windows.Forms.TextBox();
            this.searchDocDatePanel = new System.Windows.Forms.GroupBox();
            this.searchBetweenDatesRadioButton = new System.Windows.Forms.RadioButton();
            this.SearchExatlyDateRadioButton = new System.Windows.Forms.RadioButton();
            this.searchUpDate = new System.Windows.Forms.DateTimePicker();
            this.searchDownDate = new System.Windows.Forms.DateTimePicker();
            this.searchUpDateLabel = new System.Windows.Forms.Label();
            this.searchExactlyDate = new System.Windows.Forms.DateTimePicker();
            this.searchDownDateLabel = new System.Windows.Forms.Label();
            this.searchExatlyDateLabel = new System.Windows.Forms.Label();
            this.inventarizationTable = new System.Windows.Forms.DataGridView();
            this.documentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreateDocument = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventarizationHeader = new System.Windows.Forms.Label();
            this.reportEditPanel = new System.Windows.Forms.Panel();
            this.departmentSearch = new System.Windows.Forms.GroupBox();
            this.senderDepSelector = new System.Windows.Forms.CheckBox();
            this.senderDepLabel = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.numberSearch = new System.Windows.Forms.GroupBox();
            this.documentNumberSelector = new System.Windows.Forms.CheckBox();
            this.reportNumberLabel = new System.Windows.Forms.Label();
            this.reportNumber = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.reportsGrid = new System.Windows.Forms.DataGridView();
            this.documentNumberColoumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportDateColoumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderDepColoumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportDateFilter = new System.Windows.Forms.GroupBox();
            this.reportDatePeriodSelector = new System.Windows.Forms.RadioButton();
            this.reportDateSelector = new System.Windows.Forms.RadioButton();
            this.reportHighestDate = new System.Windows.Forms.DateTimePicker();
            this.reportLowestDate = new System.Windows.Forms.DateTimePicker();
            this.reportHighestDateLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.reportLowestDateLabel = new System.Windows.Forms.Label();
            this.reportDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.reportPanel.SuspendLayout();
            this.Head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsGrid)).BeginInit();
            this.reportInfo1.SuspendLayout();
            this.inventarizationPanel.SuspendLayout();
            this.editAndLookVedomost.SuspendLayout();
            this.searchDepPanel.SuspendLayout();
            this.searchDocNumberPanel.SuspendLayout();
            this.searchDocDatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventarizationTable)).BeginInit();
            this.reportEditPanel.SuspendLayout();
            this.departmentSearch.SuspendLayout();
            this.numberSearch.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportsGrid)).BeginInit();
            this.reportDateFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTree
            // 
            this.menuTree.ImageIndex = 0;
            this.menuTree.ImageList = this.imagesForMenuTree;
            this.menuTree.Location = new System.Drawing.Point(12, 12);
            this.menuTree.Name = "menuTree";
            treeNode7.ImageIndex = 1;
            treeNode7.Name = "inventarizationCreateNode";
            treeNode7.Text = "Создание";
            treeNode8.ImageIndex = 2;
            treeNode8.Name = "inventarizationModifyNode";
            treeNode8.Text = "Просмотр и редактирование";
            treeNode9.ImageIndex = 0;
            treeNode9.Name = "inventarizationNode";
            treeNode9.Text = "Ведомость инвентаризации";
            treeNode10.ImageIndex = 1;
            treeNode10.Name = "createReportNode";
            treeNode10.Text = "Создание";
            treeNode11.ImageIndex = 2;
            treeNode11.Name = "reportModifyNode";
            treeNode11.Text = "Просмотр и редактирование";
            treeNode12.ImageIndex = 3;
            treeNode12.Name = "reportsNode";
            treeNode12.Text = "Рапорта о выполнении";
            this.menuTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode12});
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
            // reportPanel
            // 
            this.reportPanel.Controls.Add(this.Head);
            this.reportPanel.Controls.Add(this.productsGrid);
            this.reportPanel.Controls.Add(this.reportInfo1);
            this.reportPanel.Location = new System.Drawing.Point(850, 196);
            this.reportPanel.Name = "reportPanel";
            this.reportPanel.Size = new System.Drawing.Size(835, 690);
            this.reportPanel.TabIndex = 12;
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
            this.dataGridViewTextBoxColumn1,
            this.receiverDepColumn});
            this.productsGrid.Location = new System.Drawing.Point(20, 264);
            this.productsGrid.Name = "productsGrid";
            this.productsGrid.RowHeadersWidth = 51;
            this.productsGrid.Size = new System.Drawing.Size(797, 399);
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
            // receiverDepColumn
            // 
            this.receiverDepColumn.HeaderText = "Цех-получатель";
            this.receiverDepColumn.MinimumWidth = 6;
            this.receiverDepColumn.Name = "receiverDepColumn";
            // 
            // reportInfo1
            // 
            this.reportInfo1.Controls.Add(this.dateTimePicker4);
            this.reportInfo1.Controls.Add(this.label9);
            this.reportInfo1.Controls.Add(this.textBox6);
            this.reportInfo1.Controls.Add(this.label10);
            this.reportInfo1.Location = new System.Drawing.Point(20, 107);
            this.reportInfo1.Name = "reportInfo1";
            this.reportInfo1.Size = new System.Drawing.Size(380, 132);
            this.reportInfo1.TabIndex = 8;
            this.reportInfo1.TabStop = false;
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
            // inventarizationPanel
            // 
            this.inventarizationPanel.Controls.Add(this.groupBox3);
            this.inventarizationPanel.Controls.Add(this.label1);
            this.inventarizationPanel.Controls.Add(this.dataGridView3);
            this.inventarizationPanel.Location = new System.Drawing.Point(783, 303);
            this.inventarizationPanel.Name = "inventarizationPanel";
            this.inventarizationPanel.Size = new System.Drawing.Size(835, 690);
            this.inventarizationPanel.TabIndex = 13;
            // 
            // editAndLookVedomost
            // 
            this.editAndLookVedomost.Controls.Add(this.searchDepPanel);
            this.editAndLookVedomost.Controls.Add(this.searchDocNumberPanel);
            this.editAndLookVedomost.Controls.Add(this.searchDocDatePanel);
            this.editAndLookVedomost.Controls.Add(this.inventarizationTable);
            this.editAndLookVedomost.Controls.Add(this.inventarizationHeader);
            this.editAndLookVedomost.Location = new System.Drawing.Point(377, 12);
            this.editAndLookVedomost.Name = "editAndLookVedomost";
            this.editAndLookVedomost.Size = new System.Drawing.Size(835, 690);
            this.editAndLookVedomost.TabIndex = 16;
            // 
            // searchDepPanel
            // 
            this.searchDepPanel.Controls.Add(this.searchDepCheckBox);
            this.searchDepPanel.Controls.Add(this.searchDepLabel);
            this.searchDepPanel.Controls.Add(this.searchDep);
            this.searchDepPanel.Location = new System.Drawing.Point(441, 148);
            this.searchDepPanel.Name = "searchDepPanel";
            this.searchDepPanel.Size = new System.Drawing.Size(380, 76);
            this.searchDepPanel.TabIndex = 14;
            this.searchDepPanel.TabStop = false;
            this.searchDepPanel.Text = "поиск по цеху";
            // 
            // searchDepCheckBox
            // 
            this.searchDepCheckBox.AutoSize = true;
            this.searchDepCheckBox.Location = new System.Drawing.Point(343, 42);
            this.searchDepCheckBox.Name = "searchDepCheckBox";
            this.searchDepCheckBox.Size = new System.Drawing.Size(18, 17);
            this.searchDepCheckBox.TabIndex = 15;
            this.searchDepCheckBox.UseVisualStyleBackColor = true;
            // 
            // searchDepLabel
            // 
            this.searchDepLabel.AutoSize = true;
            this.searchDepLabel.Location = new System.Drawing.Point(12, 37);
            this.searchDepLabel.Name = "searchDepLabel";
            this.searchDepLabel.Size = new System.Drawing.Size(35, 20);
            this.searchDepLabel.TabIndex = 7;
            this.searchDepLabel.Text = "Цех";
            // 
            // searchDep
            // 
            this.searchDep.Location = new System.Drawing.Point(145, 34);
            this.searchDep.Name = "searchDep";
            this.searchDep.Size = new System.Drawing.Size(180, 27);
            this.searchDep.TabIndex = 5;
            // 
            // searchDocNumberPanel
            // 
            this.searchDocNumberPanel.Controls.Add(this.searchDocNumberCheckBox);
            this.searchDocNumberPanel.Controls.Add(this.label8);
            this.searchDocNumberPanel.Controls.Add(this.searchDocNumber);
            this.searchDocNumberPanel.Location = new System.Drawing.Point(441, 52);
            this.searchDocNumberPanel.Name = "searchDocNumberPanel";
            this.searchDocNumberPanel.Size = new System.Drawing.Size(380, 76);
            this.searchDocNumberPanel.TabIndex = 13;
            this.searchDocNumberPanel.TabStop = false;
            this.searchDocNumberPanel.Text = "поиск по номеру документа";
            // 
            // searchDocNumberCheckBox
            // 
            this.searchDocNumberCheckBox.AutoSize = true;
            this.searchDocNumberCheckBox.Location = new System.Drawing.Point(343, 36);
            this.searchDocNumberCheckBox.Name = "searchDocNumberCheckBox";
            this.searchDocNumberCheckBox.Size = new System.Drawing.Size(18, 17);
            this.searchDocNumberCheckBox.TabIndex = 14;
            this.searchDocNumberCheckBox.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "номер документа";
            // 
            // searchDocNumber
            // 
            this.searchDocNumber.Location = new System.Drawing.Point(145, 34);
            this.searchDocNumber.Name = "searchDocNumber";
            this.searchDocNumber.Size = new System.Drawing.Size(180, 27);
            this.searchDocNumber.TabIndex = 5;
            // 
            // searchDocDatePanel
            // 
            this.searchDocDatePanel.Controls.Add(this.searchBetweenDatesRadioButton);
            this.searchDocDatePanel.Controls.Add(this.SearchExatlyDateRadioButton);
            this.searchDocDatePanel.Controls.Add(this.searchUpDate);
            this.searchDocDatePanel.Controls.Add(this.searchDownDate);
            this.searchDocDatePanel.Controls.Add(this.searchUpDateLabel);
            this.searchDocDatePanel.Controls.Add(this.searchExactlyDate);
            this.searchDocDatePanel.Controls.Add(this.searchDownDateLabel);
            this.searchDocDatePanel.Controls.Add(this.searchExatlyDateLabel);
            this.searchDocDatePanel.Location = new System.Drawing.Point(29, 52);
            this.searchDocDatePanel.Name = "searchDocDatePanel";
            this.searchDocDatePanel.Size = new System.Drawing.Size(380, 172);
            this.searchDocDatePanel.TabIndex = 12;
            this.searchDocDatePanel.TabStop = false;
            this.searchDocDatePanel.Text = "поиск по дате";
            // 
            // searchBetweenDatesRadioButton
            // 
            this.searchBetweenDatesRadioButton.AutoSize = true;
            this.searchBetweenDatesRadioButton.Location = new System.Drawing.Point(345, 115);
            this.searchBetweenDatesRadioButton.Name = "searchBetweenDatesRadioButton";
            this.searchBetweenDatesRadioButton.Size = new System.Drawing.Size(17, 16);
            this.searchBetweenDatesRadioButton.TabIndex = 13;
            this.searchBetweenDatesRadioButton.TabStop = true;
            this.searchBetweenDatesRadioButton.UseVisualStyleBackColor = true;
            // 
            // SearchExatlyDateRadioButton
            // 
            this.SearchExatlyDateRadioButton.AutoSize = true;
            this.SearchExatlyDateRadioButton.Location = new System.Drawing.Point(345, 41);
            this.SearchExatlyDateRadioButton.Name = "SearchExatlyDateRadioButton";
            this.SearchExatlyDateRadioButton.Size = new System.Drawing.Size(17, 16);
            this.SearchExatlyDateRadioButton.TabIndex = 12;
            this.SearchExatlyDateRadioButton.TabStop = true;
            this.SearchExatlyDateRadioButton.UseVisualStyleBackColor = true;
            // 
            // searchUpDate
            // 
            this.searchUpDate.CustomFormat = "dd MMMM yyyy";
            this.searchUpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.searchUpDate.Location = new System.Drawing.Point(145, 128);
            this.searchUpDate.Name = "searchUpDate";
            this.searchUpDate.Size = new System.Drawing.Size(180, 27);
            this.searchUpDate.TabIndex = 11;
            this.searchUpDate.Value = new System.DateTime(2021, 3, 25, 0, 0, 0, 0);
            // 
            // searchDownDate
            // 
            this.searchDownDate.CustomFormat = "dd MMMM yyyy";
            this.searchDownDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.searchDownDate.Location = new System.Drawing.Point(145, 87);
            this.searchDownDate.Name = "searchDownDate";
            this.searchDownDate.Size = new System.Drawing.Size(180, 27);
            this.searchDownDate.TabIndex = 10;
            this.searchDownDate.Value = new System.DateTime(2021, 3, 25, 0, 0, 0, 0);
            // 
            // searchUpDateLabel
            // 
            this.searchUpDateLabel.AutoSize = true;
            this.searchUpDateLabel.Location = new System.Drawing.Point(12, 133);
            this.searchUpDateLabel.Name = "searchUpDateLabel";
            this.searchUpDateLabel.Size = new System.Drawing.Size(100, 20);
            this.searchUpDateLabel.TabIndex = 8;
            this.searchUpDateLabel.Text = "верхняя дата";
            // 
            // searchExactlyDate
            // 
            this.searchExactlyDate.CustomFormat = "dd MMMM yyyy";
            this.searchExactlyDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.searchExactlyDate.Location = new System.Drawing.Point(145, 34);
            this.searchExactlyDate.Name = "searchExactlyDate";
            this.searchExactlyDate.Size = new System.Drawing.Size(180, 27);
            this.searchExactlyDate.TabIndex = 4;
            this.searchExactlyDate.Value = new System.DateTime(2021, 3, 25, 0, 0, 0, 0);
            // 
            // searchDownDateLabel
            // 
            this.searchDownDateLabel.AutoSize = true;
            this.searchDownDateLabel.Location = new System.Drawing.Point(12, 92);
            this.searchDownDateLabel.Name = "searchDownDateLabel";
            this.searchDownDateLabel.Size = new System.Drawing.Size(97, 20);
            this.searchDownDateLabel.TabIndex = 7;
            this.searchDownDateLabel.Text = "нижняя дата";
            // 
            // searchExatlyDateLabel
            // 
            this.searchExatlyDateLabel.AutoSize = true;
            this.searchExatlyDateLabel.Location = new System.Drawing.Point(12, 39);
            this.searchExatlyDateLabel.Name = "searchExatlyDateLabel";
            this.searchExatlyDateLabel.Size = new System.Drawing.Size(91, 20);
            this.searchExatlyDateLabel.TabIndex = 6;
            this.searchExatlyDateLabel.Text = "точная дата";
            // 
            // inventarizationTable
            // 
            this.inventarizationTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inventarizationTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventarizationTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.documentNumber,
            this.dateCreateDocument});
            this.inventarizationTable.Location = new System.Drawing.Point(29, 251);
            this.inventarizationTable.Name = "inventarizationTable";
            this.inventarizationTable.RowHeadersWidth = 51;
            this.inventarizationTable.RowTemplate.Height = 29;
            this.inventarizationTable.Size = new System.Drawing.Size(782, 364);
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
            // reportEditPanel
            // 
            this.reportEditPanel.Controls.Add(this.departmentSearch);
            this.reportEditPanel.Controls.Add(this.numberSearch);
            this.reportEditPanel.Controls.Add(this.groupBox1);
            this.reportEditPanel.Controls.Add(this.reportsGrid);
            this.reportEditPanel.Controls.Add(this.reportDateFilter);
            this.reportEditPanel.Location = new System.Drawing.Point(628, 531);
            this.reportEditPanel.Name = "reportEditPanel";
            this.reportEditPanel.Size = new System.Drawing.Size(835, 690);
            this.reportEditPanel.TabIndex = 17;
            // 
            // departmentSearch
            // 
            this.departmentSearch.Controls.Add(this.senderDepSelector);
            this.departmentSearch.Controls.Add(this.senderDepLabel);
            this.departmentSearch.Controls.Add(this.textBox7);
            this.departmentSearch.Location = new System.Drawing.Point(440, 203);
            this.departmentSearch.Name = "departmentSearch";
            this.departmentSearch.Size = new System.Drawing.Size(380, 76);
            this.departmentSearch.TabIndex = 11;
            this.departmentSearch.TabStop = false;
            this.departmentSearch.Text = "поиск по цеху";
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
            this.senderDepLabel.Size = new System.Drawing.Size(127, 20);
            this.senderDepLabel.TabIndex = 7;
            this.senderDepLabel.Text = "цех-отправитель";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(145, 34);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(180, 27);
            this.textBox7.TabIndex = 5;
            // 
            // numberSearch
            // 
            this.numberSearch.Controls.Add(this.documentNumberSelector);
            this.numberSearch.Controls.Add(this.reportNumberLabel);
            this.numberSearch.Controls.Add(this.reportNumber);
            this.numberSearch.Location = new System.Drawing.Point(440, 107);
            this.numberSearch.Name = "numberSearch";
            this.numberSearch.Size = new System.Drawing.Size(380, 76);
            this.numberSearch.TabIndex = 10;
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
            this.reportsGrid.Size = new System.Drawing.Size(800, 334);
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
            // reportDateFilter
            // 
            this.reportDateFilter.Controls.Add(this.reportDatePeriodSelector);
            this.reportDateFilter.Controls.Add(this.reportDateSelector);
            this.reportDateFilter.Controls.Add(this.reportHighestDate);
            this.reportDateFilter.Controls.Add(this.reportLowestDate);
            this.reportDateFilter.Controls.Add(this.reportHighestDateLabel);
            this.reportDateFilter.Controls.Add(this.dateTimePicker1);
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd MMMM yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(145, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(180, 27);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2021, 3, 25, 0, 0, 0, 0);
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
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 709);
            this.Controls.Add(this.reportEditPanel);
            this.Controls.Add(this.editAndLookVedomost);
            this.Controls.Add(this.reportPanel);
            this.Controls.Add(this.menuTree);
            this.Controls.Add(this.inventarizationPanel);
            this.Name = "mainForm";
            this.Text = "Рабочее место";
            this.Load += new System.EventHandler(this.mainForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.reportPanel.ResumeLayout(false);
            this.Head.ResumeLayout(false);
            this.Head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsGrid)).EndInit();
            this.reportInfo1.ResumeLayout(false);
            this.reportInfo1.PerformLayout();
            this.inventarizationPanel.ResumeLayout(false);
            this.inventarizationPanel.PerformLayout();
            this.editAndLookVedomost.ResumeLayout(false);
            this.editAndLookVedomost.PerformLayout();
            this.searchDepPanel.ResumeLayout(false);
            this.searchDepPanel.PerformLayout();
            this.searchDocNumberPanel.ResumeLayout(false);
            this.searchDocNumberPanel.PerformLayout();
            this.searchDocDatePanel.ResumeLayout(false);
            this.searchDocDatePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventarizationTable)).EndInit();
            this.reportEditPanel.ResumeLayout(false);
            this.departmentSearch.ResumeLayout(false);
            this.departmentSearch.PerformLayout();
            this.numberSearch.ResumeLayout(false);
            this.numberSearch.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportsGrid)).EndInit();
            this.reportDateFilter.ResumeLayout(false);
            this.reportDateFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView menuTree;
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
        //private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel reportPanel;
        private System.Windows.Forms.GroupBox Head;
        private System.Windows.Forms.Label anotherReportLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label reportLabel;
        private System.Windows.Forms.DataGridView productsGrid;
        private System.Windows.Forms.GroupBox reportInfo1;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel inventarizationPanel;
        private System.Windows.Forms.ImageList imagesForMenuTree;
        private System.Windows.Forms.Panel editAndLookVedomost;
        private System.Windows.Forms.DataGridView inventarizationTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreateDocument;
        private System.Windows.Forms.Label inventarizationHeader;
        private System.Windows.Forms.Panel reportEditPanel;
        private System.Windows.Forms.GroupBox departmentSearch;
        private System.Windows.Forms.CheckBox senderDepSelector;
        private System.Windows.Forms.Label senderDepLabel;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.GroupBox numberSearch;
        private System.Windows.Forms.CheckBox documentNumberSelector;
        private System.Windows.Forms.Label reportNumberLabel;
        private System.Windows.Forms.TextBox reportNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView reportsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentNumberColoumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportDateColoumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderDepColoumn;
        private System.Windows.Forms.GroupBox reportDateFilter;
        private System.Windows.Forms.RadioButton reportDatePeriodSelector;
        private System.Windows.Forms.RadioButton reportDateSelector;
        private System.Windows.Forms.DateTimePicker reportHighestDate;
        private System.Windows.Forms.DateTimePicker reportLowestDate;
        private System.Windows.Forms.Label reportHighestDateLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label reportLowestDateLabel;
        private System.Windows.Forms.Label reportDateLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn okpCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiverDepColumn;
        private System.Windows.Forms.GroupBox searchDepPanel;
        private System.Windows.Forms.CheckBox searchDepCheckBox;
        private System.Windows.Forms.Label searchDepLabel;
        private System.Windows.Forms.TextBox searchDep;
        private System.Windows.Forms.GroupBox searchDocNumberPanel;
        private System.Windows.Forms.CheckBox searchDocNumberCheckBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox searchDocNumber;
        private System.Windows.Forms.GroupBox searchDocDatePanel;
        private System.Windows.Forms.RadioButton searchBetweenDatesRadioButton;
        private System.Windows.Forms.RadioButton SearchExatlyDateRadioButton;
        private System.Windows.Forms.DateTimePicker searchUpDate;
        private System.Windows.Forms.DateTimePicker searchDownDate;
        private System.Windows.Forms.Label searchUpDateLabel;
        private System.Windows.Forms.DateTimePicker searchExactlyDate;
        private System.Windows.Forms.Label searchDownDateLabel;
        private System.Windows.Forms.Label searchExatlyDateLabel;
        private System.Windows.Forms.Label ct;
        private System.Windows.Forms.Label y;
    }
}