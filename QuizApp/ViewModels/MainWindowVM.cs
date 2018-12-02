using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    class MainWindowVM : INotifyPropertyChanged
    {
        double mHeight;

        public MainWindowVM(int ContainerHeight)
        {
            mHeight = ContainerHeight;
        }

        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

        public double CardContainerHeight
        {
            get
            {
                return mHeight;
            }
            set
            {
                if (mHeight == value)
                    return;
                mHeight = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(CardContainerHeight)));
            }
        }
    }
}
