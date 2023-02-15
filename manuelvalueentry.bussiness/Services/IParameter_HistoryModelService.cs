using Manuelvalueentry.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manuelvalueentry.Bussiness.Services
{
    public interface IParameter_HistoryModelService
    {
        List<Parameter_HistoryModel> GetAllList();
        Parameter_HistoryModel GetById(int id);
        void AddParameter_History(Parameter_HistoryModel parameter_History);
        void UpdateParameter_History(Parameter_HistoryModel parameter_History);
        void DeleteParameter_History(Parameter_HistoryModel parameter_History);
    }
}
