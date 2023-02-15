using Manuelvalueentry.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manuelvalueentry.Database.Absract
{
    public interface IFactoryModelDal
    {
        List<FactoryModel> GetAllFactory();
        void AddFactory(FactoryModel factory);
        void UpdateFactory(FactoryModel factory);
        void DeleteFactory(FactoryModel factory);
        FactoryModel GetById(int id);

    }
}
