using Manuelvalueentry.Core.Models;
using Manuelvalueentry.Entity.Models;

namespace Manuelvalueentry.Core.Mapper
{
    public class RoomMapper
    {
        public static Room MapToActiveRoom(RoomModel _roomModel)
        {
            Room _room = new Room();
            _room.Id = _roomModel.Id;
            _room.Name = _roomModel.Name;
            _room.Factory_Id = _roomModel.Factory_Id;
            return _room;
        }
        public static RoomModel MapToEntityRoom(Room _room)
        {
            RoomModel _factoryModel = new RoomModel();
            _factoryModel.Id = _room.Id;
            _factoryModel.Name = _room.Name;
            _factoryModel.Factory_Id = _room.Factory_Id;
            return _factoryModel;
        }
    }
}
