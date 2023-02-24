/***********************************************************************
 * Module:  DoctorService.cs
 * Purpose: Definition of the Class Service.Doctor.DoctorService
 ***********************************************************************/

using System;

namespace Service.Doctor
{
   public class DoctorService
   {
      public List<Doctor> GetAllAvailableDoctorsByExamination(Examination examination)
      {
         // TODO: implement
         return null;
      }
      
      public List<Doctor> GetAllAvailableDoctorsByDate(DateTime date)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean ExaminatePatient(Model.Patient.Examination examination)
      {
         // TODO: implement
         return null;
      }
      
      public void ApproveNewMedication()
      {
         // TODO: implement
      }
      
      public Boolean ChangeAppoitmentForExamination()
      {
         // TODO: implement
         return null;
      }
      
      public Boolean ChangeAppoitmentForOperation()
      {
         // TODO: implement
         return null;
      }
      
      public void LookForPatientsWithNote()
      {
         // TODO: implement
      }
      
      public Model.Actors.Doctor AddDoctor(Model.Actors.Doctor doctor)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Actors.Doctor EditDoctor(Model.Actors.Doctor doctor)
      {
         // TODO: implement
         return null;
      }
      
      public void DeleteDoctor(String jmbg)
      {
         // TODO: implement
      }
      
      public Model.Actors.Doctor SearchDoctor(String name, String surname, Model.Actors.Position position)
      {
         // TODO: implement
         return null;
      }
      
      public List<Doctor> GetAllDoctors()
      {
         // TODO: implement
         return null;
      }
      
      public List<Examination> GetAllScheduledExaminationsByDoctor(Model.Actors.Doctor doctor)
      {
         // TODO: implement
         return null;
      }
   
      public Repository.Doctor.DoctorRepository doctorRepository;
      public Repository.Patient.ExaminationRepository examinationRepository;
      public Repository.Secretary.AppointmentRepository appointmentRepository;
   
   }
}