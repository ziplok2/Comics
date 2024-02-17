using System.ComponentModel.DataAnnotations;

namespace Comics.Model
{
    public class Comics
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public string Email { get; set; }
        public Comics() 
        {
            Name ??= string.Empty;
            Email ??= string.Empty;

        }
        

    }
}
