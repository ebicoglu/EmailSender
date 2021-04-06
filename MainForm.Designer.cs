
namespace EmailSender
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSend = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpBottom = new System.Windows.Forms.GroupBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.grpBody = new System.Windows.Forms.GroupBox();
            this.txtBody = new System.Windows.Forms.RichTextBox();
            this.grpTop = new System.Windows.Forms.GroupBox();
            this.txtToEmail = new System.Windows.Forms.TextBox();
            this.lblFromEmail = new System.Windows.Forms.Label();
            this.txtFromEmail = new System.Windows.Forms.TextBox();
            this.txtFromDisplayName = new System.Windows.Forms.TextBox();
            this.cbEnableSsl = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbUseDefaultCredentials = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbHtml = new System.Windows.Forms.CheckBox();
            this.txtToDisplayName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpBottom.SuspendLayout();
            this.grpBody.SuspendLayout();
            this.grpTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Location = new System.Drawing.Point(461, 22);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(103, 23);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send Email";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grpBottom);
            this.groupBox1.Controls.Add(this.grpBody);
            this.groupBox1.Controls.Add(this.grpTop);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 445);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // grpBottom
            // 
            this.grpBottom.Controls.Add(this.progressBar);
            this.grpBottom.Controls.Add(this.btnSend);
            this.grpBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpBottom.Location = new System.Drawing.Point(3, 381);
            this.grpBottom.Name = "grpBottom";
            this.grpBottom.Size = new System.Drawing.Size(578, 61);
            this.grpBottom.TabIndex = 25;
            this.grpBottom.TabStop = false;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(9, 22);
            this.progressBar.MarqueeAnimationSpeed = 30;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(434, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 22;
            this.progressBar.Visible = false;
            // 
            // grpBody
            // 
            this.grpBody.Controls.Add(this.txtBody);
            this.grpBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBody.Location = new System.Drawing.Point(3, 176);
            this.grpBody.Name = "grpBody";
            this.grpBody.Size = new System.Drawing.Size(578, 266);
            this.grpBody.TabIndex = 24;
            this.grpBody.TabStop = false;
            this.grpBody.Text = "Body";
            // 
            // txtBody
            // 
            this.txtBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBody.Location = new System.Drawing.Point(3, 19);
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(572, 244);
            this.txtBody.TabIndex = 20;
            this.txtBody.Text = "";
            // 
            // grpTop
            // 
            this.grpTop.Controls.Add(this.txtToEmail);
            this.grpTop.Controls.Add(this.lblFromEmail);
            this.grpTop.Controls.Add(this.txtFromEmail);
            this.grpTop.Controls.Add(this.txtFromDisplayName);
            this.grpTop.Controls.Add(this.cbEnableSsl);
            this.grpTop.Controls.Add(this.label1);
            this.grpTop.Controls.Add(this.cbUseDefaultCredentials);
            this.grpTop.Controls.Add(this.label3);
            this.grpTop.Controls.Add(this.cbHtml);
            this.grpTop.Controls.Add(this.txtToDisplayName);
            this.grpTop.Controls.Add(this.label7);
            this.grpTop.Controls.Add(this.label2);
            this.grpTop.Controls.Add(this.txtPort);
            this.grpTop.Controls.Add(this.txtPassword);
            this.grpTop.Controls.Add(this.txtHost);
            this.grpTop.Controls.Add(this.label4);
            this.grpTop.Controls.Add(this.label8);
            this.grpTop.Controls.Add(this.txtSubject);
            this.grpTop.Controls.Add(this.label5);
            this.grpTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpTop.Location = new System.Drawing.Point(3, 19);
            this.grpTop.Name = "grpTop";
            this.grpTop.Size = new System.Drawing.Size(578, 157);
            this.grpTop.TabIndex = 23;
            this.grpTop.TabStop = false;
            // 
            // txtToEmail
            // 
            this.txtToEmail.Location = new System.Drawing.Point(384, 15);
            this.txtToEmail.Name = "txtToEmail";
            this.txtToEmail.Size = new System.Drawing.Size(180, 23);
            this.txtToEmail.TabIndex = 6;
            // 
            // lblFromEmail
            // 
            this.lblFromEmail.AutoSize = true;
            this.lblFromEmail.Location = new System.Drawing.Point(9, 19);
            this.lblFromEmail.Name = "lblFromEmail";
            this.lblFromEmail.Size = new System.Drawing.Size(72, 15);
            this.lblFromEmail.TabIndex = 1;
            this.lblFromEmail.Text = "From e-mail";
            // 
            // txtFromEmail
            // 
            this.txtFromEmail.Location = new System.Drawing.Point(83, 15);
            this.txtFromEmail.Name = "txtFromEmail";
            this.txtFromEmail.Size = new System.Drawing.Size(180, 23);
            this.txtFromEmail.TabIndex = 2;
            // 
            // txtFromDisplayName
            // 
            this.txtFromDisplayName.Location = new System.Drawing.Point(83, 41);
            this.txtFromDisplayName.Name = "txtFromDisplayName";
            this.txtFromDisplayName.Size = new System.Drawing.Size(180, 23);
            this.txtFromDisplayName.TabIndex = 3;
            // 
            // cbEnableSsl
            // 
            this.cbEnableSsl.AutoSize = true;
            this.cbEnableSsl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbEnableSsl.Location = new System.Drawing.Point(482, 100);
            this.cbEnableSsl.Name = "cbEnableSsl";
            this.cbEnableSsl.Size = new System.Drawing.Size(82, 19);
            this.cbEnableSsl.TabIndex = 19;
            this.cbEnableSsl.Text = "Enable SSL";
            this.cbEnableSsl.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "From display name";
            // 
            // cbUseDefaultCredentials
            // 
            this.cbUseDefaultCredentials.AutoSize = true;
            this.cbUseDefaultCredentials.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbUseDefaultCredentials.Location = new System.Drawing.Point(384, 127);
            this.cbUseDefaultCredentials.Name = "cbUseDefaultCredentials";
            this.cbUseDefaultCredentials.Size = new System.Drawing.Size(145, 19);
            this.cbUseDefaultCredentials.TabIndex = 18;
            this.cbUseDefaultCredentials.Text = "Use default credentials";
            this.cbUseDefaultCredentials.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "To e-mail";
            // 
            // cbHtml
            // 
            this.cbHtml.AutoSize = true;
            this.cbHtml.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbHtml.Location = new System.Drawing.Point(384, 100);
            this.cbHtml.Name = "cbHtml";
            this.cbHtml.Size = new System.Drawing.Size(88, 19);
            this.cbHtml.TabIndex = 17;
            this.cbHtml.Text = "HTML Body";
            this.cbHtml.UseVisualStyleBackColor = true;
            // 
            // txtToDisplayName
            // 
            this.txtToDisplayName.Location = new System.Drawing.Point(384, 41);
            this.txtToDisplayName.Name = "txtToDisplayName";
            this.txtToDisplayName.Size = new System.Drawing.Size(180, 23);
            this.txtToDisplayName.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "To display name";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(83, 123);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(180, 23);
            this.txtPort.TabIndex = 15;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(83, 68);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(180, 23);
            this.txtPassword.TabIndex = 9;
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(83, 97);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(180, 23);
            this.txtHost.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Host";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(384, 68);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(180, 23);
            this.txtSubject.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(327, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Subject";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 445);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 325);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Email Sender";
            this.groupBox1.ResumeLayout(false);
            this.grpBottom.ResumeLayout(false);
            this.grpBody.ResumeLayout(false);
            this.grpTop.ResumeLayout(false);
            this.grpTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFromEmail;
        private System.Windows.Forms.Label lblFromEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFromDisplayName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtToDisplayName;
        private System.Windows.Forms.TextBox txtToEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbHtml;
        private System.Windows.Forms.CheckBox cbUseDefaultCredentials;
        private System.Windows.Forms.CheckBox cbEnableSsl;
        private System.Windows.Forms.RichTextBox txtBody;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.GroupBox grpBottom;
        private System.Windows.Forms.GroupBox grpBody;
        private System.Windows.Forms.GroupBox grpTop;
    }
}

