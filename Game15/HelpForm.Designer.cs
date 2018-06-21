namespace Game15
{
    partial class HelpForm
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
            this.TextEdt = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // TextEdt
            // 
            this.TextEdt.BackColor = System.Drawing.Color.White;
            this.TextEdt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextEdt.Enabled = false;
            this.TextEdt.Location = new System.Drawing.Point(0, 0);
            this.TextEdt.Name = "TextEdt";
            this.TextEdt.Size = new System.Drawing.Size(397, 261);
            this.TextEdt.TabIndex = 0;
            this.TextEdt.Text = "";
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(397, 261);
            this.Controls.Add(this.TextEdt);
            this.Name = "HelpForm";
            this.Text = "HelpForm";
            this.Load += new System.EventHandler(this.HelpForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox TextEdt;
    }
}