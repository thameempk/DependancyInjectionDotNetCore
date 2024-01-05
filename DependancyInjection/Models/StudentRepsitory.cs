using static System.Collections.Specialized.BitVector32;
using System.Reflection;
using System.Xml.Linq;

namespace DependancyInjection.Models
{
    public class StudentRepsitory : IStudentRepository
    {
        
            List<Students> students =  new List<Students>()
            {
                new Students() { StudentId = 101, Name = "James", Branch = "CSE", Section = "A", Gender = "Male" },
                new Students() { StudentId = 102, Name = "Smith", Branch = "ETC", Section = "B", Gender = "Male" },
                new Students() { StudentId = 103, Name = "David", Branch = "CSE", Section = "A", Gender = "Male" },
                new Students() { StudentId = 104, Name = "Sara", Branch = "CSE", Section = "A", Gender = "Female" },
                new Students() { StudentId = 105, Name = "Pam", Branch = "ETC", Section = "B", Gender = "Female" }
    };
        public Students GetStudentById(int id)
        {
            return students.FirstOrDefault(s => s.StudentId == id) ?? new Students ();

        }
        public List<Students> GetAllStudent()
        {
            return students;
        }

    }
}
