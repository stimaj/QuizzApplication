using QuizApp.CustomControls;
using QuizApp.DataModels;
using System;
using System.Threading.Tasks;

namespace QuizApp
{
    public class BrowseFragmentVM: BaseViewModel
    {
        public BrowseFragmentVM()
        {

        }

        async Task populateFeaturedCourses()
        {
            try
            {
                await Task.Delay(10000);
                CourseCardsDataModel featuredCoursesContainer = await Constants.sendPostRequest<CourseCardsDataModel>(Constants.BASE_URL + "/featuredCourses");
                if (featuredCoursesContainer != null && featuredCoursesContainer.FeaturedCourses.Count > 0)
                {
                    foreach (CourseCardVM vm in featuredCoursesContainer.FeaturedCourses)
                    {
                        //CourseCardUC newCard = new CourseCardUC(vm);
                        //FeaturedCoursesGrid.Children.Add(newCard);
                        //Grid.SetColumn(newCard, featuredCoursesContainer.FeaturedCourses.IndexOf(vm));
                    }
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
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
                            //TopCategoriesGrid.Children.Add(cCat);
                            //Grid.SetColumn(cCat, k);
                            //Grid.SetRow(cCat, r);
                            i++;
                        }
                    }
                }
            }
            catch
            {
                //MessageBox.Show("Check Internet connection.");
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
                    //TopInstructorsGrid.Children.Add(cCat);
                    //Grid.SetColumn(cCat, k);
                }
            }
            catch
            {
                //MessageBox.Show("Check Internet connection.");
            }
        }
    }
}
