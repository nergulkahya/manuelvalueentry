using Manuelvalueentry.Core.Models;
using Manuelvalueentry.Entity.Models;

namespace Manuelvalueentry.Core.Mapper
{
    public class Room_ParameterMapper
    {
        public static Room_Parameter MapToActiveRoom_Parameter(Room_ParameterModel _room_ParameterModel)
        {
            Room_Parameter _room_Parameter = new Room_Parameter();
            _room_Parameter.Id = _room_ParameterModel.Id;
            _room_Parameter.Parameter_Id = _room_ParameterModel.Parameter_Id;
            _room_Parameter.Room_Id = _room_ParameterModel.Room_Id;
            return _room_Parameter;
        }
        public static Room_ParameterModel MapToEntityRoom_Parameter(Room_Parameter _room_Parameter)
        {
            Room_ParameterModel _room_ParameterModel = new Room_ParameterModel();
            _room_ParameterModel.Id = _room_Parameter.Id;
            _room_ParameterModel.Parameter_Id = _room_Parameter.Parameter_Id;
            _room_ParameterModel.Room_Id = _room_Parameter.Room_Id;
            return _room_ParameterModel;
        }
    }
}
