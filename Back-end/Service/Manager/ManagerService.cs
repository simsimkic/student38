/***********************************************************************
 * Module:  ManagerService.cs
 * Purpose: Definition of the Class Service.Doctor.ManagerService
 ***********************************************************************/

using System;

namespace Service.Manager
{
   public class ManagerService
   {
      public List<PatientRoom> GetPatientRoom()
      {
         // TODO: implement
         return null;
      }
      
      public List<Room> GetOperationRoom()
      {
         // TODO: implement
         return null;
      }
   
      public Repository.Manager.RoomRepository roomRepository;
      public Repository.Manager.PatientRoomRepository patientRoomRepository;
   
   }
}