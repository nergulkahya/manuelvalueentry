using Manuelvalueentry.Database.Absract;
using Manuelvalueentry.Database.Data;
using Manuelvalueentry.Entity.Models;
using System.Collections.Generic;
using System.Linq;

namespace Manuelvalueentry.Database.Repositories
{
    public class Room_ParameterModelRepository : IRoom_ParameterModelDal
    {
        Context _context = null;
        public Room_ParameterModelRepository()
        {
            _context = new Context();
        }
        public void AddRoom_Parameter(Room_ParameterModel room_parameter)
        {
            _context.Add(room_parameter);
            _context.SaveChanges();
        }
        public void DeleteRoom_Parameter(Room_ParameterModel room_parameter)
        {
            _context.Remove(room_parameter);
            _context.SaveChanges();
        }
        public List<Room_ParameterModel> GetAll()
        {
            List<Room_ParameterModel> _room_parameterList = _context.Room_ParameterModels.ToList();
            return _room_parameterList;
        }
        public Room_ParameterModel GetById(int id)
        {
            Room_ParameterModel _room_parameter = _context.Room_ParameterModels.Find(id);
            return _room_parameter;
        }
        public void UpdateRoom_Parameter(Room_ParameterModel room_parameter)
        {
            _context.Update(room_parameter);
            _context.SaveChanges();
        }
    }
}
