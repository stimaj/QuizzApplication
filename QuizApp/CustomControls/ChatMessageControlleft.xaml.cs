using System.Windows.Controls;

namespace QuizApp.CustomControls
{
    /// <summary>
    /// Interaction logic for ChatMessageControl.xaml
    /// </summary>
    public partial class ChatMessageControlleft : UserControl
    {
        public ChatMessageControlleft()
        {
            InitializeComponent();
        }
        public ChatMessageControlleft(string textMessage)
        {
            InitializeComponent();
            TextMessageTextBlock.Text = textMessage;
        }
    }
}
