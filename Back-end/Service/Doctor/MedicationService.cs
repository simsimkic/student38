/***********************************************************************
 * Module:  MedicationService.cs
 * Purpose: Definition of the Class Service.Doctor.MedicationService
 ***********************************************************************/

using System;

namespace Service.Doctor
{
   public class MedicationService
   {
      public List<Medication> GetAllMedications()
      {
         // TODO: implement
         return null;
      }
      
      public List<Medication> GetAllMedicationForAdding()
      {
         // TODO: implement
         return null;
      }
      
      public Model.Doctor.Medication GetSpecificMedication(String medicationID)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean AddNewMedication(Model.Doctor.Medication medication)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean ChangeMedicationIngrediants(Model.Doctor.Medication medication)
      {
         // TODO: implement
         return null;
      }
      
      public void NotifyDoctorOfAddedMedication(Model.Doctor.Medication medication)
      {
         // TODO: implement
      }
      
      public MedicationService GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      public Repository.Doctor.MedicationRepository medicationRepository;
   
      private MedicationService Instance;
   
   }
}