/***********************************************************************
 * Module:  SecretaryRepository.cs
 * Purpose: Definition of the Class Repository.Manager.SecretaryRepository
 ***********************************************************************/

using System;

namespace Repository.Secretary
{
   public class AppointmentRepository
   {
      public Boolean DeleteAppointment(Model.Secretary.Appointment appointment)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Secretary.Appointment AddAppointment(Model.Secretary.Appointment appointment)
      {
         // TODO: implement
         return null;
      }
      
      public List<Appointment> GetAllAppointments()
      {
         // TODO: implement
         return null;
      }
      
      public List<Appointment> GetAppointments(Model.Actors.Doctor doctor, DateTime dateTime)
      {
         // TODO: implement
         return null;
      }
      
      public List<Appointment> GetAppointments(Model.Manager.Room room, System.DateTime dateTime)
      {
         // TODO: implement
         return null;
      }
   
      private String Path;
   
   }
}