namespace QuizApp.DataModels
{
    class SignUpDataModel : LoginDataModel
    {
        public string Country { get; set; } = "";
        public string Name { get; set; } = "";
    }
}
