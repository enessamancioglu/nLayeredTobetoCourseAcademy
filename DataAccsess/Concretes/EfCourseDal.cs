
using DataAccess.Contexts;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.Repositories;

namespace DataAccess.Concretes
{
    public class EfCourseDal : EfRepositoryBase<Course, Guid, NorthwindContext>, ICourseDal
    {
        public EfCourseDal(NorthwindContext context) : base(context)
        {
        }
    }
}
