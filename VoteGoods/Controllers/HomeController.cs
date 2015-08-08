// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HomeController.cs" company="WWW.NEWBABA.COM">
//   
// </copyright>
// <summary>
//   The home controller.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace WWW.NEWBABA.COM.VoteGoods.Controllers
{
    using System.Web.Mvc;

    /// <summary>
    ///     The home controller.
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        ///     The index.
        /// </summary>
        /// <returns>
        ///     The <see cref="ActionResult" />.
        /// </returns>
        public ActionResult Index()
        {
            this.ViewBag.Title = "Home Page1";

            return this.View();
        }
    }
}