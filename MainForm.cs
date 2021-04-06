using System;
using System.ComponentModel;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace EmailSender
{
    public partial class MainForm : Form
    {
        // enable less secure apps https://myaccount.google.com/lesssecureapps

        private readonly BackgroundWorker _emailSenderBgWorker;

        public MainForm()
        {
            InitializeComponent();
            LoadFromSettings();

            _emailSenderBgWorker = new BackgroundWorker();
            _emailSenderBgWorker.DoWork += SendEmail;
            _emailSenderBgWorker.RunWorkerCompleted += SendEmailFinished;
        }

        private void SendEmail(object sender, DoWorkEventArgs e)
        {
            try
            {
                SendEmailInternal((EmailSetting) e.Argument);
                e.Result = new EmailSendResult();
            }
            catch (Exception exception)
            {
                e.Result = new EmailSendResult { Success = false, Error = exception.Message };
            }
        }

        private static void SendEmailInternal(EmailSetting setting)
        {
            var fromAddress = new MailAddress(setting.FromEmail, setting.FromDisplayName);
            var toAddress = new MailAddress(setting.ToEmail, setting.ToDisplayName);

            var smtp = new SmtpClient
            {
                Host = setting.Host,
                Port = setting.Port,
                EnableSsl = setting.EnableSsl,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = setting.UseDefaultCredentials,
                Credentials = new NetworkCredential(fromAddress.Address, setting.Password)
            };

            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = setting.Subject,
                Body = setting.Body,
                IsBodyHtml = setting.IsBodyHtml
            })
            {
                smtp.Send(message);
            }
        }

        private void SendEmailFinished(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar.Visible = false;
            btnSend.Enabled = true;

            var result = (EmailSendResult)e.Result;
            if (result == null)
            {
                return;
            }

            if (result.Success)
            {
                MessageBox.Show(@"Successfully sent :)", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(result.Error, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            progressBar.Visible = true;
            btnSend.Enabled = false;

            _emailSenderBgWorker.RunWorkerAsync(new EmailSetting
            {
                Body = txtBody.Text,
                Host = txtHost.Text.Trim(),
                Port = int.Parse(txtPort.Text.Trim()),
                EnableSsl = cbEnableSsl.Checked,
                IsBodyHtml = cbHtml.Checked,
                Subject = txtSubject.Text,
                Password = txtPassword.Text,
                FromEmail = txtFromEmail.Text.Trim(),
                FromDisplayName = txtFromDisplayName.Text.Trim(),
                ToEmail = txtToEmail.Text.Trim(),
                ToDisplayName = txtToDisplayName.Text.Trim(),
                UseDefaultCredentials = cbUseDefaultCredentials.Checked
            });
        }

        private void LoadFromSettings()
        {
            txtHost.Text = GetSetting("Host");
            txtPort.Text = GetSetting("Port");
            txtBody.Text = GetSetting("Body");
            txtFromEmail.Text = GetSetting("FromEmail");
            txtFromDisplayName.Text = GetSetting("FromDisplayName");
            txtToEmail.Text = GetSetting("ToEmail");
            txtToDisplayName.Text = GetSetting("ToDisplayName");
            txtSubject.Text = GetSetting("Subject");
            txtPassword.Text = GetSetting("Password");
            cbEnableSsl.Checked = GetSetting<bool>("EnableSsl");
            cbHtml.Checked = GetSetting<bool>("IsBodyHtml");
        }

        private static string GetSetting(string key, bool isTrim = false)
        {
            return GetSetting<string>(key, isTrim);
        }

        private static T GetSetting<T>(string key, bool isTrim = false)
        {
            var value = (ConfigurationManager.AppSettings[key] as string);
            value = isTrim ? value?.Trim() : value;
            return (T)Convert.ChangeType(value, typeof(T));
        }

        private class EmailSetting
        {
            public string Host { get; set; }
            public int Port { get; set; }
            public string Body { get; set; }
            public string FromEmail { get; set; }
            public string FromDisplayName { get; set; }
            public string ToEmail { get; set; }
            public string ToDisplayName { get; set; }
            public string Subject { get; set; }
            public string Password { get; set; }
            public bool EnableSsl { get; set; }
            public bool IsBodyHtml { get; set; }
            public bool UseDefaultCredentials { get; set; }
        }

        private class EmailSendResult
        {
            public bool Success { get; set; }
            public string Error { get; set; }

            public EmailSendResult()
            {
                Success = true;
            }
        }
    }
}
