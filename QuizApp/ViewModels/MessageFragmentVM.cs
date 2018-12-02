
using System.ComponentModel;

namespace QuizApp
{
    class MessageFragmentVM : INotifyPropertyChanged
    {
        string textMessage = "Some message";
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

        public string TextMessage
        {
            get
            {
                return textMessage;
            }
            set
            {
                if (textMessage == value)
                    return;
                textMessage = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(TextMessage)));
            }
        }
    }
}
