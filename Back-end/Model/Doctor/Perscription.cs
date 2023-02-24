/***********************************************************************
 * Module:  Perscription.cs
 * Purpose: Definition of the Class Patient.Perscription
 ***********************************************************************/

using System;

namespace Model.Doctor
{
   public class Perscription
   {
      public Medication medication;
      public Model.Actors.Doctor doctor;
      public Diagnosis diagnosis;
   
      private String DescriptionOfConsumption;
      private String PerscriptionID;
   
   }
}