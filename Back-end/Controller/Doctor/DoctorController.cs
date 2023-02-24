/***********************************************************************
 * Module:  DoctorController.cs
 * Purpose: Definition of the Class Controller.Doctor.DoctorController
 ***********************************************************************/

using System;

namespace Controller.Doctor
{
   public class DoctorController
   {
      public List<Doctor> GetAllAvailableDoctorsByExamination(Model.Patient.Examination examination)
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
      
      public List<Doctor> GetAllDoctors()
      {
         // TODO: implement
         return null;
      }
      
      public List<Examinations> GetAllScheduledExaminationsByDoctor(Model.Actors.Doctor doctor)
      {
         // TODO: implement
         return null;
      }
      
      public DoctorController GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      public Service.Doctor.DoctorService doctorService;
      public Service.Doctor.MedicationService medicationService;
   
      private DoctorController Instance;
   
   }
}