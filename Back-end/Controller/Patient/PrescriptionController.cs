/***********************************************************************
 * Module:  PrescriptionController.cs
 * Purpose: Definition of the Class Controller.Patient.PrescriptionController
 ***********************************************************************/

using System;

namespace Controller.Patient
{
   public class PrescriptionController
   {
      public Model.Doctor.Perscription RenewPrescription(Model.Doctor.Perscription perscription, Model.Actors.Patient patient)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Doctor.Perscription AddPrescription(Model.Actors.Patient patient, Medication medication, Model.Doctor.Diagnosis diagnosis, String howToUse, String note)
      {
         // TODO: implement
         return null;
      }
      
      public PrerscriptionController GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      public Service.Patient.PrescriptionService prescriptionService;
   
      private PrescriptionController Instance;
   
   }
}