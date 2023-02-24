/***********************************************************************
 * Module:  GuestPatientsController.cs
 * Purpose: Definition of the Class Controller.Secretary.GuestPatientsController
 ***********************************************************************/

using System;

namespace Controller.Secretary
{
   public class GuestPatientsController
   {
      public Model.Secretary.GuestPatient AddGuestPatient(Model.Secretary.GuestPatient guestPatient)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean DeleteGuestPatient(Model.Secretary.GuestPatient guestPatient)
      {
         // TODO: implement
         return null;
      }
      
      public GuestPatientsController GetInstance()
      {
         // TODO: implement
         return null;
      }
      
      public Model.Secretary.GuestPatient GetGuestPatient(String jmbg)
      {
         // TODO: implement
         return null;
      }
      
      public List<GuestPatient> GetGuestPatients(String firstName, String lastName)
      {
         // TODO: implement
         return null;
      }
   
      public Service.Secretary.GuestPatientService guestPatientService;
   
      private GuestPatientsController Instance;
   
   }
}