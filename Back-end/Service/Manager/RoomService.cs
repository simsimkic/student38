/***********************************************************************
 * Module:  RoomService.cs
 * Purpose: Definition of the Class Service.RoomService
 ***********************************************************************/

using System;

namespace Service.Manager
{
   public class RoomService
   {
      public Room CreateRoom(Room room)
      {
         // TODO: implement
         return null;
      }
      
      public void DeleteRoom(String index)
      {
         // TODO: implement
      }
      
      public Model.Manager.RoomType AddRoomType(String name)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Manager.Equipment AddEquipment(String roomIndex, Model.Manager.Equipment equipment)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Manager.Room GetRoom(String roomIndex)
      {
         // TODO: implement
         return null;
      }
      
      public List<Room> GetAllRooms()
      {
         // TODO: implement
         return null;
      }
      
      public List<Room> GetFreeRooms()
      {
         // TODO: implement
         return null;
      }
   
      public Repository.Manager.RoomRepository roomRepository;
   
   }
}