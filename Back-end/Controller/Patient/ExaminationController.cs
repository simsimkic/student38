/***********************************************************************
 * Module:  ExaminationController.cs
 * Purpose: Definition of the Class Controller.Patient.ExaminationController
 ***********************************************************************/

using System;

namespace Controller.Patient
{
   public class ExaminationController
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
      
      public ExaminationController GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      public Service.Patient.ExaminationService examinationService;
   
      private ExaminationController Instance;
   
   }
}