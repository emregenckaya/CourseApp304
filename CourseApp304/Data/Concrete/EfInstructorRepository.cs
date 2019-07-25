using CourseApp304.Data.Abstract;
using CourseApp304.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp304.Data.Concrete
{
    public class EfInstructorRepository : GenericRepository<Instructor>, IInstructorRepository
    {
        private DataContext context;

        public EfInstructorRepository(DataContext _context):base(_context)  //base vererek constructor ın hangi tipten veri çekeceğini belirtiyoruz yoksa const parametreyi anlayamıyor.
        {
            context = _context;
        }

        public override IEnumerable<Instructor> GetAll()
        {
            context.Courses.Where(x => x.Instructor != null && x.isActive).Load();
            return context.Instructors;
            //return context.Instructors.Include(x => x.Courses);
        }

        public IEnumerable<Instructor> GetTopInstructor()
        {
            throw new NotImplementedException();
        }
        
    }
}
