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
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string Phone { get; set; }
        public string AvatarUrl { get; set; }
        public DateTime Age { get; set; }

        //isFullInfo Флаг о том что
        //данные пользователя полные
        public bool isFullInfo { get; set; }
    }
}
