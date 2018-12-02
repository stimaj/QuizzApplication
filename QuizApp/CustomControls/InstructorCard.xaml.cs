using System.Windows.Controls;

namespace QuizApp
{
    /// <summary>
    /// Interaction logic for InstructorCard.xaml
    /// </summary>
    public partial class InstructorCard : UserControl
    {
        public InstructorCard(InstructorCardVM vm)
        {
            InitializeComponent();
            DataContext = vm;
        }
    }
}
