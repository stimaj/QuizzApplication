using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Newtonsoft.Json;

namespace QuizApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Grid currentTabView;
        MainWindowVM vm;
        ListViewItem previousSelectedListItem;
        public MainWindow()
        {
            InitializeComponent();
            currentTabView = HomeTab;
            vm = new MainWindowVM(440);
            this.DataContext = vm;
            //populateBrowseGrid();
            //populateTopCategories();
            //populateTopInstructorsGrid();
            serialize();
            previousSelectedListItem = BrowseListItem;
        }
        #region Nav Bar Open/Close Buttons
        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }
        #endregion

        #region Border Buttons
        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void maximizeButton_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
            {
                WindowState = WindowState.Normal;
            }
            else
            {
                WindowState = WindowState.Maximized;
            }
            vm.CardContainerHeight = this.ActualHeight - 160;
        }

        private void minimizeButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        #endregion

        private void ListViewItem_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ListViewItem selectedListViewItem = sender as ListViewItem;
            selectedListViewItem.Foreground = (Brush)new BrushConverter().ConvertFrom("#2E75B6");
            int index = int.Parse(selectedListViewItem.Uid);
            previousSelectedListItem.Foreground = Brushes.White;
            previousSelectedListItem = selectedListViewItem;
            switch (index)
            {
                case 0:
                    currentTabView.Visibility = Visibility.Collapsed;
                    currentTabView = HomeTab;
                    currentTabView.Visibility = Visibility.Visible;
                    break;
                case 1:
                    currentTabView.Visibility = Visibility.Collapsed;
                    currentTabView = MessageTab;
                    currentTabView.Visibility = Visibility.Visible;
                    break;
                case 2:
                    currentTabView.Visibility = Visibility.Collapsed;
                    currentTabView = CoursesTab;
                    currentTabView.Visibility = Visibility.Visible;
                    break;
                case 3:
                    currentTabView.Visibility = Visibility.Collapsed;
                    currentTabView = SettingsTab;
                    currentTabView.Visibility = Visibility.Visible;
                    break;
                case 4:
                    currentTabView.Visibility = Visibility.Collapsed;
                    currentTabView = SettingsTab;
                    currentTabView.Visibility = Visibility.Visible;
                    break;
                case 5:
                    currentTabView.Visibility = Visibility.Collapsed;
                    currentTabView = SettingsTab;
                    currentTabView.Visibility = Visibility.Visible;
                    break;
                case 6:
                    currentTabView.Visibility = Visibility.Collapsed;
                    currentTabView = SettingsTab;
                    currentTabView.Visibility = Visibility.Visible;
                    break;
                case 7:
                    currentTabView.Visibility = Visibility.Collapsed;
                    currentTabView = SettingsTab;
                    currentTabView.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("Saved Courses");
        }

        //void populateBrowseGrid()
        //{
        //    CourseCard cc0 = new CourseCard(new CourseCardDataModel("images/courseImage.jpg", "Course description",
        //        "Stefan Djuric", 25, 4, 250, 12, 7));
        //    CourseCard cc1 = new CourseCard(new CourseCardDataModel("images/courseImage.jpg", "Course description",
        //        "Stefan Djuric", 25, 4, 250, 12, 7));
        //    CourseCard cc2 = new CourseCard(new CourseCardDataModel("images/courseImage.jpg", "Course description",
        //        "Stefan Djuric", 25, 4, 250, 12, 7));
        //    CourseCard cc3 = new CourseCard(new CourseCardDataModel("images/courseImage.jpg", "Course description",
        //        "Stefan Djuric", 25, 4, 250, 12, 7));
        //    FeaturedCoursesGrid.Children.Add(cc0);
        //    FeaturedCoursesGrid.Children.Add(cc1);
        //    FeaturedCoursesGrid.Children.Add(cc2);
        //    FeaturedCoursesGrid.Children.Add(cc3);
        //    Grid.SetColumn(cc0, 0);
        //    Grid.SetColumn(cc1, 1);
        //    Grid.SetColumn(cc2, 2);
        //    Grid.SetColumn(cc3, 3);
        //}

        //void populateTopCategories()
        //{
        //    for (int r = 0; r < 2; r++)
        //    {
        //        for (int k = 0; k < 4; k++)
        //        {
        //            CourseCategory cCat = new CourseCategory();
        //            TopCategoriesGrid.Children.Add(cCat);
        //            Grid.SetColumn(cCat, k);
        //            Grid.SetRow(cCat, r);
        //        }
        //    }
        //}

        //void populateTopInstructorsGrid()
        //{
        //    for (int k = 0; k < 4; k++)
        //    {
        //        InstructorCard cCat = new InstructorCard();
        //        TopInstructorsGrid.Children.Add(cCat);
        //        Grid.SetColumn(cCat, k);
        //    }
        //}
        void serialize()
        {
            string st = JsonConvert.SerializeObject(new DeleteMe());
            Console.WriteLine(st);
            DeleteMe n = JsonConvert.DeserializeObject<DeleteMe>(st);
            Console.WriteLine(n.Name);
        }
    }
}
