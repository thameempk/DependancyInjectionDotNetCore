namespace DependancyInjection.Models
{
    public interface IStudentRepository
    {
        Students GetStudentById(int StudentId);
        List<Students> GetAllStudent();
    }
}
