using Electricity.DAL.Core.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Electricity.WebService.Core.Extensions
{
    public static class StartupEx
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TInterface"></typeparam>
        /// <typeparam name="TRepository"></typeparam>
        /// <typeparam name="TModel"></typeparam>
        /// <param name="serviceCollection"></param>
        //public static void AddRepository<TInterface, TRepository, TModel>( this IServiceCollection serviceCollection )
        //    where TInterface : IRepository<TModel>
        //    where TRepository : TInterface
        //{
        //    serviceCollection.AddScoped<TInterface, TRepository>();
        //    serviceCollection.AddScoped<IRepository<TModel>, TRepository>();
        //}
    }

    // usage:
    //services.AddRepository<ITestRepository, TestRepository, Model>();
}
