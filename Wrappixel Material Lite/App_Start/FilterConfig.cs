using System.Web;
using System.Web.Mvc;

namespace Wrappixel_Material_Lite
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
