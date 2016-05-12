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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace AirFIT
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CriarTarefa : Page
    {
        public CriarTarefa()
        {
            this.InitializeComponent();
        }

        private string atividade;
        private string transcricao;

        private void CriarAtividade_Click(object sender, RoutedEventArgs e)
        {
            var selected = (MenuFlyoutItem)sender;
            atividade = selected.Text;
            MyFrame.Navigate(typeof(CriarAtividades));
        }

        private void Transcricao_Click(object sender, RoutedEventArgs e)
        {
            var selected = (MenuFlyoutItem)sender;
            transcricao = selected.Text;
            MyFrame.Navigate(typeof(Transcrever));
        }

        private void Tarefa_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TarefaConcluida_Click(object sender,RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(CriarAtividades));
        }
    }
}
