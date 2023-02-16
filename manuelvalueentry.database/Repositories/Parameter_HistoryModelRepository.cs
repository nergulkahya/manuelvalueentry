using Manuelvalueentry.Database.Absract;
using Manuelvalueentry.Database.Data;
using Manuelvalueentry.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manuelvalueentry.Database.Repositories
{
    public class Parameter_HistoryModelRepository : IParameter_HistoryModelDal
    {
        Context _context = null;
        public Parameter_HistoryModelRepository()
        {
            _context = new Context();
        }
        public void AddParameter_History(Parameter_HistoryModel parameter_history)
        {
            _context.Add(parameter_history);
            _context.SaveChanges();
        }
        public void DeleteParameter_History(Parameter_HistoryModel parameter_history)
        {
            _context.Remove(parameter_history);
            _context.SaveChanges();
        }
        public List<Parameter_HistoryModel> GetAllParameter_History()
        {
            List<Parameter_HistoryModel> _parameter_historyList = _context.Parameter_History.ToList();
            return _parameter_historyList;
        }
        public Parameter_HistoryModel GetById(int id)
        {
            Parameter_HistoryModel _parameter_history = _context.Parameter_History.Find(id);
            return _parameter_history;
        }
        public void UpdateParameter_History(Parameter_HistoryModel parameter_history)
        {
            _context.Update(parameter_history);
            _context.SaveChanges();
        }
    }
}
