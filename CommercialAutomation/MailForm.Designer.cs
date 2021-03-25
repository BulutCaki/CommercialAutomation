
namespace CommercialAutomation
{
    partial class MailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailForm));
            this.label1 = new System.Windows.Forms.Label();
            this.textMail = new DevExpress.XtraEditors.TextEdit();
            this.textSubject = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextContent = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sendButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSubject.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mail :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textMail
            // 
            this.textMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textMail.Location = new System.Drawing.Point(118, 384);
            this.textMail.Name = "textMail";
            this.textMail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textMail.Properties.Appearance.Options.UseFont = true;
            this.textMail.Size = new System.Drawing.Size(267, 26);
            this.textMail.TabIndex = 1;
            // 
            // textSubject
            // 
            this.textSubject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textSubject.Location = new System.Drawing.Point(118, 416);
            this.textSubject.Name = "textSubject";
            this.textSubject.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textSubject.Properties.Appearance.Options.UseFont = true;
            this.textSubject.Size = new System.Drawing.Size(267, 26);
            this.textSubject.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Konu :";
            // 
            // richTextContent
            // 
            this.richTextContent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextContent.Location = new System.Drawing.Point(118, 448);
            this.richTextContent.Name = "richTextContent";
            this.richTextContent.Size = new System.Drawing.Size(267, 148);
            this.richTextContent.TabIndex = 4;
            this.richTextContent.Text = "";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 451);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mesaj :";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 303);
            this.panel1.TabIndex = 6;
            // 
            // sendButton
            // 
            this.sendButton.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sendButton.Appearance.Options.UseFont = true;
            this.sendButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.sendButton.Location = new System.Drawing.Point(141, 602);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(169, 45);
            this.sendButton.TabIndex = 7;
            this.sendButton.Text = "Gönder";
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // MailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 727);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextContent);
            this.Controls.Add(this.textSubject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textMail);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "MailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MailForm";
            this.Load += new System.EventHandler(this.MailForm_Load);
            this.BackColorChanged += new System.EventHandler(this.MailForm_BackColorChanged);
            ((System.ComponentModel.ISupportInitialize)(this.textMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSubject.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit textMail;
        private DevExpress.XtraEditors.TextEdit textSubject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextContent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton sendButton;
    }
}