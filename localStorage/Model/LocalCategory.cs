using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace localStorage.Model
{
    public class LocalCategory
    {
        public Guid id { get; set; }
        public Guid LRecordId { get; set; }
        public Guid ParentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
    }
}
