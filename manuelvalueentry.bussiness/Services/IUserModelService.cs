using Manuelvalueentry.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manuelvalueentry.Bussiness.Services
{
    public interface IUserModelService
    {
        List<UserModel> GetAllList();
        UserModel GetById(int id);
        void AddUser(UserModel user);
        void UpdateUser(UserModel user);
        void DeleteUser(UserModel user);
    }
}
