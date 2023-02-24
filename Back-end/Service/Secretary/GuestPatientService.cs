/***********************************************************************
 * Module:  AppointmentsService.cs
 * Purpose: Definition of the Class Service.Secretary.AppointmentsService
 ***********************************************************************/

using System;

namespace Service.Secretary
{
   public class GuestPatientService
   {
      public Model.Secretary.GuestPatient AddGuestPatient(Model.Secretary.Appointment appointment)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean DeleteGuestPatient(Model.Secretary.GuestPatient guestPatient)
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
   
      public Repository.Secretary.GuestPatientRepository guestPatientRepository;
   
   }
}