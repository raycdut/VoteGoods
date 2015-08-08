// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HomeControllerTest.cs" company="">
//   
// </copyright>
// <summary>
//   The home controller test.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace WWW.NEWBABA.COM.VoteGoods.Tests.Controllers
{
    using System.Web.Mvc;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using WWW.NEWBABA.COM.VoteGoods.Controllers;

    /// <summary>
    /// The home controller test.
    /// </summary>
    [TestClass]
    public class HomeControllerTest
    {
        /// <summary>
        /// The index.
        /// </summary>
        [TestMethod]
        public void Index()
        {
            // 排列
            var controller = new HomeController();

            // 操作
            var result = controller.Index() as ViewResult;

            // 断言
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}