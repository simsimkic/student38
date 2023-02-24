/***********************************************************************
 * Module:  DMedicationController.cs
 * Purpose: Definition of the Interface Controller.Doctor.DMedicationController
 ***********************************************************************/

using System;

namespace Controller.Doctor
{
   public interface DMedicationController
   {
      Model.Doctor.Medication AddNewMedication(Model.Doctor.Medication medication);
   }
}