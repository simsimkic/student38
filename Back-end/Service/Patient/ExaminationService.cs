/***********************************************************************
 * Module:  ExaminationController.cs
 * Purpose: Definition of the Class Controller.Patient.ExaminationController
 ***********************************************************************/

using System;

namespace Service.Patient
{
   public class ExaminationService
   {
      public List<Examinations> GetAvailableExaminationsByDate(DateTime date)
      {
         // TODO: implement
         return null;
      }
      
      public List<Examinations> GetAvailableExaminationsFromDoctorByDate(Doctor doctor, DateTime date)
      {
         // TODO: implement
         return null;
      }
      
      public Examination ScheduleExamination_Doctor(Model.Actors.Doctor doctor, DateTime date)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean CancelExamination(Model.Patient.Examination examination)
      {
         // TODO: implement
         return null;
      }
   
      public Repository.Patient.ExaminationRepository examinationRepository;
   
   }
}