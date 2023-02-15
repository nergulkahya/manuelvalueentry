using Manuelvalueentry.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manuelvalueentry.Bussiness.Services
{
    public interface IParameterModelService
    {
        List<ParameterModel> GetAllParameter();
        ParameterModel GetById(int id);
        void AddParameter(ParameterModel parameter);
        void UpdateParameter(ParameterModel parameter);
        void DeleteParameter(ParameterModel parameter);

    }
}
