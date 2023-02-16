using Manuelvalueentry.Core.Models;
using Manuelvalueentry.Entity.Models;

namespace Manuelvalueentry.Core.Mapper
{
    public class RoleMapper
    {
        public static Role MapToActiveRole(RoleModel _roleModel)
        {
            Role _role = new Role();
            _role.Id = _roleModel.Id;
            _role.Name = _roleModel.Name;
            return _role;
        }
        public static RoleModel MapToEntityRole(Role _role)
        {
            RoleModel _roleModel = new RoleModel();
            _roleModel.Id = _role.Id;
            _roleModel.Name = _role.Name;
            return _roleModel;
        }
    }
}
