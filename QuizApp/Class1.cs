using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    class Class1 : INotifyPropertyChanged
    {
        private double mHeight;

        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

        public Class1(double height)
        {
            mHeight = height;
        }
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
