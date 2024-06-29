namespace MVC_WebAppLevel1.Models
{
    public class Students
    {
        static List<Student> students;
        static Student? student;
        public Students()
        {
            students = new List<Student>(new List<Student>{
                new Student { Id = 1, Name = "std1", Address = "add1", Gender = "Male" },
                new Student { Id = 2, Name = "std2", Address = "add2", Gender = "Male" },
                new Student { Id = 3, Name = "std3", Address = "add3", Gender = "Male" },
                new Student { Id = 4, Name = "std4", Address = "add4", Gender = "Male" },
                new Student { Id = 5, Name = "std5", Address = "add5", Gender = "Male" },
                new Student { Id = 6, Name = "std6", Address = "add6", Gender = "Male" },
                new Student { Id = 7, Name = "std7", Address = "add7", Gender = "Male" },
                new Student { Id = 8, Name = "std8", Address = "add8", Gender = "Male" },
                new Student { Id = 9, Name = "std9", Address = "add9", Gender = "Male" },
                new Student { Id = 10, Name = "std10", Address = "add10", Gender = "Female" },
                new Student { Id = 11, Name = "std11", Address = "add11", Gender = "Female" },
                new Student { Id = 12, Name = "std12", Address = "add12", Gender = "Female" },
                new Student { Id = 13, Name = "std13", Address = "add13", Gender = "Female" },
                new Student { Id = 14, Name = "std14", Address = "add14", Gender = "Female" },
                new Student { Id = 15, Name = "std15", Address = "add15", Gender = "Female" },
                new Student { Id = 16, Name = "std16", Address = "add16", Gender = "Female" },
                new Student { Id = 17, Name = "std17", Address = "add17", Gender = "Female" },
                new Student { Id = 18, Name = "std18", Address = "add18", Gender = "Female" }});
        }

        public List<Student> GetAllStudents()
        {
            return students.ToList();
        }

        public Student GetStudent(int id)
        {
            student = students.FirstOrDefault(m => m.Id == id);
            if (student is null)
                return new Student();
            else return student;
        }
        //There's a Probability of OutOfRange Exception but now i'll suppose the rightness of the argument
        public int? GetNext(int id)
        {
            int NextIndex = students.FindIndex(m => m.Id == id) + 1;
            if (NextIndex < students.Count)
                return students[NextIndex].Id;
            return null;
        } 

        public int? GetPrevious(int id)
        {
            int PreviousIndex = students.FindIndex(m => m.Id == id) - 1;
            if (PreviousIndex >= 0)
                return students[PreviousIndex].Id;
            return null;
        }
    }
}
