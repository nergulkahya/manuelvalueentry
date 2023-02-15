using Manuelvalueentry.Entity.Models;
using System;
using System.Collections.Generic;

namespace Manuelvalueentry.Bussiness.Services
{
    public interface IFactoryModelService
    {
        List<FactoryModel> GetAllList();
        FactoryModel GetById(int id);
        void AddFactory(FactoryModel factory);
        void UpdateFactory(FactoryModel factory);
        void DeleteFactory(FactoryModel factory);
    }
}
