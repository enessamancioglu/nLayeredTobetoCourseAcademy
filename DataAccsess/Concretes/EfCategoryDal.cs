
using DataAccess.Contexts;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.Repositories;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Query;
using Core.DataAccess.Paging;
using Core.DataAccess.Dynamic;

namespace DataAccess.Concretes
{
    public class EfCategoryDal : EfRepositoryBase<Category, Guid, NorthwindContext>, ICategoryDal
    {
        public EfCategoryDal(NorthwindContext context) : base(context)
        {
        }

    }
}
