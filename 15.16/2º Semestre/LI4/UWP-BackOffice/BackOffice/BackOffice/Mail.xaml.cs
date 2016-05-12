using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Net;
using System.Threading.Tasks;
using EASendMailRT;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace AirFIT
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Mail : Page
    {

        
        public Mail()
        {
            this.InitializeComponent();
        }
        
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
        }

        private async void SendEmail_Click(object sender, RoutedEventArgs e)
        {
            SendEmail.IsEnabled = false;
            await Send_Email();
            SendEmail.IsEnabled = true;
        }

        private async Task Send_Email()
        {
            String Result = "";

            try
            {
                SmtpMail oMail = new SmtpMail("TryIt");
                SmtpClient oSmtp = new SmtpClient();

                oMail.From = new MailAddress(Mail_Info.Text);
                foreach (string destinatio in destinatario.Text.Split(';'))
                {
                    oMail.To.Add(new MailAddress(destinatario.Text));
                }

                oMail.Subject = assunto.Text;
                oMail.TextBody = corpo.Text;

                SmtpServer oServer = new SmtpServer("smtp.gmail.com");

                oServer.User = Mail_Info.Text;
                oServer.Password = Passw_Info.Text;

                await oSmtp.SendMailAsync(oServer, oMail);
                Result = "Email was sent sucessfully";
            }

            catch (Exception ep)
            {
                Result = String.Format("Failed to send email with the following error: {0} ", ep.Message);
            }

            Windows.UI.Popups.MessageDialog dlg = new Windows.UI.Popups.MessageDialog(Result);

            await dlg.ShowAsync();


        }
    }
}
