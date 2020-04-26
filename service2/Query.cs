using System.Collections.Generic;
using System.Linq;

namespace service2
{
    public class Query
    {
        public IEnumerable<Gadget> GetGadgets(int parentId) => Enumerable
            .Range(1, 3)
            .Select(n => new Gadget { Id = n, ParentId = parentId });
    }

    public class Gadget
    {
        public int ParentId { get; set; }
        public int Id { get; set; }
        public string Name() => $"Gadget {ParentId}/{Id}";
    }
}
