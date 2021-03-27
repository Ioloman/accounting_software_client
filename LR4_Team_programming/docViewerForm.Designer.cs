
namespace LR4_Team_programming
{
    partial class docViewerForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(docViewerForm));
            this.docViewer = new System.Windows.Forms.RichTextBox();
            this.editButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // docViewer
            // 
            this.docViewer.Location = new System.Drawing.Point(12, 12);
            this.docViewer.Name = "docViewer";
            this.docViewer.Size = new System.Drawing.Size(1009, 591);
            this.docViewer.TabIndex = 4;
            this.docViewer.Text = "";
            // 
            // editButton
            // 
            this.editButton.Image = ((System.Drawing.Image)(resources.GetObject("editButton.Image")));
            this.editButton.Location = new System.Drawing.Point(1027, 98);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(80, 80);
            this.editButton.TabIndex = 6;
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // printButton
            // 
            this.printButton.Image = ((System.Drawing.Image)(resources.GetObject("printButton.Image")));
            this.printButton.Location = new System.Drawing.Point(1027, 12);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(80, 80);
            this.printButton.TabIndex = 5;
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // docViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 611);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.docViewer);
            this.Name = "docViewerForm";
            this.Text = "docViewerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox docViewer;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button printButton;
    }
}