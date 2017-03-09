using System.Web;
using System.Web.Mvc;

namespace NetworkComplainCenter_NCC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
