// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ValuesControllerTest.cs" company="">
//   
// </copyright>
// <summary>
//   The values controller test.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace WWW.NEWBABA.COM.VoteGoods.Tests.Controllers
{
    using System.Linq;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using WWW.NEWBABA.COM.VoteGoods.Controllers;

    /// <summary>
    /// The values controller test.
    /// </summary>
    [TestClass]
    public class ValuesControllerTest
    {
        /// <summary>
        /// The get.
        /// </summary>
        [TestMethod]
        public void Get()
        {
            // 排列
            var controller = new ValuesController();

            // 操作
            var result = controller.Get();

            // 断言
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
            Assert.AreEqual("value1", result.ElementAt(0));
            Assert.AreEqual("value2", result.ElementAt(1));
        }

        /// <summary>
        /// The get by id.
        /// </summary>
        [TestMethod]
        public void GetById()
        {
            // 排列
            var controller = new ValuesController();

            // 操作
            var result = controller.Get(5);

            // 断言
            Assert.AreEqual("value", result);
        }

        /// <summary>
        /// The post.
        /// </summary>
        [TestMethod]
        public void Post()
        {
            // 排列
            var controller = new ValuesController();

            // 操作
            controller.Post("value");

            // 断言
        }

        /// <summary>
        /// The put.
        /// </summary>
        [TestMethod]
        public void Put()
        {
            // 排列
            var controller = new ValuesController();

            // 操作
            controller.Put(5, "value");

            // 断言
        }

        /// <summary>
        /// The delete.
        /// </summary>
        [TestMethod]
        public void Delete()
        {
            // 排列
            var controller = new ValuesController();

            // 操作
            controller.Delete(5);

            // 断言
        }
    }
}