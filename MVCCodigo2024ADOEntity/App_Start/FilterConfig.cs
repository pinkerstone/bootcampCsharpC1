using System.Web;
using System.Web.Mvc;

namespace MVCCodigo2024ADOEntity
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
