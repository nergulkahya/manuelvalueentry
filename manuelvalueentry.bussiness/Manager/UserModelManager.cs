using Manuelvalueentry.Bussiness.Services;
using Manuelvalueentry.Database.Repositories;
using Manuelvalueentry.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manuelvalueentry.Bussiness.Manager
{
    public class UserModelManager : IUserModelService
    {
        UserModelRepository _userRepository;
        public UserModelManager(UserModelRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public void AddUser(UserModel user)
        {
            _userRepository.AddUser(user);
        }

        public void DeleteUser(UserModel user)
        {
            _userRepository.DeleteUser(user);
        }

        public List<UserModel> GetAllList()
        {
            return _userRepository.GetAllUser();
        }

        public UserModel GetById(int id)
        {
            return _userRepository.GetById(id);
        }

        public void UpdateUser(UserModel user)
        {
            _userRepository.UpdateUser(user);
        }
    }
}
