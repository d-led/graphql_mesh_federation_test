using System.Collections.Generic;
using System.Linq;

namespace service1
{
    public class Query
    {
        public IEnumerable<Widget> GetWidgets() => Enumerable
            .Range(1, 5)
            .Select(n => new Widget { Id = n });
    }

    public class Widget
    {
        public int Id { get; set; }
    }
}
