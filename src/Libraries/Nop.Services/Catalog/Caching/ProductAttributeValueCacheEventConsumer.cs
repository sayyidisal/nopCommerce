﻿using Nop.Core.Domain.Catalog;
using Nop.Services.Caching;

namespace Nop.Services.Catalog.Caching
{
    /// <summary>
    /// Represents a product attribute value cache event consumer
    /// </summary>
    public partial class ProductAttributeValueCacheEventConsumer : CacheEventConsumer<ProductAttributeValue>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        /// <param name="entityEventType">Entity event type</param>
        protected override void ClearCache(ProductAttributeValue entity, EntityEventType entityEventType)
        {
            Remove(NopCatalogDefaults.ProductAttributeValuesByAttributeCacheKey, entity.ProductAttributeMappingId);

            base.ClearCache(entity, entityEventType);
        }
    }
}
