using System;
using HotChocolate;

namespace graphql.Models
{
    [GraphQLDescription("ItemData table")]
    public class ItemData
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }
        public virtual ItemList ItemList { get; set; }
        public int ItemListId { get; set; }
    }
}
