using Manuelvalueentry.Database.Absract;
using Manuelvalueentry.Database.Data;
using Manuelvalueentry.Entity.Models;
using System.Collections.Generic;
using System.Linq;

namespace Manuelvalueentry.Database.Repositories
{
    public class ParameterModelRepository : IParameterModelDal
    {
        Context _context = null;
        public ParameterModelRepository()
        {
            _context = new Context();
        }
        public void AddParameter(ParameterModel parameter)
        {
            _context.Add(parameter);
            _context.SaveChanges();
        }
        public void DeleteParameter(ParameterModel parameter)
        {
            _context.Remove(parameter);
            _context.SaveChanges();
        }
        public List<ParameterModel> GetAllParameter()
        {
            List<ParameterModel> _parameterList = _context.ParameterModels.ToList();
            return _parameterList;
        }
        public ParameterModel GetById(int id)
        {
            ParameterModel _paramater = _context.ParameterModels.Find(id);
            return _paramater;
        }
        public void UpdateParameter(ParameterModel parameter)
        {
            _context.Update(parameter);
            _context.SaveChanges();
        }
    }
}
