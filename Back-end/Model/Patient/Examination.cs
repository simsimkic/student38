/***********************************************************************
 * Module:  Examination.cs
 * Purpose: Definition of the Class Patient.Examination
 ***********************************************************************/

using System;

namespace Model.Patient
{
   public class Examination : MedicalService
   {
      public Model.Doctor.Report report;
      public MedicalRecord medicalRecord;
   
      private Boolean Performed;
      private String Type;
      private String ExaminationID;
   
   }
}