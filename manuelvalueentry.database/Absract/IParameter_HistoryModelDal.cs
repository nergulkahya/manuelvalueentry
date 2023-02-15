using Manuelvalueentry.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manuelvalueentry.Database.Absract
{
    public interface IParameter_HistoryModelDal
    {
        List<Parameter_HistoryModel> GetAllParameter_History();
        void AddParameter_History(Parameter_HistoryModel parameter_history);
        void UpdateParameter_History(Parameter_HistoryModel parameter_history);
        void DeleteParameter_History(Parameter_HistoryModel parameter_history);
        Parameter_HistoryModel GetById(int id);
    }
}
