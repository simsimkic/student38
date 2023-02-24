/***********************************************************************
 * Module:  MedicalRecordController.cs
 * Purpose: Definition of the Class Controller.Patient.MedicalRecordController
 ***********************************************************************/

using System;

namespace Controller.Patient
{
   public class MedicalRecordController
   {
      public List<Diagnosis> GetDiagnosis(Model.Patient.MedicalRecord medicalRecord)
      {
         // TODO: implement
         return null;
      }
      
      public List<Allergies> GetAllergies(Model.Patient.MedicalRecord medicalRecord)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Patient.PatientInfo GetPatientInfo(Model.Patient.MedicalRecord medicalRecord)
      {
         // TODO: implement
         return null;
      }
      
      public List<Examination> GetExaminations(Model.Patient.MedicalRecord medicalRecord, Boolean performed)
      {
         // TODO: implement
         return null;
      }
      
      public List<Surgery> GetSurgeries(Model.Patient.MedicalRecord medicalRecord)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Patient.HealthInsurance GetHealthInsurance(Model.Patient.MedicalRecord medicalRecord)
      {
         // TODO: implement
         return null;
      }
      
      public List<Perscription> GetPerscription(Model.Patient.MedicalRecord medicalRecord)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Patient.MedicalRecord GetMedicalRecord(Model.Actors.Patient patient)
      {
         // TODO: implement
         return null;
      }
      
      public MedicalRecordController GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      public Service.Patient.MedicalRecordService medicalRecordService;
   
      private MedicalRecordController Instance;
   
   }
}