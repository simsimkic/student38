/***********************************************************************
 * Module:  ValidationMedicationController.cs
 * Purpose: Definition of the Class Controller.Manager.ValidationMedicationController
 ***********************************************************************/

using System;

namespace Controller.Manager
{
   public class ValidationMedicationController
   {
      public Model.Doctor.Medication MedicationOnValidation(Model.Doctor.Medication medication)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Doctor.Medication IsMedicationCorrect(Model.Doctor.Medication medication)
      {
         // TODO: implement
         return null;
      }
      
      public ValidationMedicationController GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      public Service.Manager.ValidationMedicationService validationMedicationService;
   
      private ValidationMedicationController Instance;
   
   }
}