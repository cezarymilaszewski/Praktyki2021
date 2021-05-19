using System.Data.Entity;
using Database1.Tables.Info;

namespace Database1.Tables
{
    public class SchoolContext: DbContext
    {
        public SchoolContext(): base()
        {


        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}