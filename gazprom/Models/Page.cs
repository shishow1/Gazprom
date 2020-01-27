using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gazprom.Models
{
    public class Page<T> where T: class
    {
        public Filter Filter { get; set; }
        public string Sort { get; set; }
        public List<T> Items { get; set; }
        public Pagination Pagination { get; set; }

        public Page(Filter filter, string sort, List<T> items)
        {
            Filter = filter;
            Sort = sort;
            Items = items;
        }

        public Page(List<T> items)
        {
            Filter = new Filter();
            Sort = "Id";
            Items = items;
        }

        public Page() { }
    }
}
