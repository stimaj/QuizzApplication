namespace QuizApp
{
    public class CourseCardVM : BaseViewModel
    {
        public static CourseCardVM Instance { get { return new CourseCardVM(); } }
        public string CoursePrice { get; set; } = "";
        public string CourseName { get; set; }
        public string CourseLecturer { get; set; }
        public int NumberOfComments { get; set; }
        public int NumberOfAttenders { get; set; }
        public float AverageMark { get; set; } = 0;
        public string ImagePath { get; set; } = "../image/splashImage.jpg";
    }
}
