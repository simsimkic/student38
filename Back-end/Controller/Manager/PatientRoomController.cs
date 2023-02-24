/***********************************************************************
 * Module:  PatientRoomController.cs
 * Purpose: Definition of the Class Controller.Manager.PatientRoomController
 ***********************************************************************/

using System;

namespace Controller.Manager
{
   public class PatientRoomController
   {
      public boolean AccommodatePatient(Model.Manager.Bed bed, Patient patient)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Manager.Bed EditBedCapacity(int capacity)
      {
         // TODO: implement
         return null;
      }
      
      public boolean ReleasePatient(Model.Manager.Bed bed)
      {
         // TODO: implement
         return null;
      }
      
      public PatientRoomController GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      public Service.Manager.PatientRoomService patientRoomService;
   
      private PatientRoomController Instance;
   
   }
}