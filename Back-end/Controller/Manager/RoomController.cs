/***********************************************************************
 * Module:  RoomController.cs
 * Purpose: Definition of the Class Controller.Manager.RoomController
 ***********************************************************************/

using System;

namespace Controller.Manager
{
   public class RoomController
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
      
      public List<Room> GetFreeRooms()
      {
         // TODO: implement
         return null;
      }
      
      public RoomController GetInstance()
      {
         // TODO: implement
         return null;
      }
      
      public List<Room> GetAllRooms()
      {
         // TODO: implement
         return null;
      }
   
      public Service.Manager.RoomService roomService;
   
      private RoomController Instance;
   
   }
}