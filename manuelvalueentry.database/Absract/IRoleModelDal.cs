using Manuelvalueentry.Entity.Models;
using System.Collections.Generic;

namespace Manuelvalueentry.Database.Absract
{
    public interface IRoleModelDal
    {
        List<RoleModel> GetAllRole();
        void AddRole(RoleModel role);
        void UpdateRole(RoleModel role);
        void DeleteRole(RoleModel role);
        RoleModel GetById(int id);
    }
}
