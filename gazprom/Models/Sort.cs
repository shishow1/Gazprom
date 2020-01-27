using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gazprom.Models
{
    public class Sort
    {
        public string Field { get; set; }
        public bool IsDescending { get; set; }

        public Sort()
        {
            Field = "Id";
            IsDescending = false;
        }

        public Sort(string field, bool isDescending)
        {
            Field = field;
           IsDescending = isDescending;
        }
    }
}
