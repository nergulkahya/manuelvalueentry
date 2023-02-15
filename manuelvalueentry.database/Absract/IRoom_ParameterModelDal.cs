using Manuelvalueentry.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manuelvalueentry.Database.Absract
{
    public interface IRoom_ParameterModelDal
    {
        List<Room_ParameterModel> GetAll();
        void AddRoom_Parameter(Room_ParameterModel room_parameter);
        void UpdateRoom_Parameter(Room_ParameterModel room_parameter);
        void DeleteRoom_Parameter(Room_ParameterModel room_parameter);
        Room_ParameterModel GetById(int id);
    }
}
