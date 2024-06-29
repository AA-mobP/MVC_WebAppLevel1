namespace MVC_WebAppLevel1.Models
{
    public class Students
    {
        static List<Student> students;
        static Student? student;
        public Students()
        {
            students = new List<Student>(new List<Student>{
                new Student { Id = 1, Name = "std1", Address = "add1", Image = "std1.jpg" },
                new Student { Id = 2, Name = "std2", Address = "add2", Image = "std2.jpg" },
                new Student { Id = 3, Name = "std3", Address = "add3", Image = "std3.jpg" },
                new Student { Id = 4, Name = "std4", Address = "add4", Image = "std4.jpg" },
                new Student { Id = 5, Name = "std5", Address = "add5", Image = "std5.jpg" },
                new Student { Id = 6, Name = "std6", Address = "add6", Image = "std6.jpg" },
                new Student { Id = 7, Name = "std7", Address = "add7", Image = "std7.jpg" },
                new Student { Id = 8, Name = "std8", Address = "add8", Image = "std8.jpg" },
                new Student { Id = 9, Name = "std9", Address = "add9", Image = "std9.jpg" },
                new Student { Id = 10, Name = "std10", Address = "add10", Image = "std10.jpg" },
                new Student { Id = 11, Name = "std11", Address = "add11", Image = "std11.jpg" },
                new Student { Id = 12, Name = "std12", Address = "add12", Image = "std12.jpg" },
                new Student { Id = 13, Name = "std13", Address = "add13", Image = "std13.jpg" },
                new Student { Id = 14, Name = "std14", Address = "add14", Image = "std14.jpg" },
                new Student { Id = 15, Name = "std15", Address = "add15", Image = "std15.jpg" },
                new Student { Id = 16, Name = "std16", Address = "add16", Image = "std16.jpg" },
                new Student { Id = 17, Name = "std17", Address = "add17", Image = "std17.jpg" },
                new Student { Id = 18, Name = "std18", Address = "add18", Image = "std18.jpg" }});
        }

        public Student GetStudent(int id)
        {
            student = students.FirstOrDefault(m => m.Id == id);
            if (student is null)
                return new Student();
            else return student;
        }

        public List<Student> GetAllStudents()
        {
            return students.ToList();
        }
    }
}
