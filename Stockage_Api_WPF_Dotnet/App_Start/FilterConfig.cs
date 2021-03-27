using System.Web;
using System.Web.Mvc;

namespace Stockage_Api_WPF_Dotnet
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
