/***********************************************************************
 * Module:  MedicalRecord.cs
 * Purpose: Definition of the Class Patient.MedicalRecord
 ***********************************************************************/

using System;

namespace Model.Patient
{
   public class MedicalRecord
   {
      public HealthInsurance healthInsurance;
      public Examination[] examination;
      public Surgery[] surgery;
      public System.Collections.ArrayList allergies;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetAllergies()
      {
         if (allergies == null)
            allergies = new System.Collections.ArrayList();
         return allergies;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetAllergies(System.Collections.ArrayList newAllergies)
      {
         RemoveAllAllergies();
         foreach (Allergies oAllergies in newAllergies)
            AddAllergies(oAllergies);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddAllergies(Allergies newAllergies)
      {
         if (newAllergies == null)
            return;
         if (this.allergies == null)
            this.allergies = new System.Collections.ArrayList();
         if (!this.allergies.Contains(newAllergies))
            this.allergies.Add(newAllergies);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveAllergies(Allergies oldAllergies)
      {
         if (oldAllergies == null)
            return;
         if (this.allergies != null)
            if (this.allergies.Contains(oldAllergies))
               this.allergies.Remove(oldAllergies);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllAllergies()
      {
         if (allergies != null)
            allergies.Clear();
      }
      public PatientInfo patientInfo;
      public System.Collections.ArrayList diagnosis;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetDiagnosis()
      {
         if (diagnosis == null)
            diagnosis = new System.Collections.ArrayList();
         return diagnosis;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetDiagnosis(System.Collections.ArrayList newDiagnosis)
      {
         RemoveAllDiagnosis();
         foreach (Model.Doctor.Diagnosis oDiagnosis in newDiagnosis)
            AddDiagnosis(oDiagnosis);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddDiagnosis(Model.Doctor.Diagnosis newDiagnosis)
      {
         if (newDiagnosis == null)
            return;
         if (this.diagnosis == null)
            this.diagnosis = new System.Collections.ArrayList();
         if (!this.diagnosis.Contains(newDiagnosis))
            this.diagnosis.Add(newDiagnosis);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveDiagnosis(Model.Doctor.Diagnosis oldDiagnosis)
      {
         if (oldDiagnosis == null)
            return;
         if (this.diagnosis != null)
            if (this.diagnosis.Contains(oldDiagnosis))
               this.diagnosis.Remove(oldDiagnosis);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllDiagnosis()
      {
         if (diagnosis != null)
            diagnosis.Clear();
      }
      public System.Collections.ArrayList perscription;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetPerscription()
      {
         if (perscription == null)
            perscription = new System.Collections.ArrayList();
         return perscription;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetPerscription(System.Collections.ArrayList newPerscription)
      {
         RemoveAllPerscription();
         foreach (Model.Doctor.Perscription oPerscription in newPerscription)
            AddPerscription(oPerscription);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddPerscription(Model.Doctor.Perscription newPerscription)
      {
         if (newPerscription == null)
            return;
         if (this.perscription == null)
            this.perscription = new System.Collections.ArrayList();
         if (!this.perscription.Contains(newPerscription))
            this.perscription.Add(newPerscription);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemovePerscription(Model.Doctor.Perscription oldPerscription)
      {
         if (oldPerscription == null)
            return;
         if (this.perscription != null)
            if (this.perscription.Contains(oldPerscription))
               this.perscription.Remove(oldPerscription);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllPerscription()
      {
         if (perscription != null)
            perscription.Clear();
      }
   
      private String MedicalRecordID;
   
   }
}