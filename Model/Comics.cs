using System.ComponentModel.DataAnnotations;

namespace Comics.Model
{
    public class Comics
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Введите имя пользователя")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Введите адрес электронной почты")]
        public int Year { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<SubjectGrade> subjectGrades { get; set; }
        public Comics() 
        {
            Name ??= string.Empty;
            Email ??= string.Empty;
            
        }
        

    }
}
