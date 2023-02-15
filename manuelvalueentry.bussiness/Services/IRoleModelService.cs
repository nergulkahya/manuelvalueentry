using Manuelvalueentry.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manuelvalueentry.Bussiness.Services
{
    public interface IRoleModelService
    {
        List<RoleModel> GetAllList();
        RoleModel GetById(int id);
        void AddRole(RoleModel role);
        void UpdateRole(RoleModel role);
        void DeleteRole(RoleModel role);
    }
}
