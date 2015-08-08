// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VoteGoodsModels.cs" company="">
//
// </copyright>
// <summary>
//   The vote goods models.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace WWW.NEWBABA.COM.VoteGoods.Web.Models
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Data.Entity;
    using WWW.NEWBABA.COM.VoteGoods.Web.Models.VoteGoods;

    /// <summary>
    /// The vote goods models.
    /// </summary>
    public class VoteGoodsModels : IdentityDbContext<ApplicationUser>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoteGoodsModels"/> class.
        /// </summary>
        public VoteGoodsModels()
           : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        /// <summary>
        /// Gets or sets the product.
        /// </summary>
        public virtual DbSet<Product> Products { get; set; }

        /// <summary>
        /// The create.
        /// </summary>
        /// <returns>
        /// The <see cref="VoteGoodsModels"/>.
        /// </returns>
        public static VoteGoodsModels Create()
        {
            return new VoteGoodsModels();
        }
    }
}