using Manuelvalueentry.Database.Absract;
using Manuelvalueentry.Database.Data;
using Manuelvalueentry.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manuelvalueentry.Database.Repositories
{
    public class UserModelRepository : IUserModelDal
    {
        Context _context = null;
        public UserModelRepository()
        {
            _context = new Context();
        }
        public void AddUser(UserModel user)
        {
            _context.Add(user);
            _context.SaveChanges();
        }
        public void DeleteUser(UserModel user)
        {
            _context.Remove(user);
            _context.SaveChanges();
        }
        public List<UserModel> GetAllUser()
        {
            List<UserModel> _userList = _context.UserModels.ToList();
            return _userList;
        }
        public UserModel GetById(int id)
        {
            UserModel _user = _context.UserModels.Find(id);
            return _user;
        }
        public void UpdateUser(UserModel user)
        {
            _context.Update(user);
            _context.SaveChanges();
        }
    }
}
