using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace localStorage.Model
{
    //Модель хранения файлов
    //Пока нет реализации в UI
    public class LocalFile
    {
        public Guid Id;
        public Guid LDataId { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
    }
}
