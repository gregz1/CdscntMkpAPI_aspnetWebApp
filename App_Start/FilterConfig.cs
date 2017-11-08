using System.Web;
using System.Web.Mvc;

namespace CdscntMkpAPI_aspnetWebApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
