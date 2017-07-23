using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace localStorage.Model
{
    //Категория Записей
    //Используется в интерфейсе
    //NoteWindow.cs
    //В первом listBox с ParentId = 0
    //И во втором с ParentId = id из первого listBox'а
    public class LocalCategory
    {
        public Guid id { get; set; }
        public Guid LRecordId { get; set; }
        public Guid ParentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
    }
}
