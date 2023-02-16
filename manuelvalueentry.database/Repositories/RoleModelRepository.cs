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
    public class RoleModelRepository : IRoleModelDal
    {
        Context _context = null;
        public RoleModelRepository()
        {
            _context = new Context();
        }
        public void AddRole(RoleModel role)
        {
            _context.Add(role);
            _context.SaveChanges();
        }

        public void DeleteRole(RoleModel role)
        {
            _context.Remove(role);
            _context.SaveChanges();
        }
        public List<RoleModel> GetAllRole()
        {
            List<RoleModel> _roleList = _context.Role.ToList();
            return _roleList;
        }
        public RoleModel GetById(int id)
        {
            RoleModel _role = _context.Role.Find(id);
            return _role;
        }
        public void UpdateRole(RoleModel role)
        {
            _context.Update(role);
            _context.SaveChanges();
        }
    }
}
