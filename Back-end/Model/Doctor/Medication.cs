/***********************************************************************
 * Module:  Medication.cs
 * Purpose: Definition of the Class Model.Doctor.Medication
 ***********************************************************************/

using System;

namespace Model.Doctor
{
   public class Medication
   {
      public Ingredient[] ingredient;
      public Model.Actors.Doctor doctor;
   
      private String Dose;
      private String MedcationID;
      private String Name;
      private int Quantity;
      private String Description;
      private State State;
   
   }
}