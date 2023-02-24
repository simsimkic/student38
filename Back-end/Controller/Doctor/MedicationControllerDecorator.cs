/***********************************************************************
 * Module:  MedicationService.cs
 * Purpose: Definition of the Class Service.Doctor.MedicationService
 ***********************************************************************/

using System;

namespace Controller.Doctor
{
   public class MedicationControllerDecorator : DMedicationController
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
      
      public MedicationControllerDecorator GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      public DMedicationController dMedicationController;
      public Service.Doctor.MedicationService medicationService;
   
      private MedicationControllerDecorator Instance;
   
   }
}