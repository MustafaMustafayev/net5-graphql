using System;
using System.Threading.Tasks;
using graphql.DataContext;
using graphql.DTOs;
using graphql.Models;
using HotChocolate;
using HotChocolate.Data;

namespace graphql.Graphql
{
    public class Mutation
    {

        [UseDbContext(typeof(TestContext))]
        public async Task<ItemList> AddListAsync(ItemListToAddDTO item, [ScopedService] TestContext context)
        {
            ItemList itemList = new ItemList()
            {
                Name = item.Name
            };
            await context.ItemLists.AddAsync(itemList);
            await context.SaveChangesAsync();
            return itemList;
        }

        [UseDbContext(typeof(TestContext))]
        public async Task<ItemList> UpdateList(ItemListToUpdateDTO item, [ScopedService] TestContext context)
        {
            ItemList itemList = new ItemList()
            {
                Name = item.Name
            };
            await context.ItemLists.AddAsync(itemList);
            await context.SaveChangesAsync();
            return itemList;
        }
    }
}
