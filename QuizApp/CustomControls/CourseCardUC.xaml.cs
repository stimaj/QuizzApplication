using System.Windows.Controls;

namespace QuizApp
{
    /// <summary>
    /// Interaction logic for CourseCardUC.xaml
    /// </summary>
    public partial class CourseCardUC : UserControl
    {
        public CourseCardUC()
        {
            InitializeComponent();
        }
        public CourseCardUC(CourseCardVM vm)
        {
            InitializeComponent();
            DataContext = vm;
        }
    }
}
