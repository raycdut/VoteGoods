// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProductController.cs" company="WWW.NEWBABA.COM“>
//
// </copyright>
// <summary>
//   The product controller.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace WWW.NEWBABA.COM.VoteGoods.Web.Controllers
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Web.Mvc;

    using WWW.NEWBABA.COM.VoteGoods.Web.Models;

    /// <summary>
    ///     The product controller.
    /// </summary>
    public class ProductController : Controller
    {
        /// <summary>
        ///     The db context.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.NamingRules", "SA1306:FieldNamesMustBeginWithLowerCaseLetter", Justification = "Reviewed. Suppression is OK here.")]
        private readonly VoteGoodsModels DbContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductController"/> class.
        /// </summary>
        /// <param name="_dbContext">
        /// The _db context.
        /// </param>
        public ProductController(VoteGoodsModels _dbContext)
        {
            this.DbContext = _dbContext;
        }

        // GET: Product
        /// <summary>
        ///     The index.
        /// </summary>
        /// <returns>
        ///     The <see cref="ActionResult" />.
        /// </returns>
        public ActionResult Index()
        {
            var listProduct = this.DbContext.Products;
            return this.View(listProduct);
        }

        // GET: Product/Details/5
        /// <summary>
        /// The details.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult Details(Guid id)
        {
            var item = this.DbContext.Products.FirstOrDefault(i => i.Id == id);
            return this.View(item);
        }

        // GET: Product/Create
        /// <summary>
        ///     The create.
        /// </summary>
        /// <returns>
        ///     The <see cref="ActionResult" />.
        /// </returns>
        public ActionResult Create()
        {
            return this.View();
        }

        // POST: Product/Create
        /// <summary>
        /// The create.
        /// </summary>
        /// <param name="collection">
        /// The collection.
        /// </param>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                return this.RedirectToAction("Index");
            }
            catch
            {
                return this.View();
            }
        }

        // GET: Product/Edit/5
        /// <summary>
        /// The edit.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult Edit(int id)
        {
            return this.View();
        }

        // POST: Product/Edit/5
        /// <summary>
        /// The edit.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <param name="collection">
        /// The collection.
        /// </param>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                return this.RedirectToAction("Index");
            }
            catch
            {
                return this.View();
            }
        }

        // GET: Product/Delete/5
        /// <summary>
        /// The delete.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult Delete(int id)
        {
            return this.View();
        }

        // POST: Product/Delete/5
        /// <summary>
        /// The delete.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <param name="collection">
        /// The collection.
        /// </param>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                return this.RedirectToAction("Index");
            }
            catch
            {
                return this.View();
            }
        }
    }
}