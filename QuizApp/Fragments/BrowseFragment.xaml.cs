using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using QuizApp.DataModels;
using System;
using System.Threading.Tasks;

namespace QuizApp
{
    /// <summary>
    /// Interaction logic for BrowseFragment.xaml
    /// </summary>
    public partial class BrowseFragment : UserControl
    {

        Grid lastClickedHomeTab;
        Button previousTabButton;
        public BrowseFragment()
        {
            InitializeComponent();
            lastClickedHomeTab = tabUnderliner0;
            previousTabButton = overviewTabButton;
        }

        private void tabButton_Clicked(object sender, RoutedEventArgs e)
        {
            Button clickedButton = (Button)sender;
            int buttonIndex = int.Parse(clickedButton.Uid);
            lastClickedHomeTab.Visibility = Visibility.Collapsed;
            previousTabButton.Foreground = Brushes.Gray;
            clickedButton.Foreground = (Brush)new BrushConverter().ConvertFrom("#2D3F50");
            previousTabButton = clickedButton;
            switch (buttonIndex)
            {
                case 0:
                    tabUnderliner0.Visibility = Visibility.Visible;
                    lastClickedHomeTab = tabUnderliner0;
                    break;
                case 1:
                    tabUnderliner1.Visibility = Visibility.Visible;
                    lastClickedHomeTab = tabUnderliner1;
                    break;
                case 2:
                    tabUnderliner2.Visibility = Visibility.Visible;
                    lastClickedHomeTab = tabUnderliner2;
                    break;
                case 3:
                    tabUnderliner3.Visibility = Visibility.Visible;
                    lastClickedHomeTab = tabUnderliner3;
                    break;
                case 4:
                    tabUnderliner4.Visibility = Visibility.Visible;
                    lastClickedHomeTab = tabUnderliner4;
                    break;
                case 5:
                    tabUnderliner5.Visibility = Visibility.Visible;
                    lastClickedHomeTab = tabUnderliner5;
                    break;
                case 6:
                    tabUnderliner6.Visibility = Visibility.Visible;
                    lastClickedHomeTab = tabUnderliner6;
                    break;
                default:
                    tabUnderliner0.Visibility = Visibility.Visible;
                    lastClickedHomeTab = tabUnderliner0;
                    break;
            }
        }

        async Task populateFeaturedCourses()
        {
            try
            {
                CourseCardsDataModel featuredCoursesContainer = await Constants.sendPostRequest<CourseCardsDataModel>(Constants.BASE_URL + "/featuredCourses");
                if (featuredCoursesContainer != null && featuredCoursesContainer.FeaturedCourses.Count > 0)
                {
                    foreach (CourseCardVM vm in featuredCoursesContainer.FeaturedCourses)
                    {
                        CourseCardUC newCard = new CourseCardUC(vm);
                        FeaturedCoursesGrid.Children.Add(newCard);
                        Grid.SetColumn(newCard, featuredCoursesContainer.FeaturedCourses.IndexOf(vm));
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        async Task populateTopCategories()
        {
            try
            {
                CourseCategoriesDataModel courseCategories = await Constants.sendPostRequest<CourseCategoriesDataModel>(Constants.BASE_URL + "/courseCategory");
                if (courseCategories != null && courseCategories.TopCategories.Count > 0)
                {
                    int i = 0;
                    for (int r = 0; r < 2; r++)
                    {
                        for (int k = 0; k < 4; k++)
                        {
                            CourseCategory cCat = new CourseCategory(courseCategories.TopCategories[i]);
                            TopCategoriesGrid.Children.Add(cCat);
                            Grid.SetColumn(cCat, k);
                            Grid.SetRow(cCat, r);
                            i++;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Check Internet connection.");
            }
        }

        async Task populateTopInstructorsGrid()
        {
            try
            {
                TopInstructorsDataModel topINstructorsContainer = await Constants.sendPostRequest<TopInstructorsDataModel>(Constants.BASE_URL + "/topInstructors");
                for (int k = 0; k < 4; k++)
                {
                    InstructorCard cCat = new InstructorCard(topINstructorsContainer.TopInstructors[k]);
                    TopInstructorsGrid.Children.Add(cCat);
                    Grid.SetColumn(cCat, k);
                }
            }
            catch
            {
                MessageBox.Show("Check Internet connection.");
            }
        }

        private async void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            await populateFeaturedCourses();
            await populateTopCategories();
            await populateTopInstructorsGrid();
        }
    }
}
