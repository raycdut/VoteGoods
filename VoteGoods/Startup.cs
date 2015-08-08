using Microsoft.Owin;

using WWW.NEWBABA.COM.VoteGoods;

[assembly: OwinStartup(typeof(Startup))]

namespace WWW.NEWBABA.COM.VoteGoods
{
    using Owin;

    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            this.ConfigureAuth(app);
        }
    }
}
