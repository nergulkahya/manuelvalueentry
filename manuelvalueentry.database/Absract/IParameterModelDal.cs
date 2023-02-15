using Manuelvalueentry.Entity.Models;
using System.Collections.Generic;

namespace Manuelvalueentry.Database.Absract
{
    public interface IParameterModelDal
    {
        List<ParameterModel> GetAllParameter();
        void AddParameter(ParameterModel parameter);
        void UpdateParameter(ParameterModel parameter);
        void DeleteParameter(ParameterModel parameter);
        ParameterModel GetById(int id);
    }
}
