/***********************************************************************
 * Module:  DoctorRepository.cs
 * Purpose: Definition of the Class Repository.Manager.DoctorRepository
 ***********************************************************************/

using System;

namespace Repository.Doctor
{
   public class DoctorRepository
   {
      public List<Doctor> GetAllAvailableDoctorsByExamination(String examinationID)
      {
         // TODO: implement
         return null;
      }
      
      public List<Doctor> GetAllAvailableDoctorsByDate(DateTime date)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Actors.Doctor SearchDoctor(String name, String surname, Model.Actors.Position position)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Actors.Doctor GetDoctor(Model.Actors.Doctor doctor)
      {
         // TODO: implement
         return null;
      }
      
      public List<Doctor> GetAllDoctors()
      {
         // TODO: implement
         return null;
      }
      
      public Model.Actors.Doctor SetDoctor(Model.Actors.Doctor doctor)
      {
         // TODO: implement
         return null;
      }
      
      public void DeleteDoctor(String doctorID)
      {
         // TODO: implement
      }
      
      public List<Examination> GetAllScheduledExaminationsByDoctor(String jmbg)
      {
         // TODO: implement
         return null;
      }
   
      private List<Doctor> Doctors;
   
   }
}