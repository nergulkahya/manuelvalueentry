using Manuelvalueentry.Bussiness.Services;
using Manuelvalueentry.Database.Repositories;
using Manuelvalueentry.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manuelvalueentry.Bussiness.Manager
{
    public class Room_ParameterModelManager : IRoom_ParameterModelService
    {
        Room_ParameterModelRepository _room_ParameterRepository;
        public Room_ParameterModelManager(Room_ParameterModelRepository room_ParameterRepository)
        {
            _room_ParameterRepository = room_ParameterRepository;
        }
        public void AddRoom_Parameter(Room_ParameterModel room_Parameter)
        {
            _room_ParameterRepository.AddRoom_Parameter(room_Parameter);
        }

        public void DeleteRoom_Parameter(Room_ParameterModel room_Parameter)
        {
            _room_ParameterRepository.DeleteRoom_Parameter(room_Parameter);
        }

        public List<Room_ParameterModel> GetAllList()
        {
            return _room_ParameterRepository.GetAll();
        }

        public Room_ParameterModel GetById(int id)
        {
            return _room_ParameterRepository.GetById(id);
        }

        public void UpdateRoom_Parameter(Room_ParameterModel room_Parameter)
        {
            _room_ParameterRepository.UpdateRoom_Parameter(room_Parameter);
        }
    }
}
