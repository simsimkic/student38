/***********************************************************************
 * Module:  MedicalRecordController.cs
 * Purpose: Definition of the Class Controller.Patient.MedicalRecordController
 ***********************************************************************/

using System;

namespace Service.Patient
{
   public class MedicalRecordService
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
   
      public System.Collections.ArrayList medicalRecordRepository;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetMedicalRecordRepository()
      {
         if (medicalRecordRepository == null)
            medicalRecordRepository = new System.Collections.ArrayList();
         return medicalRecordRepository;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetMedicalRecordRepository(System.Collections.ArrayList newMedicalRecordRepository)
      {
         RemoveAllMedicalRecordRepository();
         foreach (Repository.Patient.MedicalRecordRepository oMedicalRecordRepository in newMedicalRecordRepository)
            AddMedicalRecordRepository(oMedicalRecordRepository);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddMedicalRecordRepository(Repository.Patient.MedicalRecordRepository newMedicalRecordRepository)
      {
         if (newMedicalRecordRepository == null)
            return;
         if (this.medicalRecordRepository == null)
            this.medicalRecordRepository = new System.Collections.ArrayList();
         if (!this.medicalRecordRepository.Contains(newMedicalRecordRepository))
            this.medicalRecordRepository.Add(newMedicalRecordRepository);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveMedicalRecordRepository(Repository.Patient.MedicalRecordRepository oldMedicalRecordRepository)
      {
         if (oldMedicalRecordRepository == null)
            return;
         if (this.medicalRecordRepository != null)
            if (this.medicalRecordRepository.Contains(oldMedicalRecordRepository))
               this.medicalRecordRepository.Remove(oldMedicalRecordRepository);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllMedicalRecordRepository()
      {
         if (medicalRecordRepository != null)
            medicalRecordRepository.Clear();
      }
   
   }
}