/***********************************************************************
 * Module:  MedicalRecordRepository.cs
 * Purpose: Definition of the Class Repository.Patient.MedicalRecordRepository
 ***********************************************************************/

using System;

namespace Repository.Patient
{
   public class MedicalRecordRepository
   {
      public List<Diagnosis> GetDiagnosis(String medicalRecordID)
      {
         // TODO: implement
         return null;
      }
      
      public List<Allergies> GetAllergies(String medicalRecordID)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Patient.PatientInfo GetPatientInfo(String medicalRecordID)
      {
         // TODO: implement
         return null;
      }
      
      public List<Examination> GetExaminations(String medicalRecordID)
      {
         // TODO: implement
         return null;
      }
      
      public List<Surgery> GetSurgeries(String medicalRecordID)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Patient.HealthInsurance GetHealthInsurance(String medicalRecordID)
      {
         // TODO: implement
         return null;
      }
      
      public List<Prescription> GetPrescription(String medicalRecordID)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Patient.MedicalRecord GetMedicalRecord(Model.Actors.Patient patient)
      {
         // TODO: implement
         return null;
      }
   
   }
}