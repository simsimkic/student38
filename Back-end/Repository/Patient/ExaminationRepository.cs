/***********************************************************************
 * Module:  ExaminationRepository.cs
 * Purpose: Definition of the Class Repository.Patient.ExaminationRepository
 ***********************************************************************/

using System;

namespace Repository.Patient
{
   public class ExaminationRepository
   {
      public List<Examinations> GetAvailableExaminationsByDate(DateTime date)
      {
         // TODO: implement
         return null;
      }
      
      public List<Examinations> GetAvailableExaminationsFromDoctorByDate(String jmbg, DateTime date)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Patient.Examination SetExamination(Model.Patient.Examination examination)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean CancelExamination(String examinationID)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean AddExamination(Model.Patient.Examination examination)
      {
         // TODO: implement
         return null;
      }
   
   }
}