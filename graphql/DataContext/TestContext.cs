using System;
using graphql.Models;
using Microsoft.EntityFrameworkCore;

namespace graphql.DataContext
{
    public class TestContext : DbContext
    {
        public TestContext(DbContextOptions<TestContext> options) : base(options)
        {
        }

        public DbSet<ItemList> ItemLists { get; set; }
        public DbSet<ItemData> ItemDatas { get; set; }
    }
}
