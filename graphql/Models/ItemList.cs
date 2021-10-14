using System;
using System.Collections.Generic;
using HotChocolate;

namespace graphql.Models
{
    [GraphQLDescription("ItemList table")]
    public class ItemList
    {
        public int Id { get; set; }
        [GraphQLDescription("ItemList name column")]
        public string Name { get; set; }
        public virtual List<ItemData> ItemDatas { get; set; }
    }
}
