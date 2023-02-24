/***********************************************************************
 * Module:  AppointmentsController.cs
 * Purpose: Definition of the Class Controller.Secretary.AppointmentsController
 ***********************************************************************/

using System;

namespace Controller.Secretary
{
   public class AppointmentsController
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
      
      public List<Appointment> GetAvailableAppointments(Model.Manager.Room room, DateTime date)
      {
         // TODO: implement
         return null;
      }
      
      public AppointmentsController GetInstance()
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
   
      public Service.Secretary.AppointmentsService appointmentsService;
   
      private AppointmentsController Instance;
   
   }
}