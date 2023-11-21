using HotelBookingSystem.Models;
using HotelBookingSystem.Models.DTOs;
using System.Collections.Generic;

namespace HotelBookingSystem.Interfaces
{
    public interface IRoomRepository
    {
        RoomDTO GetRoomById(int roomId);
        List<RoomDTO> GetRoomsByHotelId(int hotelId);
        void CreateRoom(RoomDTO room);
        void UpdateRoom(RoomDTO room);
        void DeleteRoom(int roomId);
    }
}