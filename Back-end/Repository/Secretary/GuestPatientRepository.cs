/***********************************************************************
 * Module:  SecretaryRepository.cs
 * Purpose: Definition of the Class Repository.Manager.SecretaryRepository
 ***********************************************************************/

using System;

namespace Repository.Secretary
{
   public class GuestPatientRepository
   {
      public Model.Secretary.GuestPatient AddGuestPatient(Model.Secretary.GuestPatient guestPatient)
      {
         // TODO: implement
         return null;
      }
      
      public List<GuestPatient> GetGuestPatients(String firstName, String lastName)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Secretary.GuestPatient GetGuestPatient(String jmbg)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean DeleteGuestPatient(Model.Secretary.GuestPatient guestPatient)
      {
         // TODO: implement
         return null;
      }
      
      public List<GuestPatient> GetAllGuestPatients()
      {
         // TODO: implement
         return null;
      }
   
      private String Path;
   
   }
}