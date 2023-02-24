/***********************************************************************
 * Module:  MedicationController.cs
 * Purpose: Definition of the Class Controller.Doctor.MedicationController
 ***********************************************************************/

using System;

namespace Controller.Doctor
{
   public class MedicationController : DMedicationController
   {
      public MedicationController GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      public Service.Doctor.MedicationService medicationService;
   
      private MedicationController Instance;
   
   }
}