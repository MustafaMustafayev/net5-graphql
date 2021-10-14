using System;
using graphql.Models;
using graphql.DataContext;
using HotChocolate.Types;
using System.Linq;
using HotChocolate;

namespace graphql.Graphql.DataItem
{
    public class ItemType : ObjectType<ItemData>
    {
        // since we are inheriting from objtype we need to override the functionality
        protected override void Configure(IObjectTypeDescriptor<ItemData> descriptor)
        {
            descriptor.Description("Used to group the do list item into groups");

            //descriptor.Field(x => x.ItemList).Ignore();

            descriptor.Field(x => x.ItemList)
                        .ResolveWith<Resolvers>(p => p.GetItems(default!, default!))
                        .UseDbContext<TestContext>()
                        .Description("This is the list of to do item available for this list");
        }

        private class Resolvers
        {
            public IQueryable<ItemData> GetItems(ItemList list, [ScopedService] TestContext context)
            {
                return context.ItemDatas.Where(x => x.ItemListId == list.Id);
            }
        }
    }
}
