namespace seepass
{
    partial class FormManual
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
            this.richTextBoxManual = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBoxManual
            // 
            this.richTextBoxManual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxManual.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxManual.Name = "richTextBoxManual";
            this.richTextBoxManual.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.richTextBoxManual.Size = new System.Drawing.Size(672, 481);
            this.richTextBoxManual.TabIndex = 0;
            this.richTextBoxManual.Text = "";
            // 
            // FormManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 505);
            this.Controls.Add(this.richTextBoxManual);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormManual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "使用说明";
            this.Load += new System.EventHandler(this.FormManual_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxManual;
    }
}