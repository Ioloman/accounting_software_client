
namespace LR4_Team_programming
{
    partial class EditingReportForm
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
            this.reportDocument1 = new LR4_Team_programming.customElements.ReportDocument();
            this.SuspendLayout();
            // 
            // reportDocument1
            // 
            this.reportDocument1.Location = new System.Drawing.Point(0, 0);
            this.reportDocument1.Name = "reportDocument1";
            this.reportDocument1.Size = new System.Drawing.Size(836, 688);
            this.reportDocument1.TabIndex = 0;
            // 
            // EditingReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 686);
            this.Controls.Add(this.reportDocument1);
            this.Name = "EditingReportForm";
            this.Text = "Редактирование рапорта сдачи продуции цехами";
            this.ResumeLayout(false);

        }

        #endregion

        private customElements.ReportDocument reportDocument1;
    }
}