using System.Web;
using System.Web.Mvc;

namespace Laba_14EntityASP
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
