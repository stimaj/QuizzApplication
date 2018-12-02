using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    public class CourseCardDataModel
    {

        public CourseCardDataModel(string ImagePath, string CourseDescription, string CourseLecturer, int NumberOfVotes,
            float AverageMark, float Price, int NumberOfStudents, int NumberOfComments)
        {
            this.ImagePath = ImagePath;
            this.CourseDescription = CourseDescription;
            this.CourseLecturer = CourseLecturer;
            this.NumberOfVotes = NumberOfVotes;
            this.AverageMark = AverageMark;
            this.Price = Price;
            this.NumberOfStudents = NumberOfStudents;
            this.NumberOfComments = NumberOfComments;
        }

        public string ImagePath { get; set; }
        public string CourseDescription { get; set; }
        public string CourseLecturer { get; set; }
        public int NumberOfVotes { get; set; }
        public float AverageMark { get; set; }
        public float Price { get; set; }
        public int NumberOfStudents { get; set; }
        public int NumberOfComments { get; set; }
    }
}
