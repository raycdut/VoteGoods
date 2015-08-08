using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WWW.NEWBABA.COM.VoteGoods.Web.Startup))]

namespace WWW.NEWBABA.COM.VoteGoods.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}