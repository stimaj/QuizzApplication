using System.Windows;
using System.Windows.Controls;
using QuizApp.CustomControls;
using System.Collections.Generic;
using QuizApp.DataModels;

namespace QuizApp
{
    /// <summary>
    /// Interaction logic for MessageFragment.xaml
    /// </summary>
    public partial class MessageFragment : UserControl
    {

        public MessageFragment()
        {
            InitializeComponent();
        }

        private void SendMessageButton_Click(object sender, RoutedEventArgs e)
        {
            MessageContent.Children.Add(new ChatMessageControlleft(MessageTextTextBox.Text));
            MessageTextTextBox.Text = "";
        }
    }
}
