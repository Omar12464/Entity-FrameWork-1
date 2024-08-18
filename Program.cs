using Entity_FrameWork_1.Context;
using Entity_FrameWork_1.Models;
using Microsoft.EntityFrameworkCore;

namespace Entity_FrameWork_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Calling Database by Convention method
            //SchoolDbContext dbcontext = new SchoolDbContext();

            #endregion
            #region Calling Database by DataAnnotation method
            SchoolDbContext dbContext = new SchoolDbContext();
            dbContext.Set<Student>().Where(s=>s.Id == 1);
            dbContext.Set<Instructor>().Where(s => s.Id == 1);
            dbContext.Set<Topic>().Where(s => s.Id == 1);
            dbContext.Set<Course>().Where(s => s.Id == 1);
            dbContext.Set<Course_Inst>().Where(s => s.CrsId == 1);
            dbContext.Set<StudCourse>().Where(s => s.StudId == 1);

            #endregion
        }
    }
}
