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
    public class ParameterModelManager:IParameterModelService
    {
        ParameterModelRepository _parameterRepository =null;
        public ParameterModelManager()
        {
            _parameterRepository = new ParameterModelRepository();
        }

        public void AddParameter(ParameterModel parameter)
        {
            _parameterRepository.AddParameter(parameter);
        }

        public void DeleteParameter(ParameterModel parameter)
        {
            _parameterRepository.DeleteParameter(parameter);
        }

        public List<ParameterModel> GetAllParameter()
        {
            return _parameterRepository.GetAllParameter();
        }

        public ParameterModel GetById(int id)
        {
            return _parameterRepository.GetById(id);
        }

        public void UpdateParameter(ParameterModel parameter)
        {
            _parameterRepository.UpdateParameter(parameter);
        }
    }
}
