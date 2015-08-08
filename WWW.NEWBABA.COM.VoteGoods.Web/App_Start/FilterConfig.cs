using System.Web;
using System.Web.Mvc;

namespace WWW.NEWBABA.COM.VoteGoods.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
