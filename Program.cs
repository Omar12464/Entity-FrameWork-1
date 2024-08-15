using Entity_FrameWork_1.Context;
using Microsoft.EntityFrameworkCore;

namespace Entity_FrameWork_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SchoolDbContext dbcontext = new SchoolDbContext();
            #region Adding Data
            dbcontext.Student.Add(new Models.Student
            {
                Id = 1,
                Fname = "Omar",
                LName = "Mido",
                Address = "Washigton",
                Age = 5,
                DepId = 3
            });
            dbcontext.Topic.Add(new Models.Topic { Id = 1, Name = "CS" });
            dbcontext.Course.Add(new Models.Course { Id = 1, Name = "aLGORITHM", Description = "Good", Duration = 6, TopId = 1 });
            dbcontext.Instructor.Add(new Models.Instructor { Id = 1, Name = "Mido", Address = "Washington", HourRate = 30, Salary = 5000, DepId = 1 });
            dbcontext.Department.Add(new Models.Department { Id = 1, HiringDate = 5, Name = "Managers", InsId = 1, });
            dbcontext.StudCourse.Add(new Models.StudCourse { crsId = 1, Grade = "A", StudId = 1 });
            dbcontext.Course_Inst.Add(new Models.Course_Inst { CrsId = 1, Evaluate = "Excellent", InstId = 1 });

            #endregion
        }
    }
}
