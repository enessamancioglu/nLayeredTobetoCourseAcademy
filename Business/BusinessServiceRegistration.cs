﻿using Business.Abstracts;
using Business.Concretes;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public static class BusinessServiceRegistration
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<ICourseService, CourseManager>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<IInstructorService, InstructorManager>();



            return services;
        }
        //public static IServiceCollection AddBusinessServices2(this IServiceCollection services)
        //{
        //    services.AddScoped<ICategoryService, CategoryManager>();

        //    return services;
        //}
    }
}


