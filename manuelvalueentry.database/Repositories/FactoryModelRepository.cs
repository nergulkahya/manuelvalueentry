using Manuelvalueentry.Database.Absract;
using Manuelvalueentry.Database.Data;
using Manuelvalueentry.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manuelvalueentry.Database.Repositories
{
    public class FactoryModelRepository : IFactoryModelDal
    {
        Context _context = null;
        public FactoryModelRepository()
        {
            _context = new Context();        }
        public void AddFactory(FactoryModel factory)
        {
            _context.Add(factory);
            _context.SaveChanges();
        }
        public void DeleteFactory(FactoryModel factory)
        {
            _context.Remove(factory);
            _context.SaveChanges();
        }
        public List<FactoryModel> GetAllFactory()
        {
            return _context.FactoryModels.ToList();
        }

        public FactoryModel GetById(int id)
        {
            return _context.FactoryModels.Find(id);
        }
        public void UpdateFactory(FactoryModel factory)
        {
            _context.Entry(factory).State =EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
