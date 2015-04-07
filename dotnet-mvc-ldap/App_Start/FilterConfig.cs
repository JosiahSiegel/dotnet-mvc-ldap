using System.Web;
using System.Web.Mvc;

namespace dotnet_mvc_ldap
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
