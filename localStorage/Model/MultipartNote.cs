using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace localStorage.Model
{
    //Записка
    public class MultipartNote
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool isPublic { get; set; }

        public Guid category { get; set; }
        public Guid[] viewers { get; set; }
        public Guid[] collaborators { get; set; }
        public Guid owner { get; set; }
        public Guid[] parts { get; set; }
        public dynamic hystory { get; set; }
    }
}
