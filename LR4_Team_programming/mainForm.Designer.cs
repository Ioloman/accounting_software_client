
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Создание", 1, 1);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Просмотр и редактирование", 2, 2);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Ведомость инвентаризации", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Создание", 1, 1);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Просмотр и редактирование", 2, 2);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Рапорта о выполнении", 3, 3, new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Сводный учет", 6, 6);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Расчет остатков", 7, 7);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.menuTree = new System.Windows.Forms.TreeView();
            this.imagesForMenuTree = new System.Windows.Forms.ImageList(this.components);
            this.reciverDep = new System.Windows.Forms.TextBox();
            this.reciverLabel = new System.Windows.Forms.Label();
            this.reportDate = new System.Windows.Forms.DateTimePicker();
            this.senderLabel = new System.Windows.Forms.Label();
            this.senderDep = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // menuTree
            // 
            this.menuTree.ImageIndex = 0;
            this.menuTree.ImageList = this.imagesForMenuTree;
            this.menuTree.Location = new System.Drawing.Point(12, 12);
            this.menuTree.Name = "menuTree";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "inventarizationCreateNode";
            treeNode1.SelectedImageIndex = 1;
            treeNode1.Text = "Создание";
            treeNode2.ImageIndex = 2;
            treeNode2.Name = "inventarizationModifyNode";
            treeNode2.SelectedImageIndex = 2;
            treeNode2.Text = "Просмотр и редактирование";
            treeNode3.ImageIndex = 0;
            treeNode3.Name = "inventarizationNode";
            treeNode3.SelectedImageIndex = 0;
            treeNode3.Text = "Ведомость инвентаризации";
            treeNode4.ImageIndex = 1;
            treeNode4.Name = "createReportNode";
            treeNode4.SelectedImageIndex = 1;
            treeNode4.Text = "Создание";
            treeNode5.ImageIndex = 2;
            treeNode5.Name = "reportModifyNode";
            treeNode5.SelectedImageIndex = 2;
            treeNode5.Text = "Просмотр и редактирование";
            treeNode6.ImageIndex = 3;
            treeNode6.Name = "reportsNode";
            treeNode6.SelectedImageIndex = 3;
            treeNode6.Text = "Рапорта о выполнении";
            treeNode7.ImageIndex = 6;
            treeNode7.Name = "summaryAccountingNode";
            treeNode7.SelectedImageIndex = 6;
            treeNode7.Text = "Сводный учет";
            treeNode8.ImageIndex = 7;
            treeNode8.Name = "СalculatingBalancesNode";
            treeNode8.SelectedImageIndex = 7;
            treeNode8.Text = "Расчет остатков";
            this.menuTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6,
            treeNode7,
            treeNode8});
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
            this.imagesForMenuTree.Images.SetKeyName(5, "Отклонения.png");
            this.imagesForMenuTree.Images.SetKeyName(6, "Сводный учет.png");
            this.imagesForMenuTree.Images.SetKeyName(7, "Остатки.png");
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
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 717);
            this.Controls.Add(this.menuTree);
            this.Name = "mainForm";
            this.Text = "Рабочее место";
            this.Load += new System.EventHandler(this.mainForm_Load_1);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView menuTree;
        private System.Windows.Forms.GroupBox fg;


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
        private System.Windows.Forms.ImageList imagesForMenuTree;
        private System.Windows.Forms.Label ct;
        private System.Windows.Forms.Label y;
    }
}