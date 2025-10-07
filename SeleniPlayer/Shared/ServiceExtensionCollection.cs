using Microsoft.Extensions.DependencyInjection;
using SeleniPlayer.Entities;
using SeleniPlayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniPlayer.Shared
{
    public static class ServiceExtensionCollection
    {
        public static void AddCommonServices(this IServiceCollection collection)
        {
            collection.AddSingleton<SeleniPlayerDBContext>();
            collection.AddTransient<MainViewModel>();
        }
    }
}
