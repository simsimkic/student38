/***********************************************************************
 * Module:  Hospitalisation.cs
 * Purpose: Definition of the Class Patient.Hospitalisation
 ***********************************************************************/

using System;

namespace Model.Patient
{
   public class Hospitalisation : MedicalService
   {
      public Model.Manager.PatientRoom patientRoom;
   
      private DateTime DateOfRelease;
      private String CauseOfHospitalisation;
   
   }
}