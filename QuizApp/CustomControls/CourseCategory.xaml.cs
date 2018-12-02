using System.Windows.Controls;

namespace QuizApp
{
    /// <summary>
    /// Interaction logic for CourseCategory.xaml
    /// </summary>
    public partial class CourseCategory : UserControl
    {
        public CourseCategory(CourseCategoryVM vm)
        {
            InitializeComponent();
            DataContext = vm;
        }
    }
}
