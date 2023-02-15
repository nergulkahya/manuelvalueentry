using Manuelvalueentry.Entity.Models;
using System.Collections.Generic;

namespace Manuelvalueentry.Bussiness.Services
{
    public interface IRoomModelService
    {
        List<RoomModel> GetAllList();
        RoomModel GetById(int id);
        void AddRoom(RoomModel room);
        void UpdateRoom(RoomModel room);
        void DeleteRoom(RoomModel room);
    }
}
