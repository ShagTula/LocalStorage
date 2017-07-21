using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace localStorage.Model
{
    public class User
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public dynamic data { get; set; }

        public Guid infoStatus { get; set; }
        public Guid chatStatus { get; set; }
        public Guid privateStatus { get; set; }
    }
}
