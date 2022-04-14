namespace SwissTransportGUI
{
    partial class PopUpForm
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
            this.SenderMail = new System.Windows.Forms.TextBox();
            this.ReceiverMail = new System.Windows.Forms.TextBox();
            this.SendMail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SenderMail
            // 
            this.SenderMail.Location = new System.Drawing.Point(160, 69);
            this.SenderMail.Name = "SenderMail";
            this.SenderMail.Size = new System.Drawing.Size(202, 31);
            this.SenderMail.TabIndex = 0;
            // 
            // ReceiverMail
            // 
            this.ReceiverMail.Location = new System.Drawing.Point(488, 69);
            this.ReceiverMail.Name = "ReceiverMail";
            this.ReceiverMail.Size = new System.Drawing.Size(196, 31);
            this.ReceiverMail.TabIndex = 1;
            // 
            // SendMail
            // 
            this.SendMail.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SendMail.Location = new System.Drawing.Point(291, 140);
            this.SendMail.Name = "SendMail";
            this.SendMail.Size = new System.Drawing.Size(279, 47);
            this.SendMail.TabIndex = 2;
            this.SendMail.Text = "Send";
            this.SendMail.UseVisualStyleBackColor = true;
            this.SendMail.Click += new System.EventHandler(this.SendMail_Click);
            // 
            // PopUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 254);
            this.Controls.Add(this.SendMail);
            this.Controls.Add(this.ReceiverMail);
            this.Controls.Add(this.SenderMail);
            this.Name = "PopUpForm";
            this.Text = "PopUpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox SenderMail;
        private TextBox ReceiverMail;
        private Button SendMail;
    }
}