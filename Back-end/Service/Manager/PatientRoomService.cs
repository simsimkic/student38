/***********************************************************************
 * Module:  PatientRoomService.cs
 * Purpose: Definition of the Class Service.Manager.PatientRoomService
 ***********************************************************************/

using System;

namespace Service.Manager
{
   public class PatientRoomService
   {
      public boolean AccommodatePatient(Model.Manager.Bed bed, Patient patient)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Manager.PatientRoom EditRoomCapacity(int capacity)
      {
         // TODO: implement
         return null;
      }
      
      public boolean ReleasePatient(Model.Manager.Bed bed, Patient patient)
      {
         // TODO: implement
         return null;
      }
   
      public Repository.Manager.PatientRoomRepository patientRoomRepository;
   
   }
}