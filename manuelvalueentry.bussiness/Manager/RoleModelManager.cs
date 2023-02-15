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
    public class RoleModelManager:IRoleModelService
    {
        RoleModelRepository _roleRepository;
        public RoleModelManager(RoleModelRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public void AddRole(RoleModel role)
        {
            _roleRepository.AddRole(role);
        }

        public void DeleteRole(RoleModel role)
        {
            _roleRepository.DeleteRole(role);
        }

        public List<RoleModel> GetAllList()
        {
            return _roleRepository.GetAllRole();
        }

        public RoleModel GetById(int id)
        {
            return _roleRepository.GetById(id);
        }

        public void UpdateRole(RoleModel role)
        {
            _roleRepository.UpdateRole(role);
        }
    }
}
