using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using localStorage.Model;

namespace localStorage.Storage
{
    interface IDataBase
    {
        //Метод синглтона для получения
        //Экземпляра класса
        IDataBase Current();

        bool Login(string username,
                   string password);
        User GetCurrentUser();
        IEnumerable<User> GetAllUsers();

        IEnumerable<LocalRecord> GetLocalRecordsByUserId(Guid userid);
        IEnumerable<LocalCategory> GetFirstLevelCategoryesByLRecordId(Guid lRecordId);
        IEnumerable<LocalCategory> GetOtherLevelCategoryesByCategoryId(Guid lCategoryId);
        IEnumerable<LocalData> GetDataByLCategoryId(Guid categoryId);
        IEnumerable<LocalFile> GetFilesByDataId(Guid lDataId);
    }
}
