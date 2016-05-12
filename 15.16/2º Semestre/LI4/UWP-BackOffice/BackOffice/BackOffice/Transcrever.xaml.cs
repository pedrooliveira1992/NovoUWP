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
using Windows.Web;
using Windows.Storage.Streams;
using Windows.Networking.Sockets;
using Windows.Media.SpeechRecognition;
using System.Threading.Tasks;



// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace AirFIT
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Transcrever : Page
    {
        public Transcrever()
        {
            this.InitializeComponent();
        }


        private void CriarAtividade_Click(object sender, RoutedEventArgs e)
        {

            MyFrame.Navigate(typeof(CriarAtividades));
        }

        private void Transcricao_Click(object sender, RoutedEventArgs e)
        {
           
            MyFrame.Navigate(typeof(Transcrever));
        }

        private async void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            //mediaElement.Play();
            //SpeechRecognizer service = new SpeechRecognizer();
            //service.setUsernameAndPassword("");

            string Result = "";

            MessageWebSocket webSock = new MessageWebSocket();

            webSock.Control.MessageType = SocketMessageType.Utf8;

            webSock.MessageReceived += WebSock_MessageReceived;

            webSock.Closed += WebSock_Closed;

            Uri serverUri = new Uri("https://stream.watsonplatform.net/speech-to-text/api");

            try
            {
                await webSock.ConnectAsync(serverUri);

                string filePath = "C:\\Users\\pedro\\Downloads\\app.wav";
                byte[] bytes = System.IO.File.ReadAllBytes(filePath);

                await WebSock_SendMessage(webSock, bytes);


            }catch(Exception ex)
            {
                Result = String.Format("Failed to send email with the following error: {0} ", ex.Message);
            }



            //service.setEndPoint("https://stream.watsonplatform.net/speech-to-text/api");

            //RecognizerOptions options = new RecognizerOptions().contentTy

        }

        private void WebSock_MessageReceived(MessageWebSocket sender, MessageWebSocketMessageReceivedEventArgs args)
        {
            DataReader messageReader = args.GetDataReader();
            messageReader.UnicodeEncoding = Windows.Storage.Streams.UnicodeEncoding.Utf8;
            string messageString = messageReader.ReadString(messageReader.UnconsumedBufferLength);
            //transcrito = messageString;

            transcrito.Text = messageString;

        }        

        private void WebSock_Closed(IWebSocket sender, WebSocketClosedEventArgs args)
        {
            
        }

        private async Task WebSock_SendMessage(MessageWebSocket webSock,byte[] data)
        {
            DataWriter messageWriter = new DataWriter(webSock.OutputStream);
            messageWriter.WriteBytes(data);
            await messageWriter.StoreAsync();
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            mediaElement.Stop();
        }

        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            mediaElement.Pause();
        }

        private async void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            await SetLocalMedia();
        }
        async private System.Threading.Tasks.Task SetLocalMedia()
        {
            var openPicker = new Windows.Storage.Pickers.FileOpenPicker();

            openPicker.FileTypeFilter.Add(".mp3");

            var file = await openPicker.PickSingleFileAsync();

            if (file != null)
            {
                var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
                mediaElement.SetSource(stream, file.ContentType);

                mediaElement.Play();
            }
        }
    }
}
