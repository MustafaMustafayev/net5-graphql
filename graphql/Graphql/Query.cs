using System;
using System.Collections.Generic;
using System.Linq;
using graphql.DataContext;
using graphql.Models;
using HotChocolate;
using HotChocolate.Data;

namespace graphql.Graphql
{
    public class Query
    {
        [UseDbContext(typeof(TestContext))]
        [UseProjection]
        [UseSorting]
        [UseFiltering]
        public IQueryable<ItemList> GetLists([ScopedService] TestContext context)
        {
            return context.ItemLists;
        }

        [UseDbContext(typeof(TestContext))]
        [UseProjection]
        [UseSorting]
        [UseFiltering]
        public IQueryable<ItemData> GetDatas([ScopedService] TestContext context)
        {
            return context.ItemDatas;
        }

        [UseDbContext(typeof(TestContext))]
        [UseProjection]
        [UseSorting]
        [UseFiltering]
        public ItemList GetFirstItem([ScopedService] TestContext context)
        {
            return context.ItemLists.FirstOrDefault();
        }

        [UseDbContext(typeof(TestContext))]
        [UseProjection]
        [UseSorting]
        [UseFiltering]
        public IQueryable<ItemData> GetIsDone([ScopedService] TestContext context)
        {
            return context.ItemDatas.Where(m => m.IsDone);
        }
    }
}
