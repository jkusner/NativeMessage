using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft.Json;

namespace NativeMessagingTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Thread inThread = new Thread(ListenForMessages);
            inThread.IsBackground = true;
            inThread.Start();
        }

        void ListenForMessages()
        {
            while (true)
            {
                NativeMessage msg = NativeMessage.Read();

                if (msg.Length > 0)
                {
                    TextMessage tMsg = msg.Get<TextMessage>();

                    txtStdin.Dispatcher.Invoke(() => {
                        txtStdin.Text = tMsg.text;
                    });
                }

                Thread.Sleep(100);
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            NativeMessage msg = new NativeMessage(new TextMessage { text = txtStdout.Text });
            msg.Send();
        }

        class TextMessage
        {
            public string text;
        }
    }
}
