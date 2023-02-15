using Manuelvalueentry.Bussiness.Services;
using Manuelvalueentry.Database.Repositories;
using Manuelvalueentry.Entity.Models;
using System;
using System.Collections.Generic;

namespace Manuelvalueentry.Bussiness.Manager
{
    public class RoomModelManager : IRoomModelService
    {
        RoomModelRepository _roomRepository;
        public RoomModelManager(RoomModelRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }
        public void AddRoom(RoomModel room)
        {
            _roomRepository.AddRoom(room);
        }

        public void DeleteRoom(RoomModel room)
        {
            _roomRepository.DeleteRoom(room);
        }

        public List<RoomModel> GetAllList()
        {
            return _roomRepository.GetAllRoom();
        }

        public RoomModel GetById(int id)
        {
            return _roomRepository.GetById(id);
        }

        public void UpdateRoom(RoomModel room)
        {
            _roomRepository.UpdateRoom(room);
        }
    }
}
