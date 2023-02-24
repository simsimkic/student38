/***********************************************************************
 * Module:  AppointmentsService.cs
 * Purpose: Definition of the Class Service.Secretary.AppointmentsService
 ***********************************************************************/

using System;

namespace Service.Secretary
{
   public class AppointmentsService
   {
      public Model.Secretary.Appointment AddAppointment(Model.Secretary.Appointment appointment)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean DeleteAppointment(Model.Secretary.Appointment appointment)
      {
         // TODO: implement
         return null;
      }
      
      public List<Patient> GetScheduledPatients(System.DateTime date, Model.Actors.Doctor doctor)
      {
         // TODO: implement
         return null;
      }
      
      public List<Patient> GetScheduledPatients(Boolean haveNote, Model.Actors.Doctor doctor)
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
      
      public List<Appointment> GetAllAppointments()
      {
         // TODO: implement
         return null;
      }
   
      public Repository.Secretary.AppointmentRepository appointmentRepository;
   
   }
}