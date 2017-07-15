using Queries.Core.Domain;
using Queries.Core.Repositories;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Queries.Persistence.Repositories
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        public CourseRepository(HCMContext context) 
            : base(context)
        {
        }

        public IEnumerable<Course> GetTopSellingCourses(int count)
        {
            return HCMContext.Courses.OrderByDescending(c => c.FullPrice).Take(count).ToList();
        }

        public IEnumerable<Course> GetCoursesWithAuthors(int pageIndex, int pageSize = 10)
        {
            return HCMContext.Courses
                .Include(c => c.Author)
                .OrderBy(c => c.Name)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        public HCMContext HCMContext
        {
            get { return Context as HCMContext; }
        }
    }
}