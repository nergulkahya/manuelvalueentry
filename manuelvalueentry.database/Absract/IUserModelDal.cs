using Manuelvalueentry.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manuelvalueentry.Database.Absract
{
    public interface IUserModelDal
    {
        List<UserModel> GetAllUser();
        void AddUser(UserModel user);
        void UpdateUser(UserModel user);
        void DeleteUser(UserModel user);
        UserModel GetById(int id);
    }
}
