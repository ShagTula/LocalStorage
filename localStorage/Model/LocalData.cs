using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace localStorage.Model
{
    //Текстовые данные которые надо
    //Хранить через интерфейс 
    //NoteWindow.cs (3-я секция)
    public class LocalData
    {
        public Guid Id { get; set; }
        public Guid LCategoryId { get; set; }
        public string Text { get; set; }
    }
}
