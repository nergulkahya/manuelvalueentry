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
    public class FactoryModelManager : IFactoryModelService
    {
        FactoryModelRepository _factoryRepository =null;
        public FactoryModelManager()
        {
            _factoryRepository = new FactoryModelRepository();
        }

        public void AddFactory(FactoryModel factory)
        {
            _factoryRepository.AddFactory(factory);
        }

        public void DeleteFactory(FactoryModel factory)
        {
            _factoryRepository.DeleteFactory(factory);
        }

        public List<FactoryModel> GetAllList()
        {
            return _factoryRepository.GetAllFactory();
        }

        public FactoryModel GetById(int id)
        {
            FactoryModel _factory = _factoryRepository.GetById(id);
            return _factory;
        }

        public void UpdateFactory(FactoryModel factory)
        {
            _factoryRepository.UpdateFactory(factory);
        }
    }
}
