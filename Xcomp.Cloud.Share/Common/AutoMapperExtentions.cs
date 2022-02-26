
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Xcomp.Web.Cloud.Share.Map;

namespace Xcomp.Cloud.Share.Common
{
    public static class AutoMapperExtentions
    {
        public static void AddAutoMapperConfig(this IServiceCollection services)
        {
            #region Add automapper
            var assembly = Assembly.GetAssembly(typeof(AutoMapperExtentions));
            services.AddAutoMapper(assembly);
            #endregion
            services.AddAutoMapper(typeof(MappingProfile));
        }
    }
}
