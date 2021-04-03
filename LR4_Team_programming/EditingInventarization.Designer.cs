
namespace LR4_Team_programming
{
    partial class EditingInventarization
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
            this.inventarizationDocument1 = new LR4_Team_programming.customElements.InventarizationDocument();
            this.SuspendLayout();
            // 
            // inventarizationDocument1
            // 
            this.inventarizationDocument1.Location = new System.Drawing.Point(12, 12);
            this.inventarizationDocument1.Name = "inventarizationDocument1";
            this.inventarizationDocument1.Size = new System.Drawing.Size(834, 689);
            this.inventarizationDocument1.TabIndex = 0;
            // 
            // EditingInventarization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 706);
            this.Controls.Add(this.inventarizationDocument1);
            this.Name = "EditingInventarization";
            this.Text = "Редактирование ведомости инвентаризации";
            this.ResumeLayout(false);

        }

        #endregion

        private customElements.InventarizationDocument inventarizationDocument1;
    }
}