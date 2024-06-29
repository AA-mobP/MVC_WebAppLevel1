namespace MVC_WebAppLevel1.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string Image
        {
            get
            {
                string image = "";
                if (Gender.ToLower() == "male")
                    image = "male student.png";
                else if (Gender.ToLower() == "female")
                    image = "female student.png";
                return image;
            }
        }
    }
}
