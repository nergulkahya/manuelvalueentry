using Manuelvalueentry.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manuelvalueentry.Bussiness.Services
{
    public interface IRoom_ParameterModelService
    {
        List<Room_ParameterModel> GetAllList();
        Room_ParameterModel GetById(int id);
        void AddRoom_Parameter(Room_ParameterModel room_Parameter);
        void UpdateRoom_Parameter(Room_ParameterModel room_Parameter);
        void DeleteRoom_Parameter(Room_ParameterModel room_Parameter);
    }
}
