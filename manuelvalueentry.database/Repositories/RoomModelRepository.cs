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
    public class RoomModelRepository: IRoomModelDal
    {
        Context _context = null;
        public RoomModelRepository()
        {
            _context = new Context();
        }
        public void AddRoom(RoomModel room)
        {
            _context.Add(room);
            _context.SaveChanges();
        }
        public void DeleteRoom(RoomModel room)
        {
            _context.Remove(room);
            _context.SaveChanges();
        }
        public List<RoomModel> GetAllRoom()
        {
            List<RoomModel> _roomList = _context.Room.ToList();
            return _roomList;
        }
        public RoomModel GetById(int id)
        {
            RoomModel _room = _context.Room.Find(id);
            return _room;
        }
        public void UpdateRoom(RoomModel room)
        {
            _context.Update(room);//bu kısım hata verebilir
            _context.SaveChanges();
        }
    }
}
