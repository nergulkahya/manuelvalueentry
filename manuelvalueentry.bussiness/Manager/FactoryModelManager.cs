using Manuelvalueentry.Bussiness.Services;
using Manuelvalueentry.Database.Absract;
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
        IFactoryModelDal _factoryDal =null;
        public FactoryModelManager(IFactoryModelDal factoryDal)
        {
            _factoryDal = factoryDal;
        }

        public void AddFactory(FactoryModel factory)
        {
            if (factory !=null)
            {
                _factoryDal.AddFactory(factory);
            }
        }
        public void DeleteFactory(FactoryModel factory)
        {
            _factoryDal.DeleteFactory(factory);
        }

        public List<FactoryModel> GetAllList()
        {
            return _factoryDal.GetAllFactory();
        }

        public FactoryModel GetById(int id)
        {
            FactoryModel _factory = _factoryDal.GetById(id);
            return _factory;
        }

        public void UpdateFactory(FactoryModel factory)
        {
            _factoryDal.UpdateFactory(factory);
        }
    }
}
