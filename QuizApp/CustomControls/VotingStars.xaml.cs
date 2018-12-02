using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace QuizApp.CustomControls
{
    /// <summary>
    /// Interaction logic for VotingStars.xaml
    /// </summary>
    public partial class VotingStars : UserControl
    {
        float numOfFullStars;
        public float MarkProp
        {
            get { return (float)GetValue(MarkProperty); }
            set
            {
                //setMarks(value);
                SetValue(MarkProperty, numOfFullStars);
            }
        }
        public VotingStars()
        {
            InitializeComponent();
        }
        public void setMarks(float markValue)
        {
            MaterialDesignThemes.Wpf.PackIcon[] starIcons = { Star0, Star1, Star2, Star3, Star4 };
            double rounded = Math.Round(markValue, 1);
            if (rounded >= 4.5)
            {
                //5 stars
                numOfFullStars = 5;
            }
            else if (rounded >= 3.5)
            {
                //4 stars
                numOfFullStars = 4;
            }
            else if (rounded >= 2.5)
            {
                //3 stars
                numOfFullStars = 3;
            }
            else if (rounded >= 1.5)
            {
                //2 stars
                numOfFullStars = 2;
            }
            else if (rounded >= 0.5)
            {
                //1 star
                numOfFullStars = 1;
            }
            else
            {
                numOfFullStars = 0;
            }
            int i;
            for (i = 0; i < numOfFullStars; i++)
            {
                starIcons[i].Kind = MaterialDesignThemes.Wpf.PackIconKind.Star;
                starIcons[i].Foreground = Brushes.Yellow;
            }
            for (int k = i; k < 5; k++)
            {
                starIcons[k].Kind = MaterialDesignThemes.Wpf.PackIconKind.StarBorder;
                starIcons[k].Foreground = Brushes.Yellow;
            }
        }

        #region Dependency property MarkProp visible in XAML
        public static readonly DependencyProperty MarkProperty = DependencyProperty.Register("MarkProp", typeof(float), typeof(VotingStars), new
            PropertyMetadata(0F, new PropertyChangedCallback(OnSetMarkChanged)));

        private static void OnSetMarkChanged(DependencyObject d,
         DependencyPropertyChangedEventArgs e)
        {
            VotingStars UserControl1Control = d as VotingStars;
            UserControl1Control.OnSetMarkChanged(e);
        }

        private void OnSetMarkChanged(DependencyPropertyChangedEventArgs e)
        {
            setMarks(float.Parse(e.NewValue.ToString()));
        }
        #endregion
    }
}
