using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace localStorage.Model
{
    public class Category
    {
        public Guid id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Public { get; set; }
        public dynamic data { get; set; }
        public Guid Parent { get; set; }
        public Guid[] users { get; set; }
        public Guid creator { get; set; }//owner user
    }
}
