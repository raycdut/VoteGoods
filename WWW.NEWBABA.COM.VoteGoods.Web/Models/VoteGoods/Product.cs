// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Goods.cs" company="WWW.NEWBABA.COM">
//
// </copyright>
// <summary>
//   The goods.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace WWW.NEWBABA.COM.VoteGoods.Web.Models.VoteGoods
{
    using System;

    /// <summary>
    /// The Product.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the manufactory.
        /// </summary>
        public string Manufactory { get; set; }

        /// <summary>
        /// Gets or sets the created date time.
        /// </summary>
        public DateTime CreatedDateTime { get; set; }

        /// <summary>
        /// Gets or sets the created by.
        /// </summary>
        //public virtual ApplicationUser CreatedBy { get; set; }
    }
}