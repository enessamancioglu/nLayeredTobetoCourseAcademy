﻿
using DataAccess.Contexts;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess
{
    public static class DataAccessServiceRegistration
    {
        public static IServiceCollection AddDataAccessServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<NorthwindContext>(options => options.UseInMemoryDatabase("nArchitecture"));
            //services.AddDbContext<BaseDbContext>(options => options.UseSq lServer(configuration.GetConnectionString("RentACar")));
            services.AddScoped<ICourseDal, EfCourseDal>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();
            services.AddScoped<IInstructorDal, EfInstructorDal>();


            return services;
        }
        //public static IServiceCollection AddDataAccessServices2(this IServiceCollection services, IConfiguration configuration)
        //{
        //    services.AddDbContext<NorthwindContext>(options => options.UseInMemoryDatabase("nArchitecture"));
        //    //services.AddDbContext<BaseDbContext>(options => options.UseSq lServer(configuration.GetConnectionString("RentACar")));
        //    services.AddScoped<ICategoryDal, EfCategoryDal>();

        //    return services;
        //}
    }


}
