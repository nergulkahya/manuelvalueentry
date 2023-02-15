using Manuelvalueentry.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manuelvalueentry.Database.Absract
{
    public interface IRoomModelDal
    {
        List<RoomModel> GetAllRoom();
        void AddRoom(RoomModel room);
        void UpdateRoom(RoomModel room);
        void DeleteRoom(RoomModel room);
        RoomModel GetById(int id);
    }
}
