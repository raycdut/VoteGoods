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
    using System.Data.Entity;

    /// <summary>
    /// The vote goods models.
    /// </summary>
    public class VoteGoodsModels : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoteGoodsModels"/> class.
        /// </summary>
        public VoteGoodsModels()
            : base("name=DefaultConnection")
        {
        }
    }
}