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
    public class Parametre_HistoryModelManager : IParameter_HistoryModelService
    {
        Parameter_HistoryModelRepository _parameter_HistoryRepository;
        public Parametre_HistoryModelManager()
        {
            _parameter_HistoryRepository = new Parameter_HistoryModelRepository();
        }
        public void AddParameter_History(Parameter_HistoryModel parameter_History)
        {
            _parameter_HistoryRepository.AddParameter_History(parameter_History);
        }

        public void DeleteParameter_History(Parameter_HistoryModel parameter_History)
        {
            _parameter_HistoryRepository.DeleteParameter_History(parameter_History);
        }

        public List<Parameter_HistoryModel> GetAllList()
        {
            return _parameter_HistoryRepository.GetAllParameter_History();
        }

        public Parameter_HistoryModel GetById(int id)
        {
            return _parameter_HistoryRepository.GetById(id);
        }

        public void UpdateParameter_History(Parameter_HistoryModel parameter_History)
        {
            _parameter_HistoryRepository.UpdateParameter_History(parameter_History);
        }
    }
}
